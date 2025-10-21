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
            jgjgjg = new Button();
            btn_clear = new Button();
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
            // jgjgjg
            // 
            jgjgjg.BackColor = Color.DarkGray;
            jgjgjg.Location = new Point(1259, 368);
            jgjgjg.Name = "jgjgjg";
            jgjgjg.Size = new Size(183, 84);
            jgjgjg.TabIndex = 3;
            jgjgjg.Text = "Draw_Rectangular_prism";
            jgjgjg.UseVisualStyleBackColor = false;
            jgjgjg.Click += button1_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.MenuHighlight;
            btn_clear.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clear.Location = new Point(1259, 458);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(183, 74);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1529, 594);
            Controls.Add(btn_clear);
            Controls.Add(jgjgjg);
            Controls.Add(btn_Parallelogram);
            Controls.Add(btn_Rectangle);
            Controls.Add(btn_Triangle);
            Name = "Form1";
            Text = "Painter";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Triangle;
        private Button btn_Rectangle;
        private Button btn_Parallelogram;
        private Button jgjgjg;
        private Button btn_clear;
    }
}
