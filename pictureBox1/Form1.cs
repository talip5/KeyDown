using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox1
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox2;

        public Form1()
        {
            InitializeComponent();
            pictureBox2 = new PictureBox();
            pictureBox2.Height = 200;
            pictureBox2.Width = 200;
            this.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(10, 10);
            pictureBox2.BackColor = Color.Orange;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = pictureBox2.Size.Width.ToString() + "    " + pictureBox2.Size.Height.ToString();
            pictureBox2.Image = Image.FromFile("C:\\picture\\resim2.JPG");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Interval = 5000;
            timer1.Enabled = true;
            this.FormBorderStyle=FormBorderStyle.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            pictureBox2.Image = Image.FromFile("C:\\picture\\resim1.JPG");
            this.Text = "timer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
