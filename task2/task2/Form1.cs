namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Red, 5);
            this.CreateGraphics().DrawLine(p, 150, 50, 100, 150);
            this.CreateGraphics().DrawLine(p, 150, 50, 200, 150);
            this.CreateGraphics().DrawLine(p, 100, 150, 200, 150);

        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Blue, 5);
            this.CreateGraphics().DrawLine(p, 250, 100, 250, 200);
            this.CreateGraphics().DrawLine(p, 250, 200, 350, 200);
            this.CreateGraphics().DrawLine(p, 350, 200, 350, 100);
            this.CreateGraphics().DrawLine(p, 350, 100, 250, 100);

        }

        private void btn_Parallelogram_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 5);
            this.CreateGraphics().DrawLine(p, 400, 100, 500, 100);
            this.CreateGraphics().DrawLine(p, 500, 100, 550, 200);
            this.CreateGraphics().DrawLine(p, 550, 200, 450, 200);
            this.CreateGraphics().DrawLine(p, 450, 200, 400, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //g.Clear(this.BackColor);

            Pen p = new Pen(Brushes.Red, 3);

            // Front face of the prism
            this.CreateGraphics().DrawRectangle(p, 100, 100, 100, 80);
           
            // Back face (shifted diagonally)
            this.CreateGraphics().DrawRectangle(p, 130, 70, 100, 80);

            // Connect the corners
            this.CreateGraphics().DrawLine(p, 100, 100, 130, 70);       // top-left
            this.CreateGraphics().DrawLine(p, 200, 100, 230, 70);       // top-right
            this.CreateGraphics().DrawLine(p, 100, 180, 130, 150);      // bottom-left
            this.CreateGraphics().DrawLine(p, 200, 180, 230, 150);      // bottom-right
        }
    }
}
