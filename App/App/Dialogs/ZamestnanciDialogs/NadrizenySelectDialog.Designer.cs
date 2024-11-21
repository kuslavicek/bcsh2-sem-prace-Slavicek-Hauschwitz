namespace App.Dialogs.ZamestnanciDialogs
{
    partial class NadrizenySelectDialog
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
            btnSave = new Button();
            panel1 = new Panel();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvEmp
            // 
            lvEmp.Location = new Point(12, 12);
            lvEmp.Name = "lvEmp";
            lvEmp.Size = new Size(776, 331);
            lvEmp.TabIndex = 0;
            lvEmp.UseCompatibleStateImageBehavior = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(208, 34);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 35);
            btnSave.TabIndex = 1;
            btnSave.Text = "Potvrdit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(1, 349);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 100);
            panel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(398, 34);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // NadrizenySelectDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lvEmp);
            Name = "NadrizenySelectDialog";
            Text = "NadrizenySelectDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvEmp;
        private Button btnSave;
        private Panel panel1;
        private Button btnCancel;
    }
}