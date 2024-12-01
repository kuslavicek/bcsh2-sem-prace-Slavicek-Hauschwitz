using App.Repositories;
using App.Model;
using App.Dialogs;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using App.Dialogs.ObjednavkaDialogs;
using App.Dialogs.ZakaznikDialogs;
using App.Dialogs.SkladDialogs;

namespace App
{
    public partial class Form1 : Form
    {
        private ZboziData _zboziData;
        private SurovinaRepo _surovinaRepo;
        private ZakaznikRepo _zakaznikRepo;
        private AdresaRepo _adresaRepo;
        private ObjednavkaRepo _objednavkaRepo;
        private ObjednaneZboziRepo _objednaneZboziRepo;
        private ProvozovnaRepo _provozovnaRepo;
        private PracovniPoziceRepo _poziceRepo;
        private ZamestnanecRepo _zamestnanecRepo;
        private TypAkceRepo _typAkceRepo;
        private SkladRepo _skladRepo;
        private AkceRepo _akceRepo;
        private FakturaRepo _fakturaRepo;
        private UserRepo _usersRepo;
        private Dictionary<int, string> skladyDict;
        private readonly Database _database;
        private User? loggedUser = null;
        private User? emulUser = null;
        public Form1()
        {
            InitializeComponent();
            //logout(); //todo odkomentovat
            _database = new Database();
            this.initBtns();
            _skladRepo = new SkladRepo();
            this.skladyDict = _skladRepo.LoadSkladyForSelect();
            LoadSklady();

            _zboziData = new ZboziData();
            LoadZbozi();
            LoadZboziFiltr();

            _surovinaRepo = new SurovinaRepo();
            LoadSuroviny();

            _zakaznikRepo = new ZakaznikRepo();
            LoadZakaznici();

            _adresaRepo = new AdresaRepo();
            LoadAdresy();
            _objednavkaRepo = new ObjednavkaRepo();
            LoadObjednavky();

            _provozovnaRepo = new ProvozovnaRepo();
            LoadProvozovna();

            _poziceRepo = new PracovniPoziceRepo();
            LoadPozice();

            _zamestnanecRepo = new ZamestnanecRepo();
            LoadZamestnanec();

            _typAkceRepo = new TypAkceRepo();
            LoadTypyAkce();

            _fakturaRepo = new FakturaRepo();
            LoadFaktury();

            _akceRepo = new AkceRepo();
            LoadAkce();

            _objednaneZboziRepo = new ObjednaneZboziRepo();
            LoadObjZbozi();

            _usersRepo = new UserRepo();
            LoadUsers();
        }
        #region Zbozi

        private void LoadZbozi()
        {
            lvPiva.Columns.Clear();
            lvPiva.View = View.Details;
            lvPiva.FullRowSelect = true;
            lvPiva.Columns.Add("N�zev", 220);
            lvPiva.Columns.Add("Obsah alkoholu", 100);
            lvPiva.Columns.Add("Cena", 150);
            lvPiva.Columns.Add("Typ", 100);
            lvPiva.Columns.Add("N�zev skladu", 200);
            lvPiva.Columns.Add("Stup�ovitost/odr�da", 100);

            var zboziList = _zboziData.Load();
            lvPiva.Items.Clear();

            foreach (var zbozi in zboziList)
            {
                string specificValue = zbozi.Typ == 'c' ? zbozi.OdrudaJablek : zbozi.Stupnovitost.ToString();

                var item = new ListViewItem(new[]
                {
                    zbozi.Nazev,
                    zbozi.ObsahAlkoholu.ToString(),
                    zbozi.Cena.ToString(),
                    zbozi.Typ.ToString(),
                    zbozi.SkladNazev.ToString(),
                    specificValue
                });

                item.Tag = zbozi.Id;
                lvPiva.Items.Add(item);
            }
        }
        #region zbo�� filtr
        private void btnCancelFiltrZbozi_Click(object sender, EventArgs e)
        {
            LoadZbozi();
        }
        private void btnFiltrZbozi_Click(object sender, EventArgs e)
        {
            string selectedColumn = comboFiltrZbozi.SelectedItem.ToString();
            string filterValue = txtFiltrValueZbozi.Text.ToLower();
            if (comboFiltrZbozi.SelectedIndex == 3)
            {
                filterValue = comboFiltrTypZbozi.Text.ToLower();
            }
            else if (comboFiltrZbozi.SelectedIndex == 4)
            {
                filterValue = comboSkladFiltrZbozi.Text.ToLower();
            }

            List<ListViewItem> filteredItems = new List<ListViewItem>();
            List<ListViewItem> nonFilteredItems = new List<ListViewItem>();

            foreach (ListViewItem item in lvPiva.Items)
            {
                string[] itemValues = item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text.ToLower()).ToArray();

                int columnIndex = -1;

                switch (selectedColumn)
                {
                    case "N�zev":
                        columnIndex = 0;
                        break;
                    case "Obsah alkoholu":
                        columnIndex = 1;
                        break;
                    case "Cena":
                        columnIndex = 2;
                        break;
                    case "Typ":
                        columnIndex = 3;
                        break;
                    case "N�zev skladu":
                        columnIndex = 4;
                        break;
                    case "Stup�ovitost/odr�da":
                        columnIndex = 5;
                        break;
                }

                if (columnIndex != -1 && itemValues[columnIndex].Contains(filterValue))
                {
                    filteredItems.Add(item);
                }
                else
                {
                    nonFilteredItems.Add(item);
                }
            }
            lvPiva.Items.Clear();

