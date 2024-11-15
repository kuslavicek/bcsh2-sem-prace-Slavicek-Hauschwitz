

namespace App.Dialogs.ObjednavkaDialogs
{
    partial class ZboziManipulationDialog
    {
        private System.Windows.Forms.ListView listViewZbozi;
        private System.Windows.Forms.TextBox inputPocet;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnUlozit;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewZbozi = new System.Windows.Forms.ListView();
            this.inputPocet = new System.Windows.Forms.TextBox();
            this.btnPridat = new System.Windows.Forms.Button();
            this.btnUlozit = new System.Windows.Forms.Button();

            // 
            // listViewZbozi
            // 
            this.listViewZbozi.Location = new System.Drawing.Point(12, 12);
            this.listViewZbozi.Name = "listViewZbozi";
            this.listViewZbozi.Size = new System.Drawing.Size(600, 300);
            this.listViewZbozi.TabIndex = 0;
            this.listViewZbozi.View = System.Windows.Forms.View.Details;
            this.listViewZbozi.FullRowSelect = true;

            // Přidání sloupců do ListView
            this.listViewZbozi.Columns.Add("ID", 50);
            this.listViewZbozi.Columns.Add("Název", 200);
            this.listViewZbozi.Columns.Add("Cena", 100);
            this.listViewZbozi.Columns.Add("Typ", 100);

            // 
            // inputPocet
            // 
            this.inputPocet.Location = new System.Drawing.Point(12, 330);
            this.inputPocet.Name = "inputPocet";
            this.inputPocet.Size = new System.Drawing.Size(100, 23);
            this.inputPocet.TabIndex = 1;

            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(130, 330);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(75, 23);
            this.btnPridat.TabIndex = 2;
            this.btnPridat.Text = "Přidat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.BtnPridat_Click);

            this.btnUlozit.Location = new System.Drawing.Point(130, 360);
            this.btnUlozit.Name = "btnUlozit";
            this.btnUlozit.Size = new System.Drawing.Size(75, 23);
            this.btnUlozit.TabIndex = 2;
            this.btnUlozit.Text = "Uložit";
            this.btnUlozit.UseVisualStyleBackColor = true;
            this.btnUlozit.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // ZboziManipulationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.btnUlozit);
            this.Controls.Add(this.inputPocet);
            this.Controls.Add(this.listViewZbozi);
            this.Name = "ZboziManipulationDialog";
            this.Text = "Manipulace se zbožím";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
