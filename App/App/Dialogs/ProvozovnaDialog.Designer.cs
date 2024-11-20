namespace App.Dialogs
{
    partial class ProvozovnaDialog
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
            textBoxPocet = new TextBox();
            textBoxNazev = new TextBox();
            panel1 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            textBoxCisloPopisne = new TextBox();
            textBoxMesto = new TextBox();
            textBoxStat = new TextBox();
            textBoxPsc = new TextBox();
            textBoxUlice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPocet
            // 
            textBoxPocet.Enabled = false;
            textBoxPocet.Location = new Point(155, 77);
            textBoxPocet.Name = "textBoxPocet";
            textBoxPocet.Size = new Size(250, 23);
            textBoxPocet.TabIndex = 0;
            // 
            // textBoxNazev
            // 
            textBoxNazev.Location = new Point(155, 32);
            textBoxNazev.Name = "textBoxNazev";
            textBoxNazev.Size = new Size(250, 23);
            textBoxNazev.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(1, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 114);
            panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(11, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 40);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 36);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Zavřit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBoxCisloPopisne
            // 
            textBoxCisloPopisne.Location = new Point(155, 218);
            textBoxCisloPopisne.Name = "textBoxCisloPopisne";
            textBoxCisloPopisne.Size = new Size(250, 23);
            textBoxCisloPopisne.TabIndex = 4;
            // 
            // textBoxMesto
            // 
            textBoxMesto.Location = new Point(155, 247);
            textBoxMesto.Name = "textBoxMesto";
            textBoxMesto.Size = new Size(250, 23);
            textBoxMesto.TabIndex = 5;
            // 
            // textBoxStat
            // 
            textBoxStat.Location = new Point(155, 276);
            textBoxStat.Name = "textBoxStat";
            textBoxStat.Size = new Size(250, 23);
            textBoxStat.TabIndex = 6;
            // 
            // textBoxPsc
            // 
            textBoxPsc.Location = new Point(155, 305);
            textBoxPsc.Name = "textBoxPsc";
            textBoxPsc.Size = new Size(250, 23);
            textBoxPsc.TabIndex = 7;
            // 
            // textBoxUlice
            // 
            textBoxUlice.Location = new Point(155, 189);
            textBoxUlice.Name = "textBoxUlice";
            textBoxUlice.Size = new Size(250, 23);
            textBoxUlice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(155, 139);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 9;
            label1.Text = "Adresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 250);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Město:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 279);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 12;
            label3.Text = "Stát:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 308);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 13;
            label4.Text = "PSČ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 221);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 14;
            label5.Text = "Číslo popisné:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 192);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 15;
            label6.Text = "Ulice:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 80);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 17;
            label8.Text = "Počet zaměstnanců:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 35);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 18;
            label9.Text = "Pozice:";
            // 
            // ProvozovnaDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxUlice);
            Controls.Add(textBoxPsc);
            Controls.Add(textBoxStat);
            Controls.Add(textBoxMesto);
            Controls.Add(textBoxCisloPopisne);
            Controls.Add(panel1);
            Controls.Add(textBoxNazev);
            Controls.Add(textBoxPocet);
            Name = "ProvozovnaDialog";
            Text = "ProvozovnaDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPocet;
        private TextBox textBoxNazev;
        private Panel panel1;
        private Button btnCancel;
        private TextBox textBoxCisloPopisne;
        private TextBox textBoxMesto;
        private TextBox textBoxStat;
        private TextBox textBoxPsc;
        private TextBox textBoxUlice;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
    }
}