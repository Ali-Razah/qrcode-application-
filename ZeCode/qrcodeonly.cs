using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;

namespace ZeCode
{
    public partial class qrcodeonly : UserControl
    {
        bool isGenerated = false;
        public qrcodeonly()
        {
            InitializeComponent();
            timer1.Start();
            Button1.Hide();
            dataGridView1.Hide();
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
                Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pic_qrcode.Image = qr.Draw(TextBox1.Text, 300);
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
