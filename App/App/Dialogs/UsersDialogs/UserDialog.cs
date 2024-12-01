using App.Dialogs.UsersDialogs;
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

namespace App.Dialogs
{
    public partial class UserDialog : Form
    {
        private UserRepo _userRepo { get; set; }
        private ZamestnanecRepo _empRepo { get; set; }
        private User User { get; set; }
        private Zamestnanec emp { get; set; }
        private bool IsEditMode { get; set; }
        public UserDialog(UserRepo repo, User user, bool edit)
        {
            InitializeComponent();
            this.User = user;
            this._userRepo = repo;
            _empRepo = new ZamestnanecRepo();
            this.IsEditMode = edit;
            this.fill();
        }

        private void btnChooseEmpl_Click(object sender, EventArgs e)
        {
            ZamestnanecSelectDialog empDialog = new ZamestnanecSelectDialog(_empRepo,this.User!=null?this.User.Id:0);
            DialogResult result = empDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.User.Id = empDialog.id;
                this.txtZamestnanec.Text = empDialog.jmeno;
                empDialog.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fill() {
            comboRole.DataSource = Enum.GetValues(typeof(RoleEnum));
            if (IsEditMode) {
                this.emp = this._empRepo.GetZamestnanecByID(this.User.IdZamestnanec);
                this.txtJmeno.Text=this.User.Jmeno;
                this.txtZamestnanec.Text = this.emp.Jmeno+" "+this.emp.Prijmeni;
                if (Enum.TryParse(typeof(RoleEnum), this.User.Role, out var selectedRole))
                {
                    comboRole.SelectedItem = (RoleEnum)selectedRole;
                }
                if (this.User.boolean == 1)
                {
                    this.checkOs.Checked = true;
                }
                else { 
                    this.checkOs.Checked=false;
                }
            }
        }
    }
}
