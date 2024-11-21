namespace App.Dialogs
{
    partial class ZamestnanecDialog
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
            txtJmeno = new TextBox();
            txtPrijmeni = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            comboProvozovna = new ComboBox();
            comboPozice = new ComboBox();
            txtNadrizeny = new TextBox();
            btnNadrizeny = new Button();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtJmeno
            // 
            txtJmeno.Location = new Point(154, 12);
            txtJmeno.Name = "txtJmeno";
            txtJmeno.Size = new Size(173, 23);
            txtJmeno.TabIndex = 0;
            // 
            // txtPrijmeni
            // 
            txtPrijmeni.Location = new Point(154, 41);
            txtPrijmeni.Name = "txtPrijmeni";
            txtPrijmeni.Size = new Size(173, 23);
            txtPrijmeni.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(154, 99);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(173, 23);
            txtTelefon.TabIndex = 3;
            // 
            // comboProvozovna
            // 
            comboProvozovna.FormattingEnabled = true;
            comboProvozovna.Location = new Point(154, 128);
            comboProvozovna.Name = "comboProvozovna";
            comboProvozovna.Size = new Size(173, 23);
            comboProvozovna.TabIndex = 4;
            // 
            // comboPozice
            // 
            comboPozice.FormattingEnabled = true;
            comboPozice.Location = new Point(154, 157);
            comboPozice.Name = "comboPozice";
            comboPozice.Size = new Size(173, 23);
            comboPozice.TabIndex = 5;
            // 
            // txtNadrizeny
            // 
            txtNadrizeny.Enabled = false;
            txtNadrizeny.Location = new Point(154, 186);
            txtNadrizeny.Name = "txtNadrizeny";
            txtNadrizeny.Size = new Size(173, 23);
            txtNadrizeny.TabIndex = 6;
            // 
            // btnNadrizeny
            // 
            btnNadrizeny.Location = new Point(333, 186);
            btnNadrizeny.Name = "btnNadrizeny";
            btnNadrizeny.Size = new Size(126, 23);
            btnNadrizeny.TabIndex = 7;
            btnNadrizeny.Text = "Vybrat";
            btnNadrizeny.UseVisualStyleBackColor = true;
            btnNadrizeny.Click += btnNadrizeny_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(0, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 88);
            panel1.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(333, 24);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Jmeno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Prijmeni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 102);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 131);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 13;
            label5.Text = "Provozovna";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 160);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 14;
            label6.Text = "Pracovní pozice:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 189);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 15;
            label7.Text = "Nadřízený";
            // 
            // ZamestnanecDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 320);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnNadrizeny);
            Controls.Add(txtNadrizeny);
            Controls.Add(comboPozice);
            Controls.Add(comboProvozovna);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtPrijmeni);
            Controls.Add(txtJmeno);
            Name = "ZamestnanecDialog";
            Text = "ZamestnanecDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJmeno;
        private TextBox txtPrijmeni;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private ComboBox comboProvozovna;
        private ComboBox comboPozice;
        private TextBox txtNadrizeny;
        private Button btnNadrizeny;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}