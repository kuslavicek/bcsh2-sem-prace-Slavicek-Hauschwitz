using App.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Dialogs.UsersDialogs
{
    public partial class ZamestnanecSelectDialog : Form
    {
        private ZamestnanecRepo repo { get; set; }
        public int id { get; set; }
        public string jmeno { get; set; }
        
        public ZamestnanecSelectDialog(ZamestnanecRepo repo,int id)
        {
            InitializeComponent();
            this.repo = repo;
            this.fill();
            this.id = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.id = (int)lvEmp.SelectedItems[0].Tag;
            this.jmeno = lvEmp.SelectedItems[0].SubItems[0].Text +" "+ lvEmp.SelectedItems[0].SubItems[1].Text;
            this.DialogResult = DialogResult.OK;
        }

        private void fill() {
            lvEmp.Columns.Clear();
            lvEmp.View = View.Details;
            lvEmp.FullRowSelect = true;
            lvEmp.Columns.Add("Jméno", 100);
            lvEmp.Columns.Add("Přijmení", 100);
            lvEmp.Columns.Add("E-mail", 150);
            lvEmp.Columns.Add("Telefonl", 130);

            var empList = this.repo.Load();
            lvEmp.Items.Clear();

            foreach (var emp in empList)
            {
                var item = new ListViewItem(new[]
                {
                    emp.Jmeno,
                    emp.Prijmeni,
                    emp.Nezobrazovat == 1 ? "*********" : emp.Email,
                    emp.Nezobrazovat == 1 ? "*********" : emp.Telefon.ToString(),
                });

                item.Tag = emp.Id;
                lvEmp.Items.Add(item);
            }
        }
    }
}
