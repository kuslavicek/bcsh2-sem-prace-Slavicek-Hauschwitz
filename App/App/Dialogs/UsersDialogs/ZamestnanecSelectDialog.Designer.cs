namespace App.Dialogs.UsersDialogs
{
    partial class ZamestnanecSelectDialog
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
            lvEmp = new ListView();
            panel1 = new Panel();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvEmp
            // 
            lvEmp.Location = new Point(12, 12);
            lvEmp.Name = "lvEmp";
            lvEmp.Size = new Size(776, 359);
            lvEmp.TabIndex = 0;
            lvEmp.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(1, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 75);
            panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(360, 24);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ZamestnanecSelectDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lvEmp);
            Name = "ZamestnanecSelectDialog";
            Text = "ZamestnanecSelectDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvEmp;
        private Panel panel1;
        private Button btnSave;
    }
}