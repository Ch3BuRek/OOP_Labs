namespace Laba2_oop
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
            panelCanvas = new Panel();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            MenuShape = new ToolStripMenuItem();
            DotShape = new ToolStripMenuItem();
            LineShape = new ToolStripMenuItem();
            RectangleShape = new ToolStripMenuItem();
            ElipseShape = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.Location = new Point(12, 33);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(776, 414);
            panelCanvas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, MenuShape, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // MenuShape
            // 
            MenuShape.DropDownItems.AddRange(new ToolStripItem[] { DotShape, LineShape, RectangleShape, ElipseShape });
            MenuShape.Name = "MenuShape";
            MenuShape.Size = new Size(72, 24);
            MenuShape.Text = "Обєкти";
            MenuShape.Click += MenuShape_Click;
            // 
            // DotShape
            // 
            DotShape.Name = "DotShape";
            DotShape.Size = new Size(185, 26);
            DotShape.Text = "Крапка";
            DotShape.Click += DotShape_Click;
            // 
            // LineShape
            // 
            LineShape.Name = "LineShape";
            LineShape.Size = new Size(185, 26);
            LineShape.Text = "Лінія";
            LineShape.Click += LineShape_Click;
            // 
            // RectangleShape
            // 
            RectangleShape.Name = "RectangleShape";
            RectangleShape.Size = new Size(185, 26);
            RectangleShape.Text = "Прямокутник";
            RectangleShape.Click += RectangleShape_Click;
            // 
            // ElipseShape
            // 
            ElipseShape.Name = "ElipseShape";
            ElipseShape.Size = new Size(185, 26);
            ElipseShape.Text = "Еліпс";
            ElipseShape.Click += ElipseShape_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(77, 24);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCanvas);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DotShape_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelCanvas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem MenuShape;
        private ToolStripMenuItem DotShape;
        private ToolStripMenuItem LineShape;
        private ToolStripMenuItem RectangleShape;
        private ToolStripMenuItem ElipseShape;
        private ToolStripMenuItem довідкаToolStripMenuItem;
    }
}
