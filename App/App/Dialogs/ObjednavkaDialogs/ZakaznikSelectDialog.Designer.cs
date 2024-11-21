namespace App.Dialogs.ObjednavkaDialogs
{
    partial class ZakaznikSelectDialog
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
            lvZakaznici = new ListView();
            btnSelectZakaznik = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvZakaznici
            // 
            lvZakaznici.FullRowSelect = true;
            lvZakaznici.Location = new Point(12, 12);
            lvZakaznici.Name = "lvZakaznici";
            lvZakaznici.Size = new Size(776, 339);
            lvZakaznici.TabIndex = 0;
            lvZakaznici.UseCompatibleStateImageBehavior = false;
            lvZakaznici.View = View.Details;
            // 
            // btnSelectZakaznik
            // 
            btnSelectZakaznik.Location = new Point(241, 22);
            btnSelectZakaznik.Name = "btnSelectZakaznik";
            btnSelectZakaznik.Size = new Size(127, 35);
            btnSelectZakaznik.TabIndex = 1;
            btnSelectZakaznik.Text = "Potvrdit";
            btnSelectZakaznik.UseVisualStyleBackColor = true;
            btnSelectZakaznik.Click += btnSelectZakaznik_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSelectZakaznik);
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(12, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 81);
            panel1.TabIndex = 3;
            // 
            // ZakaznikSelectDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lvZakaznici);
            Name = "ZakaznikSelectDialog";
            Text = "ZakaznikSelectDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvZakaznici;
        private Button btnSelectZakaznik;
        private Button btnCancel;
        private Panel panel1;
    }
}