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
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            fileSystemWatcher1 = new FileSystemWatcher();
            tabObjZbozi = new TabPage();
            label10 = new Label();
            panel14 = new Panel();
            btnCancelFiltrobjZbozi = new Button();
            btnFiltrObjZbozi = new Button();
            txtFiltrValueObjZbozi = new TextBox();
            comboFiltrObjZbozi = new ComboBox();
            label26 = new Label();
            btnObjZboziShowObj = new Button();
            lvObjZbozi = new ListView();
            tabAkce = new TabPage();
            label9 = new Label();
            panel13 = new Panel();
            comboFiltrAkceType = new ComboBox();
            btnCancelFiltrAkce = new Button();
            btnFiltrAkce = new Button();
            txtFiltrValueAkce = new TextBox();
            comboFiltrAkce = new ComboBox();
            label27 = new Label();
            btnAkceShowObjednavka = new Button();
            btnShowCalendar = new Button();
            lvAkce = new ListView();
            tabFaktura = new TabPage();
            label8 = new Label();
            panel12 = new Panel();
            btnFiltrCancelFaktura = new Button();
            btnFiltrFaktura = new Button();
            label29 = new Label();
            txtFiltrFakturaValue = new TextBox();
            label28 = new Label();
            btnSaveFaktura = new Button();
            lvFaktury = new ListView();
            tabAdresa = new TabPage();
            panel11 = new Panel();
            btnCancelFiltrAdresa = new Button();
            btnFiltrAdresa = new Button();
            txtFiltrAdresa = new TextBox();
            comboFiltrAdresa = new ComboBox();
            label21 = new Label();
            btnAdresaUse = new Button();
            btnDeleteAdresa = new Button();
            btnEditAdresa = new Button();
            btnAddAdresa = new Button();
            label17 = new Label();
            lvAdresy = new ListView();
            tabSklad = new TabPage();
            panel9 = new Panel();
            btnCancelFiltrSklad = new Button();
            btnFiltrSklad = new Button();
            txtFiltrValueSklad = new TextBox();
            comboFiltrSklad = new ComboBox();
            label24 = new Label();
            btnMigrateSklad = new Button();
            btnUpdateSklad = new Button();
            btnDeleteSklad = new Button();
            btnAddSklad = new Button();
            label7 = new Label();
            lvSklady = new ListView();
            tabTypyAkce = new TabPage();
            panel8 = new Panel();
            btnDeleteTypAkce = new Button();
            btnEditTypAkce = new Button();
            btnAddTyp = new Button();
            label6 = new Label();
            lvTypyAkce = new ListView();
            tabPozice = new TabPage();
            panel7 = new Panel();
            btnDeletePozice = new Button();
            btnEditPozice = new Button();
            btnAddPozice = new Button();
            label5 = new Label();
            lvPozice = new ListView();
            tabProvozovny = new TabPage();
            panel6 = new Panel();
            btnCancelFiltrProvozovna = new Button();
            btnFiltrProvozovna = new Button();
            txtFiltrValueProvozovna = new TextBox();
            label23 = new Label();
            comboFiltrProvozovna = new ComboBox();
            btnDeleteProvozovna = new Button();
            btnEditProvozovna = new Button();
            btnAddProvozovna = new Button();
            labelProvozovny = new Label();
            lvProvozovny = new ListView();
            tabNadrizeni = new TabPage();
            tbNadrizeni = new TextBox();
            hierarchyBtn = new Button();
            tabZaměstnanci = new TabPage();
            panel5 = new Panel();
            btnCancelFiltrZamestnanec = new Button();
            btnFiltrZamestnanec = new Button();
            textFiltrValueZamestnanec = new TextBox();
            comboFiltrZamestnanec = new ComboBox();
            label20 = new Label();
            PovysitBtn = new Button();
            btnAddZamestnanec = new Button();
            btnEditZamestnanec = new Button();
            btnDeleteZamestnanec = new Button();
            label4 = new Label();
            lvZamestnanci = new ListView();
            tabZakaznici = new TabPage();
            panel4 = new Panel();
            btnCancelFiltrZakaznik = new Button();
            btnFiltrZakaznik = new Button();
            comboFiltrZakaznik = new ComboBox();
            txtFiltrValueZakaznik = new TextBox();
            label19 = new Label();
            btnDiscount = new Button();
            UpdateZakaznikBtn = new Button();
            InsertZakaznikBtn = new Button();
            DeleteZakaznikBtn = new Button();
            lvZakaznici = new ListView();
            label3 = new Label();
            tabSuroviny = new TabPage();
            panel3 = new Panel();
            comboFiltrSurovina = new ComboBox();
            btnFiltrSurovinaCancel = new Button();
            btnFiltrSurovina = new Button();
            comboFiltrSurovinaSklad = new ComboBox();
            label18 = new Label();
            txtFiltrSurovinaCount = new TextBox();
            comboFiltrSurovinaCount = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            txtFiltrSurovinaNazev = new TextBox();
            label12 = new Label();
            KontrolaSurovinBtn = new Button();
            PresunSurovinuBtn = new Button();
            InsertSurovinaBtn = new Button();
            DeleteSurovinaBtn = new Button();
            UpdateSurovinaBtn = new Button();
            label2 = new Label();
            lvSuroviny = new ListView();
            tabObjednávky = new TabPage();
            panel2 = new Panel();
            btnCancelFiltrObjednavka = new Button();
            btnFiltrObjednavka = new Button();
            comboFiltrStatusObjednavka = new ComboBox();
            txtFiltrObjednavkaValue = new TextBox();
            comboFiltrObjednavka = new ComboBox();
            label22 = new Label();
            btnStats = new Button();
            InsertObjednavkaBtn = new Button();
            UpdateObjednavkaBtn = new Button();
            DeleteObjednavkaBtn = new Button();
            labelObj = new Label();
            lvObjednavky = new ListView();
            tabProfil = new TabPage();
            panel10 = new Panel();
            PassChangeBtn = new Button();
            label16 = new Label();
            osUdajeCheck = new CheckBox();
            registerBtn = new Button();
            labelRegisteredUsername = new Label();
            loginBtn = new Button();
            labelRegisteredName = new Label();
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
            tabControl1 = new TabControl();
            tabUsers = new TabPage();
            label11 = new Label();
            panel15 = new Panel();
            btnCancelFiltrUser = new Button();
            btnFilterUser = new Button();
            comboFiltrOsUser = new ComboBox();
            comboFiltrRoleUser = new ComboBox();
            txtFiltrValueUser = new TextBox();
            comboFiltrUser = new ComboBox();
            label25 = new Label();
            emul_button = new Button();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            lvUsers = new ListView();
            tabLogs = new TabPage();
            logLoadBtn = new Button();
            lvLogs = new ListView();
            tabSysCat = new TabPage();
            sysCatBtn = new Button();
            lvSys = new ListView();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            tabObjZbozi.SuspendLayout();
            panel14.SuspendLayout();
            tabAkce.SuspendLayout();
            panel13.SuspendLayout();
            tabFaktura.SuspendLayout();
            panel12.SuspendLayout();
            tabAdresa.SuspendLayout();
            panel11.SuspendLayout();
            tabSklad.SuspendLayout();
            panel9.SuspendLayout();
            tabTypyAkce.SuspendLayout();
            panel8.SuspendLayout();
            tabPozice.SuspendLayout();
            panel7.SuspendLayout();
            tabProvozovny.SuspendLayout();
            panel6.SuspendLayout();
            tabNadrizeni.SuspendLayout();
            tabZaměstnanci.SuspendLayout();
            panel5.SuspendLayout();
            tabZakaznici.SuspendLayout();
            panel4.SuspendLayout();
            tabSuroviny.SuspendLayout();
            panel3.SuspendLayout();
            tabObjednávky.SuspendLayout();
            panel2.SuspendLayout();
            tabProfil.SuspendLayout();
            panel10.SuspendLayout();
            tabZbozi.SuspendLayout();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabUsers.SuspendLayout();
            panel15.SuspendLayout();
            tabLogs.SuspendLayout();
            tabSysCat.SuspendLayout();
            SuspendLayout();
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
            // tabObjZbozi
            // 
            tabObjZbozi.BackColor = Color.LightGray;
            tabObjZbozi.Controls.Add(label10);
            tabObjZbozi.Controls.Add(panel14);
            tabObjZbozi.Controls.Add(lvObjZbozi);
            tabObjZbozi.Location = new Point(4, 24);
            tabObjZbozi.Name = "tabObjZbozi";
            tabObjZbozi.Padding = new Padding(3);
            tabObjZbozi.Size = new Size(1288, 757);
            tabObjZbozi.TabIndex = 15;
            tabObjZbozi.Text = "Objednené zboží";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(18, 19);
            label10.Name = "label10";
            label10.Size = new Size(126, 21);
            label10.TabIndex = 2;
            label10.Text = "Objednané zboží";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Silver;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(btnCancelFiltrobjZbozi);
            panel14.Controls.Add(btnFiltrObjZbozi);
            panel14.Controls.Add(txtFiltrValueObjZbozi);
            panel14.Controls.Add(comboFiltrObjZbozi);
            panel14.Controls.Add(label26);
            panel14.Controls.Add(btnObjZboziShowObj);
            panel14.Location = new Point(902, 55);
            panel14.Name = "panel14";
            panel14.Size = new Size(380, 607);
            panel14.TabIndex = 1;
            // 
            // btnCancelFiltrobjZbozi
            // 
            btnCancelFiltrobjZbozi.Location = new Point(107, 271);
            btnCancelFiltrobjZbozi.Name = "btnCancelFiltrobjZbozi";
            btnCancelFiltrobjZbozi.Size = new Size(186, 23);
            btnCancelFiltrobjZbozi.TabIndex = 5;
            btnCancelFiltrobjZbozi.Text = "Zrušit filtr";
            btnCancelFiltrobjZbozi.UseVisualStyleBackColor = true;
            btnCancelFiltrobjZbozi.Click += btnCancelFiltrobjZbozi_Click;
            // 
            // btnFiltrObjZbozi
            // 
            btnFiltrObjZbozi.Location = new Point(107, 242);
            btnFiltrObjZbozi.Name = "btnFiltrObjZbozi";
            btnFiltrObjZbozi.Size = new Size(186, 23);
            btnFiltrObjZbozi.TabIndex = 4;
            btnFiltrObjZbozi.Text = "Filtrovat";
            btnFiltrObjZbozi.UseVisualStyleBackColor = true;
            btnFiltrObjZbozi.Click += btnFiltrObjZbozi_Click;
            // 
            // txtFiltrValueObjZbozi
            // 
            txtFiltrValueObjZbozi.Location = new Point(107, 213);
            txtFiltrValueObjZbozi.Name = "txtFiltrValueObjZbozi";
            txtFiltrValueObjZbozi.Size = new Size(186, 23);
            txtFiltrValueObjZbozi.TabIndex = 3;
            // 
            // comboFiltrObjZbozi
            // 
            comboFiltrObjZbozi.FormattingEnabled = true;
            comboFiltrObjZbozi.Location = new Point(107, 184);
            comboFiltrObjZbozi.Name = "comboFiltrObjZbozi";
            comboFiltrObjZbozi.Size = new Size(186, 23);
            comboFiltrObjZbozi.TabIndex = 2;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 16F);
            label26.Location = new Point(167, 151);
            label26.Name = "label26";
            label26.Size = new Size(49, 30);
            label26.TabIndex = 1;
            label26.Text = "Filtr";
            // 
            // btnObjZboziShowObj
            // 
            btnObjZboziShowObj.Location = new Point(3, 3);
            btnObjZboziShowObj.Name = "btnObjZboziShowObj";
            btnObjZboziShowObj.Size = new Size(188, 23);
            btnObjZboziShowObj.TabIndex = 0;
            btnObjZboziShowObj.Text = "Zobrazit objednávku";
            btnObjZboziShowObj.UseVisualStyleBackColor = true;
            btnObjZboziShowObj.Click += btnObjZboziShowObj_Click;
            // 
            // lvObjZbozi
            // 
            lvObjZbozi.Location = new Point(18, 55);
            lvObjZbozi.Name = "lvObjZbozi";
            lvObjZbozi.Size = new Size(878, 607);
            lvObjZbozi.TabIndex = 0;
            lvObjZbozi.UseCompatibleStateImageBehavior = false;
            // 
            // tabAkce
            // 
            tabAkce.BackColor = Color.LightGray;
            tabAkce.Controls.Add(label9);
            tabAkce.Controls.Add(panel13);
            tabAkce.Controls.Add(lvAkce);
            tabAkce.Location = new Point(4, 24);
            tabAkce.Name = "tabAkce";
            tabAkce.Padding = new Padding(3);
            tabAkce.Size = new Size(1288, 757);
            tabAkce.TabIndex = 14;
            tabAkce.Text = "Akce";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(18, 19);
            label9.Name = "label9";
            label9.Size = new Size(43, 21);
            label9.TabIndex = 2;
            label9.Text = "Akce";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Silver;
            panel13.Controls.Add(comboFiltrAkceType);
            panel13.Controls.Add(btnCancelFiltrAkce);
            panel13.Controls.Add(btnFiltrAkce);
            panel13.Controls.Add(txtFiltrValueAkce);
            panel13.Controls.Add(comboFiltrAkce);
            panel13.Controls.Add(label27);
            panel13.Controls.Add(btnAkceShowObjednavka);
            panel13.Controls.Add(btnShowCalendar);
            panel13.Location = new Point(902, 55);
            panel13.Name = "panel13";
            panel13.Size = new Size(380, 607);
            panel13.TabIndex = 1;
            // 
            // comboFiltrAkceType
            // 
            comboFiltrAkceType.FormattingEnabled = true;
            comboFiltrAkceType.Location = new Point(107, 204);
            comboFiltrAkceType.Name = "comboFiltrAkceType";
            comboFiltrAkceType.Size = new Size(186, 23);
            comboFiltrAkceType.TabIndex = 9;
            // 
            // btnCancelFiltrAkce
            // 
            btnCancelFiltrAkce.Location = new Point(107, 291);
            btnCancelFiltrAkce.Name = "btnCancelFiltrAkce";
            btnCancelFiltrAkce.Size = new Size(186, 23);
            btnCancelFiltrAkce.TabIndex = 8;
            btnCancelFiltrAkce.Text = "Zrušit filtr";
            btnCancelFiltrAkce.UseVisualStyleBackColor = true;
            btnCancelFiltrAkce.Click += btnCancelFiltrAkce_Click;
            // 
            // btnFiltrAkce
            // 
            btnFiltrAkce.Location = new Point(107, 262);
            btnFiltrAkce.Name = "btnFiltrAkce";
            btnFiltrAkce.Size = new Size(186, 23);
            btnFiltrAkce.TabIndex = 7;
            btnFiltrAkce.Text = "Filtrovat";
            btnFiltrAkce.UseVisualStyleBackColor = true;
            btnFiltrAkce.Click += btnFiltrAkce_Click;
            // 
            // txtFiltrValueAkce
            // 
            txtFiltrValueAkce.Location = new Point(107, 233);
            txtFiltrValueAkce.Name = "txtFiltrValueAkce";
            txtFiltrValueAkce.Size = new Size(186, 23);
            txtFiltrValueAkce.TabIndex = 6;
            // 
            // comboFiltrAkce
            // 
            comboFiltrAkce.FormattingEnabled = true;
            comboFiltrAkce.Location = new Point(107, 175);
            comboFiltrAkce.Name = "comboFiltrAkce";
            comboFiltrAkce.Size = new Size(186, 23);
            comboFiltrAkce.TabIndex = 5;
            comboFiltrAkce.SelectedIndexChanged += comboFiltrAkce_SelectedIndexChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 16F);
            label27.Location = new Point(171, 142);
            label27.Name = "label27";
            label27.Size = new Size(49, 30);
            label27.TabIndex = 4;
            label27.Text = "Filtr";
            // 
            // btnAkceShowObjednavka
            // 
            btnAkceShowObjednavka.Location = new Point(5, 55);
            btnAkceShowObjednavka.Name = "btnAkceShowObjednavka";
            btnAkceShowObjednavka.Size = new Size(254, 23);
            btnAkceShowObjednavka.TabIndex = 3;
            btnAkceShowObjednavka.Text = "Zobrazit objednávku";
            btnAkceShowObjednavka.UseVisualStyleBackColor = true;
            btnAkceShowObjednavka.Click += btnAkceShowObjednavka_Click;
            // 
            // btnShowCalendar
            // 
            btnShowCalendar.Location = new Point(5, 5);
            btnShowCalendar.Name = "btnShowCalendar";
            btnShowCalendar.Size = new Size(254, 23);
            btnShowCalendar.TabIndex = 2;
            btnShowCalendar.Text = "Zobrazit kalendář";
            btnShowCalendar.UseVisualStyleBackColor = true;
            btnShowCalendar.Click += btnShowCalendar_Click;
            // 
            // lvAkce
            // 
            lvAkce.Location = new Point(18, 55);
            lvAkce.Name = "lvAkce";
            lvAkce.Size = new Size(878, 607);
            lvAkce.TabIndex = 0;
            lvAkce.UseCompatibleStateImageBehavior = false;
            // 
            // tabFaktura
            // 
            tabFaktura.BackColor = Color.Gainsboro;
            tabFaktura.Controls.Add(label8);
            tabFaktura.Controls.Add(panel12);
            tabFaktura.Controls.Add(lvFaktury);
            tabFaktura.Location = new Point(4, 24);
            tabFaktura.Name = "tabFaktura";
            tabFaktura.Padding = new Padding(3);
            tabFaktura.Size = new Size(1288, 757);
            tabFaktura.TabIndex = 13;
            tabFaktura.Text = "Faktury";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(18, 19);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 2;
            label8.Text = "Faktury";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Silver;
            panel12.Controls.Add(btnFiltrCancelFaktura);
            panel12.Controls.Add(btnFiltrFaktura);
            panel12.Controls.Add(label29);
            panel12.Controls.Add(txtFiltrFakturaValue);
            panel12.Controls.Add(label28);
            panel12.Controls.Add(btnSaveFaktura);
            panel12.Location = new Point(902, 55);
            panel12.Name = "panel12";
            panel12.Size = new Size(380, 607);
            panel12.TabIndex = 1;
            // 
            // btnFiltrCancelFaktura
            // 
            btnFiltrCancelFaktura.Location = new Point(109, 169);
            btnFiltrCancelFaktura.Name = "btnFiltrCancelFaktura";
            btnFiltrCancelFaktura.Size = new Size(186, 23);
            btnFiltrCancelFaktura.TabIndex = 5;
            btnFiltrCancelFaktura.Text = "Zrušit filtr";
            btnFiltrCancelFaktura.UseVisualStyleBackColor = true;
            btnFiltrCancelFaktura.Click += btnFiltrCancelFaktura_Click;
            // 
            // btnFiltrFaktura
            // 
            btnFiltrFaktura.Location = new Point(109, 140);
            btnFiltrFaktura.Name = "btnFiltrFaktura";
            btnFiltrFaktura.Size = new Size(186, 23);
            btnFiltrFaktura.TabIndex = 4;
            btnFiltrFaktura.Text = "Filtrovat";
            btnFiltrFaktura.UseVisualStyleBackColor = true;
            btnFiltrFaktura.Click += btnFiltrFaktura_Click;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(59, 114);
            label29.Name = "label29";
            label29.Size = new Size(42, 15);
            label29.TabIndex = 3;
            label29.Text = "Název:";
            label29.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFiltrFakturaValue
            // 
            txtFiltrFakturaValue.Location = new Point(109, 111);
            txtFiltrFakturaValue.Name = "txtFiltrFakturaValue";
            txtFiltrFakturaValue.Size = new Size(186, 23);
            txtFiltrFakturaValue.TabIndex = 2;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 16F);
            label28.Location = new Point(161, 78);
            label28.Name = "label28";
            label28.Size = new Size(49, 30);
            label28.TabIndex = 1;
            label28.Text = "Filtr";
            // 
            // btnSaveFaktura
            // 
            btnSaveFaktura.Location = new Point(5, 5);
            btnSaveFaktura.Name = "btnSaveFaktura";
            btnSaveFaktura.Size = new Size(190, 23);
            btnSaveFaktura.TabIndex = 0;
            btnSaveFaktura.Text = "Stáhnout fakturu";
            btnSaveFaktura.UseVisualStyleBackColor = true;
            btnSaveFaktura.Click += btnSaveFaktura_Click;
            // 
            // lvFaktury
            // 
            lvFaktury.Location = new Point(18, 55);
            lvFaktury.Name = "lvFaktury";
            lvFaktury.Size = new Size(878, 607);
            lvFaktury.TabIndex = 0;
            lvFaktury.UseCompatibleStateImageBehavior = false;
            // 
            // tabAdresa
            // 
            tabAdresa.BackColor = Color.Gainsboro;
            tabAdresa.Controls.Add(panel11);
            tabAdresa.Controls.Add(label17);
            tabAdresa.Controls.Add(lvAdresy);
            tabAdresa.Location = new Point(4, 24);
            tabAdresa.Name = "tabAdresa";
            tabAdresa.Padding = new Padding(3);
            tabAdresa.Size = new Size(1288, 757);
            tabAdresa.TabIndex = 12;
            tabAdresa.Text = "Adresy";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Silver;
            panel11.Controls.Add(btnCancelFiltrAdresa);
            panel11.Controls.Add(btnFiltrAdresa);
            panel11.Controls.Add(txtFiltrAdresa);
            panel11.Controls.Add(comboFiltrAdresa);
            panel11.Controls.Add(label21);
            panel11.Controls.Add(btnAdresaUse);
            panel11.Controls.Add(btnDeleteAdresa);
            panel11.Controls.Add(btnEditAdresa);
            panel11.Controls.Add(btnAddAdresa);
            panel11.Location = new Point(902, 55);
            panel11.Name = "panel11";
            panel11.Size = new Size(380, 607);
            panel11.TabIndex = 2;
            // 
            // btnCancelFiltrAdresa
            // 
            btnCancelFiltrAdresa.Location = new Point(103, 374);
            btnCancelFiltrAdresa.Name = "btnCancelFiltrAdresa";
            btnCancelFiltrAdresa.Size = new Size(186, 23);
            btnCancelFiltrAdresa.TabIndex = 8;
            btnCancelFiltrAdresa.Text = "Zrušit filtr";
            btnCancelFiltrAdresa.UseVisualStyleBackColor = true;
            btnCancelFiltrAdresa.Click += btnCancelFiltrAdresa_Click;
            // 
            // btnFiltrAdresa
            // 
            btnFiltrAdresa.Location = new Point(103, 345);
            btnFiltrAdresa.Name = "btnFiltrAdresa";
            btnFiltrAdresa.Size = new Size(186, 23);
            btnFiltrAdresa.TabIndex = 7;
            btnFiltrAdresa.Text = "Filtrovat";
            btnFiltrAdresa.UseVisualStyleBackColor = true;
            btnFiltrAdresa.Click += btnFiltrAdresa_Click;
            // 
            // txtFiltrAdresa
            // 
            txtFiltrAdresa.Location = new Point(103, 316);
            txtFiltrAdresa.Name = "txtFiltrAdresa";
            txtFiltrAdresa.Size = new Size(186, 23);
            txtFiltrAdresa.TabIndex = 6;
            // 
            // comboFiltrAdresa
            // 
            comboFiltrAdresa.FormattingEnabled = true;
            comboFiltrAdresa.Location = new Point(103, 287);
            comboFiltrAdresa.Name = "comboFiltrAdresa";
            comboFiltrAdresa.Size = new Size(186, 23);
            comboFiltrAdresa.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16F);
            label21.Location = new Point(166, 254);
            label21.Name = "label21";
            label21.Size = new Size(49, 30);
            label21.TabIndex = 4;
            label21.Text = "Filtr";
            // 
            // btnAdresaUse
            // 
            btnAdresaUse.Location = new Point(5, 155);
            btnAdresaUse.Name = "btnAdresaUse";
            btnAdresaUse.Size = new Size(186, 23);
            btnAdresaUse.TabIndex = 3;
            btnAdresaUse.Text = "Použití adresy";
            btnAdresaUse.UseVisualStyleBackColor = true;
            btnAdresaUse.Click += btnAdresaUse_Click;
            // 
            // btnDeleteAdresa
            // 
            btnDeleteAdresa.Location = new Point(5, 105);
            btnDeleteAdresa.Name = "btnDeleteAdresa";
            btnDeleteAdresa.Size = new Size(186, 23);
            btnDeleteAdresa.TabIndex = 2;
            btnDeleteAdresa.Text = "Odstranit adresu";
            btnDeleteAdresa.UseVisualStyleBackColor = true;
            btnDeleteAdresa.Click += btnDeleteAdresa_Click;
            // 
            // btnEditAdresa
            // 
            btnEditAdresa.Location = new Point(5, 55);
            btnEditAdresa.Name = "btnEditAdresa";
            btnEditAdresa.Size = new Size(186, 23);
            btnEditAdresa.TabIndex = 1;
            btnEditAdresa.Text = "Upravit adresu";
            btnEditAdresa.UseVisualStyleBackColor = true;
            btnEditAdresa.Click += btnEditAdresa_Click;
            // 
            // btnAddAdresa
            // 
            btnAddAdresa.Location = new Point(5, 5);
            btnAddAdresa.Name = "btnAddAdresa";
            btnAddAdresa.Size = new Size(186, 23);
            btnAddAdresa.TabIndex = 0;
            btnAddAdresa.Text = "Vložit adresu";
            btnAddAdresa.UseVisualStyleBackColor = true;
            btnAddAdresa.Click += btnAddAdresa_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(18, 19);
            label17.Name = "label17";
            label17.Size = new Size(58, 21);
            label17.TabIndex = 1;
            label17.Text = "Adresy";
            // 
            // lvAdresy
            // 
            lvAdresy.Location = new Point(18, 55);
            lvAdresy.Name = "lvAdresy";
            lvAdresy.Size = new Size(878, 607);
            lvAdresy.TabIndex = 0;
            lvAdresy.UseCompatibleStateImageBehavior = false;
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
            panel9.Controls.Add(btnCancelFiltrSklad);
            panel9.Controls.Add(btnFiltrSklad);
            panel9.Controls.Add(txtFiltrValueSklad);
            panel9.Controls.Add(comboFiltrSklad);
            panel9.Controls.Add(label24);
            panel9.Controls.Add(btnMigrateSklad);
            panel9.Controls.Add(btnUpdateSklad);
            panel9.Controls.Add(btnDeleteSklad);
            panel9.Controls.Add(btnAddSklad);
            panel9.Location = new Point(902, 55);
            panel9.Name = "panel9";
            panel9.Size = new Size(380, 607);
            panel9.TabIndex = 2;
            // 
            // btnCancelFiltrSklad
            // 
            btnCancelFiltrSklad.Location = new Point(102, 383);
            btnCancelFiltrSklad.Name = "btnCancelFiltrSklad";
            btnCancelFiltrSklad.Size = new Size(186, 23);
            btnCancelFiltrSklad.TabIndex = 8;
            btnCancelFiltrSklad.Text = "Zrušit filtr";
            btnCancelFiltrSklad.UseVisualStyleBackColor = true;
            btnCancelFiltrSklad.Click += btnCancelFiltrSklad_Click;
            // 
            // btnFiltrSklad
            // 
            btnFiltrSklad.Location = new Point(102, 354);
            btnFiltrSklad.Name = "btnFiltrSklad";
            btnFiltrSklad.Size = new Size(186, 23);
            btnFiltrSklad.TabIndex = 7;
            btnFiltrSklad.Text = "Filtrovat";
            btnFiltrSklad.UseVisualStyleBackColor = true;
            btnFiltrSklad.Click += btnFiltrSklad_Click;
            // 
            // txtFiltrValueSklad
            // 
            txtFiltrValueSklad.Location = new Point(102, 325);
            txtFiltrValueSklad.Name = "txtFiltrValueSklad";
            txtFiltrValueSklad.Size = new Size(186, 23);
            txtFiltrValueSklad.TabIndex = 6;
            // 
            // comboFiltrSklad
            // 
            comboFiltrSklad.FormattingEnabled = true;
            comboFiltrSklad.Location = new Point(102, 296);
            comboFiltrSklad.Name = "comboFiltrSklad";
            comboFiltrSklad.Size = new Size(186, 23);
            comboFiltrSklad.TabIndex = 5;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 16F);
            label24.Location = new Point(165, 262);
            label24.Name = "label24";
            label24.Size = new Size(49, 30);
            label24.TabIndex = 4;
            label24.Text = "Filtr";
            // 
            // btnMigrateSklad
            // 
            btnMigrateSklad.Location = new Point(5, 155);
            btnMigrateSklad.Name = "btnMigrateSklad";
            btnMigrateSklad.Size = new Size(204, 23);
            btnMigrateSklad.TabIndex = 3;
            btnMigrateSklad.Text = "Migrovat sklad";
            btnMigrateSklad.UseVisualStyleBackColor = true;
            btnMigrateSklad.Click += btnMigrateSklad_Click;
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
            panel6.Controls.Add(btnCancelFiltrProvozovna);
            panel6.Controls.Add(btnFiltrProvozovna);
            panel6.Controls.Add(txtFiltrValueProvozovna);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(comboFiltrProvozovna);
            panel6.Controls.Add(btnDeleteProvozovna);
            panel6.Controls.Add(btnEditProvozovna);
            panel6.Controls.Add(btnAddProvozovna);
            panel6.Location = new Point(902, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(380, 607);
            panel6.TabIndex = 2;
            // 
            // btnCancelFiltrProvozovna
            // 
            btnCancelFiltrProvozovna.Location = new Point(98, 313);
            btnCancelFiltrProvozovna.Name = "btnCancelFiltrProvozovna";
            btnCancelFiltrProvozovna.Size = new Size(186, 23);
            btnCancelFiltrProvozovna.TabIndex = 7;
            btnCancelFiltrProvozovna.Text = "Zrušit filtr";
            btnCancelFiltrProvozovna.UseVisualStyleBackColor = true;
            btnCancelFiltrProvozovna.Click += btnCancelFiltrProvozovna_Click;
            // 
            // btnFiltrProvozovna
            // 
            btnFiltrProvozovna.Location = new Point(98, 284);
            btnFiltrProvozovna.Name = "btnFiltrProvozovna";
            btnFiltrProvozovna.Size = new Size(186, 23);
            btnFiltrProvozovna.TabIndex = 6;
            btnFiltrProvozovna.Text = "Filtrovat";
            btnFiltrProvozovna.UseVisualStyleBackColor = true;
            btnFiltrProvozovna.Click += btnFiltrProvozovna_Click;
            // 
            // txtFiltrValueProvozovna
            // 
            txtFiltrValueProvozovna.Location = new Point(98, 255);
            txtFiltrValueProvozovna.Name = "txtFiltrValueProvozovna";
            txtFiltrValueProvozovna.Size = new Size(186, 23);
            txtFiltrValueProvozovna.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 16F);
            label23.Location = new Point(168, 193);
            label23.Name = "label23";
            label23.Size = new Size(49, 30);
            label23.TabIndex = 4;
            label23.Text = "Filtr";
            // 
            // comboFiltrProvozovna
            // 
            comboFiltrProvozovna.FormattingEnabled = true;
            comboFiltrProvozovna.Location = new Point(98, 226);
            comboFiltrProvozovna.Name = "comboFiltrProvozovna";
            comboFiltrProvozovna.Size = new Size(186, 23);
            comboFiltrProvozovna.TabIndex = 3;
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
            panel5.Controls.Add(btnCancelFiltrZamestnanec);
            panel5.Controls.Add(btnFiltrZamestnanec);
            panel5.Controls.Add(textFiltrValueZamestnanec);
            panel5.Controls.Add(comboFiltrZamestnanec);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(PovysitBtn);
            panel5.Controls.Add(btnAddZamestnanec);
            panel5.Controls.Add(btnEditZamestnanec);
            panel5.Controls.Add(btnDeleteZamestnanec);
            panel5.Location = new Point(902, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 607);
            panel5.TabIndex = 2;
            // 
            // btnCancelFiltrZamestnanec
            // 
            btnCancelFiltrZamestnanec.Location = new Point(97, 337);
            btnCancelFiltrZamestnanec.Name = "btnCancelFiltrZamestnanec";
            btnCancelFiltrZamestnanec.Size = new Size(186, 23);
            btnCancelFiltrZamestnanec.TabIndex = 8;
            btnCancelFiltrZamestnanec.Text = "Zrušit filtr";
            btnCancelFiltrZamestnanec.UseVisualStyleBackColor = true;
            btnCancelFiltrZamestnanec.Click += btnCancelFiltrZamestnanec_Click;
            // 
            // btnFiltrZamestnanec
            // 
            btnFiltrZamestnanec.Location = new Point(97, 308);
            btnFiltrZamestnanec.Name = "btnFiltrZamestnanec";
            btnFiltrZamestnanec.Size = new Size(186, 23);
            btnFiltrZamestnanec.TabIndex = 7;
            btnFiltrZamestnanec.Text = "Filtrovat";
            btnFiltrZamestnanec.UseVisualStyleBackColor = true;
            btnFiltrZamestnanec.Click += btnFiltrZamestnanec_Click;
            // 
            // textFiltrValueZamestnanec
            // 
            textFiltrValueZamestnanec.Location = new Point(97, 279);
            textFiltrValueZamestnanec.Name = "textFiltrValueZamestnanec";
            textFiltrValueZamestnanec.Size = new Size(186, 23);
            textFiltrValueZamestnanec.TabIndex = 6;
            // 
            // comboFiltrZamestnanec
            // 
            comboFiltrZamestnanec.FormattingEnabled = true;
            comboFiltrZamestnanec.Location = new Point(97, 250);
            comboFiltrZamestnanec.Name = "comboFiltrZamestnanec";
            comboFiltrZamestnanec.Size = new Size(186, 23);
            comboFiltrZamestnanec.TabIndex = 5;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 16F);
            label20.Location = new Point(156, 215);
            label20.Name = "label20";
            label20.Size = new Size(49, 30);
            label20.TabIndex = 4;
            label20.Text = "Filtr";
            // 
            // PovysitBtn
            // 
            PovysitBtn.Location = new Point(5, 155);
            PovysitBtn.Name = "PovysitBtn";
            PovysitBtn.Size = new Size(225, 23);
            PovysitBtn.TabIndex = 3;
            PovysitBtn.Text = "Povýšit zaměstnance";
            PovysitBtn.UseVisualStyleBackColor = true;
            PovysitBtn.Click += PovysitBtn_Click;
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
            panel4.Controls.Add(btnCancelFiltrZakaznik);
            panel4.Controls.Add(btnFiltrZakaznik);
            panel4.Controls.Add(comboFiltrZakaznik);
            panel4.Controls.Add(txtFiltrValueZakaznik);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(btnDiscount);
            panel4.Controls.Add(UpdateZakaznikBtn);
            panel4.Controls.Add(InsertZakaznikBtn);
            panel4.Controls.Add(DeleteZakaznikBtn);
            panel4.Location = new Point(902, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 607);
            panel4.TabIndex = 5;
            // 
            // btnCancelFiltrZakaznik
            // 
            btnCancelFiltrZakaznik.Location = new Point(94, 376);
            btnCancelFiltrZakaznik.Name = "btnCancelFiltrZakaznik";
            btnCancelFiltrZakaznik.Size = new Size(186, 23);
            btnCancelFiltrZakaznik.TabIndex = 10;
            btnCancelFiltrZakaznik.Text = "Zrušit filtr";
            btnCancelFiltrZakaznik.UseVisualStyleBackColor = true;
            btnCancelFiltrZakaznik.Click += btnCancelFiltrZakaznik_Click;
            // 
            // btnFiltrZakaznik
            // 
            btnFiltrZakaznik.Location = new Point(94, 347);
            btnFiltrZakaznik.Name = "btnFiltrZakaznik";
            btnFiltrZakaznik.Size = new Size(186, 23);
            btnFiltrZakaznik.TabIndex = 9;
            btnFiltrZakaznik.Text = "Filtrovat";
            btnFiltrZakaznik.UseVisualStyleBackColor = true;
            btnFiltrZakaznik.Click += btnFiltrZakaznik_Click;
            // 
            // comboFiltrZakaznik
            // 
            comboFiltrZakaznik.FormattingEnabled = true;
            comboFiltrZakaznik.Location = new Point(94, 289);
            comboFiltrZakaznik.Name = "comboFiltrZakaznik";
            comboFiltrZakaznik.Size = new Size(186, 23);
            comboFiltrZakaznik.TabIndex = 8;
            // 
            // txtFiltrValueZakaznik
            // 
            txtFiltrValueZakaznik.Location = new Point(94, 318);
            txtFiltrValueZakaznik.Name = "txtFiltrValueZakaznik";
            txtFiltrValueZakaznik.Size = new Size(186, 23);
            txtFiltrValueZakaznik.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16F);
            label19.Location = new Point(162, 256);
            label19.Name = "label19";
            label19.Size = new Size(49, 30);
            label19.TabIndex = 6;
            label19.Text = "Filtr";
            // 
            // btnDiscount
            // 
            btnDiscount.Location = new Point(5, 155);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(227, 23);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Nastavit cenovou hladinu";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
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
            panel3.Controls.Add(comboFiltrSurovina);
            panel3.Controls.Add(btnFiltrSurovinaCancel);
            panel3.Controls.Add(btnFiltrSurovina);
            panel3.Controls.Add(comboFiltrSurovinaSklad);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(txtFiltrSurovinaCount);
            panel3.Controls.Add(comboFiltrSurovinaCount);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtFiltrSurovinaNazev);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(KontrolaSurovinBtn);
            panel3.Controls.Add(PresunSurovinuBtn);
            panel3.Controls.Add(InsertSurovinaBtn);
            panel3.Controls.Add(DeleteSurovinaBtn);
            panel3.Controls.Add(UpdateSurovinaBtn);
            panel3.Location = new Point(902, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 607);
            panel3.TabIndex = 5;
            // 
            // comboFiltrSurovina
            // 
            comboFiltrSurovina.FormattingEnabled = true;
            comboFiltrSurovina.Location = new Point(105, 292);
            comboFiltrSurovina.Name = "comboFiltrSurovina";
            comboFiltrSurovina.Size = new Size(145, 23);
            comboFiltrSurovina.TabIndex = 17;
            comboFiltrSurovina.SelectedIndexChanged += comboFiltrSurovina_SelectedIndexChanged;
            // 
            // btnFiltrSurovinaCancel
            // 
            btnFiltrSurovinaCancel.Location = new Point(105, 441);
            btnFiltrSurovinaCancel.Name = "btnFiltrSurovinaCancel";
            btnFiltrSurovinaCancel.Size = new Size(145, 23);
            btnFiltrSurovinaCancel.TabIndex = 16;
            btnFiltrSurovinaCancel.Text = "Zrušit filtr";
            btnFiltrSurovinaCancel.UseVisualStyleBackColor = true;
            btnFiltrSurovinaCancel.Click += btnFiltrSurovinaCancel_Click;
            // 
            // btnFiltrSurovina
            // 
            btnFiltrSurovina.Location = new Point(105, 412);
            btnFiltrSurovina.Name = "btnFiltrSurovina";
            btnFiltrSurovina.Size = new Size(145, 23);
            btnFiltrSurovina.TabIndex = 15;
            btnFiltrSurovina.Text = "Filtrovat";
            btnFiltrSurovina.UseVisualStyleBackColor = true;
            btnFiltrSurovina.Click += btnFiltrSurovina_Click;
            // 
            // comboFiltrSurovinaSklad
            // 
            comboFiltrSurovinaSklad.FormattingEnabled = true;
            comboFiltrSurovinaSklad.Location = new Point(105, 383);
            comboFiltrSurovinaSklad.Name = "comboFiltrSurovinaSklad";
            comboFiltrSurovinaSklad.Size = new Size(121, 23);
            comboFiltrSurovinaSklad.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(53, 386);
            label18.Name = "label18";
            label18.Size = new Size(38, 15);
            label18.TabIndex = 13;
            label18.Text = "Sklad:";
            // 
            // txtFiltrSurovinaCount
            // 
            txtFiltrSurovinaCount.Location = new Point(178, 352);
            txtFiltrSurovinaCount.Name = "txtFiltrSurovinaCount";
            txtFiltrSurovinaCount.Size = new Size(109, 23);
            txtFiltrSurovinaCount.TabIndex = 12;
            // 
            // comboFiltrSurovinaCount
            // 
            comboFiltrSurovinaCount.FormattingEnabled = true;
            comboFiltrSurovinaCount.Location = new Point(105, 352);
            comboFiltrSurovinaCount.Name = "comboFiltrSurovinaCount";
            comboFiltrSurovinaCount.Size = new Size(67, 23);
            comboFiltrSurovinaCount.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(39, 355);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 10;
            label14.Text = "Množství:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(55, 322);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 9;
            label13.Text = "Název:";
            // 
            // txtFiltrSurovinaNazev
            // 
            txtFiltrSurovinaNazev.Location = new Point(105, 319);
            txtFiltrSurovinaNazev.Name = "txtFiltrSurovinaNazev";
            txtFiltrSurovinaNazev.Size = new Size(145, 23);
            txtFiltrSurovinaNazev.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F);
            label12.Location = new Point(151, 259);
            label12.Name = "label12";
            label12.Size = new Size(49, 30);
            label12.TabIndex = 7;
            label12.Text = "Filtr";
            // 
            // KontrolaSurovinBtn
            // 
            KontrolaSurovinBtn.Location = new Point(5, 219);
            KontrolaSurovinBtn.Name = "KontrolaSurovinBtn";
            KontrolaSurovinBtn.Size = new Size(227, 23);
            KontrolaSurovinBtn.TabIndex = 6;
            KontrolaSurovinBtn.Text = "Zkontrolovat suroviny";
            KontrolaSurovinBtn.UseVisualStyleBackColor = true;
            KontrolaSurovinBtn.Click += KontrolaSurovinBtn_Click;
            // 
            // PresunSurovinuBtn
            // 
            PresunSurovinuBtn.Location = new Point(5, 163);
            PresunSurovinuBtn.Name = "PresunSurovinuBtn";
            PresunSurovinuBtn.Size = new Size(227, 23);
            PresunSurovinuBtn.TabIndex = 5;
            PresunSurovinuBtn.Text = "Přesunout Surovinu";
            PresunSurovinuBtn.UseVisualStyleBackColor = true;
            PresunSurovinuBtn.Click += PresunSurovinuBtn_Click;
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
            panel2.Controls.Add(btnCancelFiltrObjednavka);
            panel2.Controls.Add(btnFiltrObjednavka);
            panel2.Controls.Add(comboFiltrStatusObjednavka);
            panel2.Controls.Add(txtFiltrObjednavkaValue);
            panel2.Controls.Add(comboFiltrObjednavka);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(btnStats);
            panel2.Controls.Add(InsertObjednavkaBtn);
            panel2.Controls.Add(UpdateObjednavkaBtn);
            panel2.Controls.Add(DeleteObjednavkaBtn);
            panel2.Location = new Point(902, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 607);
            panel2.TabIndex = 7;
            // 
            // btnCancelFiltrObjednavka
            // 
            btnCancelFiltrObjednavka.Location = new Point(103, 406);
            btnCancelFiltrObjednavka.Name = "btnCancelFiltrObjednavka";
            btnCancelFiltrObjednavka.Size = new Size(186, 23);
            btnCancelFiltrObjednavka.TabIndex = 13;
            btnCancelFiltrObjednavka.Text = "Zrušit filtr";
            btnCancelFiltrObjednavka.UseVisualStyleBackColor = true;
            btnCancelFiltrObjednavka.Click += btnCancelFiltrObjednavka_Click;
            // 
            // btnFiltrObjednavka
            // 
            btnFiltrObjednavka.Location = new Point(103, 377);
            btnFiltrObjednavka.Name = "btnFiltrObjednavka";
            btnFiltrObjednavka.Size = new Size(186, 23);
            btnFiltrObjednavka.TabIndex = 12;
            btnFiltrObjednavka.Text = "Filtrovat";
            btnFiltrObjednavka.UseVisualStyleBackColor = true;
            btnFiltrObjednavka.Click += btnFiltrObjednavka_Click;
            // 
            // comboFiltrStatusObjednavka
            // 
            comboFiltrStatusObjednavka.FormattingEnabled = true;
            comboFiltrStatusObjednavka.Location = new Point(103, 348);
            comboFiltrStatusObjednavka.Name = "comboFiltrStatusObjednavka";
            comboFiltrStatusObjednavka.Size = new Size(186, 23);
            comboFiltrStatusObjednavka.TabIndex = 11;
            // 
            // txtFiltrObjednavkaValue
            // 
            txtFiltrObjednavkaValue.Location = new Point(103, 319);
            txtFiltrObjednavkaValue.Name = "txtFiltrObjednavkaValue";
            txtFiltrObjednavkaValue.Size = new Size(186, 23);
            txtFiltrObjednavkaValue.TabIndex = 10;
            // 
            // comboFiltrObjednavka
            // 
            comboFiltrObjednavka.FormattingEnabled = true;
            comboFiltrObjednavka.Location = new Point(103, 290);
            comboFiltrObjednavka.Name = "comboFiltrObjednavka";
            comboFiltrObjednavka.Size = new Size(186, 23);
            comboFiltrObjednavka.TabIndex = 9;
            comboFiltrObjednavka.SelectedIndexChanged += comboFiltrObjednavka_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 16F);
            label22.Location = new Point(165, 255);
            label22.Name = "label22";
            label22.Size = new Size(49, 30);
            label22.TabIndex = 8;
            label22.Text = "Filtr";
            // 
            // btnStats
            // 
            btnStats.Location = new Point(5, 155);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(190, 23);
            btnStats.TabIndex = 7;
            btnStats.Text = "Statistiky";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
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
            panel10.Controls.Add(PassChangeBtn);
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
            // PassChangeBtn
            // 
            PassChangeBtn.Location = new Point(35, 493);
            PassChangeBtn.Name = "PassChangeBtn";
            PassChangeBtn.Size = new Size(370, 44);
            PassChangeBtn.TabIndex = 6;
            PassChangeBtn.Text = "Změnit heslo";
            PassChangeBtn.UseVisualStyleBackColor = true;
            PassChangeBtn.Click += PassChangeBtn_Click;
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
            tabControl1.Controls.Add(tabAdresa);
            tabControl1.Controls.Add(tabFaktura);
            tabControl1.Controls.Add(tabAkce);
            tabControl1.Controls.Add(tabObjZbozi);
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Controls.Add(tabLogs);
            tabControl1.Controls.Add(tabSysCat);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1296, 785);
            tabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(label11);
            tabUsers.Controls.Add(panel15);
            tabUsers.Controls.Add(lvUsers);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(1288, 757);
            tabUsers.TabIndex = 16;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(18, 19);
            label11.Name = "label11";
            label11.Size = new Size(49, 21);
            label11.TabIndex = 2;
            label11.Text = "Users";
            // 
            // panel15
            // 
            panel15.BackColor = Color.Silver;
            panel15.Controls.Add(btnCancelFiltrUser);
            panel15.Controls.Add(btnFilterUser);
            panel15.Controls.Add(comboFiltrOsUser);
            panel15.Controls.Add(comboFiltrRoleUser);
            panel15.Controls.Add(txtFiltrValueUser);
            panel15.Controls.Add(comboFiltrUser);
            panel15.Controls.Add(label25);
            panel15.Controls.Add(emul_button);
            panel15.Controls.Add(btnDeleteUser);
            panel15.Controls.Add(btnEditUser);
            panel15.Controls.Add(btnAddUser);
            panel15.Location = new Point(902, 55);
            panel15.Name = "panel15";
            panel15.Size = new Size(380, 607);
            panel15.TabIndex = 1;
            // 
            // btnCancelFiltrUser
            // 
            btnCancelFiltrUser.Location = new Point(107, 428);
            btnCancelFiltrUser.Name = "btnCancelFiltrUser";
            btnCancelFiltrUser.Size = new Size(186, 23);
            btnCancelFiltrUser.TabIndex = 10;
            btnCancelFiltrUser.Text = "Zrušit filtr";
            btnCancelFiltrUser.UseVisualStyleBackColor = true;
            btnCancelFiltrUser.Click += btnCancelFiltrUser_Click;
            // 
            // btnFilterUser
            // 
            btnFilterUser.Location = new Point(107, 399);
            btnFilterUser.Name = "btnFilterUser";
            btnFilterUser.Size = new Size(186, 23);
            btnFilterUser.TabIndex = 9;
            btnFilterUser.Text = "Filtrovat";
            btnFilterUser.UseVisualStyleBackColor = true;
            btnFilterUser.Click += btnFilterUser_Click;
            // 
            // comboFiltrOsUser
            // 
            comboFiltrOsUser.FormattingEnabled = true;
            comboFiltrOsUser.Location = new Point(107, 370);
            comboFiltrOsUser.Name = "comboFiltrOsUser";
            comboFiltrOsUser.Size = new Size(186, 23);
            comboFiltrOsUser.TabIndex = 8;
            // 
            // comboFiltrRoleUser
            // 
            comboFiltrRoleUser.FormattingEnabled = true;
            comboFiltrRoleUser.Location = new Point(107, 341);
            comboFiltrRoleUser.Name = "comboFiltrRoleUser";
            comboFiltrRoleUser.Size = new Size(186, 23);
            comboFiltrRoleUser.TabIndex = 7;
            // 
            // txtFiltrValueUser
            // 
            txtFiltrValueUser.Location = new Point(107, 312);
            txtFiltrValueUser.Name = "txtFiltrValueUser";
            txtFiltrValueUser.Size = new Size(186, 23);
            txtFiltrValueUser.TabIndex = 6;
            // 
            // comboFiltrUser
            // 
            comboFiltrUser.FormattingEnabled = true;
            comboFiltrUser.Location = new Point(107, 283);
            comboFiltrUser.Name = "comboFiltrUser";
            comboFiltrUser.Size = new Size(186, 23);
            comboFiltrUser.TabIndex = 5;
            comboFiltrUser.SelectedIndexChanged += comboFiltrUser_SelectedIndexChanged;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 16F);
            label25.Location = new Point(162, 250);
            label25.Name = "label25";
            label25.Size = new Size(49, 30);
            label25.TabIndex = 4;
            label25.Text = "Filtr";
            // 
            // emul_button
            // 
            emul_button.Location = new Point(3, 155);
            emul_button.Name = "emul_button";
            emul_button.Size = new Size(307, 23);
            emul_button.TabIndex = 3;
            emul_button.Text = "Emulovat Uživatele";
            emul_button.UseVisualStyleBackColor = true;
            emul_button.Click += emul_button_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(5, 105);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(201, 23);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Odebrat uživatele";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(5, 55);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(201, 23);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Upravit uživatele";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(5, 5);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(201, 23);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Vložit uživatele";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lvUsers
            // 
            lvUsers.Location = new Point(18, 55);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(878, 607);
            lvUsers.TabIndex = 0;
            lvUsers.UseCompatibleStateImageBehavior = false;
            // 
            // tabLogs
            // 
            tabLogs.Controls.Add(logLoadBtn);
            tabLogs.Controls.Add(lvLogs);
            tabLogs.Location = new Point(4, 24);
            tabLogs.Name = "tabLogs";
            tabLogs.Padding = new Padding(3);
            tabLogs.Size = new Size(1288, 757);
            tabLogs.TabIndex = 17;
            tabLogs.Text = "Logy";
            tabLogs.UseVisualStyleBackColor = true;
            // 
            // logLoadBtn
            // 
            logLoadBtn.Location = new Point(307, 724);
            logLoadBtn.Name = "logLoadBtn";
            logLoadBtn.Size = new Size(684, 25);
            logLoadBtn.TabIndex = 2;
            logLoadBtn.Text = "Načíst Logy";
            logLoadBtn.UseVisualStyleBackColor = true;
            logLoadBtn.Click += logLoadBtn_Click;
            // 
            // lvLogs
            // 
            lvLogs.Location = new Point(6, 15);
            lvLogs.Name = "lvLogs";
            lvLogs.Size = new Size(1260, 690);
            lvLogs.TabIndex = 0;
            lvLogs.UseCompatibleStateImageBehavior = false;
            // 
            // tabSysCat
            // 
            tabSysCat.Controls.Add(sysCatBtn);
            tabSysCat.Controls.Add(lvSys);
            tabSysCat.Location = new Point(4, 24);
            tabSysCat.Name = "tabSysCat";
            tabSysCat.Size = new Size(1288, 757);
            tabSysCat.TabIndex = 18;
            tabSysCat.Text = "Systémový katalog";
            tabSysCat.UseVisualStyleBackColor = true;
            // 
            // sysCatBtn
            // 
            sysCatBtn.Location = new Point(422, 700);
            sysCatBtn.Name = "sysCatBtn";
            sysCatBtn.Size = new Size(336, 23);
            sysCatBtn.TabIndex = 1;
            sysCatBtn.Text = "Načíst systémový katalog";
            sysCatBtn.UseVisualStyleBackColor = true;
            sysCatBtn.Click += sysCatBtn_Click;
            // 
            // lvSys
            // 
            lvSys.Location = new Point(23, 45);
            lvSys.Name = "lvSys";
            lvSys.Size = new Size(1238, 605);
            lvSys.TabIndex = 0;
            lvSys.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 809);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            tabObjZbozi.ResumeLayout(false);
            tabObjZbozi.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            tabAkce.ResumeLayout(false);
            tabAkce.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            tabFaktura.ResumeLayout(false);
            tabFaktura.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            tabAdresa.ResumeLayout(false);
            tabAdresa.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            tabSklad.ResumeLayout(false);
            tabSklad.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            tabTypyAkce.ResumeLayout(false);
            tabTypyAkce.PerformLayout();
            panel8.ResumeLayout(false);
            tabPozice.ResumeLayout(false);
            tabPozice.PerformLayout();
            panel7.ResumeLayout(false);
            tabProvozovny.ResumeLayout(false);
            tabProvozovny.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabNadrizeni.ResumeLayout(false);
            tabNadrizeni.PerformLayout();
            tabZaměstnanci.ResumeLayout(false);
            tabZaměstnanci.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabZakaznici.ResumeLayout(false);
            tabZakaznici.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabSuroviny.ResumeLayout(false);
            tabSuroviny.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabObjednávky.ResumeLayout(false);
            tabObjednávky.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabProfil.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tabZbozi.ResumeLayout(false);
            tabZbozi.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            tabLogs.ResumeLayout(false);
            tabSysCat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private void initBtns() {
            GlobalStyles.ApplyButtonStyle(this.DeleteZboziBtn, true);
            GlobalStyles.ApplyButtonStyle(this.updateZboziBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertZboziBtn, true);

            GlobalStyles.ApplyButtonStyle(this.DeleteObjednavkaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.UpdateObjednavkaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertObjednavkaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.btnStats, true);

            GlobalStyles.ApplyButtonStyle(this.DeleteSurovinaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.UpdateSurovinaBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertSurovinaBtn, true);

            GlobalStyles.ApplyButtonStyle(this.DeleteZakaznikBtn, true);
            GlobalStyles.ApplyButtonStyle(this.UpdateZakaznikBtn, true);
            GlobalStyles.ApplyButtonStyle(this.InsertZakaznikBtn, true);
            GlobalStyles.ApplyButtonStyle(this.btnDiscount, true);

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
            GlobalStyles.ApplyButtonStyle(this.btnMigrateSklad, true);

            GlobalStyles.ApplyButtonStyle(this.registerBtn, true);
            GlobalStyles.ApplyButtonStyle(this.loginBtn, true);

            GlobalStyles.ApplyButtonStyle(this.btnAddAdresa, true);
            GlobalStyles.ApplyButtonStyle(this.btnEditAdresa, true);
            GlobalStyles.ApplyButtonStyle(this.btnDeleteAdresa, true);
            GlobalStyles.ApplyButtonStyle(this.btnAdresaUse, true);

            GlobalStyles.ApplyButtonStyle(this.btnSaveFaktura, true);

            GlobalStyles.ApplyButtonStyle(this.btnShowCalendar, true);
            GlobalStyles.ApplyButtonStyle(this.btnAkceShowObjednavka, true);

            GlobalStyles.ApplyButtonStyle(this.btnObjZboziShowObj, true);

            GlobalStyles.ApplyButtonStyle(this.btnAddUser, true);
            GlobalStyles.ApplyButtonStyle(this.btnEditUser, true);
            GlobalStyles.ApplyButtonStyle(this.btnDeleteUser, true);

            GlobalStyles.ApplyButtonStyle(this.KontrolaSurovinBtn, true);
            GlobalStyles.ApplyButtonStyle(this.PresunSurovinuBtn, true);

            GlobalStyles.ApplyButtonStyle(this.PovysitBtn, true);
            GlobalStyles.ApplyButtonStyle(this.emul_button, true);
        }
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private FileSystemWatcher fileSystemWatcher1;
        private TabControl tabControl1;
        private TabPage tabZbozi;
        private Panel panel1;
        private Button btnCancelFiltrZbozi;
        private ComboBox comboFiltrTypZbozi;
        private ComboBox comboSkladFiltrZbozi;
        private Button btnFiltrZbozi;
        private TextBox txtFiltrValueZbozi;
        private Button updateZboziBtn;
        private Button InsertZboziBtn;
        private ComboBox comboFiltrZbozi;
        private Label label15;
        private Button DeleteZboziBtn;
        private Label label1;
        private ListView lvPiva;
        private TabPage tabProfil;
        private Panel panel10;
        private Label label16;
        private CheckBox osUdajeCheck;
        private Button registerBtn;
        private Label labelRegisteredUsername;
        private Button loginBtn;
        private Label labelRegisteredName;
        private TabPage tabObjednávky;
        private Panel panel2;
        private Button InsertObjednavkaBtn;
        private Button UpdateObjednavkaBtn;
        private Button DeleteObjednavkaBtn;
        private Label labelObj;
        private ListView lvObjednavky;
        private TabPage tabSuroviny;
        private Panel panel3;
        private Button InsertSurovinaBtn;
        private Button DeleteSurovinaBtn;
        private Button UpdateSurovinaBtn;
        private Label label2;
        private ListView lvSuroviny;
        private TabPage tabZakaznici;
        private Panel panel4;
        private Button UpdateZakaznikBtn;
        private Button InsertZakaznikBtn;
        private Button DeleteZakaznikBtn;
        private ListView lvZakaznici;
        private Label label3;
        private TabPage tabZaměstnanci;
        private Panel panel5;
        private Button btnAddZamestnanec;
        private Button btnEditZamestnanec;
        private Button btnDeleteZamestnanec;
        private Label label4;
        private ListView lvZamestnanci;
        private TabPage tabNadrizeni;
        private TextBox tbNadrizeni;
        private Button hierarchyBtn;
        private TabPage tabProvozovny;
        private Panel panel6;
        private Button btnDeleteProvozovna;
        private Button btnEditProvozovna;
        private Button btnAddProvozovna;
        private Label labelProvozovny;
        private ListView lvProvozovny;
        private TabPage tabPozice;
        private Panel panel7;
        private Button btnDeletePozice;
        private Button btnEditPozice;
        private Button btnAddPozice;
        private Label label5;
        private ListView lvPozice;
        private TabPage tabTypyAkce;
        private Panel panel8;
        private Button btnDeleteTypAkce;
        private Button btnEditTypAkce;
        private Button btnAddTyp;
        private Label label6;
        private ListView lvTypyAkce;
        private TabPage tabSklad;
        private Panel panel9;
        private Button btnUpdateSklad;
        private Button btnDeleteSklad;
        private Button btnAddSklad;
        private Label label7;
        private ListView lvSklady;
        private TabPage tabAdresa;
        private Panel panel11;
        private Button btnAdresaUse;
        private Button btnDeleteAdresa;
        private Button btnEditAdresa;
        private Button btnAddAdresa;
        private Label label17;
        private ListView lvAdresy;
        private TabPage tabFaktura;
        private Panel panel12;
        private ListView lvFaktury;
        private TabPage tabAkce;
        private Panel panel13;
        private ListView lvAkce;
        private TabPage tabObjZbozi;
        private Panel panel14;
        private ListView lvObjZbozi;
        private Button btnStats;
        private Button btnDiscount;
        private Button btnSaveFaktura;
        private Label label8;
        private Button btnShowCalendar;
        private Label label9;
        private Label label10;
        private Button btnAkceShowObjednavka;
        private Button btnObjZboziShowObj;
        private TabPage tabUsers;
        private Label label11;
        private Panel panel15;
        private ListView lvUsers;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private Button btnMigrateSklad;
        private Button emul_button;
        private Button PassChangeBtn;
        private TabPage tabLogs;
        private TabPage tabSysCat;
        private ListView lvSys;
        private Button sysCatBtn;
        private Button logLoadBtn;
        private ListView lvLogs;
        private Button PresunSurovinuBtn;
        private Button KontrolaSurovinBtn;
        private Button PovysitBtn;
        private Label label18;
        private TextBox txtFiltrSurovinaCount;
        private ComboBox comboFiltrSurovinaCount;
        private Label label14;
        private Label label13;
        private TextBox txtFiltrSurovinaNazev;
        private Label label12;
        private ComboBox comboFiltrSurovinaSklad;
        private Button btnFiltrSurovina;
        private Button btnFiltrSurovinaCancel;
        private ComboBox comboFiltrSurovina;
        private Button btnCancelFiltrZakaznik;
        private Button btnFiltrZakaznik;
        private ComboBox comboFiltrZakaznik;
        private TextBox txtFiltrValueZakaznik;
        private Label label19;
        private Button btnCancelFiltrZamestnanec;
        private Button btnFiltrZamestnanec;
        private TextBox textFiltrValueZamestnanec;
        private ComboBox comboFiltrZamestnanec;
        private Label label20;
        private TextBox txtFiltrAdresa;
        private ComboBox comboFiltrAdresa;
        private Label label21;
        private Button btnCancelFiltrAdresa;
        private Button btnFiltrAdresa;
        private TextBox txtFiltrObjednavkaValue;
        private ComboBox comboFiltrObjednavka;
        private Label label22;
        private Button btnCancelFiltrObjednavka;
        private Button btnFiltrObjednavka;
        private ComboBox comboFiltrStatusObjednavka;
        private Button btnCancelFiltrProvozovna;
        private Button btnFiltrProvozovna;
        private TextBox txtFiltrValueProvozovna;
        private Label label23;
        private ComboBox comboFiltrProvozovna;
        private Label label24;
        private Button btnCancelFiltrSklad;
        private Button btnFiltrSklad;
        private TextBox txtFiltrValueSklad;
        private ComboBox comboFiltrSklad;
        private Button btnCancelFiltrUser;
        private Button btnFilterUser;
        private ComboBox comboFiltrOsUser;
        private ComboBox comboFiltrRoleUser;
        private TextBox txtFiltrValueUser;
        private ComboBox comboFiltrUser;
        private Label label25;
        private Label label26;
        private Button btnCancelFiltrobjZbozi;
        private Button btnFiltrObjZbozi;
        private TextBox txtFiltrValueObjZbozi;
        private ComboBox comboFiltrObjZbozi;
        private Button btnCancelFiltrAkce;
        private Button btnFiltrAkce;
        private TextBox txtFiltrValueAkce;
        private ComboBox comboFiltrAkce;
        private Label label27;
        private ComboBox comboFiltrAkceType;
        private Label label28;
        private Button btnFiltrCancelFaktura;
        private Button btnFiltrFaktura;
        private Label label29;
        private TextBox txtFiltrFakturaValue;
    }
}
