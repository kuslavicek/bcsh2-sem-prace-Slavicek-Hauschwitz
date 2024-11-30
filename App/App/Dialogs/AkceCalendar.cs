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
    public partial class AkceCalendar : Form
    {
        private AkceRepo _akceRepo { get; set; }
        public AkceCalendar(AkceRepo akceRepo)
        {
            InitializeComponent();
            _akceRepo = akceRepo;
            this.LoadCalendar();
        }

        private void LoadCalendar()
        {
            var akces = _akceRepo.LoadAkce();

            kalendar.RemoveAllBoldedDates();

            foreach (var akce in akces)
            {
                kalendar.AddBoldedDate(akce.Datum);
            }

            kalendar.UpdateBoldedDates();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
