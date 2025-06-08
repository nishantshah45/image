using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Bitmap originalBitmap;

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                originalBitmap = new Bitmap(ofg.FileName);

                pictureBox1.Image = originalBitmap;
                originalBitmap = ToGrayScale((Bitmap)pictureBox1.Image);
                ShowImage(originalBitmap, "Original IMage(Gray Scale)");


            }

        }

        static Bitmap ToGrayScale(Bitmap Original)
        {
            Bitmap Gray = new Bitmap(Original.Width, Original.Height);
            for (int x = 0; x < Original.Width; x++)
            {
                for (int y = 0; y < Original.Height; y++)
                {
                    Color pixel = Original.GetPixel(x, y);
                    int grayVal = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    Gray.SetPixel(x, y, Color.FromArgb(grayVal, grayVal, grayVal));
                }
            }

            return Gray;
        }

        static void ShowImage(Bitmap bmp, string title)
        {
            Form form = new Form();
            form.Text = title;
            form.ClientSize = new Size(bmp.Width, bmp.Height);
            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.Image = bmp;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(pb);
            form.Show();

        }
        private Bitmap MeanFilter(Bitmap bmp)
        {

            Bitmap result = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width; x++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= -1; i++)
                        {
                            Color pixel = bmp.GetPixel(x + i, y + j);
                            sumR += pixel.R;
                            sumB += pixel.B;
                            sumG += pixel.G;

                        }

                    }

                    int avR = sumR / 9;
                    int avG = sumG / 9;
                    int avB = sumB / 9;
                    result.SetPixel(x, y, Color.FromArgb(avR, avG, avB));
                }
            }

            return result;
        }

        private void lowpass_Click(object sender, EventArgs e)
        {
            if (originalBitmap != null)
            {
                pictureBox2.Image = MeanFilter(originalBitmap);
                ShowImage((Bitmap)pictureBox2.Image, "Using Mean Filter");

            }
        }
        static Bitmap Applylaplacian(Bitmap gray)
        {
            int[,] kernel = new int[,]
        {
        {0,-1,0},
        {-1,4,-1},
        {0,-1,0}
        };

            int width = gray.Width;
            int Heght = gray.Height;
            Bitmap result = new Bitmap(width, Heght);

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < Heght - 1; y++)
                {
                    int sum = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int pixelval = gray.GetPixel(x + i, y + j).R;
                            sum += pixelval * kernel[i + 1, j + 1];

                        }
                    }

                    sum = Math.Min(255, Math.Max(0, sum));

                    Color edgeColor = Color.FromArgb(sum, sum, sum);
                    result.SetPixel(x, y, edgeColor);
                }

            }
            return result;
        }


        private Bitmap Highpass(Bitmap bmp)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);
            int[,] kernel ={
                          {-1,-1,-1},
                          {-1, 8,-1},
                          {-1,-1,-1}
                          };
            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;


                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixel = bmp.GetPixel(x + i, y + j);
                            int k = kernel[j + 1, i + 1];

                            sumR += pixel.R * k;
                            sumG += pixel.G * k;
                            sumB += pixel.B * k;
                        }
                    }
                    sumR = Math.Min(Math.Max(sumR, 0), 255);
                    sumB = Math.Min(Math.Max(sumB, 0), 255);
                    sumG = Math.Min(Math.Max(sumG, 0), 255);

                    result.SetPixel(x, y, Color.FromArgb(sumR, sumG, sumB));
                }

            }
            return result;

        }

        private void laplace_Click(object sender, EventArgs e)
        {
            if (originalBitmap != null)
            {
                pictureBox2.Image = Applylaplacian(originalBitmap);
                ShowImage((Bitmap)pictureBox2.Image, "Using Laplacian Filter");
            }
        }




        private void highpass_Click(object sender, EventArgs e)
        {
            if (originalBitmap != null)
            {
                pictureBox1.Image = Highpass(originalBitmap);
                ShowImage((Bitmap)pictureBox1.Image, "Using high Filter");
            }
        }
    }
}
