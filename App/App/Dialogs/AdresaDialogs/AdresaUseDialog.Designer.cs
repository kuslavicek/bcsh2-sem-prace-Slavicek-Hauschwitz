
namespace App.Dialogs
{
    partial class AdresaUseDialog
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
            lvUsed = new ListView();
            panel1 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvUsed
            // 
            lvUsed.Location = new Point(12, 12);
            lvUsed.Name = "lvUsed";
            lvUsed.Size = new Size(776, 362);
            lvUsed.TabIndex = 0;
            lvUsed.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(1, 380);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 70);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(351, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Zavřít";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AdresaUseDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lvUsed);
            Name = "AdresaUseDialog";
            Text = "AdresaUseDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUsed;
        private Panel panel1;
        private Button btnClose;
    }
}