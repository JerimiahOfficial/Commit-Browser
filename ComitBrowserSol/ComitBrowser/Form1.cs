using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ComitBrowser
{
    public partial class Form1 : Form
    {
        Form1 A;

        public Form1()
        {
            InitializeComponent();
        }



        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            mouseDown = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            webBrowser1.GoBack();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            webBrowser1.GoForward();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            webBrowser1.Refresh();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            webBrowser1.Navigate(textBox1.Text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text);
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            if (button5.Text == "1")
            {
                button5.Text = "2";
            }

            else if (button5.Text == "2")
            {
                button5.Text = "1";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();

        }

    }

}
