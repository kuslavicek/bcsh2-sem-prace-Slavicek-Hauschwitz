using App.Repositories;

namespace App.Dialogs
{
    partial class SurovinaDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private SkladRepo _skladRepository;

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
            _skladRepository = new SkladRepo();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Nová Surovina";

            // Název suroviny
            this.labelNazev = new System.Windows.Forms.Label();
            this.labelNazev.Text = "Název Suroviny:";
            this.labelNazev.Location = new System.Drawing.Point(20, 20);
            this.labelNazev.Size = new System.Drawing.Size(120, 20);

            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.textBoxNazev.Location = new System.Drawing.Point(140, 20);
            this.textBoxNazev.Size = new System.Drawing.Size(200, 20);

            // Množství suroviny
            this.labelMnozstvi = new System.Windows.Forms.Label();
            this.labelMnozstvi.Text = "Množství:";
            this.labelMnozstvi.Location = new System.Drawing.Point(20, 60);
            this.labelMnozstvi.Size = new System.Drawing.Size(120, 20);

            this.textBoxMnozstvi = new System.Windows.Forms.TextBox();
            this.textBoxMnozstvi.Location = new System.Drawing.Point(140, 60);
            this.textBoxMnozstvi.Size = new System.Drawing.Size(200, 20);

            // Název skladu
            this.labelSklad = new System.Windows.Forms.Label();
            this.labelSklad.Text = "Sklad:";
            this.labelSklad.Location = new System.Drawing.Point(20, 100);
            this.labelSklad.Size = new System.Drawing.Size(120, 20);

            this.comboSklad = new System.Windows.Forms.ComboBox();
            this.comboSklad.Location = new System.Drawing.Point(140, 100);
            this.comboSklad.Name = "comboSklad";
            this.comboSklad.Size = new System.Drawing.Size(200, 20);
            this.LoadSkladData();

            // Tlačítka
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonOk.Text = "Uložit";
            this.buttonOk.Location = new System.Drawing.Point(140, 150);
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);

            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCancel.Text = "Zrušit";
            this.buttonCancel.Location = new System.Drawing.Point(240, 150);
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // Přidání všech ovládacích prvků do formuláře
            this.Controls.Add(this.labelNazev);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.labelMnozstvi);
            this.Controls.Add(this.textBoxMnozstvi);
            this.Controls.Add(this.labelSklad);
            this.Controls.Add(this.comboSklad);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
        }

        #endregion
        private void LoadSkladData()
        {
            var sklady = _skladRepository.GetSklady();

            if (sklady == null || sklady.Count == 0)
            {
                MessageBox.Show("Nejsou k dispozici žádné sklady.");
                return;
            }

            this.comboSklad.DisplayMember = "Nazev";
            this.comboSklad.DataSource = sklady;
        }

        // Ovládací prvky
        private System.Windows.Forms.Label labelNazev;
        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.Label labelMnozstvi;
        private System.Windows.Forms.TextBox textBoxMnozstvi;
        private System.Windows.Forms.Label labelSklad;
        private System.Windows.Forms.ComboBox comboSklad;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}
