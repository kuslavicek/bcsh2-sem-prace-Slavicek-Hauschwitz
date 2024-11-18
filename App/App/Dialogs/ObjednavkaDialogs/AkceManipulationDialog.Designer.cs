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
            SuspendLayout();
            // 
            // btnAkceAdd
            // 
            btnAkceAdd.Location = new Point(168, 102);
            btnAkceAdd.Name = "btnAkceAdd";
            btnAkceAdd.Size = new Size(75, 23);
            btnAkceAdd.TabIndex = 1;
            btnAkceAdd.Text = "Přidat";
            btnAkceAdd.UseVisualStyleBackColor = true;
            btnAkceAdd.Click += btnAkceAdd_Click;
            // 
            // btnCancelAkce
            // 
            btnCancelAkce.Location = new Point(249, 102);
            btnCancelAkce.Name = "btnCancelAkce";
            btnCancelAkce.Size = new Size(75, 23);
            btnCancelAkce.TabIndex = 2;
            btnCancelAkce.Text = "Zrušit";
            btnCancelAkce.UseVisualStyleBackColor = true;
            btnCancelAkce.Click += btnCancelAkce_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(168, 73);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(168, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // LabelOsobyAkce
            // 
            LabelOsobyAkce.AutoSize = true;
            LabelOsobyAkce.Location = new Point(93, 47);
            LabelOsobyAkce.Name = "LabelOsobyAkce";
            LabelOsobyAkce.Size = new Size(69, 15);
            LabelOsobyAkce.TabIndex = 6;
            LabelOsobyAkce.Text = "Počet osob:";
            // 
            // labelDatumAkce
            // 
            labelDatumAkce.AutoSize = true;
            labelDatumAkce.Location = new Point(111, 79);
            labelDatumAkce.Name = "labelDatumAkce";
            labelDatumAkce.Size = new Size(46, 15);
            labelDatumAkce.TabIndex = 7;
            labelDatumAkce.Text = "Datum:";
            // 
            // labelTypAkce
            // 
            labelTypAkce.AutoSize = true;
            labelTypAkce.Location = new Point(111, 15);
            labelTypAkce.Name = "labelTypAkce";
            labelTypAkce.Size = new Size(55, 15);
            labelTypAkce.TabIndex = 8;
            labelTypAkce.Text = "Typ akce:";
            // 
            // AkceManipulationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 211);
            Controls.Add(labelTypAkce);
            Controls.Add(labelDatumAkce);
            Controls.Add(LabelOsobyAkce);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(btnCancelAkce);
            Controls.Add(btnAkceAdd);
            Name = "AkceManipulationDialog";
            Text = "AkceManipulationDialog";
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
    }
}