using System.Windows.Forms;

namespace FractalTheory
{
    public class Main
    {
        private static Main INSTANCE;

        public static Main get()
        {
            return INSTANCE;
        }
        public Graphics graphics { get; }

        private PictureBox pictureBox;
        private Bitmap bitMap;

        public static int MaxIterations = 100;
        public static double EscapeRadius = 2.0;

        public static double zoom = 1;
        public static Vector2d min = new(-2, -2), max = new(2, 2), offset = new(0, 0);

        public LSystem system { get; set; }

        public Main(PictureBox box, Form1 form1)
        {
            INSTANCE = this;
            this.pictureBox = box;
            this.bitMap = new(box.Width, box.Height);
            this.graphics = Graphics.FromImage(this.bitMap);
            this.pictureBox.BackColor = Color.White;
            this.system = new LSystem();
            this.system.Init();
            form1.updateGUI();
        }

        public void Draw()
        {
            float x = bitMap.Width / 2;
            float y = bitMap.Height / 2;
            float angle = system.angle;
            
            Stack<Tuple<PointF, float>> stack = new Stack<Tuple<PointF, float>>();
            foreach (char c in this.system.Iterate())
            {
                switch (c)
                {
                    case 'F':
                    case 'G':
                        float newX = x + (float)Math.Cos(angle * (float)Math.PI / 180);
                        float newY = y - (float)Math.Sin(angle * (float)Math.PI / 180);
                        this.graphics.DrawLine(Pens.Black, x, y, newX, newY);
                        x = newX;
                        y = newY;
                        break;
                    case '+':
                        angle -= system.angle;
                        break;
                    case '-':
                        angle += system.angle;
                        break;
                    case '[':
                        stack.Push(new Tuple<PointF, float>(new PointF(x, y), angle));
                        break;
                    case ']':
                        var state = stack.Pop();
                        x = state.Item1.X;
                        y = state.Item1.Y;
                        angle = state.Item2;
                        break;
                }
            }
            this.RefreshGraph();
            pictureBox.Update();
        }

        public void DrawB()
        {
            double width = bitMap.Width;
            double height = bitMap.Height;
            double minX = min.X / zoom + offset.X;
            double minY = min.Y / zoom + offset.Y;
            double maxX = max.X / zoom + offset.X;
            double maxY = max.Y / zoom + offset.Y;
            for (double y = 0; y < height; y++)
            {
                for (double x = 0; x < width; x++)
                {
                    Cplx c = Cplx.of(minX + (x / width) * (maxX - minX),
                        minY + (y / height) * (maxY - minY));
                    Cplx z = Cplx.of(0, 0);
                    int iteration = 0;
                    while (z.Norm() < EscapeRadius && iteration < MaxIterations)
                    {
                        z = z * z + c;
                        iteration++;
                    }
                    if (iteration < MaxIterations)
                    {
                        double color = 255.0d * ((double)iteration / MaxIterations);
                        int red = (int)(color * 5) % 255;
                        int green = (int)(color * 7) % 255;
                        int blue = (int)(color * 11) % 255;
                        bitMap.SetPixel((int)x, (int)y, Color.FromArgb(255, red, green, blue));
                    }
                    else
                    {
                        bitMap.SetPixel((int)x, (int)y, Color.Black);
                    }
                }
            }
            this.RefreshGraph();
        }

        public void RefreshGraph()
        {
            pictureBox.Image = bitMap;
        }

        public void ClearGraph()
        {
            pictureBox.Image = null;
        }
    }
}
