namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            DeleteZboziBtn = new Button();
            InsertZboziBtn = new Button();
            updateZboziBtn = new Button();
            lvCidery = new ListView();
            lvPiva = new ListView();
            tabPage2 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1296, 785);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(DeleteZboziBtn);
            tabPage1.Controls.Add(InsertZboziBtn);
            tabPage1.Controls.Add(updateZboziBtn);
            tabPage1.Controls.Add(lvCidery);
            tabPage1.Controls.Add(lvPiva);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1288, 757);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(18, 362);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 6;
            label2.Text = "Cidery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 5;
            label1.Text = "Piva";
            // 
            // DeleteZboziBtn
            // 
            DeleteZboziBtn.Location = new Point(978, 252);
            DeleteZboziBtn.Name = "DeleteZboziBtn";
            DeleteZboziBtn.Size = new Size(269, 23);
            DeleteZboziBtn.TabIndex = 4;
            DeleteZboziBtn.Text = "Smazat Zboží";
            DeleteZboziBtn.UseVisualStyleBackColor = true;
            DeleteZboziBtn.Click += DeleteZboziBtn_Click;
            // 
            // InsertZboziBtn
            // 
            InsertZboziBtn.Location = new Point(978, 164);
            InsertZboziBtn.Name = "InsertZboziBtn";
            InsertZboziBtn.Size = new Size(269, 23);
            InsertZboziBtn.TabIndex = 3;
            InsertZboziBtn.Text = "Vložit Zboží";
            InsertZboziBtn.UseVisualStyleBackColor = true;
            InsertZboziBtn.Click += InsertZboziBtn_Click;
            // 
            // updateZboziBtn
            // 
            updateZboziBtn.Location = new Point(977, 91);
            updateZboziBtn.Name = "updateZboziBtn";
            updateZboziBtn.Size = new Size(270, 23);
            updateZboziBtn.TabIndex = 2;
            updateZboziBtn.Text = "Upravit Zboží";
            updateZboziBtn.UseVisualStyleBackColor = true;
            updateZboziBtn.Click += updateZboziBtn_Click;
            // 
            // lvCidery
            // 
            lvCidery.Location = new Point(18, 386);
            lvCidery.Name = "lvCidery";
            lvCidery.Size = new Size(875, 294);
            lvCidery.TabIndex = 1;
            lvCidery.UseCompatibleStateImageBehavior = false;
            lvCidery.SelectedIndexChanged += lvCidery_SelectedIndexChanged;
            // 
            // lvPiva
            // 
            lvPiva.Location = new Point(18, 55);
            lvPiva.Name = "lvPiva";
            lvPiva.Size = new Size(878, 304);
            lvPiva.TabIndex = 0;
            lvPiva.UseCompatibleStateImageBehavior = false;
            lvPiva.SelectedIndexChanged += lvPiva_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1288, 757);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(506, 335);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(506, 103);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 809);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button DeleteZboziBtn;
        private Button InsertZboziBtn;
        private Button updateZboziBtn;
        private ListView lvCidery;
        private ListView lvPiva;
        private Button button5;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}
