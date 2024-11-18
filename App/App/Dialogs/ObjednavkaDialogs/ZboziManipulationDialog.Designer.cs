

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
            listViewZbozi = new ListView();
            inputPocet = new TextBox();
            btnPridat = new Button();
            btnUlozit = new Button();
            SuspendLayout();
            // 
            // listViewZbozi
            // 
            listViewZbozi.FullRowSelect = true;
            listViewZbozi.Location = new Point(12, 12);
            listViewZbozi.Name = "listViewZbozi";
            listViewZbozi.Size = new Size(776, 300);
            listViewZbozi.TabIndex = 0;
            listViewZbozi.UseCompatibleStateImageBehavior = false;
            listViewZbozi.View = View.Details;
            // 
            // inputPocet
            // 
            inputPocet.Location = new Point(12, 330);
            inputPocet.Name = "inputPocet";
            inputPocet.Size = new Size(100, 23);
            inputPocet.TabIndex = 1;
            // 
            // btnPridat
            // 
            btnPridat.Location = new Point(130, 330);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(75, 23);
            btnPridat.TabIndex = 2;
            btnPridat.Text = "Přidat";
            btnPridat.UseVisualStyleBackColor = true;
            btnPridat.Click += BtnPridat_Click;
            // 
            // btnUlozit
            // 
            btnUlozit.Location = new Point(130, 360);
            btnUlozit.Name = "btnUlozit";
            btnUlozit.Size = new Size(75, 23);
            btnUlozit.TabIndex = 2;
            btnUlozit.Text = "Uložit";
            btnUlozit.UseVisualStyleBackColor = true;
            btnUlozit.Click += BtnSave_Click;
            // 
            // ZboziManipulationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPridat);
            Controls.Add(btnUlozit);
            Controls.Add(inputPocet);
            Controls.Add(listViewZbozi);
            Name = "ZboziManipulationDialog";
            Text = "Manipulace se zbožím";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
