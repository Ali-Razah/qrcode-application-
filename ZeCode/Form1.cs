using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qrcodewithlogo1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            qrcodewithlogo1.BringToFront();
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            qrcodeonly1.BringToFront();
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            barcodeonly1.BringToFront();
         
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to close this Application ?", "Are you sure ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Application Developed By : M.A.M.Ali Razah");

            about openabout = new about();
            openabout.Show();
        }
    }
}
