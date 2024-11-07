using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Windows.Forms;
namespace App
{
    public partial class Form1 : Form
    {
        String connectionString = "User Id=ST67103;Password=abcde;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";
        public Form1()
        {
            InitializeComponent();
            InitializeLvPiva();
            InitializeLvObjednavky();
            InitializeLvSurovina();
            InitializeLvZakaznici();
            InitializeInputPanel();
            LoadSkladData();
            LoadZbozi();
            LoadObjednavky();
            LoadZakaznici();
            LoadSuroviny();
            
        }
        #region Zbozi

        private Panel inputPanel;
        private TextBox txtNazev;
        private TextBox txtObsahAlkoholu;
        private TextBox txtCena;
        private ComboBox comboSklad;
        private ComboBox comboTyp;
        private TextBox txtSpecificValue;
        private Button btnSave;
        private Button btnCancel;
        private void InitializeLvPiva()
        {
            lvPiva.View = View.Details;
            lvPiva.FullRowSelect = true;
            lvPiva.Columns.Add("Název", 150);
            lvPiva.Columns.Add("Obsah alkoholu", 100);
            lvPiva.Columns.Add("Cena", 100);
            lvPiva.Columns.Add("Typ", 100);
            lvPiva.Columns.Add("Název skladu", 150);
            lvPiva.Columns.Add("Stupòovitost/odrùda", 150);
        }

        private void InitializeInputPanel()
        {
            inputPanel = new Panel();
            inputPanel.Visible = false;
            inputPanel.Size = new System.Drawing.Size(300, 300);
            inputPanel.Location = new System.Drawing.Point(50, 50);

            Label lblNazev = new Label();
            lblNazev.Text = "Název:";
            lblNazev.Location = new System.Drawing.Point(10, 10);
            inputPanel.Controls.Add(lblNazev);

            txtNazev = new TextBox();
            txtNazev.Location = new System.Drawing.Point(130, 10);
            inputPanel.Controls.Add(txtNazev);

            Label lblObsahAlkoholu = new Label();
            lblObsahAlkoholu.Text = "Obsah alkoholu:";
            lblObsahAlkoholu.Location = new System.Drawing.Point(10, 40);
            inputPanel.Controls.Add(lblObsahAlkoholu);

            txtObsahAlkoholu = new TextBox();
            txtObsahAlkoholu.Location = new System.Drawing.Point(130, 40);
            inputPanel.Controls.Add(txtObsahAlkoholu);

            Label lblCena = new Label();
            lblCena.Text = "Cena:";
            lblCena.Location = new System.Drawing.Point(10, 70);
            inputPanel.Controls.Add(lblCena);

            txtCena = new TextBox();
            txtCena.Location = new System.Drawing.Point(130, 70);
            inputPanel.Controls.Add(txtCena);

            Label lblSklad = new Label();
            lblSklad.Text = "Sklad:";
            lblSklad.Location = new System.Drawing.Point(10, 100);
            inputPanel.Controls.Add(lblSklad);

            comboSklad = new ComboBox();
            comboSklad.Location = new System.Drawing.Point(130, 100);
            inputPanel.Controls.Add(comboSklad);

            Label lblTyp = new Label();
            lblTyp.Text = "Typ:";
            lblTyp.Location = new System.Drawing.Point(10, 130);
            inputPanel.Controls.Add(lblTyp);

            comboTyp = new ComboBox();
            comboTyp.Location = new System.Drawing.Point(130, 130);
            comboTyp.Items.AddRange(new object[] { "p", "c" });
            inputPanel.Controls.Add(comboTyp);

            Label lblSpecificValue = new Label();
            lblSpecificValue.Text = "Stupòovitost/odrùda";
            lblSpecificValue.Location = new System.Drawing.Point(10, 160);
            inputPanel.Controls.Add(lblSpecificValue);

            txtSpecificValue = new TextBox();
            txtSpecificValue.Location = new System.Drawing.Point(130, 160);
            inputPanel.Controls.Add(txtSpecificValue);

            btnSave = new Button();
            btnSave.Text = "Save";
            btnSave.Location = new System.Drawing.Point(10, 190);
            btnSave.Click += BtnSave_Click;
            inputPanel.Controls.Add(btnSave);

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(100, 190);
            btnCancel.Click += BtnCancel_Click;
            inputPanel.Controls.Add(btnCancel);

            this.Controls.Add(inputPanel);
        }




