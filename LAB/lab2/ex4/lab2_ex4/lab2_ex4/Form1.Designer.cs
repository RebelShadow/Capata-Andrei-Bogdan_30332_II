namespace lab2_ex4
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Mures = new System.Windows.Forms.RadioButton();
            this.Nasaud = new System.Windows.Forms.RadioButton();
            this.Iulia = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Targu = new System.Windows.Forms.RadioButton();
            this.Bistrita = new System.Windows.Forms.RadioButton();
            this.Alba = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.radioButton4);
            this.tabPage1.Controls.Add(this.radioButton3);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(195, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 391);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(42, 289);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Lancia";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(42, 208);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mercedes-Benz";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(42, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Audi";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BMW";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Mures);
            this.panel3.Controls.Add(this.Nasaud);
            this.panel3.Controls.Add(this.Iulia);
            this.panel3.Location = new System.Drawing.Point(251, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 140);
            this.panel3.TabIndex = 8;
            // 
            // Mures
            // 
            this.Mures.AutoSize = true;
            this.Mures.Location = new System.Drawing.Point(20, 47);
            this.Mures.Name = "Mures";
            this.Mures.Size = new System.Drawing.Size(65, 20);
            this.Mures.TabIndex = 1;
            this.Mures.TabStop = true;
            this.Mures.Text = "Mureș";
            this.Mures.UseVisualStyleBackColor = true;
            this.Mures.CheckedChanged += new System.EventHandler(this.Mures_CheckedChanged);
            // 
            // Nasaud
            // 
            this.Nasaud.AutoSize = true;
            this.Nasaud.Location = new System.Drawing.Point(20, 4);
            this.Nasaud.Name = "Nasaud";
            this.Nasaud.Size = new System.Drawing.Size(76, 20);
            this.Nasaud.TabIndex = 0;
            this.Nasaud.TabStop = true;
            this.Nasaud.Text = "Năsăud";
            this.Nasaud.UseVisualStyleBackColor = true;
            this.Nasaud.CheckedChanged += new System.EventHandler(this.Nasaud_CheckedChanged);
            // 
            // Iulia
            // 
            this.Iulia.AutoSize = true;
            this.Iulia.Location = new System.Drawing.Point(20, 94);
            this.Iulia.Name = "Iulia";
            this.Iulia.Size = new System.Drawing.Size(52, 20);
            this.Iulia.TabIndex = 2;
            this.Iulia.TabStop = true;
            this.Iulia.Text = "Iulia";
            this.Iulia.UseVisualStyleBackColor = true;
            this.Iulia.CheckedChanged += new System.EventHandler(this.Iulia_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Targu);
            this.panel2.Controls.Add(this.Bistrita);
            this.panel2.Controls.Add(this.Alba);
            this.panel2.Location = new System.Drawing.Point(49, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 140);
            this.panel2.TabIndex = 7;
            // 
            // Targu
            // 
            this.Targu.AutoSize = true;
            this.Targu.Location = new System.Drawing.Point(20, 47);
            this.Targu.Name = "Targu";
            this.Targu.Size = new System.Drawing.Size(64, 20);
            this.Targu.TabIndex = 1;
            this.Targu.TabStop = true;
            this.Targu.Text = "Târgu";
            this.Targu.UseVisualStyleBackColor = true;
            this.Targu.CheckedChanged += new System.EventHandler(this.Targu_CheckedChanged);
            // 
            // Bistrita
            // 
            this.Bistrita.AutoSize = true;
            this.Bistrita.Location = new System.Drawing.Point(20, 4);
            this.Bistrita.Name = "Bistrita";
            this.Bistrita.Size = new System.Drawing.Size(68, 20);
            this.Bistrita.TabIndex = 0;
            this.Bistrita.TabStop = true;
            this.Bistrita.Text = "Bistrița";
            this.Bistrita.UseVisualStyleBackColor = true;
            this.Bistrita.CheckedChanged += new System.EventHandler(this.Bistrita_CheckedChanged);
            // 
            // Alba
            // 
            this.Alba.AutoSize = true;
            this.Alba.Location = new System.Drawing.Point(20, 94);
            this.Alba.Name = "Alba";
            this.Alba.Size = new System.Drawing.Size(56, 20);
            this.Alba.TabIndex = 2;
            this.Alba.TabStop = true;
            this.Alba.Text = "Alba";
            this.Alba.UseVisualStyleBackColor = true;
            this.Alba.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Alba;
        private System.Windows.Forms.RadioButton Targu;
        private System.Windows.Forms.RadioButton Bistrita;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Mures;
        private System.Windows.Forms.RadioButton Nasaud;
        private System.Windows.Forms.RadioButton Iulia;
        private System.Windows.Forms.Panel panel2;
    }
}

