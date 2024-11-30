namespace App.Dialogs.ZakaznikDialogs
{
    partial class HladinaDialog
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
            txtHladina = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            txtZakaznik = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHladina
            // 
            txtHladina.Location = new Point(123, 114);
            txtHladina.Name = "txtHladina";
            txtHladina.Size = new Size(124, 23);
            txtHladina.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 117);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 1;
            label1.Text = "Cenová hladina:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(19, 42);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(263, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(0, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 97);
            panel1.TabIndex = 4;
            // 
            // txtZakaznik
            // 
            txtZakaznik.Enabled = false;
            txtZakaznik.Location = new Point(123, 54);
            txtZakaznik.Name = "txtZakaznik";
            txtZakaznik.Size = new Size(124, 23);
            txtZakaznik.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 57);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Zákazník:";
            // 
            // HladinaDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 338);
            Controls.Add(label2);
            Controls.Add(txtZakaznik);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtHladina);
            Name = "HladinaDialog";
            Text = "HladinaDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHladina;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
        private Panel panel1;
        private TextBox txtZakaznik;
        private Label label2;
    }
}