        private void LoadSkladData()
        {
            string query = "SELECT id, nazev FROM view_sklad_id_nazev";
            var data = GetDataFromView(query);

            DataTable skladDataTable = ConvertToDataTable(data);

            comboSklad.DisplayMember = "nazev";
            comboSklad.ValueMember = "id";
            comboSklad.DataSource = skladDataTable;
        }
        private void LoadZbozi()
        {
            string queryPivo = "SELECT pivo_id, zbozi_nazev, obsah_alkoholu, cena, stupnovitost, sklad_nazev FROM v_pivo";
            string queryCider = "SELECT cider_id, zbozi_nazev, obsah_alkoholu, cena, odruda_jablek, sklad_nazev FROM v_cider";

            var dataPivo = GetDataFromView(queryPivo);
            var dataCider = GetDataFromView(queryCider);

            lvPiva.Items.Clear();

            foreach (var row in dataPivo)
            {
                var item = new ListViewItem(new[]
                {
                row["ZBOZI_NAZEV"].ToString(),
                row["OBSAH_ALKOHOLU"].ToString(),
                row["CENA"].ToString(),
                "pivo",
                row["SKLAD_NAZEV"].ToString(),
                row["STUPNOVITOST"].ToString()
            });
                item.Tag = row["PIVO_ID"];
                lvPiva.Items.Add(item);
            }

            foreach (var row in dataCider)
            {
                var item = new ListViewItem(new[]
                {
                row["ZBOZI_NAZEV"].ToString(),
                row["OBSAH_ALKOHOLU"].ToString(),
                row["CENA"].ToString(),
                "cider",
                row["SKLAD_NAZEV"].ToString(),
                row["ODRUDA_JABLEK"].ToString()
            });
                item.Tag = row["CIDER_ID"];
                lvPiva.Items.Add(item);
            }
        }

