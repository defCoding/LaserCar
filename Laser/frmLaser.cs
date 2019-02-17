using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Laser
{
    public partial class frmLaser : Form
    {
        public Stopwatch watch { get; set; }

        public frmLaser()
        {
            InitializeComponent();
        }

        private void frmLaser_Load(object sender, EventArgs e)
        {
            this.watch = Stopwatch.StartNew();
            this.srlPort.Open();
        }

        private void frmLaser_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblCoordinates.Text = "X: " + e.X + " Y: " + e.Y;
            writeToPort(new Point(e.X, e.Y));
        }

        public void writeToPort(Point coordinates)
        {
            //this.watch.ElapsedMilliseconds > 15 
            if (this.watch.ElapsedMilliseconds > 14 && this.srlPort.IsOpen)
            {
                this.srlPort.Write(String.Format("X{0}Y{1}",
                    (180 - (coordinates.X / (this.Size.Width / 180))),
                    (180 -(coordinates.Y / (this.Size.Height / 180)))));

                this.watch = Stopwatch.StartNew();
            }
        }

        private void frmLaser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'p')
            {
                if (this.srlPort.IsOpen) {
                    this.srlPort.Close();
                } else
                {
                    this.srlPort.Open();
                }
            } else if (e.KeyChar == 'r')
            {
                this.srlPort.Write(String.Format("X{0}Y{1}",
                    (180 - (384 / (this.Size.Width / 180))),
                    (180 - (683 / (this.Size.Height / 180)))));
            } else
            {
                e.Handled = true;
            }
        }
    }
}
