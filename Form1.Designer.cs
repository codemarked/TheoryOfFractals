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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            richTextBox4 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            button3.Location = new Point(1180, 513);
            button3.Name = "button3";
            button3.Size = new Size(82, 50);
            button3.TabIndex = 3;
            button3.Text = "Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1180, 563);
            button4.Name = "button4";
            button4.Size = new Size(82, 50);
            button4.TabIndex = 4;
            button4.Text = "Down";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1268, 513);
            button5.Name = "button5";
            button5.Size = new Size(90, 100);
            button5.TabIndex = 5;
            button5.Text = "Right";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1084, 513);
            button6.Name = "button6";
            button6.Size = new Size(90, 100);
            button6.TabIndex = 6;
            button6.Text = "Left";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1224, 321);
            button7.Name = "button7";
            button7.Size = new Size(134, 29);
            button7.TabIndex = 7;
            button7.Text = "Zoom+";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1224, 356);
            button8.Name = "button8";
            button8.Size = new Size(134, 29);
            button8.TabIndex = 8;
            button8.Text = "Zoom-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(1084, 325);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(134, 60);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "1x";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(1084, 428);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(274, 69);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "X: 0\nY: 0";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(1084, 220);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(134, 60);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "0,0";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // button9
            // 
            button9.Location = new Point(1224, 220);
            button9.Name = "button9";
            button9.Size = new Size(65, 30);
            button9.TabIndex = 12;
            button9.Text = "X+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1224, 250);
            button10.Name = "button10";
            button10.Size = new Size(65, 30);
            button10.TabIndex = 13;
            button10.Text = "X-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1295, 250);
            button11.Name = "button11";
            button11.Size = new Size(63, 30);
            button11.TabIndex = 15;
            button11.Text = "Y-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(1295, 220);
            button12.Name = "button12";
            button12.Size = new Size(63, 30);
            button12.TabIndex = 14;
            button12.Text = "Y+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1295, 137);
            button13.Name = "button13";
            button13.Size = new Size(63, 30);
            button13.TabIndex = 20;
            button13.Text = "Y-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(1295, 107);
            button14.Name = "button14";
            button14.Size = new Size(63, 30);
            button14.TabIndex = 19;
            button14.Text = "Y+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(1224, 137);
            button15.Name = "button15";
            button15.Size = new Size(65, 30);
            button15.TabIndex = 18;
            button15.Text = "X-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(1224, 107);
            button16.Name = "button16";
            button16.Size = new Size(65, 30);
            button16.TabIndex = 17;
            button16.Text = "X+";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(1084, 107);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(134, 60);
            richTextBox4.TabIndex = 16;
            richTextBox4.Text = "0,0";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1084, 71);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 21;
            label1.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1084, 183);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 22;
            label2.Text = "Max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1084, 294);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 23;
            label3.Text = "Zoom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1084, 397);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 24;
            label4.Text = "Offset";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1377, 1061);
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

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private RichTextBox richTextBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}