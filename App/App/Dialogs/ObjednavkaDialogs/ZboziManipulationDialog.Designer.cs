

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
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            inputPocet.Location = new Point(349, 330);
            inputPocet.Name = "inputPocet";
            inputPocet.Size = new Size(100, 23);
            inputPocet.TabIndex = 1;
            // 
            // btnPridat
            // 
            btnPridat.Location = new Point(455, 330);
            btnPridat.Name = "btnPridat";
            btnPridat.Size = new Size(75, 23);
            btnPridat.TabIndex = 2;
            btnPridat.Text = "Přidat";
            btnPridat.UseVisualStyleBackColor = true;
            btnPridat.Click += BtnPridat_Click;
            // 
            // btnUlozit
            // 
            btnUlozit.Location = new Point(348, 25);
            btnUlozit.Name = "btnUlozit";
            btnUlozit.Size = new Size(100, 30);
            btnUlozit.TabIndex = 2;
            btnUlozit.Text = "Uložit";
            btnUlozit.UseVisualStyleBackColor = true;
            btnUlozit.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 333);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Počet:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnUlozit);
            panel1.Location = new Point(1, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 81);
            panel1.TabIndex = 4;
            // 
            // ZboziManipulationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPridat);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(inputPocet);
            Controls.Add(listViewZbozi);
            Name = "ZboziManipulationDialog";
            Text = "Manipulace se zbožím";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
    }
}
