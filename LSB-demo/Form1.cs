using LSB_demo.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB_demo
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null, enc_image = null;
        private string decodedText = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

       

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
        private void openImage_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFileDialog ofs = new OpenFileDialog();
                //ofs.Filter = "Image Files(*.jpg,*.jpeg,*.bmp,*.png)|*.jpg;*.jpeg;*.bmp;*.png";
                //if (ofs.ShowDialog() == DialogResult.OK)
                //{
                //    bmp = new Bitmap(ofs.FileName, false);
                //    image.Image = bmp;
                //}
                OpenFileDialog open_dialog = new OpenFileDialog();
                open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

                if (open_dialog.ShowDialog() == DialogResult.OK)
                {
                    image.Image = Image.FromFile(open_dialog.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException(" Faild to load image ");
            }
            
        }

        private void hideText_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)image.Image;
            string text = textBox1.Text;
            if (text.Equals(""))
            {
                MessageBox.Show("Đoạn văn bản mà bạn cần giấu", "Warning");
                return;
            }

            bmp = Encode.encode(text, bmp);
            enc_image = bmp;
            image_enc.Image = enc_image;
            MessageBox.Show("Đoạn văn bản đã được giấu!", "Done");
            

        }
        private void showText_Click(object sender, EventArgs e)
        {
            if(bmp != null)
            {
                bmp = (Bitmap)image.Image;
                string decodedText = Decode.decode(bmp);
                textBox1.Text = decodedText;
                MessageBox.Show("Đã tìm thấy!", "Done");
            }
            else
            {
                textBox1.Text = "Vui lòng chọn ảnh!!";
            }
            
        }
        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG Files|*.png";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                enc_image.Save(sf.FileName, ImageFormat.Png);
            }
            MessageBox.Show("Đã lưu file!", "Done");
        }
    }
}
