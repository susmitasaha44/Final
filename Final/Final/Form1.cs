using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cover_image_loc = @"C:\Users\USER\Desktop\img\fw.png";
            Bitmap newBitmap = new Bitmap(cover_image_loc);
            for (int y = 0; y < 1; y++)
            {
                for (int x = 0; x < newBitmap.Width; x++)
                {

                    newBitmap.SetPixel(x, y, Color.Yellow);
                }
            }
            newBitmap.Save(@"C:\Users\USER\Desktop\img\fw2.png");
            MessageBox.Show("Complete!!");

        }
    }
}
