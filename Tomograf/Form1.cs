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
using System.IO;

namespace Tomograf
{
    public partial class Main : Form
    {
        private Bitmap globalInBitmap;
        private Bitmap globalSiBitmap;
        private Bitmap globalOutBitmap;
        private List<Bitmap> stepOutBitmaps;



        public Image CenterDrawImage(Image imageBot, Image imageTop)
        {
            using (var graphics = Graphics.FromImage(imageBot))
            {
                int y = (imageBot.Height / 2) - imageTop.Height / 2;
                int x = (imageBot.Width / 2) - imageTop.Width / 2;

                graphics.DrawImage(imageTop, x, y, imageTop.Width, imageTop.Height);
            }

            return imageBot;
        }

        private static Bitmap DrawFilledRectangle(int x, int y)
        {
            Bitmap bmp = new Bitmap(x, y);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, x, y);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }
            return bmp;
        }

        public static int diagonal(int x, int y)
        {
            double result = Math.Sqrt(x * x + y * y);
            result = Math.Ceiling(result);
            return (int)result;
        }

        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
             new float[] {.3f, .3f, .3f, 0, 0},
             new float[] {.59f, .59f, .59f, 0, 0},
             new float[] {.11f, .11f, .11f, 0, 0},
             new float[] {0, 0, 0, 1, 0},
             new float[] {0, 0, 0, 0, 1}
                   });

                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);

                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;
        }
        private static Image cropImage(Image img, int cutWidth)
        {
            Bitmap bmpImage = new Bitmap(img);
            for(int i = cutWidth; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                    bmpImage.SetPixel(i, j, Color.Black);
            }
            return bmpImage;
        }
        private float bresenhamReader(Bitmap img, float diag, int x1, int y1, int x2, int y2)
        {
            float result = 0;
            int dx = Math.Abs(x2 - x1), sx = x1 < x2 ? 1 : -1;
            int dy = Math.Abs(y2 - y1), sy = y1 < y2 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                result += img.GetPixel(x1, y1).R;
                if (x1 == x2 && y1 == y2) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x1 += sx; }
                if (e2 < dy) { err += dx; y1 += sy; }
            }
            result /= diag;
            return result;
        }

        private void bresenhamSearchStr(Bitmap rimg, float[] img, float add, int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x2 - x1), sx = x1 < x2 ? 1 : -1;
            int dy = Math.Abs(y2 - y1), sy = y1 < y2 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                try
                {
                    img[x1 + y1 * rimg.Width] = img[x1 + y1 * rimg.Width] + add;
                }
                catch(Exception e)
                {

                }
                if (x1 == x2 && y1 == y2) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x1 += sx; }
                if (e2 < dy) { err += dx; y1 += sy; }
            }
        }
        private Bitmap bresenhamDraw(Bitmap img, int add, int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x2 - x1), sx = x1 < x2 ? 1 : -1;
            int dy = Math.Abs(y2 - y1), sy = y1 < y2 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            Bitmap result = img;
            for (; ; )
            {
                if (x1 >= 0 && x1 < img.Width && y1 >= 0 && y1 < img.Height)
                {
                    int colElem = Math.Min(255, Math.Max(0, add + img.GetPixel(x1, y1).R));
                    Color newColor = Color.FromArgb(colElem, colElem, colElem);
                    result.SetPixel(x1, y1, newColor);
                }
                if (x1 == x2 && y1 == y2) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x1 += sx; }
                if (e2 < dy) { err += dx; y1 += sy; }
            }
            return result;
        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();

            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "";

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;

            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            dlg.Filter = String.Format("{0}{1}{2} ({3})|{3}", dlg.Filter, sep, "All Files", "*.*");

            dlg.DefaultExt = ".PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = dlg.FileName;
                    Bitmap image = new Bitmap(fileName);
                    image = MakeGrayscale3(image);
                    int diag = diagonal(image.Width, image.Height);
                    Bitmap image2 = DrawFilledRectangle(diag, diag);
                    globalInBitmap = CenterDrawImage(image2, image) as Bitmap;
                    pictureIn.Image = globalInBitmap;
                    LabelError1.Text = "";
                    buttonStart.Enabled = true;
                }
                catch (Exception ex)
                {
                    LabelError1.Text = "Błędny format obrazu!";
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int rangeScan = Decimal.ToInt32(numericRangeScan.Value);
            int amDet = Decimal.ToInt32(numericAmountDet.Value);
            int amScans = Decimal.ToInt32(numericAmountScans.Value);
            float str = 0.0f;
            float angleStep = 180.0f / amScans;
            float angleBetDet = (float)rangeScan / amDet;
            float r = globalInBitmap.Width / 2;

            //Sinogram
            List<float> data = new List<float>();
            Bitmap resultBitmap = DrawFilledRectangle(amScans, amDet);
            Bitmap resultBitmap2 = DrawFilledRectangle(amScans, amDet);

            for (int i = 0; i < amScans; i++)
            {
                float mainAngle = i * angleStep;
                float actAngle = mainAngle + 360.0f - 0.5f * rangeScan;
                float actAngle2 = mainAngle + 180.0f + 0.5f * rangeScan;
                while (actAngle >= 360.0f)
                    actAngle -= 360.0f;
                while (actAngle2 >= 360.0f)
                    actAngle2 -= 360.0f;
                while (actAngle < 0.0f)
                    actAngle += 360.0f;
                while (actAngle2 < 0.0f)
                    actAngle2 += 360.0f;
                for (int j = 0; j < amDet; j++)
                {
                    float ang = actAngle / 180 * (float)Math.PI;
                    int x1 = (int)Math.Ceiling(r * Math.Cos(ang) +  r) - 1;
                    int y1 = (int)Math.Ceiling(r * Math.Sin(ang) +  r) - 1;
                    float ang2 = actAngle2 / 180 * (float)Math.PI;
                    int x2 = (int)Math.Ceiling(r * Math.Cos(ang2) +  r) - 1;
                    int y2 = (int)Math.Ceiling(r * Math.Sin(ang2) +  r) - 1;
                 
                    data.Add(bresenhamReader(globalInBitmap, globalInBitmap.Width, x1, y1, x2, y2));
                    Color myRgbColor = Color.FromArgb((int)data.Last(), (int)data.Last(), (int)data.Last());
                    resultBitmap.SetPixel(i, j, myRgbColor);

                    actAngle += angleBetDet;
                    actAngle2 -= angleBetDet;
                    while (actAngle >= 360.0f)
                        actAngle -= 360.0f;
                    while (actAngle2 >= 360.0f)
                        actAngle2 -= 360.0f;
                    while (actAngle < 0.0f)
                        actAngle += 360.0f;
                    while (actAngle2 < 0.0f)
                        actAngle2 += 360.0f;
                }
            }

            if (checkBoxFilter.Checked)
            {
                for (int i = 0; i < amScans; i++)
                {
                    for (int j = 0; j < amDet; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            if (k == 0)
                            {
                                resultBitmap2.SetPixel(i, j, resultBitmap.GetPixel(i, j));
                                continue;
                            }
                            if (k % 2 == 1)
                            {
                                float filter = (float)(-4 / (Math.PI * Math.PI)) / (k * k);
                                if (j + k < amDet)
                                {
                                    data[i * amDet + j] = Math.Max(0, filter * data[i * amDet + j + k] + data[i * amDet + j]);
                                }
                                if (j - k >= 0)
                                {
                                    data[i * amDet + j] = Math.Max(0, filter * data[i * amDet + j - k] + data[i * amDet + j]);
                                }
                            }
                        }
                    }
                }
                resultBitmap = resultBitmap2.Clone() as Bitmap;
            }

            globalSiBitmap = resultBitmap;
            pictureSinogram.Image = resultBitmap;
            //Sinogram END

            //BeforeOutput
            float[] searchList = new float[globalInBitmap.Width * globalInBitmap.Height];

            for (int i = 0; i < amScans; i++)
            {
                float mainAngle = i * angleStep;
                float actAngle = mainAngle + 360.0f - 0.5f * rangeScan;
                float actAngle2 = mainAngle + 180.0f + 0.5f * rangeScan;
                while (actAngle >= 360.0f)
                    actAngle -= 360.0f;
                while (actAngle2 >= 360.0f)
                    actAngle2 -= 360.0f;
                while (actAngle < 0.0f)
                    actAngle += 360.0f;
                while (actAngle2 < 0.0f)
                    actAngle2 += 360.0f;
                for (int j = 0; j < amDet; j++)
                {
                    float ang = actAngle / 180 * (float)Math.PI;
                    int x1 = (int)Math.Ceiling(r * Math.Cos(ang) + r) - 1;
                    int y1 = (int)Math.Ceiling(r * Math.Sin(ang) + r) - 1;
                    float ang2 = actAngle2 / 180 * (float)Math.PI;
                    int x2 = (int)Math.Ceiling(r * Math.Cos(ang2) + r) - 1;
                    int y2 = (int)Math.Ceiling(r * Math.Sin(ang2) + r) - 1;

                    bresenhamSearchStr(globalInBitmap, searchList, (int)data.ElementAt(i * amDet + j), x1, y1, x2, y2);

                    actAngle += angleBetDet;
                    actAngle2 -= angleBetDet;
                    while (actAngle >= 360.0f)
                        actAngle -= 360.0f;
                    while (actAngle2 >= 360.0f)
                        actAngle2 -= 360.0f;
                    while (actAngle < 0.0f)
                        actAngle += 360.0f;
                    while (actAngle2 < 0.0f)
                        actAngle2 += 360.0f;
                }
            }

            for(int i = 0; i < globalInBitmap.Width * globalInBitmap.Height; i++)
            {
                if (searchList[i] > str)
                    str = searchList[i];
            }
            str = str / 255;
            //BeforeOutput END

            //Output
            resultBitmap = DrawFilledRectangle(globalInBitmap.Width, globalInBitmap.Height);
            stepOutBitmaps = new List<Bitmap>();
            str /= 2.0f;

            for (int i = 0; i < amScans; i++)
            {
                float mainAngle = i * angleStep;
                float actAngle = mainAngle + 360.0f - 0.5f * rangeScan;
                float actAngle2 = mainAngle + 180.0f + 0.5f * rangeScan;
                while (actAngle >= 360.0f)
                    actAngle -= 360.0f;
                while (actAngle2 >= 360.0f)
                    actAngle2 -= 360.0f;
                while (actAngle < 0.0f)
                    actAngle += 360.0f;
                while (actAngle2 < 0.0f)
                    actAngle2 += 360.0f;
                for (int j = 0; j < amDet; j++)
                {
                    float ang = actAngle / 180 * (float)Math.PI;
                    int x1 = (int)Math.Ceiling(r * Math.Cos(ang) + r) - 1;
                    int y1 = (int)Math.Ceiling(r * Math.Sin(ang) + r) - 1;
                    float ang2 = actAngle2 / 180 * (float)Math.PI;
                    int x2 = (int)Math.Ceiling(r * Math.Cos(ang2) + r) - 1;
                    int y2 = (int)Math.Ceiling(r * Math.Sin(ang2) + r) - 1;
                    
                    bresenhamDraw(resultBitmap, (int)(data.ElementAt(i * amDet + j)/str), x1, y1, x2, y2);

                    actAngle += angleBetDet;
                    actAngle2 -= angleBetDet;
                    while (actAngle >= 360.0f)
                        actAngle -= 360.0f;
                    while (actAngle2 >= 360.0f)
                        actAngle2 -= 360.0f;
                    while (actAngle < 0.0f)
                        actAngle += 360.0f;
                    while (actAngle2 < 0.0f)
                        actAngle2 += 360.0f;
                }
                if(i%5 == 0)
                stepOutBitmaps.Add((Bitmap)resultBitmap.Clone());
            }
            globalOutBitmap = resultBitmap;
            pictureOut.Image = resultBitmap;
            //Output END

            //scroll info
            buttonSaveSinogram.Enabled = true;
            buttonSaveOutput.Enabled = true;
            scrollProgress.Enabled = true;
            scrollProgress.Minimum = 1;
            scrollProgress.Maximum = amScans;
            scrollProgress.Value = amScans;
            labelMaxStep.Text = "/ " + amScans.ToString();
            //scroll info END

            //RMSE
            double RMSE = 0.0;
            long amount = globalOutBitmap.Width * globalOutBitmap.Height;
            for (int i = 0; i < globalOutBitmap.Width; i++)
            {
                for(int j = 0; j < globalOutBitmap.Height; j++)
                {
                    RMSE += Math.Pow(globalInBitmap.GetPixel(i, j).R - globalOutBitmap.GetPixel(i, j).R, 2);
                }
            }
            RMSE = Math.Sqrt(RMSE / amount);
            labelRMSE.Text = RMSE.ToString();
            //RMSE END
        }

        private void scrollProgress_Scroll(object sender, ScrollEventArgs e)
        {
            labelStepProgress.Text = scrollProgress.Value.ToString();
            pictureSinogram.Image = cropImage(globalSiBitmap, scrollProgress.Value);
            pictureOut.Image = stepOutBitmaps.ElementAt((int)Math.Ceiling((double)(scrollProgress.Value)/5 - 1));
            if (scrollProgress.Value == scrollProgress.Maximum)
                pictureOut.Image = globalOutBitmap;
        }

        private void buttonSaveSinogram_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                globalSiBitmap.Save(sfd.FileName, format);
            }
        }

        private void buttonSaveOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                globalOutBitmap.Save(sfd.FileName, format);
            }
        }

      
    }
}
