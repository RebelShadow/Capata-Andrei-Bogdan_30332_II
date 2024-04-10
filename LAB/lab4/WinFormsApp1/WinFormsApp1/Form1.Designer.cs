namespace WinFormsApp1
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
            listBox_List = new ListBox();
            buttonList = new Button();
            textBoxC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxF = new TextBox();
            label3 = new Label();
            textBoxR = new TextBox();
            buttonFC = new Button();
            buttonCF = new Button();
            label4 = new Label();
            textBox_Date = new TextBox();
            textBoxRon = new TextBox();
            textBoxEur = new TextBox();
            label5 = new Label();
            buttonDate = new Button();
            buttonConv = new Button();
            SuspendLayout();
            // 
            // listBox_List
            // 
            listBox_List.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_List.FormattingEnabled = true;
            listBox_List.HorizontalScrollbar = true;
            listBox_List.Location = new Point(32, 24);
            listBox_List.Name = "listBox_List";
            listBox_List.Size = new Size(274, 224);
            listBox_List.TabIndex = 0;
            // 
            // buttonList
            // 
            buttonList.Location = new Point(74, 264);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(173, 51);
            buttonList.TabIndex = 1;
            buttonList.Text = "Add List";
            buttonList.UseVisualStyleBackColor = true;
            buttonList.Click += buttonList_Click;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(539, 24);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(210, 38);
            textBoxC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 27);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 3;
            label1.Text = "Degrees C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 94);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 5;
            label2.Text = "Degrees F";
            // 
            // textBoxF
            // 
            textBoxF.Location = new Point(539, 91);
            textBoxF.Name = "textBoxF";
            textBoxF.Size = new Size(210, 38);
            textBoxF.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 164);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 7;
            label3.Text = "Result";
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(539, 161);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(210, 38);
            textBoxR.TabIndex = 6;
            // 
            // buttonFC
            // 
            buttonFC.Location = new Point(575, 225);
            buttonFC.Name = "buttonFC";
            buttonFC.Size = new Size(138, 43);
            buttonFC.TabIndex = 8;
            buttonFC.Text = "FtoC";
            buttonFC.UseVisualStyleBackColor = true;
            buttonFC.Click += buttonFC_Click;
            // 
            // buttonCF
            // 
            buttonCF.Location = new Point(575, 289);
            buttonCF.Name = "buttonCF";
            buttonCF.Size = new Size(138, 43);
            buttonCF.TabIndex = 9;
            buttonCF.Text = "CtoF";
            buttonCF.UseVisualStyleBackColor = true;
            buttonCF.Click += buttonCF_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 346);
            label4.Name = "label4";
            label4.Size = new Size(62, 31);
            label4.TabIndex = 10;
            label4.Text = "Date";
            // 
            // textBox_Date
            // 
            textBox_Date.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Date.Location = new Point(37, 380);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(269, 30);
            textBox_Date.TabIndex = 11;
            // 
            // textBoxRon
            // 
            textBoxRon.Location = new Point(539, 380);
            textBoxRon.Name = "textBoxRon";
            textBoxRon.Size = new Size(210, 38);
            textBoxRon.TabIndex = 12;
            // 
            // textBoxEur
            // 
            textBoxEur.Location = new Point(539, 448);
            textBoxEur.Name = "textBoxEur";
            textBoxEur.Size = new Size(210, 38);
            textBoxEur.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 383);
            label5.Name = "label5";
            label5.Size = new Size(137, 31);
            label5.TabIndex = 14;
            label5.Text = "Ron to Euro:";
            // 
            // buttonDate
            // 
            buttonDate.Location = new Point(37, 425);
            buttonDate.Name = "buttonDate";
            buttonDate.Size = new Size(127, 42);
            buttonDate.TabIndex = 15;
            buttonDate.Text = "Get Date";
            buttonDate.UseVisualStyleBackColor = true;
            buttonDate.Click += buttonDate_Click;
            // 
            // buttonConv
            // 
            buttonConv.Location = new Point(407, 447);
            buttonConv.Name = "buttonConv";
            buttonConv.Size = new Size(105, 38);
            buttonConv.TabIndex = 16;
            buttonConv.Text = "Convert";
            buttonConv.UseVisualStyleBackColor = true;
            buttonConv.Click += buttonConv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 534);
            Controls.Add(buttonConv);
            Controls.Add(buttonDate);
            Controls.Add(label5);
            Controls.Add(textBoxEur);
            Controls.Add(textBoxRon);
            Controls.Add(textBox_Date);
            Controls.Add(label4);
            Controls.Add(buttonCF);
            Controls.Add(buttonFC);
            Controls.Add(label3);
            Controls.Add(textBoxR);
            Controls.Add(label2);
            Controls.Add(textBoxF);
            Controls.Add(label1);
            Controls.Add(textBoxC);
            Controls.Add(buttonList);
            Controls.Add(listBox_List);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_List;
        private Button buttonList;
        private TextBox textBoxC;
        private Label label1;
        private Label label2;
        private TextBox textBoxF;
        private Label label3;
        private TextBox textBoxR;
        private Button buttonFC;
        private Button buttonCF;
        private Label label4;
        private TextBox textBox_Date;
        private TextBox textBoxRon;
        private TextBox textBoxEur;
        private Label label5;
        private Button buttonDate;
        private Button buttonConv;
    }
}
