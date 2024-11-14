namespace App.Dialogs
{
    partial class ObjednavkaDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Text = "Objednavka Dialog";

            // Label pro datum
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(20, 60);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(40, 13);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "Datum:";

            // DateTimePicker pro datum
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatum.Location = new System.Drawing.Point(120, 60);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatum.TabIndex = 3;

            // Label pro cenu
            this.labelCena = new System.Windows.Forms.Label();
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(20, 100);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(34, 13);
            this.labelCena.TabIndex = 4;
            this.labelCena.Text = "Cena:";

            // TextBox pro cenu
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxCena.Location = new System.Drawing.Point(120, 100);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(200, 20);
            this.textBoxCena.TabIndex = 5;

            // Label pro zákazníka
            this.labelZakaznik = new System.Windows.Forms.Label();
            this.labelZakaznik.AutoSize = true;
            this.labelZakaznik.Location = new System.Drawing.Point(20, 140);
            this.labelZakaznik.Name = "labelZakaznik";
            this.labelZakaznik.Size = new System.Drawing.Size(56, 13);
            this.labelZakaznik.TabIndex = 6;
            this.labelZakaznik.Text = "Zákazník:";

            // TextBox pro jméno zákazníka (disabled)
            this.textBoxZakaznik = new System.Windows.Forms.TextBox();
            this.textBoxZakaznik.Location = new System.Drawing.Point(120, 140);
            this.textBoxZakaznik.Name = "textBoxZakaznik";
            this.textBoxZakaznik.Size = new System.Drawing.Size(200, 20);
            this.textBoxZakaznik.TabIndex = 7;
            this.textBoxZakaznik.Enabled = false; // Disabled, aby uživatel nemohl editovat

            // Tlačítko pro úpravu zákazníka
            this.buttonEditZakaznik = new System.Windows.Forms.Button();
            this.buttonEditZakaznik.Location = new System.Drawing.Point(330, 140);
            this.buttonEditZakaznik.Name = "buttonEditZakaznik";
            this.buttonEditZakaznik.Size = new System.Drawing.Size(75, 23);
            this.buttonEditZakaznik.TabIndex = 8;
            this.buttonEditZakaznik.Text = "Upravit";
            this.buttonEditZakaznik.UseVisualStyleBackColor = true;
            this.buttonEditZakaznik.Click += new System.EventHandler(this.buttonEditZakaznik_Click);

            // Label pro fakturu
            this.labelFaktura = new System.Windows.Forms.Label();
            this.labelFaktura.AutoSize = true;
            this.labelFaktura.Location = new System.Drawing.Point(20, 180);
            this.labelFaktura.Name = "labelFaktura";
            this.labelFaktura.Size = new System.Drawing.Size(46, 13);
            this.labelFaktura.TabIndex = 9;
            this.labelFaktura.Text = "Faktura:";

            // TextBox pro název faktury (disabled)
            this.textBoxFaktura = new System.Windows.Forms.TextBox();
            this.textBoxFaktura.Location = new System.Drawing.Point(120, 180);
            this.textBoxFaktura.Name = "textBoxFaktura";
            this.textBoxFaktura.Size = new System.Drawing.Size(200, 20);
            this.textBoxFaktura.TabIndex = 10;
            this.textBoxFaktura.Enabled = false; // Disabled, aby uživatel nemohl editovat

            // Tlačítko pro úpravu faktury
            this.buttonEditFaktura = new System.Windows.Forms.Button();
            this.buttonEditFaktura.Location = new System.Drawing.Point(330, 180);
            this.buttonEditFaktura.Name = "buttonEditFaktura";
            this.buttonEditFaktura.Size = new System.Drawing.Size(75, 23);
            this.buttonEditFaktura.TabIndex = 11;
            this.buttonEditFaktura.Text = "Upravit";
            this.buttonEditFaktura.UseVisualStyleBackColor = true;
            this.buttonEditFaktura.Click += new System.EventHandler(this.buttonEditFaktura_Click);

            // Tlačítko pro uložení
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSave.Location = new System.Drawing.Point(120, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Uložit";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // Tlačítko pro zrušení
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCancel.Location = new System.Drawing.Point(200, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Zrušit";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // ListView pro zobrazení zboží
            this.listViewZbozi = new System.Windows.Forms.ListView();
            this.listViewZbozi.Location = new System.Drawing.Point(400, 60);
            this.listViewZbozi.Name = "listViewZbozi";
            this.listViewZbozi.Size = new System.Drawing.Size(450, 300);
            this.listViewZbozi.View = View.Details;
            this.Controls.Add(this.listViewZbozi);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.labelZakaznik);
            this.Controls.Add(this.textBoxZakaznik);
            this.Controls.Add(this.buttonEditZakaznik);
            this.Controls.Add(this.labelFaktura);
            this.Controls.Add(this.textBoxFaktura);
            this.Controls.Add(this.buttonEditFaktura);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.listViewZbozi);
            this.Name = "ObjednavkaDialog";
        }

        #endregion

        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label labelZakaznik;
        private System.Windows.Forms.TextBox textBoxZakaznik;
        private System.Windows.Forms.Button buttonEditZakaznik;
        private System.Windows.Forms.Label labelFaktura;
        private System.Windows.Forms.TextBox textBoxFaktura;
        private System.Windows.Forms.Button buttonEditFaktura;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewZbozi;
    }
}
