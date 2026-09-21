using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FastBitmap;
using System.Drawing.Imaging;
namespace Lab2
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        //задание 1 - Оттенки серого
        private Bitmap grayImage1;
        private Bitmap grayImage2;
        private Bitmap differenceImage;

        private int[] histGray1;
        private int[] histGray2;

        //задание 2 - RGB
        private Bitmap redImage;
        private Bitmap greenImage;
        private Bitmap blueImage;

        private int[] histRed;
        private int[] histGreen;
        private int[] histBlue;

        //задание 3

        private Bitmap hsvImage;
        private struct HSV
        {
            public double H;
            public double S;
            public double V;
        }
 

        //задание 1 - оттенки серого
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

        //задание 2 - RGB
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

        //задание 3
        private HSV RgbToHsv(Color color)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double h;

            if (max == min)
                h = 0;
            else if (max == r && g >= b)
                h = 60 * (g - b) / (max - min);
            else if (max == r && g < b)
                h = 60 * (g - b) / (max - min) + 360;
            else if (max == g)
                h = 60 * (b - r) / (max - min) + 120;
            else
                h = 60 * (r - g) / (max - min) + 240;

            double s;

            if (max == 0)
                s = 0;
            else
                s = 1 - min / max;

            double v = max;

            HSV hsv;
            hsv.H = h;
            hsv.S = s;
            hsv.V = v;

            return hsv;
        }

        private Color HsvToRgb(HSV hsv)
        {
            double h = hsv.H;
            double s = hsv.S;
            double v = hsv.V;

            int hi = (int)Math.Floor(h / 60) % 6;
            double f = h / 60 - Math.Floor(h / 60);

            double p = v * (1 - s);
            double q = v * (1 - f * s);
            double t = v * (1 - (1 - f) * s);

            double r = 0;
            double g = 0;
            double b = 0;

            switch (hi)
            {
                case 0:
                    r = v;
                    g = t;
                    b = p;
                    break;

                case 1:
                    r = q;
                    g = v;
                    b = p;
                    break;

                case 2:
                    r = p;
                    g = v;
                    b = t;
                    break;

                case 3:
                    r = p;
                    g = q;
                    b = v;
                    break;

                case 4:
                    r = t;
                    g = p;
                    b = v;
                    break;

                case 5:
                    r = v;
                    g = p;
                    b = q;
                    break;
            }

            return Color.FromArgb(
                (int)Math.Round(r * 255),
                (int)Math.Round(g * 255),
                (int)Math.Round(b * 255)
            );
        }

        private void UpdateHSV()
        {
            if (originalImage == null)
                return;

            int hueChange = trackHue.Value;
            double saturationChange = trackSaturation.Value / 100.0;
            double valueChange = trackValue.Value / 100.0;

            Bitmap newImage = originalImage.Select(color =>
            {
                HSV hsv = RgbToHsv(color);

                hsv.H = (hsv.H + hueChange + 360) % 360;
                hsv.S = Math.Max(0, Math.Min(1, hsv.S + saturationChange));
                hsv.V = Math.Max(0, Math.Min(1, hsv.V + valueChange));

                return HsvToRgb(hsv);
            });

            if (hsvImage != null)
                hsvImage.Dispose();

            hsvImage = newImage;
            pictureResultHSV.Image = hsvImage;
        }
        public Form1()
        {
            InitializeComponent();
        }

        // загрузка изображения
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(dialog.FileName);

                pictureOriginalGray.Image = originalImage;
                pictureOriginalRGB.Image = originalImage;
                pictureOriginalHSV.Image = originalImage;

                trackHue.Value = 0;
                trackSaturation.Value = 0;
                trackValue.Value = 0;

                labelHueValue.Text = "Оттенок: 0°";
                labelSaturationValue.Text = "Насыщенность: 0";
                labelValueValue.Text = "Яркость: 0";

                UpdateHSV();
            }
        }

        //обработчики задания 1
        private void btnGray_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
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

        //обработчики задания 2
        private void btnRGB_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
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

        //обработчики задания 3
        private void trackHSV_Scroll(object sender, EventArgs e)
        {
            labelHueValue.Text = "Оттенок: " + trackHue.Value + "°";
            labelSaturationValue.Text = "Насыщенность: " + trackSaturation.Value;
            labelValueValue.Text = "Яркость: " + trackValue.Value;

            UpdateHSV();
        }
        private void btnSaveHSV_Click(object sender, EventArgs e)
        {
            if (hsvImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG изображение|*.png";
            dialog.FileName = "HSV_result.png";

            if (dialog.ShowDialog() == DialogResult.OK)
                hsvImage.Save(dialog.FileName, ImageFormat.Png);
        }
    }
}
