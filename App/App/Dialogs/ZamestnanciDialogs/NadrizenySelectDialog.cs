using App.Model;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Dialogs.ZamestnanciDialogs
{
    public partial class NadrizenySelectDialog : Form
    {
        public string NadrizenyJmeno { get; set; }
        public int IdNadrizeny {get; set;}
        private ZamestnanecRepo _empRepo { get; set; }

        public NadrizenySelectDialog()
        {
            InitializeComponent();
            this._empRepo = new ZamestnanecRepo();
            this.fill();
        }

        private void fill()
        {
            lvEmp.Columns.Clear();
            lvEmp.View = View.Details;
            lvEmp.FullRowSelect = true;
            lvEmp.Columns.Add("Jméno", 150);
            lvEmp.Columns.Add("Přijmení", 100);
            lvEmp.Columns.Add("E-mail", 150);
            lvEmp.Columns.Add("Telefonl", 150);
            var empList = _empRepo.Load();
            lvEmp.Items.Clear();

            foreach (var emp in empList)
            {
                var item = new ListViewItem(new[]
                {
                    emp.Jmeno,
                    emp.Prijmeni,
                    emp.Email,
                    emp.Telefon.ToString(),
                });

                item.Tag = emp.Id;
                lvEmp.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvEmp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvEmp.SelectedItems[0];
            this.NadrizenyJmeno=selectedItem.SubItems[0].Text+" "+selectedItem.SubItems[1].Text;
            this.IdNadrizeny = Convert.ToInt32(selectedItem.Tag);
            MessageBox.Show("Nadžízený zaměstnanec byl uložený.");
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
