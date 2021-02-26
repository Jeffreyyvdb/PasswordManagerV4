
namespace PasswordManagerV3
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageGenerator = new MetroFramework.Controls.MetroTabPage();
            this.metroTrackBarLength = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabelWebsite = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabelEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabelLength = new MetroFramework.Controls.MetroLabel();
            this.metroTileSave = new MetroFramework.Controls.MetroTile();
            this.metroTileGenerate = new MetroFramework.Controls.MetroTile();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxWebsite = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxSpecial = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxNumbers = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxUpperCase = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxLowerCase = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabelOptions = new MetroFramework.Controls.MetroLabel();
            this.metroTabPageManager = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonDeleteAll = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditAll = new MetroFramework.Controls.MetroButton();
            this.metroButtonShowAll = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxManagerPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxManagerEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelManagerPassword = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxManagerWebsite = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelManagerEmail = new MetroFramework.Controls.MetroLabel();
            this.metroLabelManagerWebsite = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.metroTabPageGenerator.SuspendLayout();
            this.metroTabPageManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPageGenerator);
            this.metroTabControl.Controls.Add(this.metroTabPageManager);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.metroTabControl.HotTrack = true;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(984, 431);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            // 
            // metroTabPageGenerator
            // 
            this.metroTabPageGenerator.Controls.Add(this.metroTrackBarLength);
            this.metroTabPageGenerator.Controls.Add(this.metroLabelWebsite);
            this.metroTabPageGenerator.Controls.Add(this.metroLabelPassword);
            this.metroTabPageGenerator.Controls.Add(this.metroLabelEmail);
            this.metroTabPageGenerator.Controls.Add(this.metroLabelLength);
            this.metroTabPageGenerator.Controls.Add(this.metroTileSave);
            this.metroTabPageGenerator.Controls.Add(this.metroTileGenerate);
            this.metroTabPageGenerator.Controls.Add(this.metroTextBoxPassword);
            this.metroTabPageGenerator.Controls.Add(this.metroTextBoxEmail);
            this.metroTabPageGenerator.Controls.Add(this.metroTextBoxWebsite);
            this.metroTabPageGenerator.Controls.Add(this.metroCheckBoxSpecial);
            this.metroTabPageGenerator.Controls.Add(this.metroCheckBoxNumbers);
            this.metroTabPageGenerator.Controls.Add(this.metroCheckBoxUpperCase);
            this.metroTabPageGenerator.Controls.Add(this.metroCheckBoxLowerCase);
            this.metroTabPageGenerator.Controls.Add(this.metroLabelOptions);
            this.metroTabPageGenerator.HorizontalScrollbarBarColor = true;
            this.metroTabPageGenerator.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageGenerator.HorizontalScrollbarSize = 1;
            this.metroTabPageGenerator.Location = new System.Drawing.Point(4, 44);
            this.metroTabPageGenerator.Name = "metroTabPageGenerator";
            this.metroTabPageGenerator.Size = new System.Drawing.Size(976, 383);
            this.metroTabPageGenerator.TabIndex = 0;
            this.metroTabPageGenerator.Text = "Generator     ";
            this.metroTabPageGenerator.VerticalScrollbarBarColor = true;
            this.metroTabPageGenerator.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageGenerator.VerticalScrollbarSize = 1;
            // 
            // metroTrackBarLength
            // 
            this.metroTrackBarLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBarLength.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarLength.Location = new System.Drawing.Point(626, 61);
            this.metroTrackBarLength.Maximum = 30;
            this.metroTrackBarLength.Minimum = 6;
            this.metroTrackBarLength.Name = "metroTrackBarLength";
            this.metroTrackBarLength.Size = new System.Drawing.Size(328, 23);
            this.metroTrackBarLength.TabIndex = 12;
            this.metroTrackBarLength.Text = "Length";
            this.metroTrackBarLength.Value = 20;
            this.metroTrackBarLength.ValueChanged += new System.EventHandler(this.metroTrackBarLength_ValueChanged);
            // 
            // metroLabelWebsite
            // 
            this.metroLabelWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabelWebsite.AutoSize = true;
            this.metroLabelWebsite.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelWebsite.Location = new System.Drawing.Point(3, 274);
            this.metroLabelWebsite.Name = "metroLabelWebsite";
            this.metroLabelWebsite.Size = new System.Drawing.Size(76, 25);
            this.metroLabelWebsite.TabIndex = 11;
            this.metroLabelWebsite.Text = "Website";
            // 
            // metroLabelPassword
            // 
            this.metroLabelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabelPassword.AutoSize = true;
            this.metroLabelPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelPassword.Location = new System.Drawing.Point(0, 346);
            this.metroLabelPassword.Name = "metroLabelPassword";
            this.metroLabelPassword.Size = new System.Drawing.Size(85, 25);
            this.metroLabelPassword.TabIndex = 11;
            this.metroLabelPassword.Text = "Password";
            // 
            // metroLabelEmail
            // 
            this.metroLabelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabelEmail.AutoSize = true;
            this.metroLabelEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelEmail.Location = new System.Drawing.Point(3, 310);
            this.metroLabelEmail.Name = "metroLabelEmail";
            this.metroLabelEmail.Size = new System.Drawing.Size(63, 25);
            this.metroLabelEmail.TabIndex = 11;
            this.metroLabelEmail.Text = "E-Mail";
            // 
            // metroLabelLength
            // 
            this.metroLabelLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelLength.AutoSize = true;
            this.metroLabelLength.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelLength.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelLength.Location = new System.Drawing.Point(577, 59);
            this.metroLabelLength.Name = "metroLabelLength";
            this.metroLabelLength.Size = new System.Drawing.Size(32, 25);
            this.metroLabelLength.TabIndex = 11;
            this.metroLabelLength.Text = "20";
            // 
            // metroTileSave
            // 
            this.metroTileSave.ActiveControl = null;
            this.metroTileSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileSave.Location = new System.Drawing.Point(778, 274);
            this.metroTileSave.Name = "metroTileSave";
            this.metroTileSave.Size = new System.Drawing.Size(186, 102);
            this.metroTileSave.TabIndex = 10;
            this.metroTileSave.Text = "Save";
            this.metroTileSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSave.UseSelectable = true;
            this.metroTileSave.Click += new System.EventHandler(this.metroTileSave_Click);
            // 
            // metroTileGenerate
            // 
            this.metroTileGenerate.ActiveControl = null;
            this.metroTileGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileGenerate.Location = new System.Drawing.Point(586, 274);
            this.metroTileGenerate.Name = "metroTileGenerate";
            this.metroTileGenerate.Size = new System.Drawing.Size(186, 102);
            this.metroTileGenerate.TabIndex = 10;
            this.metroTileGenerate.Text = "Generate";
            this.metroTileGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileGenerate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileGenerate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileGenerate.UseSelectable = true;
            this.metroTileGenerate.Click += new System.EventHandler(this.metroTileGenerate_Click);
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(398, 2);
            this.metroTextBoxPassword.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.DisplayIcon = true;
            this.metroTextBoxPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(110, 346);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '\0';
            this.metroTextBoxPassword.PromptText = "Password";
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(426, 30);
            this.metroTextBoxPassword.TabIndex = 9;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMark = "Password";
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBoxEmail
            // 
            this.metroTextBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxEmail.CustomButton.Image = null;
            this.metroTextBoxEmail.CustomButton.Location = new System.Drawing.Point(398, 2);
            this.metroTextBoxEmail.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.metroTextBoxEmail.CustomButton.Name = "";
            this.metroTextBoxEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxEmail.CustomButton.Visible = false;
            this.metroTextBoxEmail.DisplayIcon = true;
            this.metroTextBoxEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxEmail.Lines = new string[0];
            this.metroTextBoxEmail.Location = new System.Drawing.Point(110, 310);
            this.metroTextBoxEmail.MaxLength = 32767;
            this.metroTextBoxEmail.Name = "metroTextBoxEmail";
            this.metroTextBoxEmail.PasswordChar = '\0';
            this.metroTextBoxEmail.PromptText = "Email";
            this.metroTextBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmail.SelectedText = "";
            this.metroTextBoxEmail.SelectionLength = 0;
            this.metroTextBoxEmail.SelectionStart = 0;
            this.metroTextBoxEmail.ShortcutsEnabled = true;
            this.metroTextBoxEmail.Size = new System.Drawing.Size(426, 30);
            this.metroTextBoxEmail.TabIndex = 8;
            this.metroTextBoxEmail.UseSelectable = true;
            this.metroTextBoxEmail.WaterMark = "Email";
            this.metroTextBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmail.WaterMarkFont = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBoxWebsite
            // 
            this.metroTextBoxWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxWebsite.CustomButton.Image = null;
            this.metroTextBoxWebsite.CustomButton.Location = new System.Drawing.Point(398, 2);
            this.metroTextBoxWebsite.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.metroTextBoxWebsite.CustomButton.Name = "";
            this.metroTextBoxWebsite.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxWebsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxWebsite.CustomButton.TabIndex = 1;
            this.metroTextBoxWebsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxWebsite.CustomButton.UseSelectable = true;
            this.metroTextBoxWebsite.CustomButton.Visible = false;
            this.metroTextBoxWebsite.DisplayIcon = true;
            this.metroTextBoxWebsite.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxWebsite.Lines = new string[0];
            this.metroTextBoxWebsite.Location = new System.Drawing.Point(110, 274);
            this.metroTextBoxWebsite.MaxLength = 32767;
            this.metroTextBoxWebsite.Name = "metroTextBoxWebsite";
            this.metroTextBoxWebsite.PasswordChar = '\0';
            this.metroTextBoxWebsite.PromptText = "Website";
            this.metroTextBoxWebsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxWebsite.SelectedText = "";
            this.metroTextBoxWebsite.SelectionLength = 0;
            this.metroTextBoxWebsite.SelectionStart = 0;
            this.metroTextBoxWebsite.ShortcutsEnabled = true;
            this.metroTextBoxWebsite.Size = new System.Drawing.Size(426, 30);
            this.metroTextBoxWebsite.TabIndex = 7;
            this.metroTextBoxWebsite.UseSelectable = true;
            this.metroTextBoxWebsite.WaterMark = "Website";
            this.metroTextBoxWebsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxWebsite.WaterMarkFont = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroCheckBoxSpecial
            // 
            this.metroCheckBoxSpecial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBoxSpecial.AutoSize = true;
            this.metroCheckBoxSpecial.Checked = true;
            this.metroCheckBoxSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxSpecial.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBoxSpecial.Location = new System.Drawing.Point(586, 192);
            this.metroCheckBoxSpecial.Name = "metroCheckBoxSpecial";
            this.metroCheckBoxSpecial.Size = new System.Drawing.Size(231, 25);
            this.metroCheckBoxSpecial.TabIndex = 6;
            this.metroCheckBoxSpecial.Text = "Special Char (!@#$%^&*)";
            this.metroCheckBoxSpecial.UseSelectable = true;
            // 
            // metroCheckBoxNumbers
            // 
            this.metroCheckBoxNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBoxNumbers.AutoSize = true;
            this.metroCheckBoxNumbers.Checked = true;
            this.metroCheckBoxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxNumbers.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBoxNumbers.Location = new System.Drawing.Point(586, 161);
            this.metroCheckBoxNumbers.Name = "metroCheckBoxNumbers";
            this.metroCheckBoxNumbers.Size = new System.Drawing.Size(105, 25);
            this.metroCheckBoxNumbers.TabIndex = 6;
            this.metroCheckBoxNumbers.Text = "Numbers";
            this.metroCheckBoxNumbers.UseSelectable = true;
            // 
            // metroCheckBoxUpperCase
            // 
            this.metroCheckBoxUpperCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBoxUpperCase.AutoSize = true;
            this.metroCheckBoxUpperCase.Checked = true;
            this.metroCheckBoxUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxUpperCase.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBoxUpperCase.Location = new System.Drawing.Point(586, 130);
            this.metroCheckBoxUpperCase.Name = "metroCheckBoxUpperCase";
            this.metroCheckBoxUpperCase.Size = new System.Drawing.Size(117, 25);
            this.metroCheckBoxUpperCase.TabIndex = 6;
            this.metroCheckBoxUpperCase.Text = "Uppercase";
            this.metroCheckBoxUpperCase.UseSelectable = true;
            // 
            // metroCheckBoxLowerCase
            // 
            this.metroCheckBoxLowerCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroCheckBoxLowerCase.AutoSize = true;
            this.metroCheckBoxLowerCase.Checked = true;
            this.metroCheckBoxLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxLowerCase.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBoxLowerCase.Location = new System.Drawing.Point(586, 99);
            this.metroCheckBoxLowerCase.Name = "metroCheckBoxLowerCase";
            this.metroCheckBoxLowerCase.Size = new System.Drawing.Size(116, 25);
            this.metroCheckBoxLowerCase.TabIndex = 5;
            this.metroCheckBoxLowerCase.Text = "Lowercase";
            this.metroCheckBoxLowerCase.UseSelectable = true;
            // 
            // metroLabelOptions
            // 
            this.metroLabelOptions.AutoSize = true;
            this.metroLabelOptions.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelOptions.Location = new System.Drawing.Point(3, 10);
            this.metroLabelOptions.Name = "metroLabelOptions";
            this.metroLabelOptions.Size = new System.Drawing.Size(84, 25);
            this.metroLabelOptions.TabIndex = 4;
            this.metroLabelOptions.Text = "Options :";
            // 
            // metroTabPageManager
            // 
            this.metroTabPageManager.AutoScroll = true;
            this.metroTabPageManager.Controls.Add(this.metroButtonDeleteAll);
            this.metroTabPageManager.Controls.Add(this.metroButtonEditAll);
            this.metroTabPageManager.Controls.Add(this.metroButtonShowAll);
            this.metroTabPageManager.Controls.Add(this.metroTextBoxManagerPassword);
            this.metroTabPageManager.Controls.Add(this.metroTextBoxManagerEmail);
            this.metroTabPageManager.Controls.Add(this.metroLabelManagerPassword);
            this.metroTabPageManager.Controls.Add(this.metroTextBoxManagerWebsite);
            this.metroTabPageManager.Controls.Add(this.metroLabelManagerEmail);
            this.metroTabPageManager.Controls.Add(this.metroLabelManagerWebsite);
            this.metroTabPageManager.HorizontalScrollbar = true;
            this.metroTabPageManager.HorizontalScrollbarBarColor = true;
            this.metroTabPageManager.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageManager.HorizontalScrollbarSize = 1;
            this.metroTabPageManager.Location = new System.Drawing.Point(4, 44);
            this.metroTabPageManager.Name = "metroTabPageManager";
            this.metroTabPageManager.Size = new System.Drawing.Size(976, 383);
            this.metroTabPageManager.TabIndex = 1;
            this.metroTabPageManager.Text = "Manager     ";
            this.metroTabPageManager.VerticalScrollbar = true;
            this.metroTabPageManager.VerticalScrollbarBarColor = true;
            this.metroTabPageManager.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageManager.VerticalScrollbarSize = 1;
            // 
            // metroButtonDeleteAll
            // 
            this.metroButtonDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonDeleteAll.BackColor = System.Drawing.SystemColors.Window;
            this.metroButtonDeleteAll.Location = new System.Drawing.Point(926, 10);
            this.metroButtonDeleteAll.Name = "metroButtonDeleteAll";
            this.metroButtonDeleteAll.Size = new System.Drawing.Size(30, 30);
            this.metroButtonDeleteAll.TabIndex = 9;
            this.metroButtonDeleteAll.Text = "X";
            this.metroButtonDeleteAll.UseCustomBackColor = true;
            this.metroButtonDeleteAll.UseSelectable = true;
            this.metroButtonDeleteAll.Click += new System.EventHandler(this.metroButtonDeleteAll_Click);
            // 
            // metroButtonEditAll
            // 
            this.metroButtonEditAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonEditAll.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonEditAll.BackgroundImage = global::PasswordManagerV3.Properties.Resources.edit_white;
            this.metroButtonEditAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButtonEditAll.Location = new System.Drawing.Point(890, 10);
            this.metroButtonEditAll.Name = "metroButtonEditAll";
            this.metroButtonEditAll.Size = new System.Drawing.Size(30, 30);
            this.metroButtonEditAll.TabIndex = 9;
            this.metroButtonEditAll.UseSelectable = true;
            this.metroButtonEditAll.Click += new System.EventHandler(this.metroButtonEditAll_Click);
            // 
            // metroButtonShowAll
            // 
            this.metroButtonShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButtonShowAll.BackColor = System.Drawing.Color.Transparent;
            this.metroButtonShowAll.BackgroundImage = global::PasswordManagerV3.Properties.Resources.invisible_white;
            this.metroButtonShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonShowAll.Location = new System.Drawing.Point(852, 10);
            this.metroButtonShowAll.Margin = new System.Windows.Forms.Padding(5);
            this.metroButtonShowAll.Name = "metroButtonShowAll";
            this.metroButtonShowAll.Size = new System.Drawing.Size(30, 30);
            this.metroButtonShowAll.TabIndex = 9;
            this.metroButtonShowAll.UseSelectable = true;
            this.metroButtonShowAll.Click += new System.EventHandler(this.metroButtonShowAll_Click);
            // 
            // metroTextBoxManagerPassword
            // 
            this.metroTextBoxManagerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxManagerPassword.CustomButton.Image = null;
            this.metroTextBoxManagerPassword.CustomButton.Location = new System.Drawing.Point(295, 2);
            this.metroTextBoxManagerPassword.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.metroTextBoxManagerPassword.CustomButton.Name = "";
            this.metroTextBoxManagerPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxManagerPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxManagerPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxManagerPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxManagerPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxManagerPassword.CustomButton.Visible = false;
            this.metroTextBoxManagerPassword.DisplayIcon = true;
            this.metroTextBoxManagerPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxManagerPassword.Lines = new string[0];
            this.metroTextBoxManagerPassword.Location = new System.Drawing.Point(523, 38);
            this.metroTextBoxManagerPassword.MaxLength = 32767;
            this.metroTextBoxManagerPassword.Name = "metroTextBoxManagerPassword";
            this.metroTextBoxManagerPassword.PasswordChar = '\0';
            this.metroTextBoxManagerPassword.PromptText = "Password";
            this.metroTextBoxManagerPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxManagerPassword.SelectedText = "";
            this.metroTextBoxManagerPassword.SelectionLength = 0;
            this.metroTextBoxManagerPassword.SelectionStart = 0;
            this.metroTextBoxManagerPassword.ShortcutsEnabled = true;
            this.metroTextBoxManagerPassword.Size = new System.Drawing.Size(323, 30);
            this.metroTextBoxManagerPassword.TabIndex = 8;
            this.metroTextBoxManagerPassword.UseSelectable = true;
            this.metroTextBoxManagerPassword.Visible = false;
            this.metroTextBoxManagerPassword.WaterMark = "Password";
            this.metroTextBoxManagerPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxManagerPassword.WaterMarkFont = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextBoxManagerEmail
            // 
            this.metroTextBoxManagerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxManagerEmail.CustomButton.Image = null;
            this.metroTextBoxManagerEmail.CustomButton.Location = new System.Drawing.Point(287, 2);
            this.metroTextBoxManagerEmail.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.metroTextBoxManagerEmail.CustomButton.Name = "";
            this.metroTextBoxManagerEmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxManagerEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxManagerEmail.CustomButton.TabIndex = 1;
            this.metroTextBoxManagerEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxManagerEmail.CustomButton.UseSelectable = true;
            this.metroTextBoxManagerEmail.CustomButton.Visible = false;
            this.metroTextBoxManagerEmail.DisplayIcon = true;
            this.metroTextBoxManagerEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxManagerEmail.Lines = new string[0];
            this.metroTextBoxManagerEmail.Location = new System.Drawing.Point(202, 38);
            this.metroTextBoxManagerEmail.MaxLength = 32767;
            this.metroTextBoxManagerEmail.Name = "metroTextBoxManagerEmail";
            this.metroTextBoxManagerEmail.PasswordChar = '\0';
            this.metroTextBoxManagerEmail.PromptText = "Email";
            this.metroTextBoxManagerEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxManagerEmail.SelectedText = "";
            this.metroTextBoxManagerEmail.SelectionLength = 0;
            this.metroTextBoxManagerEmail.SelectionStart = 0;
            this.metroTextBoxManagerEmail.ShortcutsEnabled = true;
            this.metroTextBoxManagerEmail.Size = new System.Drawing.Size(315, 30);
            this.metroTextBoxManagerEmail.TabIndex = 8;
            this.metroTextBoxManagerEmail.UseSelectable = true;
            this.metroTextBoxManagerEmail.Visible = false;
            this.metroTextBoxManagerEmail.WaterMark = "Email";
            this.metroTextBoxManagerEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxManagerEmail.WaterMarkFont = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabelManagerPassword
            // 
            this.metroLabelManagerPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelManagerPassword.AutoSize = true;
            this.metroLabelManagerPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelManagerPassword.Location = new System.Drawing.Point(523, 10);
            this.metroLabelManagerPassword.Name = "metroLabelManagerPassword";
            this.metroLabelManagerPassword.Size = new System.Drawing.Size(85, 25);
            this.metroLabelManagerPassword.TabIndex = 2;
            this.metroLabelManagerPassword.Text = "Password";
            // 
            // metroTextBoxManagerWebsite
            // 
            // 
            // 
            // 
            this.metroTextBoxManagerWebsite.CustomButton.Image = null;
            this.metroTextBoxManagerWebsite.CustomButton.Location = new System.Drawing.Point(167, 2);
            this.metroTextBoxManagerWebsite.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.metroTextBoxManagerWebsite.CustomButton.Name = "";
            this.metroTextBoxManagerWebsite.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBoxManagerWebsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxManagerWebsite.CustomButton.TabIndex = 1;
            this.metroTextBoxManagerWebsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxManagerWebsite.CustomButton.UseSelectable = true;
            this.metroTextBoxManagerWebsite.CustomButton.Visible = false;
            this.metroTextBoxManagerWebsite.DisplayIcon = true;
            this.metroTextBoxManagerWebsite.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxManagerWebsite.Lines = new string[0];
            this.metroTextBoxManagerWebsite.Location = new System.Drawing.Point(3, 38);
            this.metroTextBoxManagerWebsite.MaxLength = 32767;
            this.metroTextBoxManagerWebsite.Name = "metroTextBoxManagerWebsite";
            this.metroTextBoxManagerWebsite.PasswordChar = '\0';
            this.metroTextBoxManagerWebsite.PromptText = "Website";
            this.metroTextBoxManagerWebsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxManagerWebsite.SelectedText = "";
            this.metroTextBoxManagerWebsite.SelectionLength = 0;
            this.metroTextBoxManagerWebsite.SelectionStart = 0;
            this.metroTextBoxManagerWebsite.ShortcutsEnabled = true;
            this.metroTextBoxManagerWebsite.Size = new System.Drawing.Size(195, 30);
            this.metroTextBoxManagerWebsite.TabIndex = 8;
            this.metroTextBoxManagerWebsite.UseSelectable = true;
            this.metroTextBoxManagerWebsite.Visible = false;
            this.metroTextBoxManagerWebsite.WaterMark = "Website";
            this.metroTextBoxManagerWebsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxManagerWebsite.WaterMarkFont = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabelManagerEmail
            // 
            this.metroLabelManagerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelManagerEmail.AutoSize = true;
            this.metroLabelManagerEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelManagerEmail.Location = new System.Drawing.Point(202, 10);
            this.metroLabelManagerEmail.Name = "metroLabelManagerEmail";
            this.metroLabelManagerEmail.Size = new System.Drawing.Size(55, 25);
            this.metroLabelManagerEmail.TabIndex = 2;
            this.metroLabelManagerEmail.Text = "Email";
            // 
            // metroLabelManagerWebsite
            // 
            this.metroLabelManagerWebsite.AutoSize = true;
            this.metroLabelManagerWebsite.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelManagerWebsite.Location = new System.Drawing.Point(3, 10);
            this.metroLabelManagerWebsite.Name = "metroLabelManagerWebsite";
            this.metroLabelManagerWebsite.Size = new System.Drawing.Size(83, 25);
            this.metroLabelManagerWebsite.TabIndex = 2;
            this.metroLabelManagerWebsite.Text = "Websites";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 511);
            this.Controls.Add(this.metroTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1024, 511);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "PasswordManagerV4";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPageGenerator.ResumeLayout(false);
            this.metroTabPageGenerator.PerformLayout();
            this.metroTabPageManager.ResumeLayout(false);
            this.metroTabPageManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPageGenerator;
        private MetroFramework.Controls.MetroTabPage metroTabPageManager;
        private MetroFramework.Controls.MetroLabel metroLabelOptions;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSpecial;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxNumbers;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUpperCase;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxLowerCase;
        private MetroFramework.Controls.MetroTextBox metroTextBoxWebsite;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmail;
        private MetroFramework.Controls.MetroTile metroTileGenerate;
        private MetroFramework.Controls.MetroTile metroTileSave;
        private MetroFramework.Controls.MetroLabel metroLabelPassword;
        private MetroFramework.Controls.MetroLabel metroLabelEmail;
        private MetroFramework.Controls.MetroLabel metroLabelLength;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarLength;
        private MetroFramework.Controls.MetroLabel metroLabelWebsite;
        private MetroFramework.Controls.MetroLabel metroLabelManagerWebsite;
        private MetroFramework.Controls.MetroTextBox metroTextBoxManagerEmail;
        private MetroFramework.Controls.MetroLabel metroLabelManagerEmail;
        private MetroFramework.Controls.MetroTextBox metroTextBoxManagerPassword;
        private MetroFramework.Controls.MetroLabel metroLabelManagerPassword;
        private MetroFramework.Controls.MetroButton metroButtonShowAll;
        private MetroFramework.Controls.MetroButton metroButtonDeleteAll;
        private MetroFramework.Controls.MetroButton metroButtonEditAll;
        private MetroFramework.Controls.MetroTextBox metroTextBoxManagerWebsite;
    }
}

