namespace App.Dialogs
{
    partial class RegisterDialog
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
        private void InitializeComponent()
        {
            CancelBtn = new Button();
            regBtn = new Button();
            komplRegBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            tbEmail = new TextBox();
            tbPassRepeat = new TextBox();
            tbPass = new TextBox();
            tbUsername = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label14 = new Label();
            tbKompUsername = new TextBox();
            tbPrijmeni = new TextBox();
            tbKompEmail = new TextBox();
            tbTelefon = new TextBox();
            tbKompPass = new TextBox();
            tbKompPassRepeat = new TextBox();
            label13 = new Label();
            label12 = new Label();
            cbProv = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tbJmeno = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.DialogResult = DialogResult.Cancel;
            CancelBtn.Location = new Point(550, 486);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(112, 23);
            CancelBtn.TabIndex = 0;
            CancelBtn.Text = "Zrušit";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // regBtn
            // 
            regBtn.DialogResult = DialogResult.OK;
            regBtn.Location = new Point(3, 474);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(408, 23);
            regBtn.TabIndex = 1;
            regBtn.Text = "Registrovat se";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // komplRegBtn
            // 
            komplRegBtn.DialogResult = DialogResult.OK;
            komplRegBtn.Location = new Point(36, 474);
            komplRegBtn.Name = "komplRegBtn";
            komplRegBtn.Size = new Size(424, 23);
            komplRegBtn.TabIndex = 2;
            komplRegBtn.Text = "Registrovat se";
            komplRegBtn.UseVisualStyleBackColor = true;
            komplRegBtn.Click += komplRegBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Rychlá registrace";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbPassRepeat);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(regBtn);
            panel1.Location = new Point(22, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 547);
            panel1.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(168, 263);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(224, 23);
            tbEmail.TabIndex = 11;
            // 
            // tbPassRepeat
            // 
            tbPassRepeat.Location = new Point(168, 183);
            tbPassRepeat.Name = "tbPassRepeat";
            tbPassRepeat.PasswordChar = '*';
            tbPassRepeat.Size = new Size(224, 23);
            tbPassRepeat.TabIndex = 10;
            tbPassRepeat.UseSystemPasswordChar = true;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(168, 123);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(224, 23);
            tbPass.TabIndex = 9;
            tbPass.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(168, 65);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(224, 23);
            tbUsername.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 271);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 7;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 191);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "Opakujte heslo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 131);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "Heslo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 72);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Uživatelské jméno";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(tbKompUsername);
            panel2.Controls.Add(tbPrijmeni);
            panel2.Controls.Add(tbKompEmail);
            panel2.Controls.Add(tbTelefon);
            panel2.Controls.Add(tbKompPass);
            panel2.Controls.Add(tbKompPassRepeat);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(cbProv);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tbJmeno);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(komplRegBtn);
            panel2.Location = new Point(12, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 547);
            panel2.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 176);
            label14.Name = "label14";
            label14.Size = new Size(102, 15);
            label14.TabIndex = 19;
            label14.Text = "Uživatelské jméno";
            // 
            // tbKompUsername
            // 
            tbKompUsername.Location = new Point(188, 173);
            tbKompUsername.Name = "tbKompUsername";
            tbKompUsername.Size = new Size(217, 23);
            tbKompUsername.TabIndex = 18;
            // 
            // tbPrijmeni
            // 
            tbPrijmeni.Location = new Point(188, 126);
            tbPrijmeni.Name = "tbPrijmeni";
            tbPrijmeni.Size = new Size(217, 23);
            tbPrijmeni.TabIndex = 17;
            // 
            // tbKompEmail
            // 
            tbKompEmail.Location = new Point(188, 212);
            tbKompEmail.Name = "tbKompEmail";
            tbKompEmail.Size = new Size(217, 23);
            tbKompEmail.TabIndex = 16;
            // 
            // tbTelefon
            // 
            tbTelefon.Location = new Point(188, 255);
            tbTelefon.Name = "tbTelefon";
            tbTelefon.Size = new Size(217, 23);
            tbTelefon.TabIndex = 15;
            // 
            // tbKompPass
            // 
            tbKompPass.Location = new Point(188, 345);
            tbKompPass.Name = "tbKompPass";
            tbKompPass.PasswordChar = '*';
            tbKompPass.Size = new Size(217, 23);
            tbKompPass.TabIndex = 14;
            tbKompPass.UseSystemPasswordChar = true;
            // 
            // tbKompPassRepeat
            // 
            tbKompPassRepeat.Location = new Point(188, 395);
            tbKompPassRepeat.Name = "tbKompPassRepeat";
            tbKompPassRepeat.PasswordChar = '*';
            tbKompPassRepeat.Size = new Size(217, 23);
            tbKompPassRepeat.TabIndex = 13;
            tbKompPassRepeat.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 398);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 12;
            label13.Text = "Opakujte heslo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 348);
            label12.Name = "label12";
            label12.Size = new Size(37, 15);
            label12.TabIndex = 11;
            label12.Text = "Heslo";
            // 
            // cbProv
            // 
            cbProv.FormattingEnabled = true;
            cbProv.Location = new Point(188, 298);
            cbProv.Name = "cbProv";
            cbProv.Size = new Size(217, 23);
            cbProv.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 306);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 9;
            label11.Text = "Provozovna";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 263);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 8;
            label10.Text = "Telefonní číslo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 215);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 7;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 134);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 6;
            label8.Text = "Příjmení";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 82);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 5;
            label7.Text = "Jméno";
            // 
            // tbJmeno
            // 
            tbJmeno.Location = new Point(188, 74);
            tbJmeno.Name = "tbJmeno";
            tbJmeno.Size = new Size(217, 23);
            tbJmeno.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 15);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 3;
            label2.Text = "Kompletní registrace";
            // 
            // RegisterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(CancelBtn);
            Name = "RegisterDialog";
            Text = "Registrace";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CancelBtn;
        private Button regBtn;
        private Button komplRegBtn;
        private Label label1;
        private Panel panel1;
        private TextBox tbEmail;
        private TextBox tbPassRepeat;
        private TextBox tbPass;
        private TextBox tbUsername;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox tbJmeno;
        private TextBox tbPrijmeni;
        private TextBox tbKompEmail;
        private TextBox tbTelefon;
        private TextBox tbKompPass;
        private TextBox tbKompPassRepeat;
        private Label label13;
        private Label label12;
        private ComboBox cbProv;
        private Label label11;
        private Label label14;
        private TextBox tbKompUsername;
    }
}