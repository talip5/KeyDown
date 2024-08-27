using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Drap
            //this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition= FormStartPosition.Manual;
            this.Location = new Point(100, 100);

            label1.MouseDown+=Label1_MouseDown;
            label1.MouseMove+=Label1_MouseMove;
            label1.MouseUp+=Label1_MouseUp;
            ilkKonum = new Point(label1.Left, label1.Top);

            button1.MouseDown+=Button1_MouseDown;
            button1.MouseMove+=Button1_MouseMove;
            button1.MouseUp+=Button1_MouseUp;

            this.MouseDown+=Form1_MouseDown;
            this.MouseMove+=Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            konum = e.Location;
            ilkKonum = new Point(this.Left, this.Top);
            this.Text = "Konum :" + konum.ToString() + "     " + "İlkkonum :" + ilkKonum;
        }



        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.Left+=e.X - (konum.X);
                button1.Top+=e.Y - (konum.y);
            }
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            konum = e.Location;
            this.Text = konum.ToString() + "     " + ilkKonum;
        }

        Point konum, ilkKonum;
        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
           // ilkKonum = new Point(label1.Left, label1.Top);
           // konum = e.Location;
            //this.Text = konum.ToString() + "     " + ilkKonum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor=Color.Orange;
            label1.AutoSize = false;
            label1.Width = 100;
            label1.Height = 100;
            //label1.AllowDrop = true;
            //ilkKonum = new Point(this.Left, this.Top);
            //this.Text = konum.ToString() + "     " + ilkKonum;
        }
    }
}
