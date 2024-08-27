using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseDown
{
    public partial class Form1 : Form
    {
        int changed = 1;
        Point konum, ilkkonum;
        public Form1()
        {
            InitializeComponent();
           
            button1.MouseDown+=Button1_MouseDown;
            button1.MouseMove+=Button1_MouseMove;
            button1.MouseUp+=Button1_MouseUp;
            ilkkonum = new Point(button1.Left,button1.Top);
            label1.Location = new Point(10, 10);

        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            //this.Text = "MouseUp";
            //button1.Location = new Point(konum_x, konum_y);
            button1.Location = ilkkonum;
           
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = "MouseMove";
            //this.Text = x.ToString();
            if(e.Button == MouseButtons.Left)
            {
                button2.Text = "MouseLeft";

                this.Text = button1.Left.ToString();

                if (button1.Left<1 || button1.Top<1)
                {
                    panel1.BackColor = Color.Brown;
                    button1.Left += e.X - (konum.X);
                    button1.Top += e.Y - (konum.Y);



                }
                else
                {
                    
                    panel1.BackColor =Color.Orange;
                    button1.Left += e.X - (konum.X);
                    button1.Top += e.Y - (konum.Y);
                }
            }
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Text = "MouseDown";
            //button1.Location = new Point(konum_x + 100, konum_y + 100);
            //form_mouse_x = e.Location.X;
            konum = e.Location;
            //this.Text =konum.ToString();
            


        }

      
            
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Text = "X :" + button2.Location.X.ToString() + "    " + "Y :" + button2.Location.Y.ToString();

            //button2.Location = new Point(button1.Right,button1.Top);
            //this.Text = button2.Left.ToString() + "    " +  button2.Top.ToString();
            panel1.BackColor = Color.Orange;

            this.Text = label1.Left.ToString();
            

        }
    }
}