        private void updateZboziBtn_Click(object sender, EventArgs e)
        {
            if (lvPiva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedItem = lvPiva.SelectedItems[0];
            inputPanel.Tag = selectedItem.Tag;
            inputPanel.Visible = true;
            inputPanel.BringToFront();

            txtNazev.Text = selectedItem.SubItems[0].Text;
            txtObsahAlkoholu.Text = selectedItem.SubItems[1].Text;
            txtCena.Text = selectedItem.SubItems[2].Text;
            comboSklad.SelectedIndex = comboSklad.FindStringExact(selectedItem.SubItems[4].Text);
            comboTyp.Items.Clear();
            comboTyp.Items.AddRange(new object[] { selectedItem.SubItems[3].Text.Substring(0, 1).ToLower() });
            comboTyp.SelectedIndex = comboTyp.FindStringExact(selectedItem.SubItems[3].Text.Substring(0, 1).ToLower());
            txtSpecificValue.Text = selectedItem.SubItems[5].Text;

        }

        private void InsertZboziBtn_Click(object sender, EventArgs e)
        {
            inputPanel.Tag = null;
            inputPanel.Show();
            inputPanel.BringToFront();
            ClearInputFields();
        }

        private void DeleteZboziBtn_Click(object sender, EventArgs e)
        {
            if (lvPiva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var selectedItem = lvPiva.SelectedItems[0];
            var parameters = new Dictionary<string, object>
        {
            { "p_id", selectedItem.Tag }
        };

            try
            {
                ExecuteProcedure("delete_zbozi", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadZbozi();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {


            if (inputPanel.Tag == null)
            {
                var parameters = new Dictionary<string, object>
        {
                    { "p_nazev", txtNazev.Text },
                    { "p_obsah_alkoholu", double.Parse(txtObsahAlkoholu.Text) },
                    { "p_cena", double.Parse(txtCena.Text) },
                    { "p_id_sklad", comboSklad.SelectedValue },
                    { "p_typ", comboTyp.SelectedItem.ToString() },
                    { "p_odruda_jablek", comboTyp.SelectedItem.ToString() == "c" ? txtSpecificValue.Text : "" },
                    { "p_stupnovitost", comboTyp.SelectedItem.ToString() == "p" ? double.Parse(txtSpecificValue.Text) : 0 }
                };
                ExecuteProcedure("insert_zbozi", parameters);
            }
            else
            {
                var parameters = new Dictionary<string, object>
                {
                   { "p_id", inputPanel.Tag },
                   { "p_nazev", txtNazev.Text },
                    { "p_obsah_alkoholu", double.Parse(txtObsahAlkoholu.Text) },
                    { "p_cena", double.Parse(txtCena.Text) },
                    { "p_id_sklad", comboSklad.SelectedValue },
                    { "p_typ", comboTyp.SelectedItem.ToString() },
                    { "p_odruda_jablek", comboTyp.SelectedItem.ToString() == "c" ? txtSpecificValue.Text : "" },
                    { "p_stupnovitost", comboTyp.SelectedItem.ToString() == "p" ? double.Parse(txtSpecificValue.Text) : 0 }
                };

                ExecuteProcedure("update_zbozi", parameters);
            }

            inputPanel.Visible = false;
            comboTyp.Items.Clear();
            comboTyp.Items.AddRange(new object[] { "p", "c" });
            LoadZbozi();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            inputPanel.Visible = false;
            comboTyp.Items.Clear();
            comboTyp.Items.AddRange(new object[] { "p", "c" });
        }

        private void ClearInputFields()
        {
            txtNazev.Text = "";
            txtObsahAlkoholu.Text = "";
            txtCena.Text = "";
            comboSklad.SelectedIndex = -1;
            comboTyp.SelectedIndex = 0;
            txtSpecificValue.Text = "";
        }







        #endregion

        #region Objednávka

        private void InitializeLvObjednavky()
        {
            lvObjednavky.View = View.Details;
            lvObjednavky.FullRowSelect = true;
            lvObjednavky.Columns.Add("Datum založení", 100);
            lvObjednavky.Columns.Add("Cena", 100);
            lvObjednavky.Columns.Add("Zákazník", 150);
            lvObjednavky.Columns.Add("Faktura", 150);
        }
        private void LoadObjednavky()
        {
            string query = "SELECT id, datum_zalozeni, cena, zakaznik, faktura FROM v_objednavka";


            var data = GetDataFromView(query);


            lvObjednavky.Items.Clear();

            foreach (var row in data)
            {
                var item = new ListViewItem(new[]
                {
                row["DATUM_ZALOZENI"].ToString(),
                row["CENA"].ToString(),
                row["ZAKAZNIK"].ToString(),
                row["FAKTURA"].ToString()
            });
                item.Tag = row["ID"];
                lvObjednavky.Items.Add(item);
            }
        }

        private void InsertObjednávkaBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateObjednavkaBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteObjednavkaBtn_Click(object sender, EventArgs e)
        {

        }

        private void objZboziBtn_Click(object sender, EventArgs e)
        {
                
        }

        private void FakturaBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Surovina

        private void InitializeLvSurovina()
        {
            lvSuroviny.View = View.Details;
            lvSuroviny.FullRowSelect = true;
            lvSuroviny.Columns.Add("Název", 200);
            lvSuroviny.Columns.Add("Množství", 100);
            lvSuroviny.Columns.Add("Název skladu", 150);
        }
        private void LoadSuroviny()
        {
            string query = "SELECT id, nazev, mnozstvi, nazev_sklad FROM v_surovina";


            var data = GetDataFromView(query);


            lvSuroviny.Items.Clear();

            foreach (var row in data)
            {
                var item = new ListViewItem(new[]
                {
                row["NAZEV"].ToString(),
                row["MNOZSTVI"].ToString(),
                row["NAZEV_SKLAD"].ToString(),

            });
                item.Tag = row["ID"];
                lvSuroviny.Items.Add(item);
            }

        }
        private void InsertSurovinaBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateSurovinaBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSurovinaBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Zakazník
        private void InitializeLvZakaznici()
        {
            lvZakaznici.View = View.Details;
            lvZakaznici.FullRowSelect = true;
            lvZakaznici.Columns.Add("Jmeno", 100);
            lvZakaznici.Columns.Add("Telefon", 100);
            lvZakaznici.Columns.Add("Email", 100);
            lvZakaznici.Columns.Add("Adresa", 250);
        }
        private void LoadZakaznici()
        {
            string query = "SELECT id, jmeno, telefon, email, adresa FROM v_zakaznik";


            var data = GetDataFromView(query);


            lvZakaznici.Items.Clear();

            foreach (var row in data)
            {
                var item = new ListViewItem(new[]
                {
                row["JMENO"].ToString(),
                row["TELEFON"].ToString(),
                row["EMAIL"].ToString(),
                row["ADRESA"].ToString()
            });
                item.Tag = row["ID"];
                lvZakaznici.Items.Add(item);
            }
        }

        #endregion

        #region Zamìstnanec

        #endregion



        private IEnumerable<Dictionary<string, object>> GetDataFromView(string query)
        {
            var result = new List<Dictionary<string, object>>();

            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                            }

                            result.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }

        private void ExecuteProcedure(string procedureName, Dictionary<string, object> parameters)
        {
            using (var connection = new OracleConnection(connectionString))
            using (var command = new OracleCommand(procedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        var oracleParam = new OracleParameter(param.Key, param.Value ?? DBNull.Value);
                        command.Parameters.Add(oracleParam);
                    }
                }

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while executing procedure: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public DataTable ConvertToDataTable(IEnumerable<Dictionary<string, object>> data)
        {
            DataTable table = new DataTable();


            if (data == null || !data.Any())
                return table;


            var firstDict = data.First();
            foreach (var key in firstDict.Keys)
            {
                table.Columns.Add(key, firstDict[key]?.GetType() ?? typeof(object));
            }


            foreach (var dict in data)
            {
                var row = table.NewRow();
                foreach (var key in dict.Keys)
                {
                    row[key] = dict[key] ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }

        
    }
}
