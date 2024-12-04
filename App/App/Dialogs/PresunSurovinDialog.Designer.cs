namespace App.Dialogs
{
    partial class PresunSurovinDialog
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
            cbSkladZdroj = new ComboBox();
            cbSkladCil = new ComboBox();
            cbSurovina = new ComboBox();
            PresunBtn = new Button();
            CancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numMnozstvi = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numMnozstvi).BeginInit();
            SuspendLayout();
            // 
            // cbSkladZdroj
            // 
            cbSkladZdroj.FormattingEnabled = true;
            cbSkladZdroj.Location = new Point(46, 67);
            cbSkladZdroj.Name = "cbSkladZdroj";
            cbSkladZdroj.Size = new Size(213, 23);
            cbSkladZdroj.TabIndex = 0;
            // 
            // cbSkladCil
            // 
            cbSkladCil.FormattingEnabled = true;
            cbSkladCil.Location = new Point(415, 67);
            cbSkladCil.Name = "cbSkladCil";
            cbSkladCil.Size = new Size(249, 23);
            cbSkladCil.TabIndex = 1;
            // 
            // cbSurovina
            // 
            cbSurovina.FormattingEnabled = true;
            cbSurovina.Location = new Point(222, 169);
            cbSurovina.Name = "cbSurovina";
            cbSurovina.Size = new Size(252, 23);
            cbSurovina.TabIndex = 2;
            // 
            // PresunBtn
            // 
            PresunBtn.DialogResult = DialogResult.OK;
            PresunBtn.Location = new Point(125, 369);
            PresunBtn.Name = "PresunBtn";
            PresunBtn.Size = new Size(122, 23);
            PresunBtn.TabIndex = 4;
            PresunBtn.Text = "Přesunout";
            PresunBtn.UseVisualStyleBackColor = true;
            PresunBtn.Click += PresunBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.DialogResult = DialogResult.Cancel;
            CancelBtn.Location = new Point(489, 369);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(122, 23);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Zrušit";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 36);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Ze skladu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 36);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Do skladu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 139);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Surovina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 242);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Množství";
            // 
            // numMnozstvi
            // 
            numMnozstvi.Location = new Point(282, 277);
            numMnozstvi.Name = "numMnozstvi";
            numMnozstvi.Size = new Size(120, 23);
            numMnozstvi.TabIndex = 10;
            // 
            // PresunSurovinDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numMnozstvi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelBtn);
            Controls.Add(PresunBtn);
            Controls.Add(cbSurovina);
            Controls.Add(cbSkladCil);
            Controls.Add(cbSkladZdroj);
            Name = "PresunSurovinDialog";
            Text = "Přesun Surovin";
            ((System.ComponentModel.ISupportInitialize)numMnozstvi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSkladZdroj;
        private ComboBox cbSkladCil;
        private ComboBox cbSurovina;
        private Button PresunBtn;
        private Button CancelBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numMnozstvi;
    }
}