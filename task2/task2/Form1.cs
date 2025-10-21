namespace task2
{
    public partial class Form1 : Form
    {

        private bool isDrawing = false;
        private Point startPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Red, 3);

            
            this.CreateGraphics().DrawLine(p, 100, 50, 50, 150);   // left side
            this.CreateGraphics().DrawLine(p, 100, 50, 150, 150);  // right side
            this.CreateGraphics().DrawLine(p, 50, 150, 150, 150);  // base
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Blue, 3);

            
            // top
            this.CreateGraphics().DrawLine(p, 200, 50, 250, 50);
            // right
            this.CreateGraphics().DrawLine(p, 250, 50, 250, 200);
            // bottom
            this.CreateGraphics().DrawLine(p, 250, 200, 200, 200);
            // left
            this.CreateGraphics().DrawLine(p, 200, 200, 200, 50);
        }

        private void btn_Parallelogram_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 3);

            
            this.CreateGraphics().DrawLine(p, 320, 100, 420, 100);  // top
            this.CreateGraphics().DrawLine(p, 420, 100, 470, 200);  // right
            this.CreateGraphics().DrawLine(p, 470, 200, 370, 200);  // bottom
            this.CreateGraphics().DrawLine(p, 370, 200, 320, 100);  // left
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Brushes.Green, 3);

            

           
            this.CreateGraphics().DrawRectangle(p, 520, 100, 140, 80); // x, y, width, height

            
            this.CreateGraphics().DrawRectangle(p, 560, 70, 140, 80);

            
            this.CreateGraphics().DrawLine(p, 520, 100, 560, 70);   // 
            this.CreateGraphics().DrawLine(p, 660, 100, 700, 70);   //
            this.CreateGraphics().DrawLine(p, 520, 180, 560, 150);  // 
            this.CreateGraphics().DrawLine(p, 660, 180, 700, 150);  //

        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
              
                Pen p = new Pen(Color.Black, 3);
                this.CreateGraphics().DrawLine(p, startPoint, e.Location);
                isDrawing = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(this.BackColor);
        }
    }
}
