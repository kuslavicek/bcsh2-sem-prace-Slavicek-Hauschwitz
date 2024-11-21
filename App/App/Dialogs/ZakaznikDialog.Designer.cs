using App.Model;

namespace App.Dialogs
{
    partial class ZakaznikDialog
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
            labelJmeno = new Label();
            textBoxJmeno = new TextBox();
            labelTelefon = new Label();
            textBoxTelefon = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelUlice = new Label();
            textBoxUlice = new TextBox();
            labelCisloPopisne = new Label();
            textBoxCisloPopisne = new TextBox();
            labelMesto = new Label();
            textBoxMesto = new TextBox();
            labelStat = new Label();
            labelPsc = new Label();
            textBoxPsc = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            comboStat = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelJmeno
            // 
            labelJmeno.Location = new Point(62, 36);
            labelJmeno.Name = "labelJmeno";
            labelJmeno.Size = new Size(100, 23);
            labelJmeno.TabIndex = 0;
            labelJmeno.Text = "Jméno:";
            // 
            // textBoxJmeno
            // 
            textBoxJmeno.Location = new Point(172, 36);
            textBoxJmeno.Name = "textBoxJmeno";
            textBoxJmeno.Size = new Size(250, 23);
            textBoxJmeno.TabIndex = 1;
            // 
            // labelTelefon
            // 
            labelTelefon.Location = new Point(62, 76);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(100, 23);
            labelTelefon.TabIndex = 2;
            labelTelefon.Text = "Telefon:";
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(172, 76);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(250, 23);
            textBoxTelefon.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.Location = new Point(62, 116);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 23);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(172, 116);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // labelUlice
            // 
            labelUlice.Location = new Point(62, 200);
            labelUlice.Name = "labelUlice";
            labelUlice.Size = new Size(100, 23);
            labelUlice.TabIndex = 6;
            labelUlice.Text = "Ulice:";
            // 
            // textBoxUlice
            // 
            textBoxUlice.Location = new Point(172, 200);
            textBoxUlice.Name = "textBoxUlice";
            textBoxUlice.Size = new Size(250, 23);
            textBoxUlice.TabIndex = 7;
            // 
            // labelCisloPopisne
            // 
            labelCisloPopisne.Location = new Point(62, 240);
            labelCisloPopisne.Name = "labelCisloPopisne";
            labelCisloPopisne.Size = new Size(100, 23);
            labelCisloPopisne.TabIndex = 8;
            labelCisloPopisne.Text = "Číslo popisné:";
            // 
            // textBoxCisloPopisne
            // 
            textBoxCisloPopisne.Location = new Point(172, 240);
            textBoxCisloPopisne.Name = "textBoxCisloPopisne";
            textBoxCisloPopisne.Size = new Size(250, 23);
            textBoxCisloPopisne.TabIndex = 9;
            // 
            // labelMesto
            // 
            labelMesto.Location = new Point(62, 280);
            labelMesto.Name = "labelMesto";
            labelMesto.Size = new Size(100, 23);
            labelMesto.TabIndex = 10;
            labelMesto.Text = "Město:";
            // 
            // textBoxMesto
            // 
            textBoxMesto.Location = new Point(172, 280);
            textBoxMesto.Name = "textBoxMesto";
            textBoxMesto.Size = new Size(250, 23);
            textBoxMesto.TabIndex = 11;
            // 
            // labelStat
            // 
            labelStat.Location = new Point(62, 320);
            labelStat.Name = "labelStat";
            labelStat.Size = new Size(100, 23);
            labelStat.TabIndex = 12;
            labelStat.Text = "Stát:";
            // 
            // labelPsc
            // 
            labelPsc.Location = new Point(62, 360);
            labelPsc.Name = "labelPsc";
            labelPsc.Size = new Size(100, 23);
            labelPsc.TabIndex = 14;
            labelPsc.Text = "PSČ:";
            // 
            // textBoxPsc
            // 
            textBoxPsc.Location = new Point(172, 360);
            textBoxPsc.Name = "textBoxPsc";
            textBoxPsc.Size = new Size(250, 23);
            textBoxPsc.TabIndex = 15;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(20, 32);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(152, 36);
            saveButton.TabIndex = 16;
            saveButton.Text = "Uložit";
            saveButton.Click += SaveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(325, 32);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(152, 36);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Zrušit";
            cancelButton.Click += CancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(cancelButton);
            panel1.Location = new Point(0, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 100);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(172, 155);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 19;
            label1.Text = "Adresa";
            // 
            // comboStat
            // 
            comboStat.FormattingEnabled = true;
            comboStat.Location = new Point(172, 317);
            comboStat.Name = "comboStat";
            comboStat.Size = new Size(250, 23);
            comboStat.TabIndex = 20;
            // 
            // ZakaznikDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);
            Controls.Add(comboStat);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(labelJmeno);
            Controls.Add(textBoxJmeno);
            Controls.Add(labelTelefon);
            Controls.Add(textBoxTelefon);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelUlice);
            Controls.Add(textBoxUlice);
            Controls.Add(labelCisloPopisne);
            Controls.Add(textBoxCisloPopisne);
            Controls.Add(labelMesto);
            Controls.Add(textBoxMesto);
            Controls.Add(labelStat);
            Controls.Add(labelPsc);
            Controls.Add(textBoxPsc);
            Name = "ZakaznikDialog";
            Text = "Zakazník";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelJmeno;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUlice;
        private System.Windows.Forms.Label labelCisloPopisne;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Label labelPsc;

        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUlice;
        private System.Windows.Forms.TextBox textBoxCisloPopisne;
        private System.Windows.Forms.TextBox textBoxMesto;
        private System.Windows.Forms.TextBox textBoxPsc;

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private Panel panel1;
        private Label label1;
        private ComboBox comboStat;
    }
}
