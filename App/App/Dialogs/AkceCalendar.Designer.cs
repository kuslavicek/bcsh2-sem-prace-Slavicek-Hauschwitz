namespace App.Dialogs
{
    partial class AkceCalendar
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
            kalendar = new MonthCalendar();
            panel1 = new Panel();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // kalendar
            // 
            kalendar.CalendarDimensions = new Size(4, 3);
            kalendar.Location = new Point(18, 18);
            kalendar.Name = "kalendar";
            kalendar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnCancel);
            panel1.Location = new Point(2, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 59);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(273, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Zavřít";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AkceCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 529);
            Controls.Add(panel1);
            Controls.Add(kalendar);
            Name = "AkceCalendar";
            Text = "AkceCalendar";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar kalendar;
        private Panel panel1;
        private Button btnCancel;
    }
}