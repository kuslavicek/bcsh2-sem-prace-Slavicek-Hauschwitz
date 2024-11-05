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
            label1 = new Label();
            DeleteZboziBtn = new Button();
            InsertZboziBtn = new Button();
            updateZboziBtn = new Button();
            lvPiva = new ListView();
            tabProfil = new TabPage();
            button5 = new Button();
            button4 = new Button();
            tabObjednávky = new TabPage();
            DeleteObjednavkaBtn = new Button();
            UpdateObjednavkaBtn = new Button();
            InsertObjednávkaBtn = new Button();
            labelObj = new Label();
            lvObjednavky = new ListView();
            tabSuroviny = new TabPage();
            DeleteSurovinaBtn = new Button();
            UpdateSurovinaBtn = new Button();
            InsertSurovinaBtn = new Button();
            label2 = new Label();
            lvSuroviny = new ListView();
            tabZakaznici = new TabPage();
            tabZaměstnanci = new TabPage();
            label3 = new Label();
            lvZamestnanci = new ListView();
            label4 = new Label();
            lvZakaznici = new ListView();
            tabControl1.SuspendLayout();
            tabZbozi.SuspendLayout();
            tabProfil.SuspendLayout();
            tabObjednávky.SuspendLayout();
            tabSuroviny.SuspendLayout();
            tabZakaznici.SuspendLayout();
            tabZaměstnanci.SuspendLayout();
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
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1296, 785);
            tabControl1.TabIndex = 0;
            // 
            // tabZbozi
            // 
            tabZbozi.Controls.Add(label1);
            tabZbozi.Controls.Add(DeleteZboziBtn);
            tabZbozi.Controls.Add(InsertZboziBtn);
            tabZbozi.Controls.Add(updateZboziBtn);
            tabZbozi.Controls.Add(lvPiva);
            tabZbozi.Location = new Point(4, 24);
            tabZbozi.Name = "tabZbozi";
            tabZbozi.Padding = new Padding(3);
            tabZbozi.Size = new Size(1288, 757);
            tabZbozi.TabIndex = 0;
            tabZbozi.Text = "Zboží";
            tabZbozi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 5;
            label1.Text = "Zboží";
            // 
            // DeleteZboziBtn
            // 
            DeleteZboziBtn.Location = new Point(978, 252);
            DeleteZboziBtn.Name = "DeleteZboziBtn";
            DeleteZboziBtn.Size = new Size(269, 23);
            DeleteZboziBtn.TabIndex = 4;
            DeleteZboziBtn.Text = "Smazat Zboží";
            DeleteZboziBtn.UseVisualStyleBackColor = true;
            DeleteZboziBtn.Click += DeleteZboziBtn_Click;
            // 
            // InsertZboziBtn
            // 
            InsertZboziBtn.Location = new Point(978, 164);
            InsertZboziBtn.Name = "InsertZboziBtn";
            InsertZboziBtn.Size = new Size(269, 23);
            InsertZboziBtn.TabIndex = 3;
            InsertZboziBtn.Text = "Vložit Zboží";
            InsertZboziBtn.UseVisualStyleBackColor = true;
            InsertZboziBtn.Click += InsertZboziBtn_Click;
            // 
            // updateZboziBtn
            // 
            updateZboziBtn.Location = new Point(977, 91);
            updateZboziBtn.Name = "updateZboziBtn";
            updateZboziBtn.Size = new Size(270, 23);
            updateZboziBtn.TabIndex = 2;
            updateZboziBtn.Text = "Upravit Zboží";
            updateZboziBtn.UseVisualStyleBackColor = true;
            updateZboziBtn.Click += updateZboziBtn_Click;
            // 
            // lvPiva
            // 
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
            tabObjednávky.Controls.Add(DeleteObjednavkaBtn);
            tabObjednávky.Controls.Add(UpdateObjednavkaBtn);
            tabObjednávky.Controls.Add(InsertObjednávkaBtn);
            tabObjednávky.Controls.Add(labelObj);
            tabObjednávky.Controls.Add(lvObjednavky);
            tabObjednávky.Location = new Point(4, 24);
            tabObjednávky.Name = "tabObjednávky";
            tabObjednávky.Padding = new Padding(3);
            tabObjednávky.Size = new Size(1288, 757);
            tabObjednávky.TabIndex = 2;
            tabObjednávky.Text = "Objednávky";
            tabObjednávky.UseVisualStyleBackColor = true;
            // 
            // DeleteObjednavkaBtn
            // 
            DeleteObjednavkaBtn.Location = new Point(1004, 174);
            DeleteObjednavkaBtn.Name = "DeleteObjednavkaBtn";
            DeleteObjednavkaBtn.Size = new Size(190, 26);
            DeleteObjednavkaBtn.TabIndex = 4;
            DeleteObjednavkaBtn.Text = "Smazat Objednávku";
            DeleteObjednavkaBtn.UseVisualStyleBackColor = true;
            DeleteObjednavkaBtn.Click += DeleteObjednavkaBtn_Click;
            // 
            // UpdateObjednavkaBtn
            // 
            UpdateObjednavkaBtn.Location = new Point(1004, 105);
            UpdateObjednavkaBtn.Name = "UpdateObjednavkaBtn";
            UpdateObjednavkaBtn.Size = new Size(190, 23);
            UpdateObjednavkaBtn.TabIndex = 3;
            UpdateObjednavkaBtn.Text = "Upravit Objednávku";
            UpdateObjednavkaBtn.UseVisualStyleBackColor = true;
            UpdateObjednavkaBtn.Click += UpdateObjednavkaBtn_Click;
            // 
            // InsertObjednávkaBtn
            // 
            InsertObjednávkaBtn.Location = new Point(1004, 37);
            InsertObjednávkaBtn.Name = "InsertObjednávkaBtn";
            InsertObjednávkaBtn.Size = new Size(190, 23);
            InsertObjednávkaBtn.TabIndex = 2;
            InsertObjednávkaBtn.Text = "Vložit Objednávku";
            InsertObjednávkaBtn.UseVisualStyleBackColor = true;
            InsertObjednávkaBtn.Click += InsertObjednávkaBtn_Click;
            // 
            // labelObj
            // 
            labelObj.AutoSize = true;
            labelObj.Font = new Font("Segoe UI", 12F);
            labelObj.Location = new Point(27, 19);
            labelObj.Name = "labelObj";
            labelObj.Size = new Size(93, 21);
            labelObj.TabIndex = 1;
            labelObj.Text = "Objednávky";
            // 
            // lvObjednavky
            // 
            lvObjednavky.Location = new Point(18, 72);
            lvObjednavky.Name = "lvObjednavky";
            lvObjednavky.Size = new Size(919, 667);
            lvObjednavky.TabIndex = 0;
            lvObjednavky.UseCompatibleStateImageBehavior = false;
            // 
            // tabSuroviny
            // 
            tabSuroviny.Controls.Add(DeleteSurovinaBtn);
            tabSuroviny.Controls.Add(UpdateSurovinaBtn);
            tabSuroviny.Controls.Add(InsertSurovinaBtn);
            tabSuroviny.Controls.Add(label2);
            tabSuroviny.Controls.Add(lvSuroviny);
            tabSuroviny.Location = new Point(4, 24);
            tabSuroviny.Name = "tabSuroviny";
            tabSuroviny.Padding = new Padding(3);
            tabSuroviny.Size = new Size(1288, 757);
            tabSuroviny.TabIndex = 3;
            tabSuroviny.Text = "Suroviny";
            tabSuroviny.UseVisualStyleBackColor = true;
            // 
            // DeleteSurovinaBtn
            // 
            DeleteSurovinaBtn.Location = new Point(989, 202);
            DeleteSurovinaBtn.Name = "DeleteSurovinaBtn";
            DeleteSurovinaBtn.Size = new Size(227, 26);
            DeleteSurovinaBtn.TabIndex = 4;
            DeleteSurovinaBtn.Text = "Smazat Surovinu";
            DeleteSurovinaBtn.UseVisualStyleBackColor = true;
            DeleteSurovinaBtn.Click += DeleteSurovinaBtn_Click;
            // 
            // UpdateSurovinaBtn
            // 
            UpdateSurovinaBtn.Location = new Point(989, 135);
            UpdateSurovinaBtn.Name = "UpdateSurovinaBtn";
            UpdateSurovinaBtn.Size = new Size(227, 23);
            UpdateSurovinaBtn.TabIndex = 3;
            UpdateSurovinaBtn.Text = "Upravit Surovinu";
            UpdateSurovinaBtn.UseVisualStyleBackColor = true;
            UpdateSurovinaBtn.Click += UpdateSurovinaBtn_Click;
            // 
            // InsertSurovinaBtn
            // 
            InsertSurovinaBtn.Location = new Point(989, 60);
            InsertSurovinaBtn.Name = "InsertSurovinaBtn";
            InsertSurovinaBtn.Size = new Size(227, 26);
            InsertSurovinaBtn.TabIndex = 2;
            InsertSurovinaBtn.Text = "Vložit Surovinu";
            InsertSurovinaBtn.UseVisualStyleBackColor = true;
            InsertSurovinaBtn.Click += InsertSurovinaBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 21);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "Suroviny";
            // 
            // lvSuroviny
            // 
            lvSuroviny.Location = new Point(30, 74);
            lvSuroviny.Name = "lvSuroviny";
            lvSuroviny.Size = new Size(894, 643);
            lvSuroviny.TabIndex = 0;
            lvSuroviny.UseCompatibleStateImageBehavior = false;
            // 
            // tabZakaznici
            // 
            tabZakaznici.Controls.Add(lvZakaznici);
            tabZakaznici.Controls.Add(label3);
            tabZakaznici.Location = new Point(4, 24);
            tabZakaznici.Name = "tabZakaznici";
            tabZakaznici.Padding = new Padding(3);
            tabZakaznici.Size = new Size(1288, 757);
            tabZakaznici.TabIndex = 4;
            tabZakaznici.Text = "Zákazníci";
            tabZakaznici.UseVisualStyleBackColor = true;
            // 
            // tabZaměstnanci
            // 
            tabZaměstnanci.Controls.Add(label4);
            tabZaměstnanci.Controls.Add(lvZamestnanci);
            tabZaměstnanci.Location = new Point(4, 24);
            tabZaměstnanci.Name = "tabZaměstnanci";
            tabZaměstnanci.Padding = new Padding(3);
            tabZaměstnanci.Size = new Size(1288, 757);
            tabZaměstnanci.TabIndex = 5;
            tabZaměstnanci.Text = "Zaměstnanci";
            tabZaměstnanci.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(32, 28);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 0;
            label3.Text = "Zákazníci";
            // 
            // lvZamestnanci
            // 
            lvZamestnanci.Location = new Point(45, 127);
            lvZamestnanci.Name = "lvZamestnanci";
            lvZamestnanci.Size = new Size(838, 565);
            lvZamestnanci.TabIndex = 0;
            lvZamestnanci.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 40);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 1;
            label4.Text = "Zaměstnanci";
            // 
            // lvZakaznici
            // 
            lvZakaznici.Location = new Point(39, 92);
            lvZakaznici.Name = "lvZakaznici";
            lvZakaznici.Size = new Size(847, 595);
            lvZakaznici.TabIndex = 1;
            lvZakaznici.UseCompatibleStateImageBehavior = false;
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
            tabProfil.ResumeLayout(false);
            tabObjednávky.ResumeLayout(false);
            tabObjednávky.PerformLayout();
            tabSuroviny.ResumeLayout(false);
            tabSuroviny.PerformLayout();
            tabZakaznici.ResumeLayout(false);
            tabZakaznici.PerformLayout();
            tabZaměstnanci.ResumeLayout(false);
            tabZaměstnanci.PerformLayout();
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
        private Button InsertObjednávkaBtn;
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
    }
}
