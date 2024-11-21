using App.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace App.Dialogs
{
    partial class ZboziDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Vstupní pole
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.TextBox txtObsahAlkoholu;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox comboSklad;
        private System.Windows.Forms.ComboBox comboTyp;
        private System.Windows.Forms.TextBox txtSpecificValue;

        // Tlačítka
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            lblNazev = new Label();
            txtNazev = new TextBox();
            lblObsahAlkoholu = new Label();
            txtObsahAlkoholu = new TextBox();
            lblCena = new Label();
            txtCena = new TextBox();
            lblSklad = new Label();
            comboSklad = new ComboBox();
            lblTyp = new Label();
            comboTyp = new ComboBox();
            lblSpecificValue = new Label();
            txtSpecificValue = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNazev
            // 
            lblNazev.Location = new Point(50, 30);
            lblNazev.Name = "lblNazev";
            lblNazev.Size = new Size(100, 23);
            lblNazev.TabIndex = 0;
            lblNazev.Text = "Název zboží:";
            // 
            // txtNazev
            // 
            txtNazev.BackColor = SystemColors.Window;
            txtNazev.Location = new Point(150, 30);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(200, 23);
            txtNazev.TabIndex = 6;
            // 
            // lblObsahAlkoholu
            // 
            lblObsahAlkoholu.Location = new Point(50, 60);
            lblObsahAlkoholu.Name = "lblObsahAlkoholu";
            lblObsahAlkoholu.Size = new Size(100, 23);
            lblObsahAlkoholu.TabIndex = 1;
            lblObsahAlkoholu.Text = "Obsah alkoholu:";
            // 
            // txtObsahAlkoholu
            // 
            txtObsahAlkoholu.Location = new Point(150, 60);
            txtObsahAlkoholu.Name = "txtObsahAlkoholu";
            txtObsahAlkoholu.Size = new Size(200, 23);
            txtObsahAlkoholu.TabIndex = 7;
            // 
            // lblCena
            // 
            lblCena.Location = new Point(50, 90);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(100, 23);
            lblCena.TabIndex = 2;
            lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            txtCena.Location = new Point(150, 90);
            txtCena.Name = "txtCena";
            txtCena.Size = new Size(200, 23);
            txtCena.TabIndex = 8;
            // 
            // lblSklad
            // 
            lblSklad.Location = new Point(50, 120);
            lblSklad.Name = "lblSklad";
            lblSklad.Size = new Size(100, 23);
            lblSklad.TabIndex = 3;
            lblSklad.Text = "Sklad:";
            // 
            // comboSklad
            // 
            comboSklad.Location = new Point(150, 120);
            comboSklad.Name = "comboSklad";
            comboSklad.Size = new Size(200, 23);
            comboSklad.TabIndex = 9;
            // 
            // lblTyp
            // 
            lblTyp.Location = new Point(50, 150);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(100, 23);
            lblTyp.TabIndex = 4;
            lblTyp.Text = "Typ:";
            // 
            // comboTyp
            // 
            comboTyp.Items.AddRange(new object[] { "p", "c" });
            comboTyp.Location = new Point(150, 150);
            comboTyp.Name = "comboTyp";
            comboTyp.Size = new Size(200, 23);
            comboTyp.TabIndex = 10;
            // 
            // lblSpecificValue
            // 
            lblSpecificValue.Location = new Point(12, 180);
            lblSpecificValue.Name = "lblSpecificValue";
            lblSpecificValue.Size = new Size(132, 23);
            lblSpecificValue.TabIndex = 5;
            lblSpecificValue.Text = "Stupòovitost/odrùda:";
            // 
            // txtSpecificValue
            // 
            txtSpecificValue.Location = new Point(150, 180);
            txtSpecificValue.Name = "txtSpecificValue";
            txtSpecificValue.Size = new Size(200, 23);
            txtSpecificValue.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(13, 20);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "Uložit";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(245, 20);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Zrušit";
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(-1, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 74);
            panel1.TabIndex = 14;
            // 
            // ZboziDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 293);
            Controls.Add(panel1);
            Controls.Add(lblNazev);
            Controls.Add(lblObsahAlkoholu);
            Controls.Add(lblCena);
            Controls.Add(lblSklad);
            Controls.Add(lblTyp);
            Controls.Add(lblSpecificValue);
            Controls.Add(txtNazev);
            Controls.Add(txtObsahAlkoholu);
            Controls.Add(txtCena);
            Controls.Add(comboSklad);
            Controls.Add(comboTyp);
            Controls.Add(txtSpecificValue);
            Name = "ZboziDialog";
            Text = "ZboziDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNazev;
        private Label lblObsahAlkoholu;
        private Label lblCena;
        private Label lblSklad;
        private Label lblTyp;
        private Label lblSpecificValue;
        private Panel panel1;
    }
}