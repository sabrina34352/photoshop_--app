using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace id_cap_that
{
    public partial class shit : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public shit()
        {
            InitializeComponent();
            thenumbersindomain();
            g=input.CreateGraphics();
            input.Controls.Add(thecaption);
            thecaption.BackColor = Color.Transparent;
           
        }

        private void input_Click(object sender, EventArgs e)
        {


        }
        public string chosen_file { get; set; }
   
        private void addpicture_Click(object sender, EventArgs e)
        {

            try 
            {
                getpicture.Title = "insert an image";
                getpicture.Filter = "All|*.jpg;*.png| JPEG|*.jpg|PNG|*.png";
                getpicture.ShowDialog();
                chosen_file = getpicture.FileName;
                Image img = Image.FromFile(chosen_file);
                if (input.Width > img.Width && input.Height > img.Height)
                {
                    input.Width = img.Width;
                    input.Height = img.Height;
                }
                else if (img.Width > input.Width && img.Height > input.Height)
                {
                    
                    input.Width = img.Width / 2; input.Height = img.Height / 2;
                    input.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                input.Image = Image.FromFile(chosen_file);
            }
            catch { }
        }

        

        private void addcaption_Click(object sender, EventArgs e)
        {
            try
            {
                textchanged();
            }
            catch { MessageBox.Show("Missing picture"); }
        }

        
        public int fontsize{ get; set; }
        public Font thefont { get; set; }
        public Graphics gr { get; set; }
        private void textchanged()
        {
            //Image image = (Image)Bitmap.FromFile(chosen_file);
            var image = new Bitmap(this.thecaption.Width, this.thecaption.Height);
            //Font font = new Font("DM Mono", fontsize);
            thefont = new Font("DM Mono", fontsize);
            gr = Graphics.FromImage(image);
            gr.DrawString(caption.Text, thefont, Brushes.Green, 0,0);
            this.thecaption.Image = image;
            //font = thefont;
            //image.Dispose();
            
        }

        private void domain_SelectedItemChanged(object sender, EventArgs e)
        {
            fontsize = Convert.ToInt32(domain.Text);
            
        }

        private void thenumbersindomain()
        {
            for(int i =99; i>=1; i--)
            {
                domain.Items.Add(i);
                domain.Text = i.ToString();
            }
            domain.SelectedIndex = 79;

        }

        
        private void thecaption_MouseMove(object sender, MouseEventArgs e)
        {

            Point point = new Point(0,0);

            if (e.Button == MouseButtons.Left)
            {
                thecaption.Left += e.X - point.X;
                thecaption.Top += e.Y - point.Y;
                
            }

        }
        private void save_Click(object sender, EventArgs e)
        {
            //Image image = (Image)Bitmap.FromFile(chosen_file);


            Graphics graphics;
            Image inputimage = input.Image;
            graphics = Graphics.FromImage(inputimage);
            Font font = new Font("DM Mono", Convert.ToInt32(domain.Text));
            graphics.DrawString(caption.Text, thefont, Brushes.Green, thecaption.Location);

            
            SaveFileDialog filesave = new SaveFileDialog();
            filesave.Filter = "JPEG|*.jpg|PNG images|*.png";
            if (filesave.ShowDialog() == DialogResult.OK) 
                inputimage.Save(filesave.FileName);
            inputimage.Dispose();

        }









        private void openFileDialog1_FileOk(object sender, CancelEventArgs e){}
        private void domain_Scroll(object sender, ScrollEventArgs e){}
        private void input_MouseMove(object sender, MouseEventArgs e){}
        private void caption2_Click(object sender, EventArgs e){}
        private void thecaption_Click(object sender, EventArgs e){}
        private void thecaption_MouseDown(object sender, MouseEventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void caption_TextChanged(object sender, EventArgs e){}

        
    }
}
