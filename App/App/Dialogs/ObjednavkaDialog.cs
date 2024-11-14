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

namespace App.Dialogs
{
    public partial class ObjednavkaDialog : Form
    {
        private ObjednavkaRepo _objednavkaRepo;
        private ZakaznikRepo _zakaznikRepo;
        public bool IsEditMode { get; set; } = false;
        private Objednavka objednavka { get; set; }
        private Zakaznik zakaznik { get; set; }
        public ObjednavkaDialog(ObjednavkaRepo objednavkaRepo, Objednavka objednavka, bool edit)
        {
            InitializeComponent();
            this.IsEditMode = edit;
            this._objednavkaRepo = objednavkaRepo;
            this._zakaznikRepo = new ZakaznikRepo();
            this.objednavka = objednavka;
            this.zakaznik = _zakaznikRepo.GetZakaznikById(this.objednavka.IdZakaznik);
            if (this.IsEditMode) { this.fillData(); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonEditFaktura_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonEditZakaznik_Click(object sender, EventArgs e)
        {
            try
            {
                ZakaznikDialog zakaznikDialog = new ZakaznikDialog(_zakaznikRepo, zakaznik, true);
                if (zakaznikDialog.ShowDialog() == DialogResult.OK)
                {
                    zakaznikDialog.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillData()
        {
            if (this.IsEditMode) {
                this.textBoxCena.Text=this.objednavka.Cena.ToString();
                this.dateTimePickerDatum.Value = this.objednavka.DatumZalozeni;
                this.textBoxZakaznik.Text=this.zakaznik.Jmeno.ToString();
            }
        }
    }
}
