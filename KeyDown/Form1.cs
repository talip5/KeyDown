using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPress+=Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int pressedKey1 = Convert.ToInt32(e.KeyChar);
            this.Text = pressedKey1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text ="OK";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hello";
            label1.BackColor = Color.Black;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                //MessageBox.Show("tamam");
                this.Text = "Enter";
            }

            if(e.KeyCode == Keys.Tab)
            {
                this.Text = "Tab";
            }

            if(e.KeyCode == Keys.W)
            {
                this.Text = "W";
                int x = label1.Location.X;
                int y = label1.Location.Y;
                y = y + 20;
                label1.Location = new Point(x, y);
            }

            if(e.KeyCode == Keys.S)
            {
                int x = label1.Location.X;
                int y = label1.Location.Y;
                y = y - 20;
                label1.Location = new Point(x,y);
            }
        }
    }
}
