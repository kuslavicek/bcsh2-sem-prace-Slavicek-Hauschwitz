namespace App.Dialogs
{
    partial class LoginDialog
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
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbPass = new TextBox();
            buttonZrusit = new Button();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 46);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Uživatelské jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 100);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Heslo";
            // 
            // tbName
            // 
            tbName.Location = new Point(224, 43);
            tbName.Name = "tbName";
            tbName.Size = new Size(262, 23);
            tbName.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(224, 97);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(262, 23);
            tbPass.TabIndex = 3;
            // 
            // buttonZrusit
            // 
            buttonZrusit.Location = new Point(79, 196);
            buttonZrusit.Name = "buttonZrusit";
            buttonZrusit.Size = new Size(173, 23);
            buttonZrusit.TabIndex = 4;
            buttonZrusit.Text = "Zrušit";
            buttonZrusit.UseVisualStyleBackColor = true;
            buttonZrusit.Click += buttonZrusit_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(433, 196);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(184, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Potvrdit";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // LoginDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 272);
            Controls.Add(buttonOk);
            Controls.Add(buttonZrusit);
            Controls.Add(tbPass);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginDialog";
            Text = "Přihlásit se";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbPass;
        private Button buttonZrusit;
        private Button buttonOk;
    }
}