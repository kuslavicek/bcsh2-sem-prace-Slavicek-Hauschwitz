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

namespace App.Dialogs.ZakaznikDialogs
{
    public partial class HladinaDialog : Form
    {
        private ZakaznikRepo _zakaznikRepo { get; set; }
        private int id { get; set; }
        private string jmeno { get; set; }
        public HladinaDialog(ZakaznikRepo repo, int id,string jmeno)
        {
            this._zakaznikRepo = repo;
            this.id = id;
            this.jmeno = jmeno;
            InitializeComponent();
            this.txtZakaznik.Text = jmeno;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputValidator.IsValidPercentage(txtHladina.Text)||
                    !InputValidator.IsNotEmpty(txtHladina))
                {
                    _zakaznikRepo.SetDiscount(this.id, double.Parse(txtHladina.Text));
                }
                else
                {
                    MessageBox.Show("Cenová hladina musí být určena v procentech.");
                    return;
                }
            }
            catch {
                MessageBox.Show("Chyba.");
            }

            MessageBox.Show("Cenová hladina pro zákazníka "+jmeno+" byla uložena a objednávky ve stavu 'Zpracovává se' byly přepočítány.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
