using App.Dialogs.ObjednavkaDialogs;
using App.Dialogs.ZamestnanciDialogs;
using App.Model;
using App.Model.Enums;
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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.Dialogs
{
    public partial class ZamestnanecDialog : Form
    {
        private ZamestnanecRepo _empRepo { get; set; }
        private PracovniPoziceRepo _poziceRepo { get; set; }
        private ProvozovnaRepo _provozovnaRepo { get; set; }
        private Zamestnanec Emp { get; set; }
        private string? Nadrizeny { get; set; }
        private bool IsEditMode { get; set; }
        public ZamestnanecDialog(ZamestnanecRepo empRepo, Zamestnanec emp, string? nadrizeny, bool edit)
        {
            InitializeComponent();
            _poziceRepo = new PracovniPoziceRepo();
            _provozovnaRepo = new ProvozovnaRepo();
            if (emp == null) { this.Emp = new Zamestnanec(); } 
            this._empRepo = empRepo;
            this.Nadrizeny = nadrizeny;
            if (edit)
            {
                this.IsEditMode = edit;
                this.Emp = emp;
            }
            this.fill();
        }

        private void btnNadrizeny_Click(object sender, EventArgs e)
        {
            try
            {
                NadrizenySelectDialog nadrizenyDialog = new NadrizenySelectDialog();
                if (nadrizenyDialog.ShowDialog() == DialogResult.OK)
                {
                    this.Nadrizeny = nadrizenyDialog.NadrizenyJmeno;
                    this.Emp.IdNadrizeny = nadrizenyDialog.IdNadrizeny;
                    nadrizenyDialog.Close();
                    this.fill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode)
                {
                    this.Emp.Jmeno = txtJmeno.Text;
                    this.Emp.Prijmeni = txtPrijmeni.Text;
                    this.Emp.Email = txtEmail.Text;
                    this.Emp.Telefon = double.Parse(txtTelefon.Text);
                    this.Emp.IdProvozovna = comboProvozovna.SelectedIndex + 1;
                    this.Emp.IdPracovniPozice = comboPozice.SelectedIndex + 1;
                    _empRepo.UpdateZamestnanec(this.Emp);
                    MessageBox.Show("Zaměstnanec byl úspěšně aktualizován.");
                }
                else
                {
                    var emp = new Zamestnanec
                    {
                        Id=null,
                        Jmeno = txtJmeno.Text,
                        Prijmeni = txtPrijmeni.Text,
                        Email = txtEmail.Text,
                        Telefon = double.Parse(txtTelefon.Text),
                        IdProvozovna = comboProvozovna.SelectedIndex + 1,
                        IdPracovniPozice = comboPozice.SelectedIndex + 1,
                        IdNadrizeny = this.Emp.IdNadrizeny
                    };

                    _empRepo.UpdateZamestnanec(emp);
                    MessageBox.Show("Zaměstnanec byl úspěšně přidán.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill()
        {
            var poziceDict = _poziceRepo.LoadPracovniPoziceForSelect();

            comboPozice.DataSource = new BindingSource(poziceDict, null);
            comboPozice.DisplayMember = "Value";
            comboPozice.ValueMember = "Key";

            var provozovnyDict = _provozovnaRepo.GetProvozovnyEnum();

            comboProvozovna.DataSource = new BindingSource(provozovnyDict, null);
            comboProvozovna.DisplayMember = "Value";
            comboProvozovna.ValueMember = "Key";

            this.comboPozice.SelectedIndex = 0;
            this.comboProvozovna.SelectedIndex = 0;

            this.txtNadrizeny.Text = this.Nadrizeny;

            if (this.IsEditMode) {
                this.txtJmeno.Text = this.Emp.Jmeno;
                this.txtPrijmeni.Text = this.Emp.Prijmeni;
                this.txtEmail.Text = this.Emp.Email;
                this.txtTelefon.Text = this.Emp.Telefon.ToString();
                this.comboPozice.SelectedIndex = this.Emp.IdPracovniPozice.Value - 1;
                this.comboProvozovna.SelectedIndex = this.Emp.IdProvozovna.Value - 1;
            }
        }

        private void btnRemoveNadrizeny_Click(object sender, EventArgs e)
        {
            this.Nadrizeny = "";
            this.Emp.IdNadrizeny = null;
            this.txtNadrizeny.Text = "";
        }
    }
}
