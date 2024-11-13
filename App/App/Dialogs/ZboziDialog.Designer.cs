using App.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace App.Dialogs
{
    partial class ZboziDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Vstupní pole
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.TextBox txtObsahAlkoholu;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox comboSklad;
        private System.Windows.Forms.ComboBox comboTyp;
        private System.Windows.Forms.TextBox txtSpecificValue;

        // Tlačítka
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ZboziDialog";

            // Nazev label
            Label lblNazev = new Label();
            lblNazev.Text = "Název zboží:";
            lblNazev.Location = new Point(50, 30);
            lblNazev.Size = new Size(100, 23);
            this.Controls.Add(lblNazev);

            // TextBox pro název
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.txtNazev.Location = new System.Drawing.Point(150, 30);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(200, 20);

            // Obsah alkoholu label
            Label lblObsahAlkoholu = new Label();
            lblObsahAlkoholu.Text = "Obsah alkoholu:";
            lblObsahAlkoholu.Location = new Point(50, 60);
            lblObsahAlkoholu.Size = new Size(100, 23);
            this.Controls.Add(lblObsahAlkoholu);

            // TextBox pro obsah alkoholu
            this.txtObsahAlkoholu = new System.Windows.Forms.TextBox();
            this.txtObsahAlkoholu.Location = new System.Drawing.Point(150, 60);
            this.txtObsahAlkoholu.Name = "txtObsahAlkoholu";
            this.txtObsahAlkoholu.Size = new System.Drawing.Size(200, 20);

            // Cena label
            Label lblCena = new Label();
            lblCena.Text = "Cena:";
            lblCena.Location = new Point(50, 90);
            lblCena.Size = new Size(100, 23);
            this.Controls.Add(lblCena);

            // TextBox pro cenu
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtCena.Location = new System.Drawing.Point(150, 90);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(200, 20);

            // Sklad label
            Label lblSklad = new Label();
            lblSklad.Text = "Sklad:";
            lblSklad.Location = new Point(50, 120);
            lblSklad.Size = new Size(100, 23);
            this.Controls.Add(lblSklad);

            // ComboBox pro sklad
            this.comboSklad = new System.Windows.Forms.ComboBox();
            this.comboSklad.Location = new System.Drawing.Point(150, 120);
            this.comboSklad.Name = "comboSklad";
            this.comboSklad.Size = new System.Drawing.Size(200, 20);
            this.LoadSkladData();

            // Typ label
            Label lblTyp = new Label();
            lblTyp.Text = "Typ:";
            lblTyp.Location = new Point(50, 150);
            lblTyp.Size = new Size(100, 23);
            this.Controls.Add(lblTyp);

            // ComboBox pro typ
            this.comboTyp = new System.Windows.Forms.ComboBox();
            this.comboTyp.Location = new System.Drawing.Point(150, 150);
            this.comboTyp.Name = "comboTyp";
            this.comboTyp.Items.AddRange(new object[] { "p", "c" });
            this.comboTyp.SelectedIndex = 0;
            this.comboTyp.Size = new System.Drawing.Size(200, 20);

            // SpecificValue label
            Label lblSpecificValue = new Label();
            lblSpecificValue.Text = "Stupòovitost/odrùda:";
            lblSpecificValue.Location = new Point(50,180);
            lblSpecificValue.Size = new Size(100, 23);
            this.Controls.Add(lblSpecificValue);

            // TextBox pro specifickou hodnotu (např. stupnovitost nebo odrůda jablek)
            this.txtSpecificValue = new System.Windows.Forms.TextBox();
            this.txtSpecificValue.Location = new System.Drawing.Point(150, 180);
            this.txtSpecificValue.Name = "txtSpecificValue";
            this.txtSpecificValue.Size = new System.Drawing.Size(200, 20);

            // Tlačítko pro uložení
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.Location = new System.Drawing.Point(150, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Uložit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Tlačítko pro zrušení
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancel.Location = new System.Drawing.Point(250, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Zrušit";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Přidání všech ovládacích prvků do okna
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.txtObsahAlkoholu);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.comboSklad);
            this.Controls.Add(this.comboTyp);
            this.Controls.Add(this.txtSpecificValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
        }

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

        #endregion
    }
}