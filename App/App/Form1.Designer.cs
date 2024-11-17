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
            updateZboziBtn = new Button();
            InsertZboziBtn = new Button();
            DeleteZboziBtn = new Button();
            label1 = new Label();
            lvPiva = new ListView();
            tabProfil = new TabPage();
            button5 = new Button();
            button4 = new Button();
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
            label4 = new Label();
            lvZamestnanci = new ListView();
            tabNadrizeni = new TabPage();
            lvNadrizeni = new ListView();
            panel5 = new Panel();
            tabControl1.SuspendLayout();
            tabZbozi.SuspendLayout();
            panel1.SuspendLayout();
            tabProfil.SuspendLayout();
            tabObjednávky.SuspendLayout();
            panel2.SuspendLayout();
            tabSuroviny.SuspendLayout();
            panel3.SuspendLayout();
            tabZakaznici.SuspendLayout();
            panel4.SuspendLayout();
            tabZaměstnanci.SuspendLayout();
            tabNadrizeni.SuspendLayout();
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
            panel1.Controls.Add(updateZboziBtn);
            panel1.Controls.Add(InsertZboziBtn);
            panel1.Controls.Add(DeleteZboziBtn);
            panel1.Location = new Point(902, 55);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(380, 607);
            panel1.TabIndex = 6;
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
            tabProfil.Controls.Add(button5);
            tabProfil.Controls.Add(button4);
            tabProfil.Location = new Point(4, 24);
            tabProfil.Name = "tabProfil";
            tabProfil.Padding = new Padding(3);
            tabProfil.Size = new Size(1288, 757);
            tabProfil.TabIndex = 1;
            tabProfil.Text = "Profil";
            tabProfil.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(65, 191);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(65, 89);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
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
            tabNadrizeni.Controls.Add(lvNadrizeni);
            tabNadrizeni.Location = new Point(4, 24);
            tabNadrizeni.Name = "tabNadrizeni";
            tabNadrizeni.Padding = new Padding(3);
            tabNadrizeni.Size = new Size(1288, 757);
            tabNadrizeni.TabIndex = 6;
            tabNadrizeni.Text = "Nadřízení";
            tabNadrizeni.UseVisualStyleBackColor = true;
            // 
            // lvNadrizeni
            // 
            lvNadrizeni.Location = new Point(34, 56);
            lvNadrizeni.Name = "lvNadrizeni";
            lvNadrizeni.Size = new Size(1175, 645);
            lvNadrizeni.TabIndex = 0;
            lvNadrizeni.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(902, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 607);
            panel5.TabIndex = 2;
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
            tabProfil.ResumeLayout(false);
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
            tabNadrizeni.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProfil;
        private Button button5;
        private Button button4;
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
        private ListView lvNadrizeni;
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
        }

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}
