namespace FractalTheory
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
            pictureBox1 = new DoubleBufferedPictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button8 = new Button();
            button7 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button14 = new Button();
            button13 = new Button();
            button15 = new Button();
            button16 = new Button();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            richTextBox9 = new RichTextBox();
            label9 = new Label();
            button17 = new Button();
            button18 = new Button();
            richTextBox10 = new RichTextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1050, 1050);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1084, 12);
            button1.Name = "button1";
            button1.Size = new Size(134, 56);
            button1.TabIndex = 1;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1224, 12);
            button2.Name = "button2";
            button2.Size = new Size(134, 56);
            button2.TabIndex = 2;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1180, 333);
            button3.Name = "button3";
            button3.Size = new Size(82, 50);
            button3.TabIndex = 3;
            button3.Text = "Up";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1180, 383);
            button4.Name = "button4";
            button4.Size = new Size(82, 50);
            button4.TabIndex = 4;
            button4.Text = "Down";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1268, 333);
            button5.Name = "button5";
            button5.Size = new Size(90, 100);
            button5.TabIndex = 5;
            button5.Text = "Right";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1084, 333);
            button6.Name = "button6";
            button6.Size = new Size(90, 100);
            button6.TabIndex = 6;
            button6.Text = "Left";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(1084, 107);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(134, 39);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "1x";
            richTextBox1.Visible = false;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(1084, 258);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(274, 69);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "X: 0\nY: 0";
            richTextBox2.Visible = false;
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(1224, 180);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(76, 40);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "0,0";
            richTextBox3.Visible = false;
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // richTextBox4
            // 
            richTextBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(1224, 107);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(76, 39);
            richTextBox4.TabIndex = 16;
            richTextBox4.Text = "0,0";
            richTextBox4.Visible = false;
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1224, 76);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 21;
            label1.Text = "Min";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1224, 149);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 22;
            label2.Text = "Max";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1084, 76);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 23;
            label3.Text = "Zoom";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1084, 227);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 24;
            label4.Text = "Offset";
            label4.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(1084, 195);
            button8.Name = "button8";
            button8.Size = new Size(134, 29);
            button8.TabIndex = 8;
            button8.Text = "Zoom-";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1084, 153);
            button7.Name = "button7";
            button7.Size = new Size(134, 29);
            button7.TabIndex = 7;
            button7.Text = "Zoom+";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button12
            // 
            button12.Location = new Point(1327, 180);
            button12.Name = "button12";
            button12.Size = new Size(31, 24);
            button12.TabIndex = 14;
            button12.Text = "Y+";
            button12.UseVisualStyleBackColor = true;
            button12.Visible = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1327, 199);
            button11.Name = "button11";
            button11.Size = new Size(31, 21);
            button11.TabIndex = 15;
            button11.Text = "Y-";
            button11.UseVisualStyleBackColor = true;
            button11.Visible = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1300, 199);
            button10.Name = "button10";
            button10.Size = new Size(30, 21);
            button10.TabIndex = 13;
            button10.Text = "X-";
            button10.UseVisualStyleBackColor = true;
            button10.Visible = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1300, 180);
            button9.Name = "button9";
            button9.Size = new Size(30, 24);
            button9.TabIndex = 12;
            button9.Text = "X+";
            button9.UseVisualStyleBackColor = true;
            button9.Visible = false;
            button9.Click += button9_Click;
            // 
            // button14
            // 
            button14.Location = new Point(1327, 107);
            button14.Name = "button14";
            button14.Size = new Size(31, 24);
            button14.TabIndex = 19;
            button14.Text = "Y+";
            button14.UseVisualStyleBackColor = true;
            button14.Visible = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1327, 125);
            button13.Name = "button13";
            button13.Size = new Size(31, 21);
            button13.TabIndex = 20;
            button13.Text = "Y-";
            button13.UseVisualStyleBackColor = true;
            button13.Visible = false;
            button13.Click += button13_Click;
            // 
            // button15
            // 
            button15.Location = new Point(1297, 125);
            button15.Name = "button15";
            button15.Size = new Size(33, 21);
            button15.TabIndex = 18;
            button15.Text = "X-";
            button15.UseVisualStyleBackColor = true;
            button15.Visible = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(1297, 107);
            button16.Name = "button16";
            button16.Size = new Size(33, 24);
            button16.TabIndex = 17;
            button16.Text = "X+";
            button16.UseVisualStyleBackColor = true;
            button16.Visible = false;
            button16.Click += button16_Click;
            // 
            // richTextBox5
            // 
            richTextBox5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox5.Location = new Point(1231, 541);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(134, 39);
            richTextBox5.TabIndex = 25;
            richTextBox5.Text = "";
            richTextBox5.TextChanged += richTextBox5_TextChanged;
            // 
            // richTextBox6
            // 
            richTextBox6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox6.Location = new Point(1084, 541);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(134, 39);
            richTextBox6.TabIndex = 26;
            richTextBox6.Text = "";
            richTextBox6.TextChanged += richTextBox6_TextChanged;
            // 
            // richTextBox8
            // 
            richTextBox8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox8.Location = new Point(1084, 461);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.Size = new Size(134, 39);
            richTextBox8.TabIndex = 28;
            richTextBox8.Text = "";
            richTextBox8.TextChanged += richTextBox8_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1084, 436);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 29;
            label5.Text = "Variables";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1231, 510);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 30;
            label6.Text = "Angle";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1084, 510);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 31;
            label7.Text = "Start";
            // 
            // richTextBox9
            // 
            richTextBox9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox9.Location = new Point(1084, 614);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.Size = new Size(274, 69);
            richTextBox9.TabIndex = 33;
            richTextBox9.Text = "";
            richTextBox9.TextChanged += richTextBox9_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1084, 583);
            label9.Name = "label9";
            label9.Size = new Size(58, 28);
            label9.TabIndex = 34;
            label9.Text = "Rules";
            // 
            // button17
            // 
            button17.Location = new Point(1157, 736);
            button17.Name = "button17";
            button17.Size = new Size(33, 21);
            button17.TabIndex = 37;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Location = new Point(1157, 718);
            button18.Name = "button18";
            button18.Size = new Size(33, 24);
            button18.TabIndex = 36;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // richTextBox10
            // 
            richTextBox10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox10.Location = new Point(1084, 718);
            richTextBox10.Name = "richTextBox10";
            richTextBox10.ReadOnly = true;
            richTextBox10.Size = new Size(76, 39);
            richTextBox10.TabIndex = 35;
            richTextBox10.Text = "0";
            richTextBox10.TextChanged += richTextBox10_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1084, 687);
            label10.Name = "label10";
            label10.Size = new Size(86, 28);
            label10.TabIndex = 38;
            label10.Text = "Iteration";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1377, 1061);
            Controls.Add(label10);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(richTextBox10);
            Controls.Add(label9);
            Controls.Add(richTextBox9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(richTextBox8);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(richTextBox4);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button8;
        private Button button7;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button14;
        private Button button13;
        private Button button15;
        private Button button16;
        private DoubleBufferedPictureBox pictureBox1;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox8;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox9;
        private Label label9;
        private Button button17;
        private Button button18;
        private RichTextBox richTextBox10;
        private Label label10;
    }
}