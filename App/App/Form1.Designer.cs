namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabZbozi = new TabPage();
            panel1 = new Panel();
            btnCancelFiltrZbozi = new Button();
            comboFiltrTypZbozi = new ComboBox();
            comboSkladFiltrZbozi = new ComboBox();
            btnFiltrZbozi = new Button();
            txtFiltrValueZbozi = new TextBox();
            updateZboziBtn = new Button();
            InsertZboziBtn = new Button();
            comboFiltrZbozi = new ComboBox();
            label15 = new Label();
            DeleteZboziBtn = new Button();
            label1 = new Label();
            lvPiva = new ListView();
            tabProfil = new TabPage();
            panel10 = new Panel();
            label16 = new Label();
            osUdajeCheck = new CheckBox();
            registerBtn = new Button();
            labelRegisteredUsername = new Label();
            loginBtn = new Button();
            labelRegisteredName = new Label();
            tabObjednávky = new TabPage();
            panel2 = new Panel();
            InsertObjednavkaBtn = new Button();
            objZboziBtn = new Button();
            UpdateObjednavkaBtn = new Button();
            FakturaBtn = new Button();
            DeleteObjednavkaBtn = new Button();
            labelObj = new Label();
            lvObjednavky = new ListView();
            tabSuroviny = new TabPage();
            panel3 = new Panel();
            InsertSurovinaBtn = new Button();
            DeleteSurovinaBtn = new Button();
            UpdateSurovinaBtn = new Button();
            label2 = new Label();
            lvSuroviny = new ListView();
            tabZakaznici = new TabPage();
            panel4 = new Panel();
            UpdateZakaznikBtn = new Button();
            InsertZakaznikBtn = new Button();
            DeleteZakaznikBtn = new Button();
            lvZakaznici = new ListView();
            label3 = new Label();
            tabZaměstnanci = new TabPage();
            panel5 = new Panel();
            btnAddZamestnanec = new Button();
            btnEditZamestnanec = new Button();
            btnDeleteZamestnanec = new Button();
            label4 = new Label();
            lvZamestnanci = new ListView();
            tabNadrizeni = new TabPage();
            tbNadrizeni = new TextBox();
            hierarchyBtn = new Button();
            tabProvozovny = new TabPage();
            panel6 = new Panel();
            btnDeleteProvozovna = new Button();
            btnEditProvozovna = new Button();
            btnAddProvozovna = new Button();
            labelProvozovny = new Label();
            lvProvozovny = new ListView();
            tabPozice = new TabPage();
            panel7 = new Panel();
            btnDeletePozice = new Button();
            btnEditPozice = new Button();
            btnAddPozice = new Button();
            label5 = new Label();
            lvPozice = new ListView();
            tabTypyAkce = new TabPage();
            panel8 = new Panel();
            btnDeleteTypAkce = new Button();
            btnEditTypAkce = new Button();
            btnAddTyp = new Button();
            label6 = new Label();
            lvTypyAkce = new ListView();
            tabSklad = new TabPage();
            panel9 = new Panel();
            btnUpdateSklad = new Button();
            btnDeleteSklad = new Button();
            btnAddSklad = new Button();
            label7 = new Label();
            lvSklady = new ListView();
            tabStats = new TabPage();
            txtMostExpensiveCustomer = new TextBox();
            txtLeastExpensiveCustomer = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtLeastExpensiveOrder = new TextBox();
            txtMostExpensiveOrder = new TextBox();
            txtPendingOrders = new TextBox();
            txtCompletedOrders = new TextBox();
            txtTotalPrice = new TextBox();
            txtAveragePrice = new TextBox();
            txtTotalOrders = new TextBox();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            fileSystemWatcher1 = new FileSystemWatcher();
            tabControl1.SuspendLayout();
            tabZbozi.SuspendLayout();
            panel1.SuspendLayout();
            tabProfil.SuspendLayout();
            panel10.SuspendLayout();
            tabObjednávky.SuspendLayout();
            panel2.SuspendLayout();
            tabSuroviny.SuspendLayout();
            panel3.SuspendLayout();
            tabZakaznici.SuspendLayout();
            panel4.SuspendLayout();
            tabZaměstnanci.SuspendLayout();
            panel5.SuspendLayout();
            tabNadrizeni.SuspendLayout();
            tabProvozovny.SuspendLayout();
            panel6.SuspendLayout();
            tabPozice.SuspendLayout();
            panel7.SuspendLayout();
            tabTypyAkce.SuspendLayout();
            panel8.SuspendLayout();
            tabSklad.SuspendLayout();
            panel9.SuspendLayout();
            tabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabZbozi);
            tabControl1.Controls.Add(tabProfil);
            tabControl1.Controls.Add(tabObjednávky);
            tabControl1.Controls.Add(tabSuroviny);
            tabControl1.Controls.Add(tabZakaznici);
            tabControl1.Controls.Add(tabZaměstnanci);
            tabControl1.Controls.Add(tabNadrizeni);
            tabControl1.Controls.Add(tabProvozovny);
            tabControl1.Controls.Add(tabPozice);
            tabControl1.Controls.Add(tabTypyAkce);
            tabControl1.Controls.Add(tabSklad);
            tabControl1.Controls.Add(tabStats);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1296, 785);
            tabControl1.TabIndex = 0;
            // 
            // tabZbozi
            // 
            tabZbozi.BackColor = Color.Gainsboro;
            tabZbozi.Controls.Add(panel1);
            tabZbozi.Controls.Add(label1);
            tabZbozi.Controls.Add(lvPiva);
            tabZbozi.Location = new Point(4, 24);
            tabZbozi.Name = "tabZbozi";
            tabZbozi.Padding = new Padding(3);
            tabZbozi.Size = new Size(1288, 757);
            tabZbozi.TabIndex = 0;
            tabZbozi.Text = "Zboží";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancelFiltrZbozi);
            panel1.Controls.Add(comboFiltrTypZbozi);
            panel1.Controls.Add(comboSkladFiltrZbozi);
            panel1.Controls.Add(btnFiltrZbozi);
            panel1.Controls.Add(txtFiltrValueZbozi);
            panel1.Controls.Add(updateZboziBtn);
            panel1.Controls.Add(InsertZboziBtn);
            panel1.Controls.Add(comboFiltrZbozi);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(DeleteZboziBtn);
            panel1.Location = new Point(902, 55);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(380, 607);
            panel1.TabIndex = 6;
            // 
            // btnCancelFiltrZbozi
            // 
            btnCancelFiltrZbozi.Location = new Point(94, 346);
            btnCancelFiltrZbozi.Name = "btnCancelFiltrZbozi";
            btnCancelFiltrZbozi.Size = new Size(185, 23);
            btnCancelFiltrZbozi.TabIndex = 13;
            btnCancelFiltrZbozi.Text = "Zrušit Filtr";
            btnCancelFiltrZbozi.UseVisualStyleBackColor = true;
            btnCancelFiltrZbozi.Click += btnCancelFiltrZbozi_Click;
            // 
            // comboFiltrTypZbozi
            // 
            comboFiltrTypZbozi.FormattingEnabled = true;
            comboFiltrTypZbozi.Location = new Point(94, 279);
            comboFiltrTypZbozi.Name = "comboFiltrTypZbozi";
            comboFiltrTypZbozi.Size = new Size(185, 23);
            comboFiltrTypZbozi.TabIndex = 12;
            // 
            // comboSkladFiltrZbozi
            // 
            comboSkladFiltrZbozi.FormattingEnabled = true;
            comboSkladFiltrZbozi.Location = new Point(94, 250);
            comboSkladFiltrZbozi.Name = "comboSkladFiltrZbozi";
            comboSkladFiltrZbozi.Size = new Size(185, 23);
            comboSkladFiltrZbozi.TabIndex = 11;
            // 
            // btnFiltrZbozi
            // 
            btnFiltrZbozi.Location = new Point(94, 317);
            btnFiltrZbozi.Name = "btnFiltrZbozi";
            btnFiltrZbozi.Size = new Size(185, 23);
            btnFiltrZbozi.TabIndex = 9;
            btnFiltrZbozi.Text = "Filtrovat";
            btnFiltrZbozi.UseVisualStyleBackColor = true;
            btnFiltrZbozi.Click += btnFiltrZbozi_Click;
            // 
            // txtFiltrValueZbozi
            // 
            txtFiltrValueZbozi.Location = new Point(94, 221);
            txtFiltrValueZbozi.Name = "txtFiltrValueZbozi";
            txtFiltrValueZbozi.Size = new Size(185, 23);
            txtFiltrValueZbozi.TabIndex = 10;
            // 
            // updateZboziBtn
            // 
            updateZboziBtn.Location = new Point(5, 5);
            updateZboziBtn.Name = "updateZboziBtn";
            updateZboziBtn.Size = new Size(371, 23);
            updateZboziBtn.TabIndex = 2;
            updateZboziBtn.Text = "Upravit Zboží";
            updateZboziBtn.UseVisualStyleBackColor = true;
            updateZboziBtn.Click += updateZboziBtn_Click;
            // 
            // InsertZboziBtn
            // 
            InsertZboziBtn.Location = new Point(5, 55);
            InsertZboziBtn.Name = "InsertZboziBtn";
            InsertZboziBtn.Size = new Size(370, 23);
            InsertZboziBtn.TabIndex = 3;
            InsertZboziBtn.Text = "Vložit Zboží";
            InsertZboziBtn.UseVisualStyleBackColor = true;
            InsertZboziBtn.Click += InsertZboziBtn_Click;
            // 
            // comboFiltrZbozi
            // 
            comboFiltrZbozi.FormattingEnabled = true;
            comboFiltrZbozi.Location = new Point(94, 192);
            comboFiltrZbozi.Name = "comboFiltrZbozi";
            comboFiltrZbozi.Size = new Size(185, 23);
            comboFiltrZbozi.TabIndex = 7;
            comboFiltrZbozi.SelectedIndexChanged += comboFiltrZbozi_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16F);
            label15.Location = new Point(164, 159);
            label15.Name = "label15";
            label15.Size = new Size(49, 30);
            label15.TabIndex = 8;
            label15.Text = "Filtr";
            // 
            // DeleteZboziBtn
            // 
            DeleteZboziBtn.Location = new Point(5, 105);
            DeleteZboziBtn.Name = "DeleteZboziBtn";
            DeleteZboziBtn.Size = new Size(370, 23);
            DeleteZboziBtn.TabIndex = 4;
            DeleteZboziBtn.Text = "Smazat Zboží";
            DeleteZboziBtn.UseVisualStyleBackColor = true;
            DeleteZboziBtn.Click += DeleteZboziBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 5;
            label1.Text = "Zboží";
            // 
            // lvPiva
            // 
            lvPiva.BackColor = SystemColors.Window;
            lvPiva.Location = new Point(18, 55);
            lvPiva.Name = "lvPiva";
            lvPiva.Size = new Size(878, 607);
            lvPiva.TabIndex = 0;
            lvPiva.UseCompatibleStateImageBehavior = false;
            // 
            // tabProfil
            // 
            tabProfil.BackColor = Color.Gainsboro;
            tabProfil.Controls.Add(panel10);
            tabProfil.Location = new Point(4, 24);
            tabProfil.Name = "tabProfil";
            tabProfil.Padding = new Padding(3);
            tabProfil.Size = new Size(1288, 757);
            tabProfil.TabIndex = 1;
            tabProfil.Text = "Profil";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Silver;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label16);
            panel10.Controls.Add(osUdajeCheck);
            panel10.Controls.Add(registerBtn);
            panel10.Controls.Add(labelRegisteredUsername);
            panel10.Controls.Add(loginBtn);
            panel10.Controls.Add(labelRegisteredName);
            panel10.Location = new Point(442, 36);
            panel10.Name = "panel10";
            panel10.Size = new Size(432, 682);
            panel10.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.LightGray;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(12, 9);
            label16.Name = "label16";
            label16.Padding = new Padding(180, 10, 180, 10);
            label16.Size = new Size(407, 41);
            label16.TabIndex = 5;
            label16.Text = "Profil";
            // 
            // osUdajeCheck
            // 
            osUdajeCheck.AutoSize = true;
            osUdajeCheck.Location = new Point(35, 267);
            osUdajeCheck.Name = "osUdajeCheck";
            osUdajeCheck.Size = new Size(169, 19);
            osUdajeCheck.TabIndex = 4;
            osUdajeCheck.Text = "Nezobrazovat osobní údaje";
            osUdajeCheck.UseVisualStyleBackColor = true;
            osUdajeCheck.CheckedChanged += osUdajeCheck_CheckedChanged;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(35, 330);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(370, 40);
            registerBtn.TabIndex = 0;
            registerBtn.Text = "button4";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // labelRegisteredUsername
            // 
            labelRegisteredUsername.AutoSize = true;
            labelRegisteredUsername.Font = new Font("Segoe UI", 12F);
            labelRegisteredUsername.Location = new Point(35, 155);
            labelRegisteredUsername.Name = "labelRegisteredUsername";
            labelRegisteredUsername.Size = new Size(61, 21);
            labelRegisteredUsername.TabIndex = 3;
            labelRegisteredUsername.Text = "label16";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(35, 418);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(370, 40);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "button5";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // labelRegisteredName
            // 
            labelRegisteredName.AutoSize = true;
            labelRegisteredName.Font = new Font("Segoe UI", 12F);
            labelRegisteredName.Location = new Point(35, 79);
            labelRegisteredName.Name = "labelRegisteredName";
            labelRegisteredName.Size = new Size(61, 21);
            labelRegisteredName.TabIndex = 2;
            labelRegisteredName.Text = "label16";
            // 
            // tabObjednávky
            // 
            tabObjednávky.BackColor = Color.Gainsboro;
            tabObjednávky.Controls.Add(panel2);
            tabObjednávky.Controls.Add(labelObj);
            tabObjednávky.Controls.Add(lvObjednavky);
            tabObjednávky.Location = new Point(4, 24);
            tabObjednávky.Name = "tabObjednávky";
            tabObjednávky.Padding = new Padding(3);
            tabObjednávky.Size = new Size(1288, 757);
            tabObjednávky.TabIndex = 2;
            tabObjednávky.Text = "Objednávky";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(InsertObjednavkaBtn);
            panel2.Controls.Add(objZboziBtn);
            panel2.Controls.Add(UpdateObjednavkaBtn);
            panel2.Controls.Add(FakturaBtn);
            panel2.Controls.Add(DeleteObjednavkaBtn);
            panel2.Location = new Point(902, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 607);
            panel2.TabIndex = 7;
            // 
            // InsertObjednavkaBtn
            // 
            InsertObjednavkaBtn.Location = new Point(5, 5);
            InsertObjednavkaBtn.Name = "InsertObjednavkaBtn";
            InsertObjednavkaBtn.Size = new Size(190, 23);
            InsertObjednavkaBtn.TabIndex = 2;
            InsertObjednavkaBtn.Text = "Vložit Objednávku";
            InsertObjednavkaBtn.UseVisualStyleBackColor = true;
            InsertObjednavkaBtn.Click += InsertObjednavkaBtn_Click;
            // 
            // objZboziBtn
            // 
            objZboziBtn.Location = new Point(5, 205);
            objZboziBtn.Name = "objZboziBtn";
            objZboziBtn.Size = new Size(190, 23);
            objZboziBtn.TabIndex = 6;
            objZboziBtn.Text = "Objednané zboží";
            objZboziBtn.UseVisualStyleBackColor = true;
            objZboziBtn.Click += objZboziBtn_Click;
            // 
            // UpdateObjednavkaBtn
            // 
            UpdateObjednavkaBtn.Location = new Point(5, 55);
            UpdateObjednavkaBtn.Name = "UpdateObjednavkaBtn";
            UpdateObjednavkaBtn.Size = new Size(190, 23);
            UpdateObjednavkaBtn.TabIndex = 3;
            UpdateObjednavkaBtn.Text = "Upravit Objednávku";
            UpdateObjednavkaBtn.UseVisualStyleBackColor = true;
            UpdateObjednavkaBtn.Click += UpdateObjednavkaBtn_Click;
            // 
            // FakturaBtn
            // 
            FakturaBtn.Location = new Point(5, 155);
            FakturaBtn.Name = "FakturaBtn";
            FakturaBtn.Size = new Size(190, 23);
            FakturaBtn.TabIndex = 5;
            FakturaBtn.Text = "Faktura";
            FakturaBtn.UseVisualStyleBackColor = true;
            FakturaBtn.Click += FakturaBtn_Click;
            // 
            // DeleteObjednavkaBtn
            // 
            DeleteObjednavkaBtn.Location = new Point(5, 105);
            DeleteObjednavkaBtn.Name = "DeleteObjednavkaBtn";
            DeleteObjednavkaBtn.Size = new Size(190, 26);
            DeleteObjednavkaBtn.TabIndex = 4;
            DeleteObjednavkaBtn.Text = "Smazat Objednávku";
            DeleteObjednavkaBtn.UseVisualStyleBackColor = true;
            DeleteObjednavkaBtn.Click += DeleteObjednavkaBtn_Click;
            // 
            // labelObj
            // 
            labelObj.AutoSize = true;
            labelObj.Font = new Font("Segoe UI", 12F);
            labelObj.Location = new Point(18, 19);
            labelObj.Name = "labelObj";
            labelObj.Size = new Size(93, 21);
            labelObj.TabIndex = 1;
            labelObj.Text = "Objednávky";
            // 
            // lvObjednavky
            // 
            lvObjednavky.Location = new Point(18, 55);
            lvObjednavky.Name = "lvObjednavky";
            lvObjednavky.Size = new Size(878, 607);
            lvObjednavky.TabIndex = 0;
            lvObjednavky.UseCompatibleStateImageBehavior = false;
            // 
            // tabSuroviny
            // 
            tabSuroviny.BackColor = Color.Gainsboro;
            tabSuroviny.Controls.Add(panel3);
            tabSuroviny.Controls.Add(label2);
            tabSuroviny.Controls.Add(lvSuroviny);
            tabSuroviny.Location = new Point(4, 24);
            tabSuroviny.Name = "tabSuroviny";
            tabSuroviny.Padding = new Padding(3);
            tabSuroviny.Size = new Size(1288, 757);
            tabSuroviny.TabIndex = 3;
            tabSuroviny.Text = "Suroviny";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(InsertSurovinaBtn);
            panel3.Controls.Add(DeleteSurovinaBtn);
            panel3.Controls.Add(UpdateSurovinaBtn);
            panel3.Location = new Point(902, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 607);
            panel3.TabIndex = 5;
            // 
            // InsertSurovinaBtn
            // 
            InsertSurovinaBtn.Location = new Point(5, 5);
            InsertSurovinaBtn.Name = "InsertSurovinaBtn";
            InsertSurovinaBtn.Size = new Size(227, 26);
            InsertSurovinaBtn.TabIndex = 2;
            InsertSurovinaBtn.Text = "Vložit Surovinu";
            InsertSurovinaBtn.UseVisualStyleBackColor = true;
            InsertSurovinaBtn.Click += InsertSurovinaBtn_Click;
            // 
            // DeleteSurovinaBtn
            // 
            DeleteSurovinaBtn.Location = new Point(5, 105);
            DeleteSurovinaBtn.Name = "DeleteSurovinaBtn";
            DeleteSurovinaBtn.Size = new Size(227, 26);
            DeleteSurovinaBtn.TabIndex = 4;
            DeleteSurovinaBtn.Text = "Smazat Surovinu";
            DeleteSurovinaBtn.UseVisualStyleBackColor = true;
            DeleteSurovinaBtn.Click += DeleteSurovinaBtn_Click;
            // 
            // UpdateSurovinaBtn
            // 
            UpdateSurovinaBtn.Location = new Point(5, 55);
            UpdateSurovinaBtn.Name = "UpdateSurovinaBtn";
            UpdateSurovinaBtn.Size = new Size(227, 23);
            UpdateSurovinaBtn.TabIndex = 3;
            UpdateSurovinaBtn.Text = "Upravit Surovinu";
            UpdateSurovinaBtn.UseVisualStyleBackColor = true;
            UpdateSurovinaBtn.Click += UpdateSurovinaBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Suroviny";
            // 
            // lvSuroviny
            // 
            lvSuroviny.Location = new Point(18, 55);
            lvSuroviny.Name = "lvSuroviny";
            lvSuroviny.Size = new Size(878, 607);
            lvSuroviny.TabIndex = 0;
            lvSuroviny.UseCompatibleStateImageBehavior = false;
            // 
            // tabZakaznici
            // 
            tabZakaznici.BackColor = Color.Gainsboro;
            tabZakaznici.Controls.Add(panel4);
            tabZakaznici.Controls.Add(lvZakaznici);
            tabZakaznici.Controls.Add(label3);
            tabZakaznici.Location = new Point(4, 24);
            tabZakaznici.Name = "tabZakaznici";
            tabZakaznici.Padding = new Padding(3);
            tabZakaznici.Size = new Size(1288, 757);
            tabZakaznici.TabIndex = 4;
            tabZakaznici.Text = "Zákazníci";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(UpdateZakaznikBtn);
            panel4.Controls.Add(InsertZakaznikBtn);
            panel4.Controls.Add(DeleteZakaznikBtn);
            panel4.Location = new Point(902, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 607);
            panel4.TabIndex = 5;
            // 
            // UpdateZakaznikBtn
            // 
            UpdateZakaznikBtn.Location = new Point(5, 55);
            UpdateZakaznikBtn.Name = "UpdateZakaznikBtn";
            UpdateZakaznikBtn.Size = new Size(227, 23);
            UpdateZakaznikBtn.TabIndex = 3;
            UpdateZakaznikBtn.Text = "Upravit Zákazníka";
            UpdateZakaznikBtn.UseVisualStyleBackColor = true;
            UpdateZakaznikBtn.Click += UpdateZakaznikBtn_Click;
            // 
            // InsertZakaznikBtn
            // 
            InsertZakaznikBtn.Location = new Point(5, 5);
            InsertZakaznikBtn.Name = "InsertZakaznikBtn";
            InsertZakaznikBtn.Size = new Size(227, 26);
            InsertZakaznikBtn.TabIndex = 2;
            InsertZakaznikBtn.Text = "Vložit Zákazníka";
            InsertZakaznikBtn.UseVisualStyleBackColor = true;
            InsertZakaznikBtn.Click += InsertZakaznikBtn_Click;
            // 
            // DeleteZakaznikBtn
            // 
            DeleteZakaznikBtn.Location = new Point(5, 105);
            DeleteZakaznikBtn.Name = "DeleteZakaznikBtn";
            DeleteZakaznikBtn.Size = new Size(227, 26);
            DeleteZakaznikBtn.TabIndex = 4;
            DeleteZakaznikBtn.Text = "Smazat Zákazníka";
            DeleteZakaznikBtn.UseVisualStyleBackColor = true;
            DeleteZakaznikBtn.Click += DeleteZakaznikBtn_Click;
            // 
            // lvZakaznici
            // 
            lvZakaznici.Location = new Point(18, 55);
            lvZakaznici.Name = "lvZakaznici";
            lvZakaznici.Size = new Size(878, 607);
            lvZakaznici.TabIndex = 1;
            lvZakaznici.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 0;
            label3.Text = "Zákazníci";
            // 
            // tabZaměstnanci
            // 
            tabZaměstnanci.BackColor = Color.Gainsboro;
            tabZaměstnanci.Controls.Add(panel5);
            tabZaměstnanci.Controls.Add(label4);
            tabZaměstnanci.Controls.Add(lvZamestnanci);
            tabZaměstnanci.Location = new Point(4, 24);
            tabZaměstnanci.Name = "tabZaměstnanci";
            tabZaměstnanci.Padding = new Padding(3);
            tabZaměstnanci.Size = new Size(1288, 757);
            tabZaměstnanci.TabIndex = 5;
            tabZaměstnanci.Text = "Zaměstnanci";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnAddZamestnanec);
            panel5.Controls.Add(btnEditZamestnanec);
            panel5.Controls.Add(btnDeleteZamestnanec);
            panel5.Location = new Point(902, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 607);
            panel5.TabIndex = 2;
            // 
            // btnAddZamestnanec
            // 
            btnAddZamestnanec.Location = new Point(5, 5);
            btnAddZamestnanec.Name = "btnAddZamestnanec";
            btnAddZamestnanec.Size = new Size(225, 23);
            btnAddZamestnanec.TabIndex = 2;
            btnAddZamestnanec.Text = "Vložit zaměstnance";
            btnAddZamestnanec.UseVisualStyleBackColor = true;
            btnAddZamestnanec.Click += btnAddZamestnanec_Click;
            // 
            // btnEditZamestnanec
            // 
            btnEditZamestnanec.Location = new Point(5, 55);
            btnEditZamestnanec.Name = "btnEditZamestnanec";
            btnEditZamestnanec.Size = new Size(225, 23);
            btnEditZamestnanec.TabIndex = 1;
            btnEditZamestnanec.Text = "Upravit Zaměstnance";
            btnEditZamestnanec.UseVisualStyleBackColor = true;
            btnEditZamestnanec.Click += btnEditZamestnanec_Click;
            // 
            // btnDeleteZamestnanec
            // 
            btnDeleteZamestnanec.Location = new Point(5, 105);
            btnDeleteZamestnanec.Name = "btnDeleteZamestnanec";
            btnDeleteZamestnanec.Size = new Size(225, 23);
            btnDeleteZamestnanec.TabIndex = 0;
            btnDeleteZamestnanec.Text = "Odebrat zaměstnance";
            btnDeleteZamestnanec.UseVisualStyleBackColor = true;
            btnDeleteZamestnanec.Click += btnDeleteZamestnanec_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 19);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 1;
            label4.Text = "Zaměstnanci";
            // 
            // lvZamestnanci
            // 
            lvZamestnanci.Location = new Point(18, 55);
            lvZamestnanci.Name = "lvZamestnanci";
            lvZamestnanci.Size = new Size(878, 607);
            lvZamestnanci.TabIndex = 0;
            lvZamestnanci.UseCompatibleStateImageBehavior = false;
            // 
            // tabNadrizeni
            // 
            tabNadrizeni.Controls.Add(tbNadrizeni);
            tabNadrizeni.Controls.Add(hierarchyBtn);
            tabNadrizeni.Location = new Point(4, 24);
            tabNadrizeni.Name = "tabNadrizeni";
            tabNadrizeni.Padding = new Padding(3);
            tabNadrizeni.Size = new Size(1288, 757);
            tabNadrizeni.TabIndex = 6;
            tabNadrizeni.Text = "Nadřízení";
            tabNadrizeni.UseVisualStyleBackColor = true;
            // 
            // tbNadrizeni
            // 
            tbNadrizeni.Font = new Font("Segoe UI", 13F);
            tbNadrizeni.Location = new Point(64, 22);
            tbNadrizeni.Multiline = true;
            tbNadrizeni.Name = "tbNadrizeni";
            tbNadrizeni.Size = new Size(1119, 660);
            tbNadrizeni.TabIndex = 2;
            // 
            // hierarchyBtn
            // 
            hierarchyBtn.Location = new Point(34, 717);
            hierarchyBtn.Name = "hierarchyBtn";
            hierarchyBtn.Size = new Size(1175, 23);
            hierarchyBtn.TabIndex = 1;
            hierarchyBtn.Text = "Načíst hierarchii";
            hierarchyBtn.UseVisualStyleBackColor = true;
            hierarchyBtn.Click += hierarchyBtn_Click;
            // 
            // tabProvozovny
            // 
            tabProvozovny.BackColor = Color.Gainsboro;
            tabProvozovny.Controls.Add(panel6);
            tabProvozovny.Controls.Add(labelProvozovny);
            tabProvozovny.Controls.Add(lvProvozovny);
            tabProvozovny.Location = new Point(4, 24);
            tabProvozovny.Name = "tabProvozovny";
            tabProvozovny.Padding = new Padding(3);
            tabProvozovny.Size = new Size(1288, 757);
            tabProvozovny.TabIndex = 7;
            tabProvozovny.Text = "Provozovny";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnDeleteProvozovna);
            panel6.Controls.Add(btnEditProvozovna);
            panel6.Controls.Add(btnAddProvozovna);
            panel6.Location = new Point(902, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(380, 607);
            panel6.TabIndex = 2;
            // 
            // btnDeleteProvozovna
            // 
            btnDeleteProvozovna.Location = new Point(5, 105);
            btnDeleteProvozovna.Name = "btnDeleteProvozovna";
            btnDeleteProvozovna.Size = new Size(197, 23);
            btnDeleteProvozovna.TabIndex = 2;
            btnDeleteProvozovna.Text = "Odstranit provozovnu";
            btnDeleteProvozovna.UseVisualStyleBackColor = true;
            btnDeleteProvozovna.Click += btnDeleteProvozovna_Click;
            // 
            // btnEditProvozovna
            // 
            btnEditProvozovna.Location = new Point(5, 55);
            btnEditProvozovna.Name = "btnEditProvozovna";
            btnEditProvozovna.Size = new Size(197, 23);
            btnEditProvozovna.TabIndex = 1;
            btnEditProvozovna.Text = "Upravit provozovnu";
            btnEditProvozovna.UseVisualStyleBackColor = true;
            btnEditProvozovna.Click += btnEditProvozovna_Click;
            // 
            // btnAddProvozovna
            // 
            btnAddProvozovna.Location = new Point(5, 5);
            btnAddProvozovna.Name = "btnAddProvozovna";
            btnAddProvozovna.Size = new Size(197, 23);
            btnAddProvozovna.TabIndex = 0;
            btnAddProvozovna.Text = "Vložit provozovnu";
            btnAddProvozovna.UseVisualStyleBackColor = true;
            btnAddProvozovna.Click += btnAddProvozovna_Click;
            // 
            // labelProvozovny
            // 
            labelProvozovny.AutoSize = true;
            labelProvozovny.Font = new Font("Segoe UI", 12F);
            labelProvozovny.Location = new Point(18, 19);
            labelProvozovny.Name = "labelProvozovny";
            labelProvozovny.Size = new Size(92, 21);
            labelProvozovny.TabIndex = 1;
            labelProvozovny.Text = "Provozovny";
            // 
            // lvProvozovny
            // 
            lvProvozovny.Location = new Point(18, 55);
            lvProvozovny.Name = "lvProvozovny";
            lvProvozovny.Size = new Size(878, 607);
            lvProvozovny.TabIndex = 0;
            lvProvozovny.UseCompatibleStateImageBehavior = false;
            // 
            // tabPozice
            // 
            tabPozice.BackColor = Color.Gainsboro;
            tabPozice.Controls.Add(panel7);
            tabPozice.Controls.Add(label5);
            tabPozice.Controls.Add(lvPozice);
            tabPozice.Location = new Point(4, 24);
            tabPozice.Name = "tabPozice";
            tabPozice.Padding = new Padding(3);
            tabPozice.Size = new Size(1288, 757);
            tabPozice.TabIndex = 8;
            tabPozice.Text = "Pracovní pozice";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btnDeletePozice);
            panel7.Controls.Add(btnEditPozice);
            panel7.Controls.Add(btnAddPozice);
            panel7.Location = new Point(902, 55);
            panel7.Name = "panel7";
            panel7.Size = new Size(380, 607);
            panel7.TabIndex = 2;
            // 
            // btnDeletePozice
            // 
            btnDeletePozice.Location = new Point(5, 105);
            btnDeletePozice.Name = "btnDeletePozice";
            btnDeletePozice.Size = new Size(212, 23);
            btnDeletePozice.TabIndex = 2;
            btnDeletePozice.Text = "Odebrat pracovní pozici";
            btnDeletePozice.UseVisualStyleBackColor = true;
            btnDeletePozice.Click += btnDeletePozice_Click;
            // 
            // btnEditPozice
            // 
            btnEditPozice.Location = new Point(5, 55);
            btnEditPozice.Name = "btnEditPozice";
            btnEditPozice.Size = new Size(212, 23);
            btnEditPozice.TabIndex = 1;
            btnEditPozice.Text = "Upravit pracovní pozici";
            btnEditPozice.UseVisualStyleBackColor = true;
            btnEditPozice.Click += btnEditPozice_Click;
            // 
            // btnAddPozice
            // 
            btnAddPozice.Location = new Point(5, 5);
            btnAddPozice.Name = "btnAddPozice";
            btnAddPozice.Size = new Size(212, 23);
            btnAddPozice.TabIndex = 0;
            btnAddPozice.Text = "Vložit pracovní pozici";
            btnAddPozice.UseVisualStyleBackColor = true;
            btnAddPozice.Click += btnAddPozice_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 19);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 1;
            label5.Text = "Pracovní pozice";
            // 
            // lvPozice
            // 
            lvPozice.Location = new Point(18, 55);
            lvPozice.Name = "lvPozice";
            lvPozice.Size = new Size(878, 607);
            lvPozice.TabIndex = 0;
            lvPozice.UseCompatibleStateImageBehavior = false;
            // 
            // tabTypyAkce
            // 
            tabTypyAkce.BackColor = Color.Gainsboro;
            tabTypyAkce.Controls.Add(panel8);
            tabTypyAkce.Controls.Add(label6);
            tabTypyAkce.Controls.Add(lvTypyAkce);
            tabTypyAkce.Location = new Point(4, 24);
            tabTypyAkce.Name = "tabTypyAkce";
            tabTypyAkce.Padding = new Padding(3);
            tabTypyAkce.Size = new Size(1288, 757);
            tabTypyAkce.TabIndex = 9;
            tabTypyAkce.Text = "Typy akce";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btnDeleteTypAkce);
            panel8.Controls.Add(btnEditTypAkce);
            panel8.Controls.Add(btnAddTyp);
            panel8.Location = new Point(902, 55);
            panel8.Name = "panel8";
            panel8.Size = new Size(380, 607);
            panel8.TabIndex = 2;
            // 
            // btnDeleteTypAkce
            // 
            btnDeleteTypAkce.Location = new Point(5, 105);
            btnDeleteTypAkce.Name = "btnDeleteTypAkce";
            btnDeleteTypAkce.Size = new Size(261, 23);
            btnDeleteTypAkce.TabIndex = 2;
            btnDeleteTypAkce.Text = "Odebrat typ akce";
            btnDeleteTypAkce.UseVisualStyleBackColor = true;
            btnDeleteTypAkce.Click += btnDeleteTypAkce_Click;
            // 
            // btnEditTypAkce
            // 
            btnEditTypAkce.Location = new Point(5, 55);
            btnEditTypAkce.Name = "btnEditTypAkce";
            btnEditTypAkce.Size = new Size(261, 23);
            btnEditTypAkce.TabIndex = 1;
            btnEditTypAkce.Text = "Upravit typ akce";
            btnEditTypAkce.UseVisualStyleBackColor = true;
            btnEditTypAkce.Click += btnEditTypAkce_Click;
            // 
            // btnAddTyp
            // 
            btnAddTyp.Location = new Point(5, 5);
            btnAddTyp.Name = "btnAddTyp";
            btnAddTyp.Size = new Size(261, 23);
            btnAddTyp.TabIndex = 0;
            btnAddTyp.Text = "Vložit typ akce";
            btnAddTyp.UseVisualStyleBackColor = true;
            btnAddTyp.Click += btnAddTyp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 19);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 1;
            label6.Text = "Typy akce";
            // 
            // lvTypyAkce
            // 
            lvTypyAkce.Location = new Point(18, 55);
            lvTypyAkce.Name = "lvTypyAkce";
            lvTypyAkce.Size = new Size(878, 607);
            lvTypyAkce.TabIndex = 0;
            lvTypyAkce.UseCompatibleStateImageBehavior = false;
            // 
            // tabSklad
            // 
            tabSklad.BackColor = Color.Gainsboro;
            tabSklad.Controls.Add(panel9);
            tabSklad.Controls.Add(label7);
            tabSklad.Controls.Add(lvSklady);
            tabSklad.Location = new Point(4, 24);
            tabSklad.Name = "tabSklad";
            tabSklad.Padding = new Padding(3);
            tabSklad.Size = new Size(1288, 757);
            tabSklad.TabIndex = 10;
            tabSklad.Text = "Sklady";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Silver;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(btnUpdateSklad);
            panel9.Controls.Add(btnDeleteSklad);
            panel9.Controls.Add(btnAddSklad);
            panel9.Location = new Point(902, 55);
            panel9.Name = "panel9";
            panel9.Size = new Size(380, 607);
            panel9.TabIndex = 2;
            // 
            // btnUpdateSklad
            // 
            btnUpdateSklad.Location = new Point(5, 55);
            btnUpdateSklad.Name = "btnUpdateSklad";
            btnUpdateSklad.Size = new Size(204, 23);
            btnUpdateSklad.TabIndex = 2;
            btnUpdateSklad.Text = "Upravit sklad";
            btnUpdateSklad.UseVisualStyleBackColor = true;
            btnUpdateSklad.Click += btnUpdateSklad_Click;
            // 
            // btnDeleteSklad
            // 
            btnDeleteSklad.Location = new Point(5, 105);
            btnDeleteSklad.Name = "btnDeleteSklad";
            btnDeleteSklad.Size = new Size(204, 23);
            btnDeleteSklad.TabIndex = 1;
            btnDeleteSklad.Text = "Odstranit sklad";
            btnDeleteSklad.UseVisualStyleBackColor = true;
            btnDeleteSklad.Click += btnDeleteSklad_Click;
            // 
            // btnAddSklad
            // 
            btnAddSklad.Location = new Point(5, 5);
            btnAddSklad.Name = "btnAddSklad";
            btnAddSklad.Size = new Size(204, 23);
            btnAddSklad.TabIndex = 0;
            btnAddSklad.Text = "Vložit sklad";
            btnAddSklad.UseVisualStyleBackColor = true;
            btnAddSklad.Click += btnAddSklad_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 19);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 1;
            label7.Text = "Sklady";
            // 
            // lvSklady
            // 
            lvSklady.Location = new Point(18, 55);
            lvSklady.Name = "lvSklady";
            lvSklady.Size = new Size(878, 607);
            lvSklady.TabIndex = 0;
            lvSklady.UseCompatibleStateImageBehavior = false;
            // 
            // tabStats
            // 
            tabStats.Controls.Add(txtMostExpensiveCustomer);
            tabStats.Controls.Add(txtLeastExpensiveCustomer);
            tabStats.Controls.Add(label14);
            tabStats.Controls.Add(label13);
            tabStats.Controls.Add(label12);
            tabStats.Controls.Add(label11);
            tabStats.Controls.Add(label10);
            tabStats.Controls.Add(label9);
            tabStats.Controls.Add(label8);
            tabStats.Controls.Add(txtLeastExpensiveOrder);
            tabStats.Controls.Add(txtMostExpensiveOrder);
            tabStats.Controls.Add(txtPendingOrders);
            tabStats.Controls.Add(txtCompletedOrders);
            tabStats.Controls.Add(txtTotalPrice);
            tabStats.Controls.Add(txtAveragePrice);
            tabStats.Controls.Add(txtTotalOrders);
            tabStats.Location = new Point(4, 24);
            tabStats.Name = "tabStats";
            tabStats.Padding = new Padding(3);
            tabStats.Size = new Size(1288, 757);
            tabStats.TabIndex = 11;
            tabStats.Text = "Statistiky objednávek";
            tabStats.UseVisualStyleBackColor = true;
            // 
            // txtMostExpensiveCustomer
            // 
            txtMostExpensiveCustomer.Enabled = false;
            txtMostExpensiveCustomer.Location = new Point(312, 199);
            txtMostExpensiveCustomer.Name = "txtMostExpensiveCustomer";
            txtMostExpensiveCustomer.Size = new Size(100, 23);
            txtMostExpensiveCustomer.TabIndex = 15;
            // 
            // txtLeastExpensiveCustomer
            // 
            txtLeastExpensiveCustomer.Enabled = false;
            txtLeastExpensiveCustomer.Location = new Point(312, 228);
            txtLeastExpensiveCustomer.Name = "txtLeastExpensiveCustomer";
            txtLeastExpensiveCustomer.Size = new Size(100, 23);
            txtLeastExpensiveCustomer.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(59, 202);
            label14.Name = "label14";
            label14.Size = new Size(142, 15);
            label14.TabIndex = 13;
            label14.Text = "Nejvyšší cena objednávky";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(59, 231);
            label13.Name = "label13";
            label13.Size = new Size(140, 15);
            label13.TabIndex = 12;
            label13.Text = "Nejnižsí cena objednávky";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(103, 173);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 11;
            label12.Text = "Ve stavu vyřízeno";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(74, 144);
            label11.Name = "label11";
            label11.Size = new Size(126, 15);
            label11.TabIndex = 10;
            label11.Text = "Ve stavu zpracovává se";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 86);
            label10.Name = "label10";
            label10.Size = new Size(151, 15);
            label10.TabIndex = 9;
            label10.Text = "Průměrná cena objednávky";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 115);
            label9.Name = "label9";
            label9.Size = new Size(141, 15);
            label9.TabIndex = 8;
            label9.Text = "Celková cena objednávky";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 57);
            label8.Name = "label8";
            label8.Size = new Size(146, 15);
            label8.TabIndex = 7;
            label8.Text = "Celkový počet objednávek";
            // 
            // txtLeastExpensiveOrder
            // 
            txtLeastExpensiveOrder.Enabled = false;
            txtLeastExpensiveOrder.Location = new Point(206, 228);
            txtLeastExpensiveOrder.Name = "txtLeastExpensiveOrder";
            txtLeastExpensiveOrder.Size = new Size(100, 23);
            txtLeastExpensiveOrder.TabIndex = 6;
            // 
            // txtMostExpensiveOrder
            // 
            txtMostExpensiveOrder.Enabled = false;
            txtMostExpensiveOrder.Location = new Point(206, 199);
            txtMostExpensiveOrder.Name = "txtMostExpensiveOrder";
            txtMostExpensiveOrder.Size = new Size(100, 23);
            txtMostExpensiveOrder.TabIndex = 5;
            // 
            // txtPendingOrders
            // 
            txtPendingOrders.Enabled = false;
            txtPendingOrders.Location = new Point(206, 141);
            txtPendingOrders.Name = "txtPendingOrders";
            txtPendingOrders.Size = new Size(100, 23);
            txtPendingOrders.TabIndex = 4;
            // 
            // txtCompletedOrders
            // 
            txtCompletedOrders.Enabled = false;
            txtCompletedOrders.Location = new Point(206, 170);
            txtCompletedOrders.Name = "txtCompletedOrders";
            txtCompletedOrders.Size = new Size(100, 23);
            txtCompletedOrders.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Location = new Point(206, 112);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(100, 23);
            txtTotalPrice.TabIndex = 2;
            // 
            // txtAveragePrice
            // 
            txtAveragePrice.Enabled = false;
            txtAveragePrice.Location = new Point(206, 83);
            txtAveragePrice.Name = "txtAveragePrice";
            txtAveragePrice.Size = new Size(100, 23);
            txtAveragePrice.TabIndex = 1;
            // 
            // txtTotalOrders
            // 
            txtTotalOrders.Enabled = false;
            txtTotalOrders.Location = new Point(206, 54);
            txtTotalOrders.Name = "txtTotalOrders";
            txtTotalOrders.Size = new Size(100, 23);
            txtTotalOrders.TabIndex = 0;
            // 
            // oracleCommand1
            // 
            oracleCommand1.Transaction = null;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 809);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabZbozi.ResumeLayout(false);
            tabZbozi.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabProfil.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tabObjednávky.ResumeLayout(false);
            tabObjednávky.PerformLayout();
            panel2.ResumeLayout(false);
            tabSuroviny.ResumeLayout(false);
            tabSuroviny.PerformLayout();
            panel3.ResumeLayout(false);
            tabZakaznici.ResumeLayout(false);
            tabZakaznici.PerformLayout();
            panel4.ResumeLayout(false);
            tabZaměstnanci.ResumeLayout(false);
            tabZaměstnanci.PerformLayout();
            panel5.ResumeLayout(false);
            tabNadrizeni.ResumeLayout(false);
            tabNadrizeni.PerformLayout();
            tabProvozovny.ResumeLayout(false);
            tabProvozovny.PerformLayout();
            panel6.ResumeLayout(false);
            tabPozice.ResumeLayout(false);
            tabPozice.PerformLayout();
            panel7.ResumeLayout(false);
            tabTypyAkce.ResumeLayout(false);
            tabTypyAkce.PerformLayout();
            panel8.ResumeLayout(false);
            tabSklad.ResumeLayout(false);
            tabSklad.PerformLayout();
            panel9.ResumeLayout(false);
            tabStats.ResumeLayout(false);
            tabStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProfil;
        private Button loginBtn;
        private Button registerBtn;
        private TabPage tabZbozi;
        private Label label1;
        private Button DeleteZboziBtn;
        private Button InsertZboziBtn;
        private Button updateZboziBtn;
        private ListView lvPiva;
        private TabPage tabObjednávky;
        private Button DeleteObjednavkaBtn;
        private Button UpdateObjednavkaBtn;
        private Button InsertObjednavkaBtn;
        private Label labelObj;
        private ListView lvObjednavky;
        private TabPage tabSuroviny;
        private Label label2;
        private ListView lvSuroviny;
        private Button DeleteSurovinaBtn;
        private Button UpdateSurovinaBtn;
        private Button InsertSurovinaBtn;
        private TabPage tabZakaznici;
        private TabPage tabZaměstnanci;
        private Label label3;
        private ListView lvZakaznici;
        private Label label4;
        private ListView lvZamestnanci;
        private TabPage tabNadrizeni;
        private Button objZboziBtn;
        private Button UpdateZakaznikBtn;
        private Button InsertZakaznikBtn;
        private Button DeleteZakaznikBtn;
        private Button FakturaBtn;
        private Panel panel1;

        private void initBtns() {
            GlobalStyles.ApplyButtonStyle(this.DeleteZboziBtn, true);
            GlobalStyles.ApplyButtonStyle(this.updateZboziBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertZboziBtn, true);

            GlobalStyles.ApplyButtonStyle(this.DeleteObjednavkaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.UpdateObjednavkaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertObjednavkaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.FakturaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.objZboziBtn, true);

            GlobalStyles.ApplyButtonStyle(this.DeleteSurovinaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.UpdateSurovinaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertSurovinaBtn, true);

            GlobalStyles.ApplyButtonStyle(this.DeleteZakaznikBtn, true);
            GlobalStyles.ApplyButtonStyle(this.UpdateZakaznikBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertZakaznikBtn, true);

            GlobalStyles.ApplyButtonStyle(this.btnAddProvozovna, true);
            GlobalStyles.ApplyButtonStyle(this.btnDeleteProvozovna, true);
            GlobalStyles.ApplyButtonStyle(this.btnEditProvozovna, true);

            GlobalStyles.ApplyButtonStyle(this.btnDeletePozice, true);
            GlobalStyles.ApplyButtonStyle(this.btnAddPozice, true);
            GlobalStyles.ApplyButtonStyle(this.btnEditPozice, true);

            GlobalStyles.ApplyButtonStyle(this.btnAddZamestnanec, true);
            GlobalStyles.ApplyButtonStyle(this.btnDeleteZamestnanec, true);
            GlobalStyles.ApplyButtonStyle(this.btnEditZamestnanec, true);

            GlobalStyles.ApplyButtonStyle(this.btnAddTyp, true);
            GlobalStyles.ApplyButtonStyle(this.btnEditTypAkce, true);
            GlobalStyles.ApplyButtonStyle(this.btnDeleteTypAkce, true);

            GlobalStyles.ApplyButtonStyle(this.btnAddSklad, true);
            GlobalStyles.ApplyButtonStyle(this.btnDeleteSklad, true);
            GlobalStyles.ApplyButtonStyle(this.btnUpdateSklad, true);

            GlobalStyles.ApplyButtonStyle(this.registerBtn, true);
            GlobalStyles.ApplyButtonStyle(this.loginBtn, true);
        }

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TabPage tabProvozovny;
        private Panel panel6;
        private Label labelProvozovny;
        private ListView lvProvozovny;
        private Button btnDeleteProvozovna;
        private Button btnEditProvozovna;
        private Button btnAddProvozovna;
        private TabPage tabPozice;
        private Label label5;
        private ListView lvPozice;
        private Panel panel7;
        private Button btnDeletePozice;
        private Button btnEditPozice;
        private Button btnAddPozice;
        private Button btnAddZamestnanec;
        private Button btnEditZamestnanec;
        private Button btnDeleteZamestnanec;
        private TabPage tabTypyAkce;
        private ListView lvTypyAkce;
        private Panel panel8;
        private Button btnDeleteTypAkce;
        private Button btnEditTypAkce;
        private Button btnAddTyp;
        private Label label6;
        private TabPage tabSklad;
        private Panel panel9;
        private Label label7;
        private ListView lvSklady;
        private Button btnUpdateSklad;
        private Button btnDeleteSklad;
        private Button btnAddSklad;
        private TabPage tabStats;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtLeastExpensiveOrder;
        private TextBox txtMostExpensiveOrder;
        private TextBox txtPendingOrders;
        private TextBox txtCompletedOrders;
        private TextBox txtTotalPrice;
        private TextBox txtAveragePrice;
        private TextBox txtTotalOrders;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private TextBox txtMostExpensiveCustomer;
        private TextBox txtLeastExpensiveCustomer;
        private Button btnFiltrZbozi;
        private Label label15;
        private ComboBox comboFiltrZbozi;
        private TextBox txtFiltrValueZbozi;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox comboSkladFiltrZbozi;
        private ComboBox comboFiltrTypZbozi;
        private Button btnCancelFiltrZbozi;
        private Label labelRegisteredName;
        private Label labelRegisteredUsername;
        private Button hierarchyBtn;
        private TextBox tbNadrizeni;
        private CheckBox osUdajeCheck;
        private Panel panel10;
        private Label label16;
    }
}
