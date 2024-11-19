using App.Repositories;

namespace App.Dialogs
{
    partial class SurovinaDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private SkladRepo _skladRepository;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNazev = new Label();
            textBoxNazev = new TextBox();
            labelMnozstvi = new Label();
            textBoxMnozstvi = new TextBox();
            labelSklad = new Label();
            comboSklad = new ComboBox();
            buttonOk = new Button();
            buttonCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNazev
            // 
            labelNazev.Location = new Point(39, 51);
            labelNazev.Name = "labelNazev";
            labelNazev.Size = new Size(120, 20);
            labelNazev.TabIndex = 0;
            labelNazev.Text = "Název Suroviny:";
            // 
            // textBoxNazev
            // 
            textBoxNazev.Location = new Point(159, 51);
            textBoxNazev.Name = "textBoxNazev";
            textBoxNazev.Size = new Size(200, 23);
            textBoxNazev.TabIndex = 1;
            // 
            // labelMnozstvi
            // 
            labelMnozstvi.Location = new Point(39, 91);
            labelMnozstvi.Name = "labelMnozstvi";
            labelMnozstvi.Size = new Size(120, 20);
            labelMnozstvi.TabIndex = 2;
            labelMnozstvi.Text = "Množství:";
            // 
            // textBoxMnozstvi
            // 
            textBoxMnozstvi.Location = new Point(159, 91);
            textBoxMnozstvi.Name = "textBoxMnozstvi";
            textBoxMnozstvi.Size = new Size(200, 23);
            textBoxMnozstvi.TabIndex = 3;
            // 
            // labelSklad
            // 
            labelSklad.Location = new Point(39, 131);
            labelSklad.Name = "labelSklad";
            labelSklad.Size = new Size(120, 20);
            labelSklad.TabIndex = 4;
            labelSklad.Text = "Sklad:";
            // 
            // comboSklad
            // 
            comboSklad.Location = new Point(159, 131);
            comboSklad.Name = "comboSklad";
            comboSklad.Size = new Size(200, 23);
            comboSklad.TabIndex = 5;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(12, 33);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(152, 36);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "Uložit";
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(236, 33);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(152, 36);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Zrušit";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(buttonOk);
            panel1.Controls.Add(buttonCancel);
            panel1.Location = new Point(0, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 100);
            panel1.TabIndex = 8;
            // 
            // SurovinaDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(panel1);
            Controls.Add(labelNazev);
            Controls.Add(textBoxNazev);
            Controls.Add(labelMnozstvi);
            Controls.Add(textBoxMnozstvi);
            Controls.Add(labelSklad);
            Controls.Add(comboSklad);
            Name = "SurovinaDialog";
            Text = "Nová Surovina";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void LoadSkladData()
        {
            var sklady = _skladRepository.GetSklady();

            if (sklady == null || sklady.Count == 0)
            {
                MessageBox.Show("Nejsou k dispozici žádné sklady.");
                return;
            }

            this.comboSklad.DisplayMember = "Nazev";
            this.comboSklad.DataSource = sklady;
        }

        // Ovládací prvky
        private System.Windows.Forms.Label labelNazev;
        private System.Windows.Forms.TextBox textBoxNazev;
        private System.Windows.Forms.Label labelMnozstvi;
        private System.Windows.Forms.TextBox textBoxMnozstvi;
        private System.Windows.Forms.Label labelSklad;
        private System.Windows.Forms.ComboBox comboSklad;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private Panel panel1;
    }
}
