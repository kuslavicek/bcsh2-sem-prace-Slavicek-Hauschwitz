namespace App.Dialogs
{
    partial class AdresaDialogs
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
            txtUlice = new TextBox();
            comboStat = new ComboBox();
            txtMesto = new TextBox();
            txtPsc = new TextBox();
            txtCisloPopisne = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUlice
            // 
            txtUlice.Location = new Point(159, 44);
            txtUlice.Name = "txtUlice";
            txtUlice.Size = new Size(164, 23);
            txtUlice.TabIndex = 0;
            // 
            // comboStat
            // 
            comboStat.FormattingEnabled = true;
            comboStat.Location = new Point(159, 165);
            comboStat.Name = "comboStat";
            comboStat.Size = new Size(164, 23);
            comboStat.TabIndex = 1;
            // 
            // txtMesto
            // 
            txtMesto.Location = new Point(159, 77);
            txtMesto.Name = "txtMesto";
            txtMesto.Size = new Size(164, 23);
            txtMesto.TabIndex = 2;
            // 
            // txtPsc
            // 
            txtPsc.Location = new Point(159, 107);
            txtPsc.Name = "txtPsc";
            txtPsc.Size = new Size(164, 23);
            txtPsc.TabIndex = 3;
            // 
            // txtCisloPopisne
            // 
            txtCisloPopisne.Location = new Point(159, 136);
            txtCisloPopisne.Name = "txtCisloPopisne";
            txtCisloPopisne.Size = new Size(164, 23);
            txtCisloPopisne.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 80);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "Ulice:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 47);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Město:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 110);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "PSČ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 139);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Číslo popisné:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 168);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Stát:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(0, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 74);
            panel1.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(309, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(72, 21);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AdresaDialogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 286);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCisloPopisne);
            Controls.Add(txtPsc);
            Controls.Add(txtMesto);
            Controls.Add(comboStat);
            Controls.Add(txtUlice);
            Name = "AdresaDialogs";
            Text = "AdresaDialogs";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUlice;
        private ComboBox comboStat;
        private TextBox txtMesto;
        private TextBox txtPsc;
        private TextBox txtCisloPopisne;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
    }
}