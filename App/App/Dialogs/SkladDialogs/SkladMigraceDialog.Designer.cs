namespace App.Dialogs.SkladDialogs
{
    partial class SkladMigraceDialog
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
            comboZ = new ComboBox();
            comboDo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            checkZbozi = new CheckBox();
            checkSuroviny = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboZ
            // 
            comboZ.FormattingEnabled = true;
            comboZ.Location = new Point(109, 64);
            comboZ.Name = "comboZ";
            comboZ.Size = new Size(109, 23);
            comboZ.TabIndex = 2;
            // 
            // comboDo
            // 
            comboDo.FormattingEnabled = true;
            comboDo.Location = new Point(301, 64);
            comboDo.Name = "comboDo";
            comboDo.Size = new Size(109, 23);
            comboDo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 67);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Ze skladu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 67);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Do skladu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Location = new Point(0, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 98);
            panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 33);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zavřít";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(109, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Potvrdit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // checkZbozi
            // 
            checkZbozi.AutoSize = true;
            checkZbozi.Location = new Point(109, 119);
            checkZbozi.Name = "checkZbozi";
            checkZbozi.Size = new Size(55, 19);
            checkZbozi.TabIndex = 7;
            checkZbozi.Text = "Zboží";
            checkZbozi.UseVisualStyleBackColor = true;
            // 
            // checkSuroviny
            // 
            checkSuroviny.AutoSize = true;
            checkSuroviny.Location = new Point(301, 119);
            checkSuroviny.Name = "checkSuroviny";
            checkSuroviny.Size = new Size(72, 19);
            checkSuroviny.TabIndex = 8;
            checkSuroviny.Text = "Suroviny";
            checkSuroviny.UseVisualStyleBackColor = true;
            // 
            // SkladMigraceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 260);
            Controls.Add(checkSuroviny);
            Controls.Add(checkZbozi);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboDo);
            Controls.Add(comboZ);
            Name = "SkladMigraceDialog";
            Text = "SkladMigraceDialog";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboZ;
        private ComboBox comboDo;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox checkZbozi;
        private CheckBox checkSuroviny;
    }
}