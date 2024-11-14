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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Zakazník";

            // Label for Name
            this.labelJmeno = new System.Windows.Forms.Label();
            this.labelJmeno.Location = new System.Drawing.Point(20, 20);
            this.labelJmeno.Text = "Jméno:";
            this.Controls.Add(this.labelJmeno);

            // TextBox for Name
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.textBoxJmeno.Location = new System.Drawing.Point(130, 20);
            this.textBoxJmeno.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxJmeno);

            // Label for Phone
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelTelefon.Location = new System.Drawing.Point(20, 60);
            this.labelTelefon.Text = "Telefon:";
            this.Controls.Add(this.labelTelefon);

            // TextBox for Phone
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxTelefon.Location = new System.Drawing.Point(130, 60);
            this.textBoxTelefon.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxTelefon);

            // Label for Email
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmail.Location = new System.Drawing.Point(20, 100);
            this.labelEmail.Text = "Email:";
            this.Controls.Add(this.labelEmail);

            // TextBox for Email
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmail.Location = new System.Drawing.Point(130, 100);
            this.textBoxEmail.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxEmail);

            // Label for Address (Street)
            this.labelUlice = new System.Windows.Forms.Label();
            this.labelUlice.Location = new System.Drawing.Point(20, 140);
            this.labelUlice.Text = "Ulice:";
            this.Controls.Add(this.labelUlice);

            // TextBox for Street
            this.textBoxUlice = new System.Windows.Forms.TextBox();
            this.textBoxUlice.Location = new System.Drawing.Point(130, 140);
            this.textBoxUlice.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxUlice);

            // Label for House number
            this.labelCisloPopisne = new System.Windows.Forms.Label();
            this.labelCisloPopisne.Location = new System.Drawing.Point(20, 180);
            this.labelCisloPopisne.Text = "Číslo popisné:";
            this.Controls.Add(this.labelCisloPopisne);

            // TextBox for House number
            this.textBoxCisloPopisne = new System.Windows.Forms.TextBox();
            this.textBoxCisloPopisne.Location = new System.Drawing.Point(130, 180);
            this.textBoxCisloPopisne.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxCisloPopisne);

            // Label for City
            this.labelMesto = new System.Windows.Forms.Label();
            this.labelMesto.Location = new System.Drawing.Point(20, 220);
            this.labelMesto.Text = "Město:";
            this.Controls.Add(this.labelMesto);

            // TextBox for City
            this.textBoxMesto = new System.Windows.Forms.TextBox();
            this.textBoxMesto.Location = new System.Drawing.Point(130, 220);
            this.textBoxMesto.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxMesto);

            // Label for Country
            this.labelStat = new System.Windows.Forms.Label();
            this.labelStat.Location = new System.Drawing.Point(20, 260);
            this.labelStat.Text = "Stát:";
            this.Controls.Add(this.labelStat);

            // TextBox for Country
            this.textBoxStat = new System.Windows.Forms.TextBox();
            this.textBoxStat.Location = new System.Drawing.Point(130, 260);
            this.textBoxStat.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxStat);

            // Label for Postal code (optional)
            this.labelPsc = new System.Windows.Forms.Label();
            this.labelPsc.Location = new System.Drawing.Point(20, 300);
            this.labelPsc.Text = "PSČ:";
            this.Controls.Add(this.labelPsc);

            // TextBox for Postal code
            this.textBoxPsc = new System.Windows.Forms.TextBox();
            this.textBoxPsc.Location = new System.Drawing.Point(130, 300);
            this.textBoxPsc.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.textBoxPsc);

            // Save Button
            this.saveButton = new System.Windows.Forms.Button();
            this.saveButton.Location = new System.Drawing.Point(130, 340);
            this.saveButton.Text = "Uložit";
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.Controls.Add(this.saveButton);

            // Cancel Button
            this.cancelButton = new System.Windows.Forms.Button();
            this.cancelButton.Location = new System.Drawing.Point(230, 340);
            this.cancelButton.Text = "Zrušit";
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.Controls.Add(this.cancelButton);
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
        private System.Windows.Forms.TextBox textBoxStat;
        private System.Windows.Forms.TextBox textBoxPsc;

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
