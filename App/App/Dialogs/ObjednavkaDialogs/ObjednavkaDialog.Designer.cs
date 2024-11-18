
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
            btnDeleteZbozi = new Button();
            btnOdebratAkci = new Button();
            panel1 = new Panel();
            btnSaveFaktura = new Button();
            labelakce = new Label();
            labelZbozi = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDatum
            // 
            labelDatum.AutoSize = true;
            labelDatum.Location = new Point(472, 35);
            labelDatum.Margin = new Padding(4, 0, 4, 0);
            labelDatum.Name = "labelDatum";
            labelDatum.Size = new Size(46, 15);
            labelDatum.TabIndex = 2;
            labelDatum.Text = "Datum:";
            // 
            // dateTimePickerDatum
            // 
            dateTimePickerDatum.Location = new Point(526, 33);
            dateTimePickerDatum.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDatum.Name = "dateTimePickerDatum";
            dateTimePickerDatum.Size = new Size(233, 23);
            dateTimePickerDatum.TabIndex = 3;
            // 
            // labelCena
            // 
            labelCena.AutoSize = true;
            labelCena.Location = new Point(791, 35);
            labelCena.Margin = new Padding(4, 0, 4, 0);
            labelCena.Name = "labelCena";
            labelCena.Size = new Size(37, 15);
            labelCena.TabIndex = 4;
            labelCena.Text = "Cena:";
            // 
            // textBoxCena
            // 
            textBoxCena.Location = new Point(836, 33);
            textBoxCena.Margin = new Padding(4, 3, 4, 3);
            textBoxCena.Name = "textBoxCena";
            textBoxCena.Size = new Size(233, 23);
            textBoxCena.TabIndex = 5;
            // 
            // labelZakaznik
            // 
            labelZakaznik.AutoSize = true;
            labelZakaznik.Location = new Point(462, 65);
            labelZakaznik.Margin = new Padding(4, 0, 4, 0);
            labelZakaznik.Name = "labelZakaznik";
            labelZakaznik.Size = new Size(56, 15);
            labelZakaznik.TabIndex = 6;
            labelZakaznik.Text = "Zákazník:";
            // 
            // textBoxZakaznik
            // 
            textBoxZakaznik.Enabled = false;
            textBoxZakaznik.Location = new Point(526, 62);
            textBoxZakaznik.Margin = new Padding(4, 3, 4, 3);
            textBoxZakaznik.Name = "textBoxZakaznik";
            textBoxZakaznik.Size = new Size(233, 23);
            textBoxZakaznik.TabIndex = 7;
            // 
            // buttonEditZakaznik
            // 
            buttonEditZakaznik.Location = new Point(170, 9);
            buttonEditZakaznik.Margin = new Padding(4, 3, 4, 3);
            buttonEditZakaznik.Name = "buttonEditZakaznik";
            buttonEditZakaznik.Size = new Size(152, 36);
            buttonEditZakaznik.TabIndex = 8;
            buttonEditZakaznik.Text = "Zákazník";
            buttonEditZakaznik.UseVisualStyleBackColor = true;
            buttonEditZakaznik.Click += buttonEditZakaznik_Click;
            // 
            // labelFaktura
            // 
            labelFaktura.AutoSize = true;
            labelFaktura.Location = new Point(779, 65);
            labelFaktura.Margin = new Padding(4, 0, 4, 0);
            labelFaktura.Name = "labelFaktura";
            labelFaktura.Size = new Size(49, 15);
            labelFaktura.TabIndex = 9;
            labelFaktura.Text = "Faktura:";
            // 
            // textBoxFaktura
            // 
            textBoxFaktura.Enabled = false;
            textBoxFaktura.Location = new Point(836, 65);
            textBoxFaktura.Margin = new Padding(4, 3, 4, 3);
            textBoxFaktura.Name = "textBoxFaktura";
            textBoxFaktura.Size = new Size(233, 23);
            textBoxFaktura.TabIndex = 10;
            // 
            // buttonGenerateFaktura
            // 
            buttonGenerateFaktura.Location = new Point(9, 9);
            buttonGenerateFaktura.Margin = new Padding(4, 3, 4, 3);
            buttonGenerateFaktura.Name = "buttonGenerateFaktura";
            buttonGenerateFaktura.Size = new Size(153, 36);
            buttonGenerateFaktura.TabIndex = 11;
            buttonGenerateFaktura.Text = "Generovat fakturu";
            buttonGenerateFaktura.UseVisualStyleBackColor = true;
            buttonGenerateFaktura.Click += buttonEditFaktura_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(9, 421);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(153, 36);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Uložit";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(170, 421);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(152, 36);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Zrušit";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAddZbozi
            // 
            buttonAddZbozi.Location = new Point(9, 240);
            buttonAddZbozi.Margin = new Padding(4, 3, 4, 3);
            buttonAddZbozi.Name = "buttonAddZbozi";
            buttonAddZbozi.Size = new Size(153, 36);
            buttonAddZbozi.TabIndex = 13;
            buttonAddZbozi.Text = "Přidat zboží";
            buttonAddZbozi.UseVisualStyleBackColor = true;
            buttonAddZbozi.Click += buttonAddZbozi_Click;
            // 
            // listViewZbozi
            // 
            listViewZbozi.FullRowSelect = true;
            listViewZbozi.Location = new Point(472, 135);
            listViewZbozi.Margin = new Padding(4, 3, 4, 3);
            listViewZbozi.Name = "listViewZbozi";
            listViewZbozi.Size = new Size(300, 372);
            listViewZbozi.TabIndex = 0;
            listViewZbozi.UseCompatibleStateImageBehavior = false;
            listViewZbozi.View = View.Details;
            // 
            // listViewAkce
            // 
            listViewAkce.FullRowSelect = true;
            listViewAkce.Location = new Point(779, 135);
            listViewAkce.Name = "listViewAkce";
            listViewAkce.Size = new Size(300, 372);
            listViewAkce.TabIndex = 14;
            listViewAkce.UseCompatibleStateImageBehavior = false;
            listViewAkce.View = View.Details;
            // 
            // buttonAddAkce
            // 
            buttonAddAkce.Location = new Point(9, 282);
            buttonAddAkce.Name = "buttonAddAkce";
            buttonAddAkce.Size = new Size(153, 34);
            buttonAddAkce.TabIndex = 15;
            buttonAddAkce.Text = "Přidat Akci";
            buttonAddAkce.UseVisualStyleBackColor = true;
            buttonAddAkce.Click += buttonAddAkce_Click;
            // 
            // btnDeleteZbozi
            // 
            btnDeleteZbozi.Location = new Point(169, 240);
            btnDeleteZbozi.Name = "btnDeleteZbozi";
            btnDeleteZbozi.Size = new Size(153, 36);
            btnDeleteZbozi.TabIndex = 16;
            btnDeleteZbozi.Text = "Odebrat zboží";
            btnDeleteZbozi.UseVisualStyleBackColor = true;
            btnDeleteZbozi.Click += btnDeleteZbozi_Click;
            // 
            // btnOdebratAkci
            // 
            btnOdebratAkci.Location = new Point(169, 282);
            btnOdebratAkci.Name = "btnOdebratAkci";
            btnOdebratAkci.Size = new Size(153, 34);
            btnOdebratAkci.TabIndex = 17;
            btnOdebratAkci.Text = "Odebrat akci";
            btnOdebratAkci.UseVisualStyleBackColor = true;
            btnOdebratAkci.Click += btnOdebratAkci_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSaveFaktura);
            panel1.Controls.Add(btnDeleteZbozi);
            panel1.Controls.Add(btnOdebratAkci);
            panel1.Controls.Add(buttonAddZbozi);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonAddAkce);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonGenerateFaktura);
            panel1.Controls.Add(buttonEditZakaznik);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 472);
            panel1.TabIndex = 18;
            // 
            // btnSaveFaktura
            // 
            btnSaveFaktura.Enabled = false;
            btnSaveFaktura.Location = new Point(9, 51);
            btnSaveFaktura.Name = "btnSaveFaktura";
            btnSaveFaktura.Size = new Size(153, 35);
            btnSaveFaktura.TabIndex = 18;
            btnSaveFaktura.Text = "Stáhnout fakturu";
            btnSaveFaktura.UseVisualStyleBackColor = true;
            btnSaveFaktura.Click += btnSaveFaktura_Click;
            // 
            // labelakce
            // 
            labelakce.AutoSize = true;
            labelakce.Location = new Point(779, 117);
            labelakce.Name = "labelakce";
            labelakce.Size = new Size(33, 15);
            labelakce.TabIndex = 19;
            labelakce.Text = "Akce";
            // 
            // labelZbozi
            // 
            labelZbozi.AutoSize = true;
            labelZbozi.Location = new Point(472, 117);
            labelZbozi.Name = "labelZbozi";
            labelZbozi.Size = new Size(36, 15);
            labelZbozi.TabIndex = 20;
            labelZbozi.Text = "Zboží";
            // 
            // ObjednavkaDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 577);
            Controls.Add(labelZbozi);
            Controls.Add(labelakce);
            Controls.Add(panel1);
            Controls.Add(listViewAkce);
            Controls.Add(labelDatum);
            Controls.Add(dateTimePickerDatum);
            Controls.Add(labelCena);
            Controls.Add(textBoxCena);
            Controls.Add(labelZakaznik);
            Controls.Add(textBoxZakaznik);
            Controls.Add(labelFaktura);
            Controls.Add(textBoxFaktura);
            Controls.Add(listViewZbozi);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ObjednavkaDialog";
            Text = "Objednavka Dialog";
            panel1.ResumeLayout(false);
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
        private Button btnOdebratAkci;
        private Button buttonAddAkce;
        private ListView listViewAkce;
        private Button btnDeleteZbozi;
        private Panel panel1;
        private Label labelakce;
        private Label labelZbozi;
        private Button btnSaveFaktura;
    }
}
