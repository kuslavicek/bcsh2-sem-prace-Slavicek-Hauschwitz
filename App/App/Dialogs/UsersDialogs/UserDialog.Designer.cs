namespace App.Dialogs
{
    partial class UserDialog
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
            txtHeslo = new TextBox();
            checkOs = new CheckBox();
            txtZamestnanec = new TextBox();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnChooseEmpl = new Button();
            comboRole = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtJmeno
            // 
            txtJmeno.Location = new Point(145, 34);
            txtJmeno.Name = "txtJmeno";
            txtJmeno.Size = new Size(181, 23);
            txtJmeno.TabIndex = 0;
            // 
            // txtHeslo
            // 
            txtHeslo.Location = new Point(145, 63);
            txtHeslo.Name = "txtHeslo";
            txtHeslo.Size = new Size(181, 23);
            txtHeslo.TabIndex = 1;
            // 
            // checkOs
            // 
            checkOs.AutoSize = true;
            checkOs.Location = new Point(145, 222);
            checkOs.Name = "checkOs";
            checkOs.Size = new Size(169, 19);
            checkOs.TabIndex = 5;
            checkOs.Text = "Nezobrazovat osobní údaje";
            checkOs.UseVisualStyleBackColor = true;
            // 
            // txtZamestnanec
            // 
            txtZamestnanec.AutoCompleteMode = AutoCompleteMode.Append;
            txtZamestnanec.Enabled = false;
            txtZamestnanec.Location = new Point(145, 273);
            txtZamestnanec.Name = "txtZamestnanec";
            txtZamestnanec.Size = new Size(181, 23);
            txtZamestnanec.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 100);
            panel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(318, 35);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(67, 35);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 37);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Jméno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 66);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 9;
            label2.Text = "Heslo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 276);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 10;
            label3.Text = "Zaměstnanec:";
            // 
            // btnChooseEmpl
            // 
            btnChooseEmpl.Location = new Point(332, 272);
            btnChooseEmpl.Name = "btnChooseEmpl";
            btnChooseEmpl.Size = new Size(75, 23);
            btnChooseEmpl.TabIndex = 11;
            btnChooseEmpl.Text = "Vybrat";
            btnChooseEmpl.UseVisualStyleBackColor = true;
            btnChooseEmpl.Click += btnChooseEmpl_Click;
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(145, 146);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(181, 23);
            comboRole.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 149);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 13;
            label4.Text = "Role:";
            // 
            // UserDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(label4);
            Controls.Add(comboRole);
            Controls.Add(btnChooseEmpl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtZamestnanec);
            Controls.Add(checkOs);
            Controls.Add(txtHeslo);
            Controls.Add(txtJmeno);
            Name = "UserDialog";
            Text = "UserDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtJmeno;
        private TextBox txtHeslo;
        private CheckBox checkOs;
        private TextBox txtZamestnanec;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnChooseEmpl;
        private ComboBox comboRole;
        private Label label4;
    }
}