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
    public partial class UpdateZboziForm : Form
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public decimal ObsahAlkoholu { get; set; }
        public decimal Cena { get; set; }
        public int IdSklad { get; set; }
        public char Typ { get; set; }

        private TextBox txtId;
        private TextBox txtNazev;
        private TextBox txtObsahAlkoholu;
        private TextBox txtCena;
        private ComboBox comboBoxSklad;
        private ComboBox comboBoxTyp;
        private Label labelSpecific;
        private Button btnConfirm;

        public UpdateZboziForm()
        {
            InitializeComponent();

            // Initialize controls
            txtId = new TextBox();
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
            this.Controls.Add(txtId);
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
            this.Controls.Add(new Label() { Text = "ID:", Location = new Point(10, y) });
            txtId.Location = new Point(100, y);
            y += 30;
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
            Id = int.Parse(txtId.Text);
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
