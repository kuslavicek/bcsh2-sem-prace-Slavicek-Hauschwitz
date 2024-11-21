namespace App.Dialogs.ObjednavkaDialogs
{
    partial class AkceManipulationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnAkceAdd = new Button();
            btnCancelAkce = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            LabelOsobyAkce = new Label();
            labelDatumAkce = new Label();
            labelTypAkce = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAkceAdd
            // 
            btnAkceAdd.Location = new Point(11, 26);
            btnAkceAdd.Name = "btnAkceAdd";
            btnAkceAdd.Size = new Size(100, 30);
            btnAkceAdd.TabIndex = 1;
            btnAkceAdd.Text = "Přidat";
            btnAkceAdd.UseVisualStyleBackColor = true;
            btnAkceAdd.Click += btnAkceAdd_Click;
            // 
            // btnCancelAkce
            // 
            btnCancelAkce.Location = new Point(323, 26);
            btnCancelAkce.Name = "btnCancelAkce";
            btnCancelAkce.Size = new Size(100, 30);
            btnCancelAkce.TabIndex = 2;
            btnCancelAkce.Text = "Zrušit";
            btnCancelAkce.UseVisualStyleBackColor = true;
            btnCancelAkce.Click += btnCancelAkce_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(126, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 5;
            // 
            // LabelOsobyAkce
            // 
            LabelOsobyAkce.AutoSize = true;
            LabelOsobyAkce.Location = new Point(51, 47);
            LabelOsobyAkce.Name = "LabelOsobyAkce";
            LabelOsobyAkce.Size = new Size(69, 15);
            LabelOsobyAkce.TabIndex = 6;
            LabelOsobyAkce.Text = "Počet osob:";
            // 
            // labelDatumAkce
            // 
            labelDatumAkce.AutoSize = true;
            labelDatumAkce.Location = new Point(69, 79);
            labelDatumAkce.Name = "labelDatumAkce";
            labelDatumAkce.Size = new Size(46, 15);
            labelDatumAkce.TabIndex = 7;
            labelDatumAkce.Text = "Datum:";
            // 
            // labelTypAkce
            // 
            labelTypAkce.AutoSize = true;
            labelTypAkce.Location = new Point(69, 15);
            labelTypAkce.Name = "labelTypAkce";
            labelTypAkce.Size = new Size(55, 15);
            labelTypAkce.TabIndex = 8;
            labelTypAkce.Text = "Typ akce:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnAkceAdd);
            panel1.Controls.Add(btnCancelAkce);
            panel1.Location = new Point(1, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 82);
            panel1.TabIndex = 9;
            // 
            // AkceManipulationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 211);
            Controls.Add(panel1);
            Controls.Add(labelTypAkce);
            Controls.Add(labelDatumAkce);
            Controls.Add(LabelOsobyAkce);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "AkceManipulationDialog";
            Text = "AkceManipulationDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAkceAdd;
        private Button btnCancelAkce;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label LabelOsobyAkce;
        private Label labelDatumAkce;
        private Label labelTypAkce;
        private Panel panel1;
    }
}