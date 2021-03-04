using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PasswordManagerV4
{
    public partial class LoginPage : MetroFramework.Forms.MetroForm
    {
        System.Timers.Timer t;
        // Voor het aantal seconden
        int s;
        // Om te tellen hoevaak er een fout wachtwoord is opgegeven
        int count;

        const string JSON_PATH_PASSWORD = @"..\..\password.json";
        const string JSON_PATH_ACCOUNT = @"..\..\account.json";
        string jsonString;
        public string username;
        public string masterPassword;
        List<Account> accountList = new List<Account>();

        [Obsolete]
        public LoginPage()
        {
            InitializeComponent();
            //Account list updaten
            jsonString = File.ReadAllText(JSON_PATH_ACCOUNT);
            accountList = JsonConvert.DeserializeObject<List<Account>>(jsonString);

            t = new System.Timers.Timer();
            t.Interval = 1000; // = 1 second
            t.Elapsed += OnTimeEvent;

            count = 5;
            s = 30;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s <= 0)
                {
                    t.Stop();
                    count = 5;
                    s = 30;
                }

                Console.WriteLine($"{s.ToString().PadLeft(2, '0')}");
            }));
        }

        private void metroTileLogin_Click(object sender, EventArgs e)
        {

            string hashedPasswordInput = Account.GenerateSHA256Hash(metroTextBoxPassword.Text, accountList[0].salt);
            string savedHashedPassword = accountList[0].hashedPassword;

            if (metroTextBoxUsername.Text == accountList[0].username)
            {
                // Als het juiste wachtwoord is ingevoerd en username
                if (hashedPasswordInput == savedHashedPassword)
                {
                    // Omdat naar de password manager te gaan.
                    username = accountList[0].username;
                    masterPassword = metroTextBoxPassword.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if(count > 0)
                    {
                        count--;
                        MetroFramework.MetroMessageBox.Show(this, $"\n\nFout wachtwoord opgegeven, U heeft nog {count} pogingen over.", "PASSWORDMANAGERV4 | LOGIN ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(count == 0)
                    {
                        t.Start();
                        MetroFramework.MetroMessageBox.Show(this, $"\n\nU heeft tevaak een fout wachtwoord opgegeven. U kunt het opnieuw proberen over {s} Seconden", "PASSWORDMANAGERV4 | LOGIN ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nAccount niet gevonden", "PASSWORDMANAGERV4 | LOGIN ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void metroTileRegister_Click(object sender, EventArgs e)
        {
            string newUsername = metroTextBoxRegisterUserName.Text;
            string newPassword = metroTextBoxRegisterPassword.Text;

            if (newUsername.Length > 0)
            {
                bool validPassword = IsValidPassword(newPassword);
                if (validPassword)
                {

                    //Add new account
                    Account newAccount = new Account(newUsername, newPassword);
                    accountList.Clear();
                    accountList.Add(newAccount);
                    jsonString = Json.AccountListToStringAsJson(accountList);
                    File.WriteAllText(JSON_PATH_ACCOUNT,jsonString);

                    // Delete all old passwords
                    File.WriteAllText(JSON_PATH_PASSWORD, "");

                    MetroFramework.MetroMessageBox.Show(this, "\n\nJe hebt een nieuw account geregistreerd en kunt inloggen.", "PASSWORDMANAGERV3 | REGISTERED SUCCESFULLY",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nGeen juist wachtwoord opgegeven. Uw wachtwoord moet minimaal 8 karakters lang zijn, een hoofdletter, nummer en speciaal karakter hebben", "PASSWORDMANAGERV3 | REGISTER ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nGeen username opgegeven", "PASSWORDMANAGERV3 | REGISTER ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool IsValidPassword(string password)
        {
            //Checken of password minimaal 8 lang is, hoofdletter, kleine letter en nummer heeft.
            Regex regex = new Regex(@"^(?=^.{8,}$)(?=.*\d)(?=.*[a-zA-Z])");
            Match match = regex.Match(password);
            return match.Success;
        }

    }
}
