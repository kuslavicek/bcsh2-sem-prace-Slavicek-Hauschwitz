using App.Model;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Dialogs.ObjednavkaDialogs
{
    public partial class AkceManipulationDialog : Form
    {
        public delegate void AkceAddedEventHandler(Akce akce);
        public event AkceAddedEventHandler AkceAdded;
        private AkceRepo _akceRepo { get; set; }
        private TypAkceRepo _typAkceRepo { get; set; }
        private List<Akce> _akce { get; set; }
        public AkceManipulationDialog()
        {
            InitializeComponent();
            this._akceRepo = new AkceRepo();
            this._akce = new List<Akce>();
            this._typAkceRepo = new TypAkceRepo();
            this.fill();
        }

        private void btnAkceAdd_Click(object sender, EventArgs e)
        {
            if (!InputValidator.IsNotEmpty(textBox1, "Zadejte počet osob.") ||
                !InputValidator.IsNumberInRange(textBox1, 1, 1000, "Počet osob musí být mezi 1 a 1000.") ||
                !InputValidator.IsSelected(comboBox1, "Vyberte typ akce.") ||
                !InputValidator.IsDateValid(dateTimePicker1, DateTime.Now, null, "Datum musí být v budoucnosti."))
            {
                return;
            }

            var Akce = new Akce()
            {
                Id = null,
                PocetOsob = Convert.ToInt32(this.textBox1.Text),
                Datum = dateTimePicker1.Value,
                IdTypAkce = (int)comboBox1.SelectedValue,
                IdObjednavka = null,
            };

            AkceAdded?.Invoke(Akce);
            this.Close();
        }

        private void btnCancelAkce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill()
        {
            comboBox1.Items.Clear();

            var provozovnyDict = this._typAkceRepo.LoadTypyAkceForSelect();

            comboBox1.DataSource = new BindingSource(provozovnyDict, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
