namespace sec3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x1 = 0, y1 = 0;
        bool test = false;

        private void button1_Click(object sender, EventArgs e)
        {

            //this code to write line 
            //this.CreateGraphics().DrawLine(Pens.Black, 100, 100, 100, 200);
            //this.CreateGraphics().DrawLine(Pens.Black, 100, 200, 200, 200);
            //this.CreateGraphics().DrawLine(Pens.Black, 200, 100, 200, 200);
            //this.CreateGraphics().DrawLine(Pens.Black, 100, 100, 200, 100);

            Pen p = new Pen(Brushes.Red, 5);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            test = true;
            x1 = e.X;
            y1 = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(test)
            {
                Pen pen = new Pen(Brushes.Red, 5);
                this.CreateGraphics().DrawLine(pen, x1, y1, e.X, e.Y);

            }test=false;

        }
    }
}
