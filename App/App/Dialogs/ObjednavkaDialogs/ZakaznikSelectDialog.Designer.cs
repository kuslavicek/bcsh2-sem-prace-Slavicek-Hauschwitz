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
            SuspendLayout();
            // 
            // lvZakaznici
            // 
            lvZakaznici.Location = new Point(12, 12);
            lvZakaznici.Name = "lvZakaznici";
            lvZakaznici.Size = new Size(776, 339);
            lvZakaznici.TabIndex = 0;
            lvZakaznici.UseCompatibleStateImageBehavior = false;
            // 
            // btnSelectZakaznik
            // 
            btnSelectZakaznik.Location = new Point(355, 357);
            btnSelectZakaznik.Name = "btnSelectZakaznik";
            btnSelectZakaznik.Size = new Size(127, 35);
            btnSelectZakaznik.TabIndex = 1;
            btnSelectZakaznik.Text = "Potvrdit";
            btnSelectZakaznik.UseVisualStyleBackColor = true;
            btnSelectZakaznik.Click += btnSelectZakaznik_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(355, 403);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ZakaznikSelectDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSelectZakaznik);
            Controls.Add(lvZakaznici);
            Name = "ZakaznikSelectDialog";
            Text = "ZakaznikSelectDialog";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvZakaznici;
        private Button btnSelectZakaznik;
        private Button btnCancel;
    }
}