using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBitmap;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        private Bitmap grayImage1;
        private Bitmap grayImage2;
        private Bitmap differenceImage;

        private int[] histGray1;
        private int[] histGray2;

        private Bitmap redImage;
        private Bitmap greenImage;
        private Bitmap blueImage;

        private int[] histRed;
        private int[] histGreen;
        private int[] histBlue;

        private Bitmap MakeGray1(Bitmap source)
        {
            return source.Select(color =>
            {
                int gray = (int)Math.Round(0.299 * color.R + 0.587 * color.G + 0.114 * color.B);
                return Color.FromArgb(gray, gray, gray);
            });
        }

        private Bitmap MakeGray2(Bitmap source)
        {
            return source.Select(color =>
            {
                int gray = (int)Math.Round(0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B);
                return Color.FromArgb(gray, gray, gray);
            });
        }

        private Bitmap MakeRed(Bitmap source)
        {
            return source.Select(color =>
            {
                return Color.FromArgb(color.R, 0, 0);
            });
        }

        private Bitmap MakeGreen(Bitmap source)
        {
            return source.Select(color =>
            {
                return Color.FromArgb(0, color.G, 0);
            });
        }

        private Bitmap MakeBlue(Bitmap source)
        {
            return source.Select(color =>
            {
                return Color.FromArgb(0, 0, color.B);
            });
        }

        private int[] GetRedHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            image.ForEach(color =>
            {
                histogram[color.R]++;
            });

            return histogram;
        }

        private int[] GetGreenHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            image.ForEach(color =>
            {
                histogram[color.G]++;
            });

            return histogram;
        }

        private int[] GetBlueHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            image.ForEach(color =>
            {
                histogram[color.B]++;
            });

            return histogram;
        }

        private Bitmap MakeDifference(Bitmap first, Bitmap second)
        {
            Bitmap result = new Bitmap(first.Width, first.Height);

            using (var fastFirst = new FastBitmap.FastBitmap(first))
            using (var fastSecond = new FastBitmap.FastBitmap(second))
            using (var fastResult = new FastBitmap.FastBitmap(result))
            {
                for (int y = 0; y < first.Height; y++)
                {
                    for (int x = 0; x < first.Width; x++)
                    {
                        Color color1 = fastFirst[x, y];
                        Color color2 = fastSecond[x, y];

                        int difference = Math.Abs(color1.R - color2.R);

                        fastResult[x, y] =
                            Color.FromArgb(difference, difference, difference);
                    }
                }
            }

            return result;
        }

        private int[] GetHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            image.ForEach(color =>
            {
                histogram[color.R]++;
            });

            return histogram;
        }

        private void DrawHistogram(Graphics g, int[] histogram, int width, int height)
        {
            g.Clear(Color.White);

            if (histogram == null)
                return;

            int max = histogram.Max();

            if (max == 0)
                return;

            for (int i = 0; i < 256; i++)
            {
                float x = i * width / 256f;
                float lineHeight = histogram[i] * height / (float)max;
                g.DrawLine(Pens.Black, x, height, x, height - lineHeight);
            }
        }

        private void DrawColorHistogram(Graphics g, int[] histogram, int width, int height, Pen pen)
        {
            g.Clear(Color.White);

            if (histogram == null)
                return;

            int max = histogram.Max();

            if (max == 0)
                return;

            for (int i = 0; i < 256; i++)
            {
                float x = i * width / 256f;
                float lineHeight = histogram[i] * height / (float)max;

                g.DrawLine(pen, x, height, x, height - lineHeight);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(dialog.FileName);

                pictureOriginalGray.Image = originalImage;
                pictureOriginalRGB.Image = originalImage;
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Сначала откройте изображение.");
                return;
            }

            grayImage1 = MakeGray1(originalImage);
            grayImage2 = MakeGray2(originalImage);

            differenceImage = MakeDifference(grayImage1, grayImage2);

            pictureGray1.Image = grayImage1;
            pictureGray2.Image = grayImage2;
            pictureDifference.Image = differenceImage;

            histGray1 = GetHistogram(grayImage1);
            histGray2 = GetHistogram(grayImage2);

            panelHistGray1.Invalidate();
            panelHistGray2.Invalidate();
        }

        private void panelHistGray1_Paint(object sender, PaintEventArgs e)
        {
            DrawHistogram(e.Graphics, histGray1, panelHistGray1.Width, panelHistGray1.Height);
        }

        private void panelHistGray2_Paint(object sender, PaintEventArgs e)
        {
            DrawHistogram(e.Graphics, histGray2, panelHistGray2.Width, panelHistGray2.Height);
        }

        private void btnRGB_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Сначала откройте изображение.");
                return;
            }

            redImage = MakeRed(originalImage);
            greenImage = MakeGreen(originalImage);
            blueImage = MakeBlue(originalImage);

            pictureRed.Image = redImage;
            pictureGreen.Image = greenImage;
            pictureBlue.Image = blueImage;

            histRed = GetRedHistogram(originalImage);
            histGreen = GetGreenHistogram(originalImage);
            histBlue = GetBlueHistogram(originalImage);

            panelHistRed.Invalidate();
            panelHistGreen.Invalidate();
            panelHistBlue.Invalidate();
        }

        private void panelHistRed_Paint(object sender, PaintEventArgs e)
        {
            DrawColorHistogram(
                e.Graphics,
                histRed,
                panelHistRed.Width,
                panelHistRed.Height,
                Pens.Red
            );
        }

        private void panelHistGreen_Paint(object sender, PaintEventArgs e)
        {
            DrawColorHistogram(
                e.Graphics,
                histGreen,
                panelHistGreen.Width,
                panelHistGreen.Height,
                Pens.Green
            );
        }

        private void panelHistBlue_Paint(object sender, PaintEventArgs e)
        {
            DrawColorHistogram(
                e.Graphics,
                histBlue,
                panelHistBlue.Width,
                panelHistBlue.Height,
                Pens.Blue
            );
        }
    }
}
