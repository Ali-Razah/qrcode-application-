using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZeCode
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            IDAC.Text = "1";
            timer1.Start();
            
        }
    
    
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = progressBar1.Value + 3;
                if (progressBar1.Value > 97)
                {

                    timer1.Stop();


                DateTime trialStartDate = DateTime.Now;
                int trialDays = 7;
                DateTime trialEndDate = trialStartDate.AddDays(trialDays);
                if (DateTime.Now > trialEndDate)
                {
                    MessageBox.Show("Your trial period has expired. Please purchase the full version.\n\n\n Contact Number Whatsapp : +94 76 4462 442");
                    Application.Exit();
                }
                if (DateTime.Now <= trialEndDate)
                {
                    this.Text = "My Application (Trial Version)";
                    MessageBox.Show("You are using a trial version of My Application. Please purchase the full version to unlock all features.");
                }
                Form1 F = new Form1();
                    F.Show();
                    this.Hide();

                }
 

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
