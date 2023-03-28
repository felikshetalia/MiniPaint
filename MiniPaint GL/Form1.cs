using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace MiniPaint_GL
{
    public partial class Form1 : Form
    {
        public Bitmap drawBitmap;
        private const int RADIUS = 1;
        public Pen pen;
        public bool switch_;
        private int X = -1;
        private int Y = -1;

        public Bitmap oldBitmap;

        public bool drawingnow;
        public bool brushinuse = false;

        bool rectangle_in_use = false;
        bool circle_in_use = false;
        public Form1()
        {
            InitializeComponent();

            pen = new Pen(Brushes.Black, RADIUS);

            drawBitmap = new Bitmap(drawingArea.Size.Width, drawingArea.Size.Height);
            oldBitmap = new Bitmap(drawingArea.Size.Width, drawingArea.Size.Height);
            drawingArea.Image = drawBitmap;

            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                PictureBox colorBox = new PictureBox();
                colorBox.BackColor = Color.FromKnownColor(color);
                colorBox.ForeColor = Color.FromKnownColor(color);
                colorBox.Size = new Size(25, 25);
                colorBox.Name = color.ToString();
                colorBox.Click += new EventHandler(this.ChooseColorButton_Click);
                coloursPanel.Controls.Add(colorBox);

                //Button button = new Button();
                //button.BackColor = Color.FromKnownColor(color);
                //button.ForeColor = Color.FromKnownColor(color);
                //button.Size = new Size(25, 25);
                //button.Name = color.ToString();
                //button.Click += new EventHandler(this.ChooseColorButton_Click);
                //coloursPanel.Controls.Add(button);

            }

            using (Graphics g = Graphics.FromImage(drawBitmap))
            {
                g.Clear(Color.White);
            }

           
        }

        private void btnCLick_Event(object sender, EventArgs e)
        {
            Pen dashedPen = new Pen(Color.Black, 2);
            dashedPen.DashPattern = new float[] { 1, 3 };
            Color color = ((PictureBox)sender).BackColor;
            color = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);



            colorBtn.BackColor = pen.Color = ((PictureBox)sender).BackColor;
        }

        private void drawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (e.Button != MouseButtons.Left) || (e.Button == MouseButtons.Right) && (e.Button == MouseButtons.Left))
            {
                drawingnow = false;
                X = -1;
                Y = -1;
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawingnow = true;
                X = e.X;
                Y = e.Y;
            }

            pen.Width = int.Parse(toolThicknessComboBox.Text);

            if(rectangle_in_use || circle_in_use)
            {
                oldBitmap = new Bitmap(drawBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);

            }
                
        }

        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Cross;
            if (drawingnow && brushinuse)
            {
                using (Graphics g = Graphics.FromImage(drawBitmap))
                {
                    g.DrawLine(pen, new Point(X, Y), new Point(e.X, e.Y));
                    X = e.X;
                    Y = e.Y;
                }
                drawingArea.Refresh();
            }
            else if (rectangle_in_use && drawingnow)
            {
                //Bitmap oldBitmap = new Bitmap(drawBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                drawBitmap = new Bitmap(oldBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                drawingArea.Image = drawBitmap;
                oldBitmap = new Bitmap(drawBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                using (Graphics g = Graphics.FromImage(drawBitmap))
                {
                    g.DrawRectangle(pen, new Rectangle(new Point(X > e.X ? e.X : X, Y > e.Y ? e.Y : Y), new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y))));
                }
                drawingArea.Refresh();
            }
            else if (circle_in_use && drawingnow)
            {
                //Bitmap oldBitmap = new Bitmap(drawBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                drawBitmap = new Bitmap(oldBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                drawingArea.Image = drawBitmap;
                oldBitmap = new Bitmap(drawBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                using (Graphics g = Graphics.FromImage(drawBitmap))
                {
                    g.DrawEllipse(pen, new Rectangle(new Point(X > e.X ? e.X : X, Y > e.Y ? e.Y : Y), new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y))));
                }
                drawingArea.Refresh();
            }
        }

        private void brushToolButton_Click(object sender, EventArgs e)
        {
            brushinuse = !brushinuse;
            circle_in_use = false;
            rectangle_in_use = false;

        }

        bool showChosenColour = true;
        Bitmap chosenColourBitmap;


        private void ChooseColorButton_Click(object sender,EventArgs e)
        {
            PictureBox bx = (PictureBox)sender;
            //Button bt = (Button)sender;
            pen.Color = bx.BackColor;

            if (!showChosenColour)
            {
                using (Graphics g = Graphics.FromImage(chosenColourBitmap))
                {
                    g.Clear(colorBtn.BackColor);
                    //colorBtn.Refresh();
                }
            }

            Color backcolor = ((PictureBox)sender).BackColor;
            backcolor = Color.FromArgb(255 - backcolor.R, 255 - backcolor.G, 255 - backcolor.B);

            Pen dashedBorder = new Pen(backcolor, 2);
            dashedBorder.DashPattern = new float[] { 1, 2 };

            // Color Image for Chosen Color
            chosenColourBitmap = new Bitmap(25, 25);
            ((PictureBox)sender).Image = chosenColourBitmap;
            using (Graphics g = Graphics.FromImage(chosenColourBitmap))
            {
                g.DrawRectangle(dashedBorder, 0, 0, 25, 25);
                ((PictureBox)sender).Refresh();
            }

            showChosenColour = false;
            //colorBtn = (Button)sender;

            colorBtn.BackColor = pen.Color;
        }

        private void drawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right && e.Button == MouseButtons.Left)
            {
                if (rectangle_in_use && drawingnow)
                {
                    using (Graphics g = Graphics.FromImage(drawBitmap))
                    {
                        g.DrawRectangle(pen, new Rectangle(new Point(X > e.X ? e.X : X, Y > e.Y ? e.Y : Y), new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y))));
                    }
                    drawingArea.Refresh();
                }
                else if (circle_in_use && drawingnow)
                {
                    using (Graphics g = Graphics.FromImage(drawBitmap))
                    {
                        g.DrawEllipse(pen, new Rectangle(new Point(X > e.X ? e.X : X, Y > e.Y ? e.Y : Y), new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y))));
                    }
                    drawingArea.Refresh();
                }
            }

            drawingnow = false;
            X = -1;
            Y = -1;    
        }

        private void drawingArea_Click(object sender, EventArgs e)
        {
            
        }

        private void drawingArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //ColorDialog colorDialog = new();
            //if (colorDialog.ShowDialog() == DialogResult.OK)
            //    pen.Color = colorDialog.Color;

            //KnownColor newColor = new();
            

            //foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            //{

            
        }

        private void drawingArea_Resize(object sender, EventArgs e)
        {
            

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Bitmap newbitmap = new Bitmap(drawingArea.Size.Width, drawingArea.Size.Height);
            using (Graphics g = Graphics.FromImage(newbitmap))
            {
                g.Clear(Color.White);
                g.DrawImage(drawBitmap, 0, 0);
            }

            drawBitmap = newbitmap;
            drawingArea.Image = drawBitmap;

            drawingArea.Refresh();
        }

        private void saveToolButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog toSave = new SaveFileDialog();

            toSave.Filter = "PNG Image |.png;*.png|Bitmap Image|.bmp;*.bmp | JPEG Image |.jpeg;*.jpeg";
            toSave.FileName = "default.jpg";

            if (toSave.ShowDialog() == DialogResult.OK)
            {
                drawBitmap.Save(toSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void loadToolButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog toLoad = new OpenFileDialog();

            toLoad.Title = "Import";
            toLoad.Filter = "PNG Image |.png;*.png|Bitmap Image|.bmp;*.bmp | JPEG Image |.jpeg;*.jpeg";

            if (toLoad.ShowDialog() == DialogResult.OK)
            {
                drawBitmap = (Bitmap)Image.FromFile(toLoad.FileName);
                drawBitmap = new Bitmap(drawBitmap, drawBitmap.Size.Width, drawBitmap.Size.Height);
                //drawingArea.Size = new Size(drawBitmap.Size.Width, drawBitmap.Size.Height);
                //drawingArea.BackColor = 

                drawingArea.Image = drawBitmap;
                drawingArea.Refresh();
            }
        }

        

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            brushinuse = false;
            rectangle_in_use = false;
            circle_in_use = true;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            brushinuse = false;
            rectangle_in_use = true;
            circle_in_use = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(drawBitmap))
            {
                g.Clear(Color.White);
                drawingArea.Refresh();
            }
        }
    }
}
