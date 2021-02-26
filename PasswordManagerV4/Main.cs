using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerV3
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        const string JSON_PATH_PASSWORD = @"..\..\password.json";
        const string JSON_PATH_ACCOUNT = @"..\..\account.json";

        string jsonPassword;
        string jsonAccount;

        List<Password> passwordList = new List<Password>();
        List<Account> accountList = new List<Account>();

        // List voor alle labels, textboxxen, buttons etc..
        List<MetroLabel> WebsiteLabelsList = new List<MetroLabel>();
        List<MetroTextBox> emailTextBoxxenList = new List<MetroTextBox>();
        List<MetroTextBox> passwordTextBoxxenList = new List<MetroTextBox>();
        List<MetroButton> showButtonsList = new List<MetroButton>();
        List<MetroButton> editButtonsList = new List<MetroButton>();
        List<MetroButton> deleteButtonsList = new List<MetroButton>();

        LoginPage loginPage = new LoginPage();

        // boolean voor het showen, editen van passworden all en individueel
        bool isShowing;
        bool canEdit;
        bool allShown;
        bool allCanEdit;

        MetroFramework.MetroColorStyle style = MetroFramework.MetroColorStyle.Orange;
        Color accentColor = MetroFramework.MetroColors.Orange;
        Color mainColor = MetroFramework.MetroColors.Black;
    
        public Main()
        {
            InitializeComponent();

            // PasswordList initializeren met json
            passwordList = Json.JsonToPasswordList(JSON_PATH_PASSWORD);
            //AccountsList initializeren
            accountList = Json.JsonToAccountList(JSON_PATH_ACCOUNT);
        }

        #region EVENTS
        // Length Label updaten naar waarde van trackbar
        private void metroTrackBarLength_ValueChanged(object sender, EventArgs e)
        {
            metroLabelLength.Text = "" + metroTrackBarLength.Value;
        }

        // Password Generator naar textbox
        private void metroTileGenerate_Click(object sender, EventArgs e)
        {
            // Eigenschappen om password te genereren 
            decimal length = Convert.ToDecimal(metroLabelLength.Text);
            bool useLowerCase = metroCheckBoxLowerCase.Checked;
            bool useUpperCase = metroCheckBoxUpperCase.Checked;
            bool useNumbers = metroCheckBoxNumbers.Checked;
            bool useSpecialChar = metroCheckBoxSpecial.Checked;

            string password = Password.GeneratePassword(length, useLowerCase, useUpperCase, useNumbers, useSpecialChar);
            // Als er geen wachtwoord is gegenereerd door een fout messagebox showen
            if(password == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nFout opgetreden bij het genereren van het wachtwoord, controleer of u minimaal 1 optie hebt gekozen?", this.Text + " | GENERATE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                metroTextBoxPassword.Text = password;
            }
        }

        //Save event voor het saven van een password
        private void metroTileSave_Click(object sender, EventArgs e)
        {
            // list updaten mocht er veranderingen zijn geweest
            passwordList = Json.JsonToPasswordList(JSON_PATH_PASSWORD);

            // Inputs
            string website = metroTextBoxWebsite.Text;
            string email = metroTextBoxEmail.Text;
            string generatedPassword = metroTextBoxPassword.Text;


            if(generatedPassword != "")
            {

                
                //Inputs toevoegen aan list
                passwordList = Json.AddPasswordToList(passwordList, JSON_PATH_PASSWORD, website, email, generatedPassword);

                //EncryptPassword
                string encryptedPassword = Account.Encrypt(generatedPassword, loginPage.username + loginPage.masterPassword + passwordList[passwordList.Count - 1].keySalt );
                //password aanpassen naar encrypted password in list
                passwordList[passwordList.Count - 1].password = encryptedPassword;

                //List naar string as json
                jsonPassword = Json.PasswordListToStringAsJson(passwordList);

                // String Json naar json file schrijven
                File.WriteAllText(JSON_PATH_PASSWORD, jsonPassword);

                //Fields leeg maken
                resetInputs();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nFout opgetreden bij het opslaan van het wachtwoord, controleer of u een wachtwoord heeft gegenereerd of opgegeven", this.Text +" | SAVE ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event zodat de Manager word geupdate
        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl.SelectedIndex == 1)
            {
                // PasswordManager updaten wanneer er naar de manager genavigeerd word
                Console.WriteLine("PasswordManager Updated");
                UpdatePasswordManager();
            }
        }

        //Event voor show buttons van passwords etccc
        private void buttonShow_click(object sender, EventArgs e)
        {
            MetroButton button = ((MetroButton)sender);
            //Show Buttons
            //Index is laatste getal van de name als int
            int i = numberFromString(button.Name);

            // Bool goed op true of false zetten
            if (passwordTextBoxxenList[i].UseSystemPasswordChar)
            {
                isShowing = false;
            }
            else { isShowing = true; }

            if (!isShowing)
            {
                Console.WriteLine($"Show clicked : {button.Name}");
                Console.WriteLine($" PasswordTextBoxxen i : {passwordTextBoxxenList[i].Name}");

                passwordTextBoxxenList[i].UseSystemPasswordChar = false;
                button.BackColor = accentColor;
                button.BackgroundImage = global::PasswordManagerV3.Properties.Resources.visibility_white;
            }
            else
            {
                passwordTextBoxxenList[i].UseSystemPasswordChar = true;
                button.BackColor = mainColor;
                button.BackgroundImage = global::PasswordManagerV3.Properties.Resources.invisible_white;
            }
            isShowing = !isShowing;
        }

        // Even voor showall button
        private void metroButtonShowAll_Click(object sender, EventArgs e)
        {

            int i = 0;
            if (!allShown)
            {
                foreach (MetroTextBox textBox in passwordTextBoxxenList)
                {
                    textBox.UseSystemPasswordChar = false;
                    showButtonsList[i].BackColor = accentColor;

                    showButtonsList[i].BackgroundImage = global::PasswordManagerV3.Properties.Resources.visibility_white;
                    i++;
                }
                // Zodat je showen ook gelijk uit kan zetten
                isShowing = true;
                metroButtonShowAll.BackColor = accentColor;
                metroButtonShowAll.BackgroundImage = global::PasswordManagerV3.Properties.Resources.visibility_white;
            }
            else
            {
                foreach (MetroTextBox textBox in passwordTextBoxxenList)
                {
                    textBox.UseSystemPasswordChar = true;
                    showButtonsList[i].BackColor = mainColor;
                    showButtonsList[i].UseCustomBackColor = false;

                    showButtonsList[i].BackgroundImage = global::PasswordManagerV3.Properties.Resources.invisible_white;
                    i++;
                }
                isShowing = false;
                metroButtonShowAll.BackColor = mainColor;

                metroButtonShowAll.BackgroundImage = global::PasswordManagerV3.Properties.Resources.invisible_white;
            }
            allShown = !allShown;
            i = 0;
        }

        //Buttons voor het editten van passwords...
        private void buttonEdit_click(object sender, EventArgs e)
        {
            MetroButton button = ((MetroButton)sender);
            //Edit buttons

            int i = numberFromString(button.Name);

            // Bool goed op true of false zetten
            if (passwordTextBoxxenList[i].ReadOnly)
            {
                canEdit = false;
            }
            else { canEdit = true; }

            //Disable read only
            if (!canEdit)
            {
                Console.WriteLine($"Show clicked : {button.Name}");
                Console.WriteLine($" PasswordTextBoxxen i : {passwordTextBoxxenList[i].Name}");
                //kan editten
                canEdit = !canEdit;
                passwordTextBoxxenList[i].ReadOnly = false;
                emailTextBoxxenList[i].ReadOnly = false;

                // BackColors veranderen
                passwordTextBoxxenList[i].BackColor = accentColor;
                emailTextBoxxenList[i].BackColor = accentColor;

                button.BackColor = accentColor;
            }
            else
            {
                // niet meer editten
                canEdit = !canEdit;
                passwordTextBoxxenList[i].ReadOnly = true;
                emailTextBoxxenList[i].ReadOnly = true;

                passwordTextBoxxenList[i].BackColor = mainColor;
                emailTextBoxxenList[i].BackColor = mainColor;

                button.BackColor = mainColor;

                // if changes 
                // if Are you sure to save == OK

                //Json to list
                passwordList = Json.JsonToPasswordList(JSON_PATH_PASSWORD);
                //Textbox text encrypten en dan aanpassen in Json
                string encryptedPassword = Account.Encrypt(passwordTextBoxxenList[i].Text, loginPage.username + loginPage.masterPassword + passwordList[i].keySalt);
                //Changes aanpassen in list
                passwordList[i].email = emailTextBoxxenList[i].Text;
                passwordList[i].password = encryptedPassword;

                //list schrijven naar json string
                jsonPassword = Json.PasswordListToStringAsJson(passwordList);

                //Jsonstring opslaan in file
                File.WriteAllText(JSON_PATH_PASSWORD, jsonPassword);
            }
        }

        //Event voor Edit all
        private void metroButtonEditAll_Click(object sender, EventArgs e)
        {
            // int i gebruikt zodat ik niet nog een for each moet gebruiken voor de emailss
            int i = 0;
            if (!allCanEdit)
            {
                foreach (MetroTextBox textBoxPassword in passwordTextBoxxenList)
                {
                    textBoxPassword.ReadOnly = false;
                    textBoxPassword.BackColor = accentColor;
                    i++;
                }
                foreach(MetroTextBox textboxEmail in emailTextBoxxenList)
                {
                    textboxEmail.ReadOnly = false;
                    textboxEmail.BackColor = accentColor;
                }
                foreach(MetroButton buttonEdit in editButtonsList)
                {
                    buttonEdit.BackColor = accentColor;
                }
                canEdit = true;
                metroButtonEditAll.BackColor = accentColor;
            }
            else
            {
                // Array voor alle oude wachtwoorden om ze terug te halen als de edits worden gecanceld
                string[] oldPassword = new string[passwordList.Count];
                string[] oldEmail = new string[passwordList.Count];

                // Each password decrypten en in oldPassword array zetten
                foreach (Password password in passwordList)
                {
                    string decrypted = Account.Decrypt(password.password, loginPage.username + loginPage.masterPassword + passwordList[i].keySalt);
                    oldPassword[i] = decrypted;
                    oldEmail[i] = password.email;
                    i++;
                }
                i = 0;
                //Alle wacthtwoorden opslaan als op OK word gedrukt
                if (confirmBox("SAVE CHANGES?", "Wil je alle veranderingen opslaan?") == DialogResult.Yes)
                {
                    foreach (MetroTextBox textBoxPassword in passwordTextBoxxenList)
                    {
                        // Alle textboxxen weer op readOnly zetten
                        textBoxPassword.ReadOnly = true;
                        textBoxPassword.BackColor = mainColor;
                        
                        passwordList = Json.JsonToPasswordList(JSON_PATH_PASSWORD);
                        jsonPassword = Json.PasswordListToStringAsJson(passwordList);

                        // Encrypted wachtwoord in passwordlist
                        string encrypted = Account.Encrypt(textBoxPassword.Text, loginPage.username + loginPage.masterPassword + passwordList[i].keySalt);
                        // Edits saven in password list
                        passwordList[i].password = encrypted;
                        passwordList[i].email = emailTextBoxxenList[i].Text;

                        // Password list saven
                        jsonPassword = Json.PasswordListToStringAsJson(passwordList);

                        File.WriteAllText(JSON_PATH_PASSWORD, jsonPassword);

                        i++;
                    }
                    foreach (MetroTextBox emailTextBox in emailTextBoxxenList)
                    {
                        emailTextBox.ReadOnly = true;
                        emailTextBox.BackColor = mainColor;
                    }
                    foreach (MetroButton editButton in editButtonsList)
                    {
                        editButton.BackColor = mainColor;
                    }
                    metroButtonEditAll.BackColor = mainColor;

                    canEdit = false;
                }
                else
                {
                    foreach (MetroTextBox textBoxPassword in passwordTextBoxxenList)
                    {
                        // Alle textboxxen weer op readOnly zetten
                        textBoxPassword.ReadOnly = true;
                        textBoxPassword.BackColor = mainColor;

                        // Alle textboxxen de orginele waardes geven
                        emailTextBoxxenList[i].Text = oldEmail[i];
                        textBoxPassword.Text = oldPassword[i];
                        i++;
                    }
                    foreach (MetroTextBox emailTextBox in emailTextBoxxenList)
                    {
                        emailTextBox.ReadOnly = true;
                        emailTextBox.BackColor = mainColor;
                    }
                    foreach(MetroButton editButton in editButtonsList)
                    {
                        editButton.BackColor = mainColor;
                    }
                    metroButtonEditAll.BackColor = mainColor;
                    Console.WriteLine("edits Opslaan is gecanceld!");
                }
                canEdit = false;

            }
            allCanEdit = !allCanEdit;
            i = 0;
        }

        // Delete all event
        private void metroButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if (confirmBox("Delete All ?", "All passwords will be deleted") == DialogResult.Yes)
            {
                Console.WriteLine("Delete All OK!");

                passwordList.Clear();
                jsonPassword = Json.PasswordListToStringAsJson(passwordList);
                File.WriteAllText(JSON_PATH_PASSWORD, jsonPassword);

                UpdatePasswordManager();
            }
            else
            {
                Console.WriteLine("Delete All is gecanceld!");
            }
        }

        // Event Delete 1 row
        private void buttonDelete_click(object sender, EventArgs e)
        {
            // Getriggerde button
            Button button = ((Button)sender);
            // index uit de naam van de knop halen
            int i = numberFromString(button.Name);


            if (confirmBox("Delete ?", $"Wachtwoord van {passwordList[i].website} met E-mail : {passwordList[i].email} verwijderen ?") == DialogResult.Yes)
            {
                Console.WriteLine($"Wachtwoord van {passwordList[i].website} met E-mail : {passwordList[i].email} is verwijderd!");
                // Password verwijderen via index
                passwordList.RemoveAt(i);
                // Updaten in Json
                jsonPassword = Json.PasswordListToStringAsJson(passwordList);
                //JsonString schrijven naar file
                File.WriteAllText(JSON_PATH_PASSWORD, jsonPassword);
                // Lijst updaten
                UpdatePasswordManager();
            }
            else
            {
                Console.WriteLine("Delete is gecanceld!");
            }
        }

        #endregion

        #region Methods
        public int numberFromString(string str)
        {
            string numeric = new String(str.Where(Char.IsDigit).ToArray());
            int i = Convert.ToInt32(numeric);
            return i;
        }

        // Textboxxen resetten voor na het opslaan van password
        public void resetInputs()
        {
            metroTextBoxWebsite.Text = null;
            metroTextBoxEmail.Text = null;
            metroTextBoxPassword.Text = null;
        }

        // Message box voor confirmen van delete van items
        private DialogResult confirmBox(string title, string text)
        {
            DialogResult confirmResult;
            return confirmResult = MetroFramework.MetroMessageBox.Show
                (this, "\n\n" + text, this.Text +" | " + title,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void UpdatePasswordManager()
        {
            metroButtonDeleteAll.BackColor = accentColor;
            //string jsonPassword = File.ReadAllText() 
            passwordList = Json.JsonToPasswordList(JSON_PATH_PASSWORD);
            //tabPageManager.Control.Clear(); WERKT!!!!
            if (passwordList != null)
            {
                int i = 0;

                // Als de Textboxxen al een keer in het tabpage staan, verwijderen
                //tabPageManager.Control.Clear() werkt ook maar dan zijn de labels die ik van te voren in de designer heb geplaatst ook weg
                if (emailTextBoxxenList.Count > 0 && passwordTextBoxxenList.Count > 0)
                {
                    // Alles verwijderen uit de tabpage anders staat het er dubbel
                    foreach (Label website in WebsiteLabelsList)
                    {
                        metroTabPageManager.Controls.Remove(WebsiteLabelsList[i]);
                        metroTabPageManager.Controls.Remove(emailTextBoxxenList[i]);
                        metroTabPageManager.Controls.Remove(passwordTextBoxxenList[i]);
                        metroTabPageManager.Controls.Remove(showButtonsList[i]);
                        metroTabPageManager.Controls.Remove(editButtonsList[i]);
                        metroTabPageManager.Controls.Remove(deleteButtonsList[i]);
                        i++;
                    }
                }
                // i weer op 0 zetten zodat die hergebruikt kan worden..
                i = 0;

                // list clearen..
                WebsiteLabelsList = new List<MetroLabel>();
                emailTextBoxxenList = new List<MetroTextBox>();
                passwordTextBoxxenList = new List<MetroTextBox>();
                showButtonsList = new List<MetroButton>();
                editButtonsList = new List<MetroButton>();
                deleteButtonsList = new List<MetroButton>();

                // X locaties
                int websiteX = metroLabelManagerWebsite.Location.X;
                int emailX = metroLabelManagerEmail.Location.X;
                int passwordX = metroLabelManagerPassword.Location.X;
                int showX = metroButtonShowAll.Location.X;
                int editX = metroButtonEditAll.Location.X;
                int deleteX = metroButtonDeleteAll.Location.X;

                int positionY = metroLabelManagerWebsite.Location.Y;

                // Sizes
                Size textBoxEmailSize = metroTextBoxManagerEmail.Size;
                Size textBoxPasswordSize = metroTextBoxManagerPassword.Size;
                Size buttonSize = metroButtonShowAll.Size;
                Size buttonDeleteSize = metroButtonDeleteAll.Size;
                Point location;

                // Labels, textboxxen en buttons maken voor de passworden..
                foreach (Password password in passwordList)
                {
                    // Verschil in y locatie per regel
                    positionY += 35;

                    // LABEL WEBSITE
                    location = new Point(websiteX, positionY);
                    MetroLabel websiteLabel = new MetroLabel();
                    websiteLabel.Text = password.website;
                    websiteLabel.Location = location;
                    websiteLabel.AutoSize = true;
                    websiteLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
                    websiteLabel.Style = MetroFramework.MetroColorStyle.Orange;
                    websiteLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
                    metroTabPageManager.Controls.Add(websiteLabel);
                    WebsiteLabelsList.Add(websiteLabel);

                    // Textbox EMAIL
                    location = new Point(emailX, positionY);
                    MetroTextBox emailTextBox = new MetroTextBox();
                    emailTextBox.Text = password.email;
                    emailTextBox.Name = "emailTextBox" + i;
                    emailTextBox.Location = location;
                    emailTextBox.Size = textBoxEmailSize;
                    emailTextBox.ReadOnly = true;
                    emailTextBox.UseCustomBackColor = true;
                    emailTextBox.BackColor = mainColor;
                    emailTextBox.UseCustomForeColor = true;
                    emailTextBox.ForeColor = MetroFramework.MetroColors.White;
                    emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
                    emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left)));
                    metroTabPageManager.Controls.Add(emailTextBox);
                    emailTextBoxxenList.Add(emailTextBox);
                    
                    //Password decrypten en in de passwordTextBox zetten
                    string decryptedPassword = Account.Decrypt(password.password, loginPage.username + loginPage.masterPassword + password.keySalt);
                    // Textbox Password
                    location = new Point(passwordX, positionY);
                    MetroTextBox passwordTextBox = new MetroTextBox();
                    passwordTextBox.Text = decryptedPassword;
                    passwordTextBox.Name = "passwordTextBox" + i;
                    passwordTextBox.Location = location;
                    passwordTextBox.Size = textBoxPasswordSize;
                    passwordTextBox.ReadOnly = true;
                    passwordTextBox.UseSystemPasswordChar = true;
                    passwordTextBox.UseCustomBackColor = true;
                    passwordTextBox.BackColor = mainColor;
                    passwordTextBox.UseCustomForeColor = true;
                    passwordTextBox.ForeColor = MetroFramework.MetroColors.White;
                    passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
                    passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    metroTabPageManager.Controls.Add(passwordTextBox);
                    passwordTextBoxxenList.Add(passwordTextBox);

                    //Button Show
                    location = new Point(showX, positionY);
                    MetroButton buttonShow = new MetroButton();
                    buttonShow.Name = "buttonShow" + i;
                    buttonShow.Location = location;
                    buttonShow.Size = buttonSize;
                    buttonShow.UseCustomBackColor = true;
                    buttonShow.BackColor = mainColor;
                    buttonShow.BackgroundImage = global::PasswordManagerV3.Properties.Resources.invisible_white;
                    buttonShow.BackgroundImageLayout = ImageLayout.Stretch;
                    buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    metroTabPageManager.Controls.Add(buttonShow);
                    //Alle buttons zelfde event geven
                    buttonShow.Click += new System.EventHandler(this.buttonShow_click);
                    showButtonsList.Add(buttonShow);

                    //Button Edit
                    location = new Point(editX, positionY);
                    MetroButton buttonEdit = new MetroButton();
                    buttonEdit.Name = "buttonEdit" + i;
                    buttonEdit.Location = location;
                    buttonEdit.Size = buttonSize;
                    buttonEdit.UseCustomBackColor = true;
                    buttonEdit.BackColor = mainColor;
                    buttonEdit.BackgroundImage = global::PasswordManagerV3.Properties.Resources.edit_white;
                    buttonEdit.BackgroundImageLayout = ImageLayout.Stretch;
                    buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    metroTabPageManager.Controls.Add(buttonEdit);
                    //Alle buttons zelfde event geven
                    buttonEdit.Click += new System.EventHandler(this.buttonEdit_click);
                    editButtonsList.Add(buttonEdit);

                    //Button Delete
                    location = new Point(deleteX, positionY);
                    MetroButton buttonDelete = new MetroButton();
                    buttonDelete.Name = "buttonDelete" + i;
                    buttonDelete.Text = "X";
                    buttonDelete.Location = location;
                    buttonDelete.Size = buttonDeleteSize;
                    buttonDelete.UseCustomBackColor = true;
                    buttonDelete.BackColor = accentColor;
                    buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    metroTabPageManager.Controls.Add(buttonDelete);
                    //Alle buttons zelfde event geven
                    buttonDelete.Click += new System.EventHandler(this.buttonDelete_click);
                    deleteButtonsList.Add(buttonDelete);

                    i++;
                }
            }
        }


        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            //Password manager afsluiten als er niet ingelogd word..
            if (loginPage.ShowDialog() == DialogResult.Cancel)
            {
                Console.WriteLine("CANCEL");
                Application.Exit();
            }
            else
            {
                Console.WriteLine($"Logged in as {loginPage.username}");
               // Console.WriteLine($"Loginpage.masterpasword : {loginPage.masterPassword}");
                
            }
        }
    }
}