            foreach (var item in filteredItems)
            {
                lvPiva.Items.Add(item);
            }

            foreach (var item in nonFilteredItems)
            {
                lvPiva.Items.Add(item);
            }

            if (lvPiva.Items.Count > 0 && filteredItems.Count > 0)
            {
                lvPiva.Items[0].BackColor = Color.LightYellow;
            }
        }

        private void LoadZboziFiltr()
        {
            comboFiltrZbozi.Items.Clear();
            comboFiltrZbozi.Items.Add("N�zev");
            comboFiltrZbozi.Items.Add("Obsah alkoholu");
            comboFiltrZbozi.Items.Add("Cena");
            comboFiltrZbozi.Items.Add("Typ");
            comboFiltrZbozi.Items.Add("N�zev skladu");
            comboFiltrZbozi.Items.Add("Stup�ovitost/odr�da");

            comboFiltrZbozi.SelectedIndex = 0;

            comboSkladFiltrZbozi.DataSource = new BindingSource(this.skladyDict, null);
            comboSkladFiltrZbozi.DisplayMember = "Value";
            comboSkladFiltrZbozi.ValueMember = "Key";

            comboFiltrTypZbozi.Items.Add("c");
            comboFiltrTypZbozi.Items.Add("p");

            comboFiltrTypZbozi.SelectedIndex = 0;
            comboFiltrTypZbozi.Enabled = false;
            comboSkladFiltrZbozi.Enabled = false;
        }

