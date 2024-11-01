using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Windows.Forms;
using App.Forms;
namespace App
{
    public partial class Form1 : Form
    {
        String connectionString = "User Id=ST67103;Password=abcde;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521))(CONNECT_DATA=(SID=BDAS)(SERVER=DEDICATED)))";
        public Form1()
        {
            InitializeComponent();
            lvPiva.View = View.Details; // Set view to Details to show columns
            lvPiva.Columns.Add("", 150);  
            lvPiva.Columns.Add("Název", 150);  // Product name column
            lvPiva.Columns.Add("Obsah Alkoholu", 120);  // Alcohol content column
            lvPiva.Columns.Add("Cena", 100);  // Price column
            lvPiva.Columns.Add("Stupòovitost", 100);  // Degree column
            lvPiva.Columns.Add("Sklad", 150);  // Warehouse name column

            // Configure the ListView to allow row selection
            lvPiva.FullRowSelect = true;   // Makes the full row selectable
            lvPiva.HideSelection = false;  // Keeps selection highlighted when control loses focus
            lvPiva.MultiSelect = false;    // Optional: set to true if you want multi-row selection

            lvCidery.FullRowSelect = true;
            lvCidery.HideSelection = false;
            lvCidery.MultiSelect = false;

            // Configure lvCidery (for Cider)
            lvCidery.View = View.Details; // Set view to Details to show columns
            lvCidery.Columns.Add("", 150); 
            lvCidery.Columns.Add("Název", 150);  // Product name column
            lvCidery.Columns.Add("Obsah Alkoholu", 120);  // Alcohol content column
            lvCidery.Columns.Add("Cena", 100);  // Price column
            lvCidery.Columns.Add("Odrùda jablek", 100);  // Degree column
            lvCidery.Columns.Add("Sklad", 150);  // Warehouse name column
            this.Load += new EventHandler(Form1_Load);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadZbozi();  // Naète data pøi spuštìní formuláøe
        }
        #region Zbozi
        private int selectedZboziId = -1;
        private ListViewItem selectedZbozi = null;
        private char selectedtyp;
        private void LoadZbozi()
        {
            lvPiva.Items.Clear();
            lvCidery.Items.Clear();

            // Load pivo data with sklad_nazev
            var pivoData = GetDataFromView(@"
SELECT pivo_id, zbozi_nazev, obsah_alkoholu, cena, stupnovitost, sklad_nazev
FROM v_pivo");

            foreach (var item in pivoData)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Tag = item["PIVO_ID"].ToString();
                lvItem.SubItems.Add(item["ZBOZI_NAZEV"].ToString());
                lvItem.SubItems.Add(item["OBSAH_ALKOHOLU"].ToString());
                lvItem.SubItems.Add(item["CENA"].ToString());
                lvItem.SubItems.Add(item["STUPNOVITOST"].ToString());
                lvItem.SubItems.Add(item["SKLAD_NAZEV"].ToString());
                lvPiva.Items.Add(lvItem);
            }

            // Load cider data with sklad_nazev
            var ciderData = GetDataFromView(@"
SELECT cider_id, zbozi_nazev, obsah_alkoholu, cena, odruda_jablek, sklad_nazev
FROM v_cider");

            foreach (var item in ciderData)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Tag = item["CIDER_ID"].ToString();
                lvItem.SubItems.Add(item["ZBOZI_NAZEV"].ToString());
                lvItem.SubItems.Add(item["OBSAH_ALKOHOLU"].ToString());
                lvItem.SubItems.Add(item["CENA"].ToString());
                lvItem.SubItems.Add(item["ODRUDA_JABLEK"].ToString());
                lvItem.SubItems.Add(item["SKLAD_NAZEV"].ToString());
                lvCidery.Items.Add(lvItem);
            }
        }

        private void updateZboziBtn_Click(object sender, EventArgs e)
        {
            if (selectedZboziId == -1)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            else
            {
                PopulateUpdateForm(selectedZbozi);
            }
            
        }

