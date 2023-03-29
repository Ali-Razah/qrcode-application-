using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using MySql.Data.MySqlClient;

namespace ZeCode
{
    public partial class qrcodewithlogo : UserControl
    {
        public qrcodewithlogo()
        {
            InitializeComponent();
            textBox2.Text = "250";
            timer1.Start();
            textBox3.Text = "250";
            Button1.Hide();
        }
 
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
 
            int aa1 = Convert.ToInt32(textBox2.Text);
            int aa2 = Convert.ToInt32(textBox3.Text);

            var qrcode_text = TextBox1.Text;
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = aa1, Height = aa2, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(pictureBox1.Image, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pic_qrcode.Image = bitmap;

                Button1.Show();
            }
            catch
            {
                MessageBox.Show("Something Went Wrong","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clear();
            }
          
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {

            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog asd = new OpenFileDialog();
            if (asd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = asd.FileName;
            }
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

        private void qrcodewithlogo_Load(object sender, EventArgs e)
        {
          
        }
    }
}
