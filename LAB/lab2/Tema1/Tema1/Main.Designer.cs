namespace Tema1
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BlocksTrafic = new System.Windows.Forms.CheckBox();
            this.IlegalParking = new System.Windows.Forms.CheckBox();
            this.HydrantParking = new System.Windows.Forms.CheckBox();
            this.C = new System.Windows.Forms.GroupBox();
            this.VolksWagen = new System.Windows.Forms.RadioButton();
            this.Skoda = new System.Windows.Forms.RadioButton();
            this.Audi = new System.Windows.Forms.RadioButton();
            this.Add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.C.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.ViewCarToolStripMenuItem,
            this.addCarToolStripMenuItem,
            this.removeCarsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // ViewCarToolStripMenuItem
            // 
            this.ViewCarToolStripMenuItem.Name = "ViewCarToolStripMenuItem";
            this.ViewCarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.ViewCarToolStripMenuItem.Text = "View Cars";
            this.ViewCarToolStripMenuItem.Click += new System.EventHandler(this.removeCarToolStripMenuItem_Click);
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // removeCarsToolStripMenuItem
            // 
            this.removeCarsToolStripMenuItem.Name = "removeCarsToolStripMenuItem";
            this.removeCarsToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.removeCarsToolStripMenuItem.Text = "Remove Cars";
            this.removeCarsToolStripMenuItem.Click += new System.EventHandler(this.removeCarsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 417);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click on View Cars to view the cars in the right pannel\r\nClick Add car to add car" +
    "\r\nClick remove car to remove car\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car impound application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(15, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 417);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select the car from the list and than hit the button";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 130);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.C);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Location = new System.Drawing.Point(12, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 390);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlocksTrafic);
            this.groupBox2.Controls.Add(this.IlegalParking);
            this.groupBox2.Controls.Add(this.HydrantParking);
            this.groupBox2.Location = new System.Drawing.Point(287, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reason";
            // 
            // BlocksTrafic
            // 
            this.BlocksTrafic.AutoSize = true;
            this.BlocksTrafic.Location = new System.Drawing.Point(32, 47);
            this.BlocksTrafic.Name = "BlocksTrafic";
            this.BlocksTrafic.Size = new System.Drawing.Size(104, 20);
            this.BlocksTrafic.TabIndex = 6;
            this.BlocksTrafic.Text = "BlocksTrafic";
            this.BlocksTrafic.UseVisualStyleBackColor = true;
            // 
            // IlegalParking
            // 
            this.IlegalParking.AutoSize = true;
            this.IlegalParking.Location = new System.Drawing.Point(32, 20);
            this.IlegalParking.Name = "IlegalParking";
            this.IlegalParking.Size = new System.Drawing.Size(111, 20);
            this.IlegalParking.TabIndex = 5;
            this.IlegalParking.Text = "Ilegal Parking";
            this.IlegalParking.UseVisualStyleBackColor = true;
            // 
            // HydrantParking
            // 
            this.HydrantParking.AutoSize = true;
            this.HydrantParking.Location = new System.Drawing.Point(32, 73);
            this.HydrantParking.Name = "HydrantParking";
            this.HydrantParking.Size = new System.Drawing.Size(124, 20);
            this.HydrantParking.TabIndex = 7;
            this.HydrantParking.Text = "Hydrant parking";
            this.HydrantParking.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Controls.Add(this.VolksWagen);
            this.C.Controls.Add(this.Skoda);
            this.C.Controls.Add(this.Audi);
            this.C.Location = new System.Drawing.Point(42, 99);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(200, 100);
            this.C.TabIndex = 9;
            this.C.TabStop = false;
            this.C.Text = "Car Type";
            // 
            // VolksWagen
            // 
            this.VolksWagen.AutoSize = true;
            this.VolksWagen.Location = new System.Drawing.Point(24, 21);
            this.VolksWagen.Name = "VolksWagen";
            this.VolksWagen.Size = new System.Drawing.Size(106, 20);
            this.VolksWagen.TabIndex = 2;
            this.VolksWagen.TabStop = true;
            this.VolksWagen.Text = "VolksWagen";
            this.VolksWagen.UseVisualStyleBackColor = true;
            this.VolksWagen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Skoda
            // 
            this.Skoda.AutoSize = true;
            this.Skoda.Location = new System.Drawing.Point(24, 47);
            this.Skoda.Name = "Skoda";
            this.Skoda.Size = new System.Drawing.Size(68, 20);
            this.Skoda.TabIndex = 3;
            this.Skoda.TabStop = true;
            this.Skoda.Text = "Skoda";
            this.Skoda.UseVisualStyleBackColor = true;
            // 
            // Audi
            // 
            this.Audi.AutoSize = true;
            this.Audi.Location = new System.Drawing.Point(24, 73);
            this.Audi.Name = "Audi";
            this.Audi.Size = new System.Drawing.Size(55, 20);
            this.Audi.TabIndex = 4;
            this.Audi.TabStop = true;
            this.Audi.Text = "Audi";
            this.Audi.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(114, 240);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(262, 113);
            this.Add.TabIndex = 8;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(520, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(280, 428);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.C.ResumeLayout(false);
            this.C.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCarsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton VolksWagen;
        private System.Windows.Forms.RadioButton Skoda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox HydrantParking;
        private System.Windows.Forms.CheckBox BlocksTrafic;
        private System.Windows.Forms.CheckBox IlegalParking;
        private System.Windows.Forms.RadioButton Audi;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox C;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}