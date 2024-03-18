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
            new Main(pictureBox1, this);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void updateGUI()
        {
            richTextBox8.Text = string.Join(" ", Main.get().system.variables);
            richTextBox6.Text = Main.get().system.start;
            richTextBox5.Text = Main.get().system.angle.ToString();
            richTextBox10.Text = Main.get().system.iterations.ToString();
            richTextBox9.Lines = Main.get().system.rules.Select(rule => rule.ToString()).ToArray();
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)// Variables
        {
            try
            {
                Main.get().system.variables = richTextBox8.Text.Split(' ').Select(s => s[0]).ToList();
            } catch { }
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)// Start
        {
            try
            {
                Main.get().system.start = richTextBox6.Text;
            } catch { }
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)// Angle
        {
            try
            {
                Main.get().system.angle = float.Parse(richTextBox5.Text);
            } catch
            {
                Main.get().system.angle = 45f;
            }
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)// Iteration
        {
            try
            {
                Main.get().system.iterations = int.Parse(richTextBox10.Text);
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)// Iteration +
        {
            try
            {
                richTextBox10.Text = $"{++Main.get().system.iterations}";
            }
            catch { }
        }

        private void button17_Click(object sender, EventArgs e)// Iteartion -
        {
            try
            {
                richTextBox10.Text = $"{--Main.get().system.iterations}";
            }
            catch { }
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<LSystem.Rule> rules = new List<LSystem.Rule>();
                foreach (string line in richTextBox9.Lines)
                {
                    string[] split = line.Split(' ');
                    rules.Add(new(split[0][0], split[1]));
                }
                Main.get().system.rules = rules;
            }
            catch { }
        }
    }
}