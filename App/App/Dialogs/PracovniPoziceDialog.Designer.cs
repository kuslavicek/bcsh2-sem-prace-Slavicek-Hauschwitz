namespace App.Dialogs
{
    partial class PracovniPoziceDialog
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
            btnCancel = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            textBoxNazev = new TextBox();
            textBoxPlat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 30);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 36);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(0, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 100);
            panel1.TabIndex = 2;
            // 
            // textBoxNazev
            // 
            textBoxNazev.Location = new Point(104, 61);
            textBoxNazev.Name = "textBoxNazev";
            textBoxNazev.Size = new Size(100, 23);
            textBoxNazev.TabIndex = 3;
            // 
            // textBoxPlat
            // 
            textBoxPlat.Location = new Point(104, 102);
            textBoxPlat.Name = "textBoxPlat";
            textBoxPlat.Size = new Size(100, 23);
            textBoxPlat.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 105);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Plat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 64);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Název:";
            // 
            // PracovniPoziceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 296);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPlat);
            Controls.Add(textBoxNazev);
            Controls.Add(panel1);
            Name = "PracovniPoziceDialog";
            Text = "PracovniPoziceDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Panel panel1;
        private TextBox textBoxNazev;
        private TextBox textBoxPlat;
        private Label label1;
        private Label label2;
    }
}