        private void InsertZboziBtn_Click(object sender, EventArgs e)
        {
            using (var insertForm = new InsertZboziForm())
            {
                if (insertForm.ShowDialog() == DialogResult.OK)
                {
                    // Get the data from the form
                    string nazev = insertForm.Nazev;
                    decimal obsahAlkoholu = insertForm.ObsahAlkoholu;
                    decimal cena = insertForm.Cena;
                    int idSklad = insertForm.IdSklad;
                    char typ = insertForm.Typ;

                    // Create a dictionary with the parameters
                    var parameters = new Dictionary<string, object>
            {
                { "p_nazev", nazev },
                { "p_obsah_alkoholu", obsahAlkoholu },
                { "p_cena", cena },
                { "p_id_sklad", idSklad },
                { "p_typ", typ }
            };

                    // Execute the insert procedure
                    ExecuteProcedure("insert_zbozi", parameters);
                }
            }
        }

        private void DeleteZboziBtn_Click(object sender, EventArgs e)
        {
            if(selectedZboziId == -1)
            {
                MessageBox.Show("Vyberte zboží");
            }
            else
            {
                var parameters = new Dictionary<string, object>
            {
                { "p_id", selectedZboziId }
            };

                // Execute the delete procedure
                ExecuteProcedure("delete_zbozi", parameters);
                LoadZbozi();
            }
        }
        private void PopulateUpdateForm(ListViewItem selectedItem)
        {
            if (selectedItem != null)
            {
                // Extract data from the selected ListViewItem
                int zboziId = Convert.ToInt32(selectedItem.Tag);
                string nazev = selectedItem.SubItems[1].Text;
                decimal obsahAlkoholu = Convert.ToDecimal(selectedItem.SubItems[2].Text);
                decimal cena = Convert.ToDecimal(selectedItem.SubItems[3].Text);
                int idSklad = Convert.ToInt32(selectedItem.SubItems[5].Text); // Assuming the sklad_nazev is in the 6th column
                char typ = selectedtyp; // Assuming the type is in the 1st column

                // Open the update form and populate it with the data
                using (var updateForm = new UpdateZboziForm())
                {
                    updateForm.Id = zboziId;
                    updateForm.Nazev = nazev;
                    updateForm.ObsahAlkoholu = obsahAlkoholu;
                    updateForm.Cena = cena;
                    updateForm.IdSklad = idSklad;
                    updateForm.Typ = typ;

                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update the zbozi record
                        var parameters = new Dictionary<string, object>
                {
                    { "p_id", updateForm.Id },
                    { "p_nazev", updateForm.Nazev },
                    { "p_obsah_alkoholu", updateForm.ObsahAlkoholu },
                    { "p_cena", updateForm.Cena },
                    { "p_id_sklad", updateForm.IdSklad },
                    { "p_typ", updateForm.Typ }
                };

                        ExecuteProcedure("update_zbozi", parameters);
                    }
                }
            }
        }
        private void lvPiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var args = e as ListViewItemSelectionChangedEventArgs;
            if (args != null && args.IsSelected)
            {
                lvCidery.SelectedItems.Clear();

                // Store the selected ID
                selectedZboziId = Convert.ToInt32(args.Item.Tag);
                selectedZbozi = args.Item;
                selectedtyp = 'p';
            }
        }

        private void lvCidery_SelectedIndexChanged(object sender, EventArgs e)
        {
            var args = e as ListViewItemSelectionChangedEventArgs;
            if (args != null && args.IsSelected)
            {
                lvPiva.SelectedItems.Clear();

                // Store the selected ID
                selectedZboziId = Convert.ToInt32(args.Item.SubItems[0].Tag);
                selectedZbozi = args.Item;
                selectedtyp = 'c';
            }
        }





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

                // Pøidání parametrù do pøíkazu
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

        
    }
}
