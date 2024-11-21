namespace App.Dialogs
{
    partial class TypyAkceDialog
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
            txtNazev = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNazev
            // 
            txtNazev.Location = new Point(118, 38);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(100, 23);
            txtNazev.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Název:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(0, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 83);
            panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 29);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(196, 29);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // TypyAkceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 228);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtNazev);
            Name = "TypyAkceDialog";
            Text = "TypyAkceDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNazev;
        private Label label1;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
    }
}