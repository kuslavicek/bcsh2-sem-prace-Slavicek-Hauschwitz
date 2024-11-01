using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class InsertZboziForm : Form
    {
        public string Nazev { get; private set; }
        public decimal ObsahAlkoholu { get; private set; }
        public decimal Cena { get; private set; }
        public int IdSklad { get; private set; }
        public char Typ { get; private set; }

        private TextBox txtNazev;
        private TextBox txtObsahAlkoholu;
        private TextBox txtCena;
        private ComboBox comboBoxSklad;
        private ComboBox comboBoxTyp;
        private Label labelSpecific;
        private Button btnConfirm;

        public InsertZboziForm()
        {
            InitializeComponent();

            // Initialize controls
            txtNazev = new TextBox();
            txtObsahAlkoholu = new TextBox();
            txtCena = new TextBox();
            comboBoxSklad = new ComboBox();
            comboBoxTyp = new ComboBox();
            labelSpecific = new Label();
            btnConfirm = new Button();

            // Set properties and event handlers
            comboBoxTyp.Items.Add("c");
            comboBoxTyp.Items.Add("p");
            comboBoxTyp.SelectedIndexChanged += (s, e) => UpdateLabels();

            btnConfirm.Text = "Confirm";
            btnConfirm.Click += btnConfirm_Click;

            // Add controls to the form
            this.Controls.Add(txtNazev);
            this.Controls.Add(txtObsahAlkoholu);
            this.Controls.Add(txtCena);
            this.Controls.Add(comboBoxSklad);
            this.Controls.Add(comboBoxTyp);
            this.Controls.Add(labelSpecific);
            this.Controls.Add(btnConfirm);

            // Set layout
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Example layout (you can adjust as needed)
            int y = 10;
            this.Controls.Add(new Label() { Text = "Název:", Location = new Point(10, y) });
            txtNazev.Location = new Point(100, y);
            y += 30;
            this.Controls.Add(new Label() { Text = "Obsah alkoholu:", Location = new Point(10, y) });
            txtObsahAlkoholu.Location = new Point(100, y);
            y += 30;
            this.Controls.Add(new Label() { Text = "Cena:", Location = new Point(10, y) });
            txtCena.Location = new Point(100, y);
            y += 30;
            this.Controls.Add(new Label() { Text = "Sklad:", Location = new Point(10, y) });
            comboBoxSklad.Location = new Point(100, y);
            y += 30;
            this.Controls.Add(new Label() { Text = "Typ:", Location = new Point(10, y) });
            comboBoxTyp.Location = new Point(100, y);
            y += 30;
            labelSpecific.Location = new Point(10, y);
            y += 30;
            btnConfirm.Location = new Point(10, y);
        }

        private void UpdateLabels()
        {
            if (comboBoxTyp.SelectedItem != null)
            {
                char selectedTyp = comboBoxTyp.SelectedItem.ToString()[0];
                if (selectedTyp == 'c')
                {
                    labelSpecific.Text = "Odruda jablek:";
                }
                else if (selectedTyp == 'p')
                {
                    labelSpecific.Text = "Stupnovitost:";
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Nazev = txtNazev.Text;
            ObsahAlkoholu = decimal.Parse(txtObsahAlkoholu.Text);
            Cena = decimal.Parse(txtCena.Text);
            IdSklad = (int)comboBoxSklad.SelectedValue;
            Typ = char.Parse(comboBoxTyp.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