        private void comboFiltrZbozi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltrZbozi.SelectedIndex == 4)
            {
                comboSkladFiltrZbozi.Enabled = true;
                txtFiltrValueZbozi.Enabled = false;
                comboFiltrTypZbozi.Enabled = false;
            }
            else if (comboFiltrZbozi.SelectedIndex == 3)
            {
                comboFiltrTypZbozi.Enabled = true;
                txtFiltrValueZbozi.Enabled = false;
                comboSkladFiltrZbozi.Enabled = false;
            }
            else
            {
                txtFiltrValueZbozi.Enabled = true;
                comboFiltrTypZbozi.Enabled = false;
                comboSkladFiltrZbozi.Enabled = false;
            }
        }
        #endregion

        private void updateZboziBtn_Click(object sender, EventArgs e)
        {
            if (lvPiva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvPiva.SelectedItems[0];
            double stupnovitost = 0;
            if (selectedItem.SubItems[3].Text == "p" && double.TryParse(selectedItem.SubItems[5].Text, out double parsedStupnovitost))
            {
                stupnovitost = parsedStupnovitost;
            }

            var zbozi = new Zbozi(
                id: (int)selectedItem.Tag,
                nazev: selectedItem.SubItems[0].Text,
                obsahAlkoholu: double.Parse(selectedItem.SubItems[1].Text),
                cena: double.Parse(selectedItem.SubItems[2].Text),
                typ: selectedItem.SubItems[3].Text[0],
                skladNazev: selectedItem.SubItems[4].Text,
                odrudaJablek: selectedItem.SubItems[3].Text == "c" ? selectedItem.SubItems[5].Text : null,
                stupnovitost: stupnovitost
            );

            try
            {
                ZboziDialog zboziDialog = new ZboziDialog(_zboziData, zbozi, true);
                if (zboziDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadZbozi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZbozi();
        }
        private void InsertZboziBtn_Click(object sender, EventArgs e)
        {
            ZboziDialog zboziDialog = new ZboziDialog(_zboziData, null, false);
            DialogResult result = zboziDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadZbozi();
            }
        }

        private void DeleteZboziBtn_Click(object sender, EventArgs e)
        {
            if (lvPiva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvPiva.SelectedItems[0];
            var zboziId = (int)selectedItem.Tag;

            try
            {
                _zboziData.DeleteZbozi(zboziId);
                MessageBox.Show("Zbo�� bylo �sp�n� smaz�no.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZbozi();
        }

        #endregion

        #region Objedn�vka

        private void LoadObjednavky()
        {
            lvObjednavky.Columns.Clear();
            lvObjednavky.View = View.Details;
            lvObjednavky.FullRowSelect = true;
            lvObjednavky.Columns.Add("Datum zalo�en�", 100);
            lvObjednavky.Columns.Add("Cena", 100);
            lvObjednavky.Columns.Add("Z�kazn�k", 150);
            lvObjednavky.Columns.Add("Faktura", 150);
            lvObjednavky.Columns.Add("Status", 150);

            var orderList = _objednavkaRepo.Load();
            lvObjednavky.Items.Clear();
            foreach (var order in orderList)
            {
                lvObjednavky.Items.Add(order);
            }
        }

        private void InsertObjednavkaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ObjednavkaDialog objednavkaDialog = new ObjednavkaDialog(_objednavkaRepo, null, false);
                if (objednavkaDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadObjednavky();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.LoadObjednavky();
        }

        private void UpdateObjednavkaBtn_Click(object sender, EventArgs e)
        {
            if (lvObjednavky.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvObjednavky.SelectedItems[0];
            string dateString = selectedItem.SubItems[0].Text;
            string format = "dd.MM.yyyy H:mm:ss";
            DateTime date = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            var objednavka = new Objednavka(
                Convert.ToInt32(selectedItem.Tag.ToString()),
                date,
                double.Parse(selectedItem.SubItems[1].Text.ToString()),
                Convert.ToInt32(selectedItem.SubItems[2].Tag),
                Convert.ToInt32(selectedItem.SubItems[4].Tag),
                Convert.ToInt32(selectedItem.SubItems[3].Tag)
            );

            try
            {
                ObjednavkaDialog objednavkaDialog = new ObjednavkaDialog(_objednavkaRepo, objednavka, true);
                if (objednavkaDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadObjednavky();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadObjednavky();
        }

        private void DeleteObjednavkaBtn_Click(object sender, EventArgs e)
        {
            if (lvObjednavky.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            else
            {
                var selectedItem = lvObjednavky.SelectedItems[0];
                _objednavkaRepo.DeleteObjednavka(Convert.ToInt32(selectedItem.Tag));
            }
            this.LoadObjednavky();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            try
            {
                ObjednavkyStatsDialog statsDialog = new ObjednavkyStatsDialog(_objednavkaRepo);
                if (statsDialog.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Surovina

        private void LoadSuroviny()
        {
            lvSuroviny.Columns.Clear();
            lvSuroviny.View = View.Details;
            lvSuroviny.FullRowSelect = true;
            lvSuroviny.Columns.Add("N�zev", 150);
            lvSuroviny.Columns.Add("Mno�stv�", 100);
            lvSuroviny.Columns.Add("N�zev skladu", 150);

            var surovinaList = _surovinaRepo.Load();
            lvSuroviny.Items.Clear();

            foreach (var surovina in surovinaList)
            {
                var item = new ListViewItem(new[]
                {
                    surovina.Nazev,
                    surovina.Mnozstvi.ToString(),
                    surovina.NazevSklad
                });

                item.Tag = surovina.Id;
                lvSuroviny.Items.Add(item);
            }
        }

        private void InsertSurovinaBtn_Click(object sender, EventArgs e)
        {
            SurovinaDialog zboziDialog = new SurovinaDialog(_surovinaRepo, null, false);
            DialogResult result = zboziDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadSuroviny();
            }
        }

        private void UpdateSurovinaBtn_Click(object sender, EventArgs e)
        {
            if (lvSuroviny.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvSuroviny.SelectedItems[0];
            double mnozstvi = 0;
            if (double.TryParse(selectedItem.SubItems[1].Text, out double parsedMnozstvi))
            {
                mnozstvi = parsedMnozstvi;
            }

            var surovina = new Surovina(
                id: (int)selectedItem.Tag,
                nazev: selectedItem.SubItems[0].Text,
                mnozstvi: mnozstvi,
                nazevSklad: selectedItem.SubItems[2].Text
            );

            try
            {
                SurovinaDialog surovinaDialog = new SurovinaDialog(_surovinaRepo, surovina, true);
                if (surovinaDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadSuroviny();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadSuroviny();
        }

        private void DeleteSurovinaBtn_Click(object sender, EventArgs e)
        {
            if (lvSuroviny.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvSuroviny.SelectedItems[0];
            var surovinaId = (int)selectedItem.Tag;

            try
            {
                _surovinaRepo.DeleteSurovina(surovinaId);
                MessageBox.Show("Surovina byl �sp�n� smaz�na.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadSuroviny();
        }

        #endregion

        #region Zakazn�k
        private void LoadZakaznici()
        {
            lvZakaznici.Columns.Clear();
            lvZakaznici.View = View.Details;
            lvZakaznici.FullRowSelect = true;
            lvZakaznici.Columns.Add("Jm�no", 150);
            lvZakaznici.Columns.Add("Telefon", 100);
            lvZakaznici.Columns.Add("Email", 200);
            lvZakaznici.Columns.Add("Adresa", 300);
            lvZakaznici.Columns.Add("Cenov� hladina", 100);

            var zakazniciList = _zakaznikRepo.Load();
            lvZakaznici.Items.Clear();

            foreach (var zakaznik in zakazniciList)
            {
                string adresa = $"{zakaznik.Adresa.Mesto}, {zakaznik.Adresa.Ulice}, {zakaznik.Adresa.CisloPopisne}, {zakaznik.Adresa.Psc}, {zakaznik.Adresa.Stat}";

                var item = new ListViewItem(new[]
                {
                    zakaznik.Jmeno,
                    zakaznik.Telefon.ToString(),
                    zakaznik.Email,
                    adresa,
                    zakaznik.CenovaHladina.ToString()
                });

                item.Tag = zakaznik.Id;
                item.SubItems[3].Tag = zakaznik.Adresa.Id;
                lvZakaznici.Items.Add(item);
            }
        }

        private void InsertZakaznikBtn_Click(object sender, EventArgs e)
        {
            ZakaznikDialog zakaznikDialog = new ZakaznikDialog(_zakaznikRepo, null, false);
            DialogResult result = zakaznikDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadZakaznici();
            }
        }

        private void UpdateZakaznikBtn_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvZakaznici.SelectedItems[0];

            var zakaznik = new Zakaznik(
                id: (int)selectedItem.Tag,
                jmeno: selectedItem.SubItems[0].Text,
                telefon: double.Parse(selectedItem.SubItems[1].Text),
                email: selectedItem.SubItems[2].Text,
                cenovaHladina: double.Parse(selectedItem.SubItems[4].Text),
                adresa: _adresaRepo.ParseAdresa(selectedItem.SubItems[3].Text + ", " + selectedItem.SubItems[3].Tag),
                null
            );

            try
            {
                ZakaznikDialog zakaznikDialog = new ZakaznikDialog(_zakaznikRepo, zakaznik, true);
                if (zakaznikDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadZakaznici();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZakaznici();
        }


        private void DeleteZakaznikBtn_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvZakaznici.SelectedItems[0];
            var zakaznikId = (int)selectedItem.Tag;

            try
            {
                _zakaznikRepo.DeleteZakaznik(zakaznikId);
                MessageBox.Show("Z�kazn�k byl �sp�n� smaz�n.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZakaznici();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (lvZakaznici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvZakaznici.SelectedItems[0];

            try
            {
                HladinaDialog hladinaDialog = new HladinaDialog(_zakaznikRepo, (int)selectedItem.Tag, selectedItem.SubItems[0].Text);
                if (hladinaDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadZakaznici();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadZakaznici();
        }
        #endregion

        #region Zam�stnanec
        private void LoadZamestnanec()
        {
            lvZamestnanci.Columns.Clear();
            lvZamestnanci.View = View.Details;
            lvZamestnanci.FullRowSelect = true;
            lvZamestnanci.Columns.Add("Jm�no", 100);
            lvZamestnanci.Columns.Add("P�ijmen�", 100);
            lvZamestnanci.Columns.Add("E-mail", 150);
            lvZamestnanci.Columns.Add("Telefonl", 130);
            lvZamestnanci.Columns.Add("Provozovna", 150);
            lvZamestnanci.Columns.Add("Pozice", 150);
            lvZamestnanci.Columns.Add("Nad��zen�", 150);

            var empList = _zamestnanecRepo.Load();
            lvZamestnanci.Items.Clear();

            foreach (var emp in empList)
            {
                var nadrizeny = _zamestnanecRepo.GetNadrizeny(emp.IdNadrizeny);
                var pozice = _poziceRepo.GetPoziceByID(emp.IdPracovniPozice);
                var provozovna = _provozovnaRepo.GetProvoznaById(emp.IdProvozovna);
                var item = new ListViewItem(new[]
                {
                    emp.Jmeno,
                    emp.Prijmeni,
                    emp.Nezobrazovat == 1 ? "*********" : emp.Email,
                emp.Nezobrazovat == 1 ? "*********" : emp.Telefon.ToString(),
                provozovna !=null?provozovna.Nazev:"",
                    pozice!=null?pozice.Nazev:null,
                    nadrizeny!=null?nadrizeny.Jmeno+" "+nadrizeny.Prijmeni:"",
                });

                item.Tag = new Tuple<int?, double, string>(emp.Id, emp.Telefon, emp.Email);
                item.SubItems[4].Tag = provozovna != null ? provozovna.Id : null;
                item.SubItems[5].Tag = pozice != null ? pozice.Id : null;
                item.SubItems[6].Tag = nadrizeny != null ? nadrizeny.Id : null;
                lvZamestnanci.Items.Add(item);
            }
        }
        private void btnAddZamestnanec_Click(object sender, EventArgs e)
        {
            ZamestnanecDialog empDialog = new ZamestnanecDialog(this._zamestnanecRepo, null, "", false);
            DialogResult result = empDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadZamestnanec();
            }
        }

        private void btnEditZamestnanec_Click(object sender, EventArgs e)
        {
            if (lvZamestnanci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvZamestnanci.SelectedItems[0];
            var tag = (Tuple<int?, double, string>)selectedItem.Tag;
            var emp = new Zamestnanec
            {
                Id = (int)tag.Item1,
                Jmeno = selectedItem.SubItems[0].Text,
                Prijmeni = selectedItem.SubItems[1].Text,
                Email = tag.Item3,
                Telefon = tag.Item2,
                IdProvozovna = Convert.ToInt32(selectedItem.SubItems[4].Tag),
                IdPracovniPozice = Convert.ToInt32(selectedItem.SubItems[5].Tag),
                IdNadrizeny = selectedItem.SubItems[6].Tag != null ? Convert.ToInt32(selectedItem.SubItems[6].Tag) : null
            };

            try
            {
                ZamestnanecDialog empDialog = new ZamestnanecDialog(this._zamestnanecRepo, emp, selectedItem.SubItems[6].Text, true);
                if (empDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadZamestnanec();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadZamestnanec();
        }

        private void btnDeleteZamestnanec_Click(object sender, EventArgs e)
        {
            if (lvZamestnanci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvZamestnanci.SelectedItems[0];
            var tag = (Tuple<int, string, string>)selectedItem.Tag;
            this._zamestnanecRepo.DeleteZamestnanec(Convert.ToInt32(tag.Item1));
            LoadZamestnanec();
        }
        #endregion

        #region Provozovna
        private void LoadProvozovna()
        {
            lvProvozovny.Columns.Clear();
            lvProvozovny.View = View.Details;
            lvProvozovny.FullRowSelect = true;
            lvProvozovny.Columns.Add("N�zev", 220);
            lvProvozovny.Columns.Add("Po�et zam�stnanc�", 150);
            lvProvozovny.Columns.Add("Adresa", 300);

            var provozovnaList = _provozovnaRepo.Load();
            lvProvozovny.Items.Clear();

            foreach (var provozovna in provozovnaList)
            {
                string adresa = $"{provozovna.Adresa.Mesto}, {provozovna.Adresa.Ulice}, {provozovna.Adresa.CisloPopisne}, {provozovna.Adresa.Psc}, {provozovna.Adresa.Stat}";
                var item = new ListViewItem(new[]
                {
                    provozovna.Nazev,
                    provozovna.PocetZamestnancu.ToString(),
                    adresa
                });

                item.Tag = provozovna.Id;
                item.SubItems[2].Tag = provozovna.Adresa.Id;
                lvProvozovny.Items.Add(item);
            }
        }
        private void btnAddProvozovna_Click(object sender, EventArgs e)
        {

            ProvozovnaDialog provozovnaDialog = new ProvozovnaDialog(_provozovnaRepo, null, false);
            DialogResult result = provozovnaDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadProvozovna();
            }
        }

        private void btnEditProvozovna_Click(object sender, EventArgs e)
        {
            if (lvProvozovny.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvProvozovny.SelectedItems[0];

            var provozovna = new Provozovna(
                Id: (int)selectedItem.Tag,
                Nazev: selectedItem.SubItems[0].Text,
                PocetOsob: Convert.ToInt32(selectedItem.SubItems[1].Text),
                Adresa: _adresaRepo.ParseAdresa(selectedItem.SubItems[2].Text + ", " + selectedItem.SubItems[2].Tag),
                idAdresa: null
            );

            try
            {
                ProvozovnaDialog provozovnaDialog = new ProvozovnaDialog(_provozovnaRepo, provozovna, true);
                if (provozovnaDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadProvozovna();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadProvozovna();
        }

        private void btnDeleteProvozovna_Click(object sender, EventArgs e)
        {
            if (lvProvozovny.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvProvozovny.SelectedItems[0];
            var provozovnaId = (int)selectedItem.Tag;

            try
            {
                _provozovnaRepo.DeleteProvozovna(provozovnaId);
                MessageBox.Show("Provozovna byla �sp�n� smaz�na.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadProvozovna();
        }
        #endregion

        #region Pracovn� pozice
        private void LoadPozice()
        {
            lvPozice.Columns.Clear();
            lvPozice.View = View.Details;
            lvPozice.FullRowSelect = true;
            lvPozice.Columns.Add("N�zev", 250);
            lvPozice.Columns.Add("Plat", 250);

            var poziceList = _poziceRepo.Load();
            lvPozice.Items.Clear();

            foreach (var pozice in poziceList)
            {
                lvPozice.Items.Add(pozice);
            }
        }
        private void btnAddPozice_Click(object sender, EventArgs e)
        {
            try
            {
                PracovniPoziceDialog poziceDialog = new PracovniPoziceDialog(_poziceRepo, null, false);
                if (poziceDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadPozice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadPozice();
        }

        private void btnEditPozice_Click(object sender, EventArgs e)
        {
            if (lvPozice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvPozice.SelectedItems[0];

            var pozice = new PracovniPozice
            {
                Id = Convert.ToInt32(selectedItem.Tag),
                Nazev = selectedItem.SubItems[0].Text,
                Plat = double.Parse(selectedItem.SubItems[1].Text)
            };
            try
            {
                PracovniPoziceDialog poziceDialog = new PracovniPoziceDialog(_poziceRepo, pozice, true);
                if (poziceDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadPozice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadPozice();
        }

        private void btnDeletePozice_Click(object sender, EventArgs e)
        {
            if (lvPozice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvPozice.SelectedItems[0];
            var poziceId = Convert.ToInt32(selectedItem.Tag);

            try
            {
                _poziceRepo.DeletePozice(poziceId);
                MessageBox.Show("Pozice byla �sp�n� smaz�na.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadPozice();
        }
        #endregion

        #region Typy Akce
        private void LoadTypyAkce()
        {
            lvTypyAkce.Columns.Clear();
            lvTypyAkce.View = View.Details;
            lvTypyAkce.FullRowSelect = true;
            lvTypyAkce.Columns.Add("N�zev", 300);

            var typyList = _typAkceRepo.LoadTypyAkceForSelect();
            lvTypyAkce.Items.Clear();

            foreach (var typ in typyList)
            {
                var item = new ListViewItem(new[]
                {
                    typ.Value,
                });

                item.Tag = typ.Key;
                lvTypyAkce.Items.Add(item);
            }
        }

        private void btnAddTyp_Click(object sender, EventArgs e)
        {
            try
            {
                TypyAkceDialog typyDialog = new TypyAkceDialog(_typAkceRepo, null, false);
                if (typyDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadTypyAkce();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadTypyAkce();
        }

        private void btnEditTypAkce_Click(object sender, EventArgs e)
        {
            if (lvTypyAkce.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvTypyAkce.SelectedItems[0];

            var typ = new TypAkce
            {
                Id = Convert.ToInt32(selectedItem.Tag),
                Nazev = selectedItem.SubItems[0].Text,
            };
            try
            {
                TypyAkceDialog typDialog = new TypyAkceDialog(_typAkceRepo, typ, true);
                if (typDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadTypyAkce();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadTypyAkce();
        }

        private void btnDeleteTypAkce_Click(object sender, EventArgs e)
        {
            if (lvTypyAkce.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvTypyAkce.SelectedItems[0];
            var typId = Convert.ToInt32(selectedItem.Tag);

            try
            {
                _typAkceRepo.DeleteTypAkce(typId);
                MessageBox.Show("Typ akce byl �sp�n� smaz�n.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadTypyAkce();
        }
        #endregion

        #region Sklad
        private void LoadSklady()
        {
            lvSklady.Columns.Clear();
            lvSklady.View = View.Details;
            lvSklady.FullRowSelect = true;
            lvSklady.Columns.Add("N�zev", 150);
            lvSklady.Columns.Add("U�itn� plocha", 150);
            lvSklady.Columns.Add("Adresa", 250);

            var sklady = _skladRepo.GetSklady();
            lvSklady.Items.Clear();

            foreach (var sklad in sklady)
            {
                string adresa = $"{sklad.Adresa.Mesto}, {sklad.Adresa.Ulice}, {sklad.Adresa.CisloPopisne}, {sklad.Adresa.Psc}, {sklad.Adresa.Stat}";
                var item = new ListViewItem(new[]
                {
                    sklad.Nazev,
                    sklad.UzitnaPlocha.ToString(),
                    adresa
                });

                item.Tag = sklad.Id;
                item.SubItems[2].Tag = sklad.IdAdresa;
                lvSklady.Items.Add(item);
            }
        }

        private void btnAddSklad_Click(object sender, EventArgs e)
        {
            try
            {
                SkladDialog skladDialog = new SkladDialog(_skladRepo, null, false);
                if (skladDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadSklady();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadSklady();
        }

        private void btnUpdateSklad_Click(object sender, EventArgs e)
        {
            if (lvSklady.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvSklady.SelectedItems[0];

            var sklad = new Sklad
            {
                Id = Convert.ToInt32(selectedItem.Tag),
                Nazev = selectedItem.SubItems[0].Text,
                UzitnaPlocha = Convert.ToInt32(selectedItem.SubItems[1].Text),
                Adresa = _adresaRepo.ParseAdresa(selectedItem.SubItems[2].Text + ", " + selectedItem.SubItems[2].Tag),
                IdAdresa = Convert.ToInt32(selectedItem.SubItems[2].Tag)
            };

            try
            {
                SkladDialog skladDialog = new SkladDialog(_skladRepo, sklad, true);
                if (skladDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadSklady();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadSklady();
        }

        private void btnDeleteSklad_Click(object sender, EventArgs e)
        {
            if (lvSklady.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvSklady.SelectedItems[0];
            var skladId = Convert.ToInt32(selectedItem.Tag);

            try
            {
                _skladRepo.DeleteSklad(skladId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadSklady();
        }
        #endregion

        private void hierarchyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch the hierarchical data from the database
                var hierarchy = _database.GetEmployeeHierarchy();



                // Display in ListView
                tbNadrizeni.Clear();
                foreach (var line in hierarchy)
                {
                    tbNadrizeni.AppendText(line + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        #region profil

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loggedUser == null)
            {
                LoginDialog dialog = new LoginDialog(false);
                if (dialog.ShowDialog() == DialogResult.OK && dialog.user != null)
                {
                    loggedUser = dialog.user;

                    switch (loggedUser.Role)
                    {
                        case "Admin":
                            panelyAdmin();
                            break;
                        case "Vedouc�":
                            panelySekretarka();
                            buttonyVedouci();
                            break;
                        case "Sekret��ka":
                            panelySekretarka();
                            buttonySekretarka();
                            break;
                    }
                    osUdajeCheck.Show();
                    if (loggedUser.boolean == 1)
                    {
                        osUdajeCheck.Checked = true;
                    }
                    else
                    {
                        osUdajeCheck.Checked = false;
                    }
                    loginBtn.Text = "Odhl�sit se";
                    registerBtn.Hide();
                    labelRegisteredName.Text = "";//Vz�t jm�no a p��jmen� z tabulky zam�stnanec
                    labelRegisteredUsername.Text = "U�ivatelsk� jm�no: " + loggedUser.Jmeno;
                }
            }
            else
            {
                logout();
            }
        }



        private void osUdajeCheck_CheckedChanged(object sender, EventArgs e)
        {
            //todo volat proceduru zm�� nezobrazovat_os
        }
        private void logout()
        {
            loggedUser = null;
            emulUser = null;
            tabControl1.TabPages.Remove(tabNadrizeni);
            tabControl1.TabPages.Remove(tabNadrizeni);
            tabControl1.TabPages.Remove(tabObjedn�vky);
            tabControl1.TabPages.Remove(tabPozice);
            tabControl1.TabPages.Remove(tabProvozovny);
            tabControl1.TabPages.Remove(tabSklad);
            tabControl1.TabPages.Remove(tabSuroviny);
            tabControl1.TabPages.Remove(tabTypyAkce);
            tabControl1.TabPages.Remove(tabZakaznici);
            tabControl1.TabPages.Remove(tabZam�stnanci);
            panel1.Hide();
            osUdajeCheck.Hide();
            loginBtn.Text = "P�ihl�sit se";
            registerBtn.Text = "Registrovat se";
            registerBtn.Show();
            labelRegisteredName.Text = "";
            labelRegisteredUsername.Text = "Nep�ihl�en� u�ivatel";
        }
        private void panelySekretarka()
        {
            panel1.Show();
            tabControl1.TabPages.Insert(2, tabObjedn�vky);
            tabControl1.TabPages.Insert(3, tabSuroviny);
            tabControl1.TabPages.Insert(4, tabZakaznici);
            tabControl1.TabPages.Insert(5, tabZam�stnanci);
            tabControl1.TabPages.Insert(6, tabNadrizeni);

        }

        private void buttonySekretarka()
        {
            UpdateObjednavkaBtn.Hide();
            DeleteObjednavkaBtn.Hide();
            DeleteZakaznikBtn.Hide();
            panel5.Hide();
        }

        private void buttonyVedouci()
        {
            UpdateObjednavkaBtn.Show();
            DeleteObjednavkaBtn.Show();
            DeleteZakaznikBtn.Show();
            panel5.Show();
        }

        private void panelyAdmin()
        {
            panelySekretarka();
            buttonyVedouci();
            tabControl1.TabPages.Insert(7, tabProvozovny);
            tabControl1.TabPages.Insert(8, tabPozice);
            tabControl1.TabPages.Insert(9, tabTypyAkce);
            tabControl1.TabPages.Insert(10, tabSklad);

        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            string email = Microsoft.VisualBasic.Interaction.InputBox("Vlo�te email pro registraci", "Email", "priklad@priklad.com");


            object result = _database.ExecuteFindEmailRegistered(email);

            string resultString = result?.ToString();
            switch (result.ToString())
            {
                case "Invalid email format":
                    MessageBox.Show("�patn� form�t emailu");
                    return;
                case "Used in users":
                    MessageBox.Show("Email je ji� pou�it");
                    return;

                case "Used in zamestnanec only":
                    RegisterDialog fastDialog = new RegisterDialog(false, email);
                    if (fastDialog.ShowDialog() == DialogResult.OK && fastDialog.user != null)
                    {
                        loggedUser = fastDialog.user;

                        switch (loggedUser.Role)
                        {
                            case "Admin":
                                panelyAdmin();
                                break;
                            case "Vedouc�":
                                panelySekretarka();
                                buttonyVedouci();
                                break;
                            case "Sekret��ka":
                                panelySekretarka();
                                buttonySekretarka();
                                break;
                        }
                        osUdajeCheck.Show();
                        if (loggedUser.boolean == 1)
                        {
                            osUdajeCheck.Checked = true;
                        }
                        else
                        {
                            osUdajeCheck.Checked = false;
                        }
                        loginBtn.Text = "Odhl�sit se";
                        registerBtn.Hide();
                        labelRegisteredName.Text = "";//Vz�t jm�no a p��jmen� z tabulky zam�stnanec
                        labelRegisteredUsername.Text = "U�ivatelsk� jm�no: " + loggedUser.Jmeno;
                    }
                    return;

                case "Not used":
                    RegisterDialog kompDialog = new RegisterDialog(true, email);
                    if (kompDialog.ShowDialog() == DialogResult.OK && kompDialog.user != null)
                    {
                        loggedUser = kompDialog.user;

                        switch (loggedUser.Role)
                        {
                            case "Admin":
                                panelyAdmin();
                                break;
                            case "Vedouc�":
                                panelySekretarka();
                                buttonyVedouci();
                                break;
                            case "Sekret��ka":
                                panelySekretarka();
                                buttonySekretarka();
                                break;
                        }
                        osUdajeCheck.Show();
                        if (loggedUser.boolean == 1)
                        {
                            osUdajeCheck.Checked = true;
                        }
                        else
                        {
                            osUdajeCheck.Checked = false;
                        }
                        loginBtn.Text = "Odhl�sit se";
                        registerBtn.Hide();
                        labelRegisteredName.Text = "";//Vz�t jm�no a p��jmen� z tabulky zam�stnanec
                        labelRegisteredUsername.Text = "U�ivatelsk� jm�no: " + loggedUser.Jmeno;
                        LoadZamestnanec();
                    }
                    return;
                default:
                    MessageBox.Show("Chyba p�i registraci");
                    return;
            }
        }


        #endregion

        #region Adresy
        private void LoadAdresy()
        {
            lvAdresy.Columns.Clear();
            lvAdresy.View = View.Details;
            lvAdresy.FullRowSelect = true;
            lvAdresy.Columns.Add("Ulice", 220);
            lvAdresy.Columns.Add("M�sto", 100);
            lvAdresy.Columns.Add("PS�", 150);
            lvAdresy.Columns.Add("��slo popisn�", 100);
            lvAdresy.Columns.Add("St�t", 200);

            var adresyList = _adresaRepo.Load();
            lvAdresy.Items.Clear();

            foreach (var adresa in adresyList)
            {

                var item = new ListViewItem(new[]
                {
                    adresa.Mesto,
                    adresa.Ulice,
                    adresa.Psc.ToString(),
                    adresa.CisloPopisne.ToString(),
                    adresa.Stat
                });

                item.Tag = adresa.Id;
                lvAdresy.Items.Add(item);
            }
        }
        private void btnAddAdresa_Click(object sender, EventArgs e)
        {
            AdresaDialogs adresaDialog = new AdresaDialogs(_adresaRepo, null, false);
            DialogResult result = adresaDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                this.LoadAdresy();
            }
        }

        private void btnEditAdresa_Click(object sender, EventArgs e)
        {
            if (lvAdresy.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvAdresy.SelectedItems[0];

            var adresa = new Adresa(
                id: (int)selectedItem.Tag,
                mesto: selectedItem.SubItems[0].Text,
                ulice: selectedItem.SubItems[1].Text,
                cisloPopisne: Convert.ToInt32(selectedItem.SubItems[3].Text),
                psc: Convert.ToInt32(selectedItem.SubItems[2].Text),
                stat: selectedItem.SubItems[4].Text
            );

            try
            {
                AdresaDialogs adresaDialog = new AdresaDialogs(_adresaRepo, adresa, true);
                if (adresaDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadAdresy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadAdresy();
        }

        private void btnDeleteAdresa_Click(object sender, EventArgs e)
        {
            if (lvAdresy.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvAdresy.SelectedItems[0];
            var adresaId = (int)selectedItem.Tag;

            try
            {
                _adresaRepo.DeleteAdresa(adresaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadAdresy();
        }

        private void btnAdresaUse_Click(object sender, EventArgs e)
        {
            if (lvAdresy.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvAdresy.SelectedItems[0];

            try
            {
                AdresaUseDialog adresaUseDialog = new AdresaUseDialog(_adresaRepo, (int)selectedItem.Tag);
                if (adresaUseDialog.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Faktura

        private void LoadFaktury()
        {
            lvFaktury.Columns.Clear();
            lvFaktury.View = View.Details;
            lvFaktury.FullRowSelect = true;
            lvFaktury.Columns.Add("N�zev souboru", 150);
            lvFaktury.Columns.Add("Datum vlo�en�", 150);

            var faktury = _fakturaRepo.Load();
            lvFaktury.Items.Clear();

            foreach (var faktura in faktury)
            {
                var item = new ListViewItem(new[]
                {
                    faktura.NazevSouboru,
                    faktura.DatumVlozeni.ToString(),
                });

                item.Tag = faktura.Id;
                lvFaktury.Items.Add(item);
            }
        }

        private void btnSaveFaktura_Click(object sender, EventArgs e)
        {
            if (lvFaktury.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vyberte fakturu.");
                return;
            }

            var selectedItem = lvFaktury.SelectedItems[0];

            var faktura = _fakturaRepo.GetFakturaById((int)selectedItem.Tag);
            if (faktura != null && faktura.FakturaBlob != null)
            {
                byte[] fakturaBlob = faktura.FakturaBlob;

                if (fakturaBlob != null && fakturaBlob.Length > 0)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF File|*.pdf|All files|*.*";
                        saveFileDialog.Title = "Ulo�it fakturu jako";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            try
                            {
                                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                                {
                                    fileStream.Write(fakturaBlob, 0, fakturaBlob.Length);
                                }

                                MessageBox.Show("Faktura byla �sp�n� ulo�ena.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Chyba p�i ukl�d�n� faktury: " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faktura je pr�zdn�.");
                }
            }
            else
            {
                MessageBox.Show("Faktura nebyla nalezena.");
            }
        }
        #endregion

        #region Akce
        private void LoadAkce()
        {
            lvAkce.Columns.Clear();
            lvAkce.View = View.Details;
            lvAkce.FullRowSelect = true;
            lvAkce.Columns.Add("Typ akce", 150);
            lvAkce.Columns.Add("Po�et osob", 150);
            lvAkce.Columns.Add("Datum", 250);

            var akces = _akceRepo.LoadAkce();
            lvAkce.Items.Clear();

            foreach (var akce in akces)
            {
                var item = new ListViewItem(new[]
                {
                    _typAkceRepo.GetTypAkceByAkce((int)akce.IdTypAkce).Nazev,
                    akce.PocetOsob.ToString(),
                    akce.Datum.ToString()
                });

                item.Tag = Tuple.Create(akce.Id, akce.IdObjednavka);
                lvAkce.Items.Add(item);
            }
        }

        private void btnAkceShowObjednavka_Click(object sender, EventArgs e)
        {
            if (lvAkce.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvAkce.SelectedItems[0];
            var tag = (Tuple<int?, int?>)selectedItem.Tag;
            var objednavka = _objednavkaRepo.GetObjednavkaById((int)tag.Item2);

            try
            {
                ObjednavkaDialog objednavkaDialog = new ObjednavkaDialog(_objednavkaRepo, objednavka, true);
                if (objednavkaDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadObjednavky();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadObjednavky();
        }

        private void btnShowCalendar_Click(object sender, EventArgs e)
        {
            try
            {
                AkceCalendar calendarDialog = new AkceCalendar(_akceRepo);
                if (calendarDialog.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Objednan� zbo��

        private void btnObjZboziShowObj_Click(object sender, EventArgs e)
        {
            if (lvObjZbozi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvObjZbozi.SelectedItems[0];
            var tag = (Tuple<int?, int?>)selectedItem.Tag;
            var objednavka = _objednavkaRepo.GetObjednavkaById((int)tag.Item2);

            try
            {
                ObjednavkaDialog objednavkaDialog = new ObjednavkaDialog(_objednavkaRepo, objednavka, true);
                if (objednavkaDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LoadObjednavky();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LoadObjednavky();
        }
        private void LoadObjZbozi()
        {
            lvObjZbozi.Columns.Clear();
            lvObjZbozi.View = View.Details;
            lvObjZbozi.FullRowSelect = true;
            lvObjZbozi.Columns.Add("Zbo��", 150);
            lvObjZbozi.Columns.Add("Mno�stv�", 150);
            lvObjZbozi.Columns.Add("Cena", 250);

            var zboziList = _objednaneZboziRepo.Load();
            lvObjZbozi.Items.Clear();

            foreach (var zbozi in zboziList)
            {
                var item = new ListViewItem(new[]
                {
                    zbozi.Value.Nazev,
                    zbozi.Key.Mnozstvi.ToString(),
                    zbozi.Value.Cena.ToString()
                });

                item.Tag = Tuple.Create(zbozi.Key.Id, zbozi.Key.IdObjednavka);
                item.SubItems[0].Tag = zbozi.Value.Id;
                lvObjZbozi.Items.Add(item);
            }
        }
        #endregion

        #region Users
        private void LoadUsers()
        {
            lvUsers.Columns.Clear();
            lvUsers.View = View.Details;
            lvUsers.FullRowSelect = true;
            lvUsers.Columns.Add("Jmeno", 150);
            lvUsers.Columns.Add("Role", 250);
            lvUsers.Columns.Add("Nezobrazovat OS", 250);

            var users = _usersRepo.Load();
            lvUsers.Items.Clear();

            foreach (var user in users)
            {
                var item = new ListViewItem(new[]
                {
                    user.Jmeno,
                    user.Role,
                    user.boolean==1?"Ano":"Ne"

                });

                item.Tag = user.Id;
                lvUsers.Items.Add(item);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnMigrateSklad_Click(object sender, EventArgs e)
        {
            try
            {
                SkladMigraceDialog migraceDialog = new SkladMigraceDialog(_skladRepo);
                if (migraceDialog.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadSuroviny();
            LoadZbozi();
        }
    }
}

