namespace App.Dialogs
{
    partial class SkladDialog
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
            txtNazev = new TextBox();
            txtPlocha = new TextBox();
            txtUlice = new TextBox();
            txtMesto = new TextBox();
            txtPsc = new TextBox();
            txtCisloPopisne = new TextBox();
            txtStat = new TextBox();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNazev
            // 
            txtNazev.Location = new Point(209, 55);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(218, 23);
            txtNazev.TabIndex = 0;
            // 
            // txtPlocha
            // 
            txtPlocha.Location = new Point(209, 94);
            txtPlocha.Name = "txtPlocha";
            txtPlocha.Size = new Size(218, 23);
            txtPlocha.TabIndex = 1;
            // 
            // txtUlice
            // 
            txtUlice.Location = new Point(209, 177);
            txtUlice.Name = "txtUlice";
            txtUlice.Size = new Size(218, 23);
            txtUlice.TabIndex = 2;
            // 
            // txtMesto
            // 
            txtMesto.Location = new Point(209, 215);
            txtMesto.Name = "txtMesto";
            txtMesto.Size = new Size(218, 23);
            txtMesto.TabIndex = 3;
            // 
            // txtPsc
            // 
            txtPsc.Location = new Point(209, 244);
            txtPsc.Name = "txtPsc";
            txtPsc.Size = new Size(218, 23);
            txtPsc.TabIndex = 4;
            // 
            // txtCisloPopisne
            // 
            txtCisloPopisne.Location = new Point(209, 273);
            txtCisloPopisne.Name = "txtCisloPopisne";
            txtCisloPopisne.Size = new Size(218, 23);
            txtCisloPopisne.TabIndex = 5;
            // 
            // txtStat
            // 
            txtStat.Location = new Point(209, 302);
            txtStat.Name = "txtStat";
            txtStat.Size = new Size(218, 23);
            txtStat.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(0, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 100);
            panel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(471, 36);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 58);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Název:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 97);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 10;
            label3.Text = "Užitná plocha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 180);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 11;
            label4.Text = "Ulice:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 218);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 12;
            label5.Text = "Město:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 247);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 13;
            label6.Text = "PSC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 276);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 14;
            label7.Text = "Číslo popisné:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(165, 305);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 15;
            label8.Text = "Stát:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(209, 139);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 16;
            label2.Text = "Adresa";
            // 
            // SkladDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 515);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtStat);
            Controls.Add(txtCisloPopisne);
            Controls.Add(txtPsc);
            Controls.Add(txtMesto);
            Controls.Add(txtUlice);
            Controls.Add(txtPlocha);
            Controls.Add(txtNazev);
            Name = "SkladDialog";
            Text = "SkladDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNazev;
        private TextBox txtPlocha;
        private TextBox txtUlice;
        private TextBox txtMesto;
        private TextBox txtPsc;
        private TextBox txtCisloPopisne;
        private TextBox txtStat;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
    }
}