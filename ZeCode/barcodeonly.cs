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
    public partial class barcodeonly : UserControl
    {
        bool isGenerated = false;

        public barcodeonly()
        {
            InitializeComponent();
            timer1.Start();
            Button1.Hide();
        }
 
        private void Button3_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            { 

            }
            else
            {
                isGenerated = true;

                pic_qrcode.SizeMode = PictureBoxSizeMode.AutoSize;
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pic_qrcode.Image = barcode.Draw(TextBox1.Text, 200);
 
            }
            Button1.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveaa = new SaveFileDialog();
            saveaa.Filter = "PNG Image |*.png";
            saveaa.RestoreDirectory = true;
            if (saveaa.ShowDialog() == DialogResult.OK)
            {
                pic_qrcode.Image.Save(saveaa.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            clear();
        }
        public void clear()
        {
            TextBox1.Clear();
            Button1.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }
    }
}
