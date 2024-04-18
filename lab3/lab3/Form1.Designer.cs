namespace lab3
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label8 = new Label();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            trackBar1 = new TrackBar();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(326, 294);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 1;
            button1.Text = "start!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 6F);
            textBox1.Location = new Point(56, 38);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 143);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 6F);
            textBox2.Location = new Point(301, 38);
            textBox2.Margin = new Padding(4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 143);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 6F);
            textBox3.Location = new Point(536, 38);
            textBox3.Margin = new Padding(4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 143);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 101);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 5;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 101);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 6;
            label2.Text = "=";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(182, 254);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 236);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 8;
            label3.Text = "Number of threads:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(458, 254);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(131, 23);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 236);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 10;
            label4.Text = "Matrix size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 376);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(448, 300);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 185);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 13;
            label7.Text = "seed:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.ImeMode = ImeMode.Disable;
            numericUpDown3.Location = new Point(99, 184);
            numericUpDown3.Margin = new Padding(3, 2, 3, 2);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(60, 23);
            numericUpDown3.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(344, 184);
            numericUpDown4.Margin = new Padding(3, 2, 3, 2);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(58, 23);
            numericUpDown4.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 188);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 16;
            label8.Text = "seed:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(806, 38);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(297, 499);
            listBox1.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(42, 254);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Show matrices";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(595, 254);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Maximum = 15;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(206, 45);
            trackBar1.TabIndex = 19;
            trackBar1.Value = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(608, 236);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 20;
            label9.Text = "Text size";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(42, 300);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Thread";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(42, 325);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 22;
            radioButton2.Text = "Parallel";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1169, 551);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label9);
            Controls.Add(trackBar1);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Controls.Add(label8);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label8;
        public ListBox listBox1;
        private CheckBox checkBox1;
        private TrackBar trackBar1;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
