namespace FractalTheory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Main(pictureBox1);
            Main.get().Draw();
            richTextBox4.Text = Main.min.X + "," + Main.min.Y;
            richTextBox3.Text = Main.max.X + "," + Main.max.Y;
            richTextBox2.Text = Main.offset.X + "," + Main.offset.Y;
            richTextBox1.Text = Main.zoom + "x";
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.get().Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.get().ClearGraph();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Main.min.X++;
            richTextBox4.Text = Main.min.X + "," + Main.min.Y;
            Main.get().Draw();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Main.min.X--;
            richTextBox4.Text = Main.min.X + "," + Main.min.Y;
            Main.get().Draw();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Main.min.Y++;
            richTextBox4.Text = Main.min.X + "," + Main.min.Y;
            Main.get().Draw();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Main.min.Y--;
            richTextBox4.Text = Main.min.X + "," + Main.min.Y;
            Main.get().Draw();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e) { }

        private void button9_Click(object sender, EventArgs e)
        {
            Main.max.X++;
            richTextBox3.Text = Main.max.X + "," + Main.max.Y;
            Main.get().Draw();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Main.max.X--;
            richTextBox3.Text = Main.max.X + "," + Main.max.Y;
            Main.get().Draw();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Main.max.Y++;
            richTextBox3.Text = Main.max.X + "," + Main.max.Y;
            Main.get().Draw();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Main.max.Y--;
            richTextBox3.Text = Main.max.X + "," + Main.max.Y;
            Main.get().Draw();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e) { }

        private void button7_Click(object sender, EventArgs e)
        {
            Main.zoom *= 2;
            richTextBox1.Text = Main.zoom + "x";
            Main.get().Draw();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Main.zoom /= 2;
            richTextBox1.Text = Main.zoom + "x";
            Main.get().Draw();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            Main.offset.Y -= 1.0d / Main.zoom;// Up
            richTextBox2.Text = Main.offset.X + "," + Main.offset.Y;
            Main.get().Draw();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main.offset.Y += 1.0d / Main.zoom;// Down
            richTextBox2.Text = Main.offset.X + "," + Main.offset.Y;
            Main.get().Draw();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main.offset.X -= 1.0d / Main.zoom;// Left
            richTextBox2.Text = Main.offset.X + "," + Main.offset.Y;
            Main.get().Draw();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main.offset.X += 1.0d / Main.zoom;// Right
            richTextBox2.Text = Main.offset.X + "," + Main.offset.Y;
            Main.get().Draw();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
    }
}