
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
            labelDatum = new Label();
            dateTimePickerDatum = new DateTimePicker();
            labelCena = new Label();
            textBoxCena = new TextBox();
            labelZakaznik = new Label();
            textBoxZakaznik = new TextBox();
            buttonEditZakaznik = new Button();
            labelFaktura = new Label();
            textBoxFaktura = new TextBox();
            buttonGenerateFaktura = new Button();
            buttonSave = new Button();
            buttonCancel = new Button();
            buttonAddZbozi = new Button();
            listViewZbozi = new ListView();
            listViewAkce = new ListView();
            buttonAddAkce = new Button();
            SuspendLayout();
            // 
            // labelDatum
            // 
            labelDatum.AutoSize = true;
            labelDatum.Location = new Point(23, 69);
            labelDatum.Margin = new Padding(4, 0, 4, 0);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(46, 15);
            labelDatum.TabIndex = 2;
            labelDatum.Text = "Datum:";
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Location = new Point(140, 69);
            dateTimePickerDatum.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(233, 23);
            dateTimePickerDatum.TabIndex = 3;
            // 
            // labelCena
            // 
            labelCena.AutoSize = true;
            labelCena.Location = new Point(23, 115);
            labelCena.Margin = new Padding(4, 0, 4, 0);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(37, 15);
            labelCena.TabIndex = 4;
            labelCena.Text = "Cena:";
            // 
            // textBoxCena
            // 
            textBoxCena.Location = new Point(140, 115);
            textBoxCena.Margin = new Padding(4, 3, 4, 3);
            textBoxCena.Name = "textBoxCena";
            textBoxCena.Size = new Size(233, 23);
            textBoxCena.TabIndex = 5;
            // 
            // labelZakaznik
            // 
            labelZakaznik.AutoSize = true;
            labelZakaznik.Location = new Point(23, 162);
            labelZakaznik.Margin = new Padding(4, 0, 4, 0);
            labelZakaznik.Name = "labelZakaznik";
            labelZakaznik.Size = new Size(56, 15);
            labelZakaznik.TabIndex = 6;
            labelZakaznik.Text = "Zákazník:";
            // 
            // textBoxZakaznik
            // 
            textBoxZakaznik.Enabled = false;
            textBoxZakaznik.Location = new Point(140, 162);
            textBoxZakaznik.Margin = new Padding(4, 3, 4, 3);
            textBoxZakaznik.Name = "textBoxZakaznik";
            textBoxZakaznik.Size = new Size(233, 23);
            textBoxZakaznik.TabIndex = 7;
            // 
            // buttonEditZakaznik
            // 
            buttonEditZakaznik.Location = new Point(385, 162);
            buttonEditZakaznik.Margin = new Padding(4, 3, 4, 3);
            buttonEditZakaznik.Name = "buttonEditZakaznik";
            buttonEditZakaznik.Size = new Size(88, 27);
            buttonEditZakaznik.TabIndex = 8;
            buttonEditZakaznik.Text = "Upravit";
            buttonEditZakaznik.UseVisualStyleBackColor = true;
            buttonEditZakaznik.Click += buttonEditZakaznik_Click;
            // 
            // labelFaktura
            // 
            labelFaktura.AutoSize = true;
            labelFaktura.Location = new Point(23, 208);
            labelFaktura.Margin = new Padding(4, 0, 4, 0);
            labelFaktura.Name = "labelFaktura";
            labelFaktura.Size = new Size(49, 15);
            labelFaktura.TabIndex = 9;
            labelFaktura.Text = "Faktura:";
            // 
            // textBoxFaktura
            // 
            textBoxFaktura.Enabled = false;
            textBoxFaktura.Location = new Point(140, 208);
            textBoxFaktura.Margin = new Padding(4, 3, 4, 3);
            textBoxFaktura.Name = "textBoxFaktura";
            textBoxFaktura.Size = new Size(233, 23);
            textBoxFaktura.TabIndex = 10;
            // 
            // buttonGenerateFaktura
            // 
            buttonGenerateFaktura.Location = new Point(385, 205);
            buttonGenerateFaktura.Margin = new Padding(4, 3, 4, 3);
            buttonGenerateFaktura.Name = "buttonGenerateFaktura";
            buttonGenerateFaktura.Size = new Size(88, 27);
            buttonGenerateFaktura.TabIndex = 11;
            buttonGenerateFaktura.Text = "Generovat";
            buttonGenerateFaktura.UseVisualStyleBackColor = true;
            buttonGenerateFaktura.Click += buttonEditFaktura_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(140, 254);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(88, 27);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Uložit";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(233, 254);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 27);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Zrušit";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddZbozi
            // 
            buttonAddZbozi.Location = new Point(481, 29);
            buttonAddZbozi.Margin = new Padding(4, 3, 4, 3);
            buttonAddZbozi.Name = "buttonAddZbozi";
            buttonAddZbozi.Size = new Size(303, 36);
            buttonAddZbozi.TabIndex = 13;
            buttonAddZbozi.Text = "Přidat zboží";
            buttonAddZbozi.UseVisualStyleBackColor = true;
            buttonAddZbozi.Click += buttonAddZbozi_Click;
            // 
            // listViewZbozi
            // 
            listViewZbozi.Location = new Point(481, 69);
            listViewZbozi.Margin = new Padding(4, 3, 4, 3);
            listViewZbozi.Name = "listViewZbozi";
            listViewZbozi.Size = new Size(300, 350);
            listViewZbozi.TabIndex = 0;
            listViewZbozi.UseCompatibleStateImageBehavior = false;
            listViewZbozi.View = View.Details;
            // 
            // listViewAkce
            // 
            listViewAkce.Location = new Point(791, 69);
            listViewAkce.Name = "listViewAkce";
            listViewAkce.Size = new Size(300, 350);
            listViewAkce.TabIndex = 14;
            listViewAkce.UseCompatibleStateImageBehavior = false;
            listViewAkce.View = View.Details;
            // 
            // buttonAddAkce
            // 
            buttonAddAkce.Location = new Point(791, 29);
            buttonAddAkce.Name = "buttonAddAkce";
            buttonAddAkce.Size = new Size(300, 34);
            buttonAddAkce.TabIndex = 15;
            buttonAddAkce.Text = "Přidat Akci";
            buttonAddAkce.UseVisualStyleBackColor = true;
            buttonAddAkce.Click += buttonAddAkce_Click;
            // 
            // ObjednavkaDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 577);
            Controls.Add(buttonAddAkce);
            Controls.Add(listViewAkce);
            Controls.Add(labelDatum);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(labelCena);
            Controls.Add(textBoxCena);
            Controls.Add(labelZakaznik);
            Controls.Add(textBoxZakaznik);
            Controls.Add(buttonEditZakaznik);
            Controls.Add(labelFaktura);
            Controls.Add(textBoxFaktura);
            Controls.Add(buttonGenerateFaktura);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(listViewZbozi);
            Controls.Add(buttonAddZbozi);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ObjednavkaDialog";
            Text = "Objednavka Dialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label labelZakaznik;
        private System.Windows.Forms.TextBox textBoxZakaznik;
        private System.Windows.Forms.Button buttonEditZakaznik;
        private System.Windows.Forms.Button buttonAddZbozi;
        private System.Windows.Forms.Label labelFaktura;
        private System.Windows.Forms.TextBox textBoxFaktura;
        private System.Windows.Forms.Button buttonGenerateFaktura;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewZbozi;
        private ListView listView1;
        private Button button1;
        private Button buttonAddAkce;
        private ListView listViewAkce;
    }
}
