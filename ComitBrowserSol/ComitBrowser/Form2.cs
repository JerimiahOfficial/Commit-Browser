using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComitBrowser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Draggable Form

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

        //end

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2.Text = Environment.MachineName;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/JerimiahOfficial/");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCHi47xiIYDponERT6IXLRew?view_as=subscriber");

        }

    }

}
