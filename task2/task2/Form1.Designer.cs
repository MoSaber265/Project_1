namespace task2
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
            btn_Triangle = new Button();
            btn_Rectangle = new Button();
            btn_Parallelogram = new Button();
            btn_Rectangular_prism = new Button();
            SuspendLayout();
            // 
            // btn_Triangle
            // 
            btn_Triangle.BackColor = SystemColors.Desktop;
            btn_Triangle.Location = new Point(1259, 38);
            btn_Triangle.Name = "btn_Triangle";
            btn_Triangle.Size = new Size(183, 107);
            btn_Triangle.TabIndex = 0;
            btn_Triangle.Text = "Draw_Triangle";
            btn_Triangle.UseVisualStyleBackColor = false;
            btn_Triangle.Click += btn_Triangle_Click;
            // 
            // btn_Rectangle
            // 
            btn_Rectangle.BackColor = SystemColors.ActiveCaption;
            btn_Rectangle.Location = new Point(1259, 151);
            btn_Rectangle.Name = "btn_Rectangle";
            btn_Rectangle.Size = new Size(183, 110);
            btn_Rectangle.TabIndex = 1;
            btn_Rectangle.Text = "Draw_Rectangle";
            btn_Rectangle.UseVisualStyleBackColor = false;
            btn_Rectangle.Click += btn_Rectangle_Click;
            // 
            // btn_Parallelogram
            // 
            btn_Parallelogram.BackColor = SystemColors.InactiveCaption;
            btn_Parallelogram.Location = new Point(1259, 267);
            btn_Parallelogram.Name = "btn_Parallelogram";
            btn_Parallelogram.Size = new Size(183, 95);
            btn_Parallelogram.TabIndex = 2;
            btn_Parallelogram.Text = "Draw_Parallelogram";
            btn_Parallelogram.UseVisualStyleBackColor = false;
            btn_Parallelogram.Click += btn_Parallelogram_Click;
            // 
            // btn_Rectangular_prism
            // 
            btn_Rectangular_prism.BackColor = Color.DarkGray;
            btn_Rectangular_prism.Location = new Point(1259, 368);
            btn_Rectangular_prism.Name = "btn_Rectangular_prism";
            btn_Rectangular_prism.Size = new Size(183, 84);
            btn_Rectangular_prism.TabIndex = 3;
            btn_Rectangular_prism.Text = "Draw_Rectangular_prism";
            btn_Rectangular_prism.UseVisualStyleBackColor = false;
            btn_Rectangular_prism.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 594);
            Controls.Add(btn_Rectangular_prism);
            Controls.Add(btn_Parallelogram);
            Controls.Add(btn_Rectangle);
            Controls.Add(btn_Triangle);
            Name = "Form1";
            Text = "Painter";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Triangle;
        private Button btn_Rectangle;
        private Button btn_Parallelogram;
        private Button btn_Rectangular_prism;
    }
}
