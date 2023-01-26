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
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.Reg;
using Emgu.CV.UI;
using System.IO;

namespace Image_processing
{
    public partial class Form1 : Form
    {

        string[] files_names;
        string file_name;
        int current_index = 0;

        int undoIndex = -1;
        List<Mat> imageList = new List<Mat>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.png, *.jfif) | *.jpg;*.png;*.jfif";
            
            ofd.Multiselect = true;
            
            ofd.CheckFileExists = true;
            

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file_name = ofd.FileName; 
                files_names = ofd.FileNames;
                listBox1.SuspendLayout();
                listBox1.Items.AddRange(ofd.FileNames);
                listBox1.ResumeLayout();
                current_index = 0; 
                listBox1.SelectedIndex = current_index; 
                panAndZoomPictureBox1.Image = Image.FromFile(files_names[current_index]);
                textBox1.Text = getImageDetails(Image.FromFile(files_names[current_index]));
                imageList.Add(BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image));
                undoIndex++;
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; 
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] file_list = (string[])e.Data.GetData(DataFormats.FileDrop);
            listBox1.Items.Clear();
            listBox1.SuspendLayout();
            listBox1.Items.AddRange(file_list);
            listBox1.ResumeLayout();
            current_index = 0;
            listBox1.SelectedIndex = current_index;
            panAndZoomPictureBox1.Image = Image.FromFile(file_list[current_index]);
            textBox1.Text = getImageDetails(Image.FromFile(file_list[current_index]));
            imageList.Add(BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image));
            undoIndex++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_index = listBox1.SelectedIndex;
            string file_name = listBox1.SelectedItem.ToString();
            panAndZoomPictureBox1.Image = Image.FromFile(file_name);
            textBox1.Text = getImageDetails(Image.FromFile(file_name));
            imageList.Add(BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image));
            undoIndex++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current_index++; 
            if (current_index >= listBox1.Items.Count) 
            {
                current_index = 0; 
            }
            listBox1.SelectedIndex = current_index;
            panAndZoomPictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
            textBox1.Text = getImageDetails(Image.FromFile(listBox1.SelectedItem.ToString()));
            imageList.Add(BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image));
            undoIndex++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current_index--; 
            if (current_index < 0) 
            {
                current_index = listBox1.Items.Count - 1; 
            }
            listBox1.SelectedIndex = current_index;
            panAndZoomPictureBox1.Image = Image.FromFile(listBox1.SelectedItem.ToString());
            textBox1.Text = getImageDetails(Image.FromFile(listBox1.SelectedItem.ToString()));
            imageList.Add(BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image));
            undoIndex++;
        }

        private string getImageDetails(Image selectedImage)
        {
            string format = "Format";

            if (selectedImage.RawFormat == ImageFormat.Jpeg)
            {
                format = "Format: Jpeg";
            }
            else if (selectedImage.RawFormat == ImageFormat.Png)
            {
                format = "Format: Png";
            }
            else if (selectedImage.RawFormat == ImageFormat.Tiff)
            {
                format = "Format: Tiff";
            }else if (selectedImage.RawFormat == ImageFormat.Bmp)
            {
                format = "Foramt: Bmp";
            }
            else if (selectedImage.RawFormat == ImageFormat.Gif)
            {
                format = "Foramt: Gif";
            }
            else
            {
                format = "s";
            }

            string imageDetails = "Width: " + selectedImage.Width + System.Environment.NewLine + "Height: " + selectedImage.Height + System.Environment.NewLine +
                selectedImage.RawFormat.Guid.ToString();
            return imageDetails;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Image<Bgr, byte> image = new Image<Bgr, byte>(listBox1.SelectedItem.ToString());
                Mat image_mat = image.Mat;
                Mat image_gray = new Mat();
                CvInvoke.CvtColor(image_mat, image_gray, ColorConversion.Bgr2Gray);
                Image<Gray, byte>[] images = image.Split();
                Mat B = images[0].Mat;
                Mat G = images[1].Mat;
                Mat R = images[2].Mat;

                //Histogram
                CvInvoke.CalcHist(new VectorOfMat(R), new int[] { 0 }, null, R, new int[] { 256 }, new float[] { 0, 255 }, false);
                CvInvoke.CalcHist(new VectorOfMat(G), new int[] { 0 }, null, G, new int[] { 256 }, new float[] { 0, 255 }, false);
                CvInvoke.CalcHist(new VectorOfMat(B), new int[] { 0 }, null, B, new int[] { 256 }, new float[] { 0, 255 }, false);
                CvInvoke.CalcHist(new VectorOfMat(image_gray), new int[] { 0 }, null, B, new int[] { 256 }, new float[] { 0, 255 }, false);


                CvInvoke.Normalize(R, R, 0, 300, NormType.MinMax);
                R.ConvertTo(R, DepthType.Cv32S);

                CvInvoke.Normalize(G, G, 0, 300, NormType.MinMax);
                G.ConvertTo(G, DepthType.Cv32S);

                CvInvoke.Normalize(B, B, 0, 300, NormType.MinMax);
                B.ConvertTo(B, DepthType.Cv32S);

                CvInvoke.Normalize(image_gray, image_gray, 0, 300, NormType.MinMax);
                image_gray.ConvertTo(image_gray, DepthType.Cv32S);


                Mat histR_image = Mat.Zeros(300, 256, DepthType.Cv8U, 3);
                Point[] pointsR = new Point[256];
                for (int i = 0; i < pointsR.Length; i++)
                    pointsR[i] = new Point(i, 300 - (int)(R.ToImage<Gray, byte>().Data[i, 0, 0]));
                CvInvoke.Polylines(histR_image, pointsR, false, new MCvScalar(255, 0, 0));

                Mat histG_image = Mat.Zeros(300, 256, DepthType.Cv8U, 3);
                Point[] pointsG = new Point[256];
                for (int i = 0; i < pointsG.Length; i++)
                    pointsG[i] = new Point(i, 300 - (int)(G.ToImage<Gray, byte>().Data[i, 0, 0]));
                CvInvoke.Polylines(histG_image, pointsG, false, new MCvScalar(0, 255, 0));

                Mat histB_image = Mat.Zeros(300, 256, DepthType.Cv8U, 3);
                Point[] pointsB = new Point[256];
                for (int i = 0; i < pointsB.Length; i++)
                    pointsB[i] = new Point(i, 300 - (int)(B.ToImage<Gray, byte>().Data[i, 0, 0]));
                CvInvoke.Polylines(histB_image, pointsB, false, new MCvScalar(0, 0, 255));

                Mat histGray_image = Mat.Zeros(300, 256, DepthType.Cv8U, 3);
                Point[] pointsGray = new Point[256];
                for (int i = 0; i < pointsGray.Length; i++)
                    pointsGray[i] = new Point(i, 300 - (int)(B.ToImage<Gray, byte>().Data[i, 0, 0]));
                CvInvoke.Polylines(histGray_image, pointsGray, false, new MCvScalar(255, 255, 255));

                CvInvoke.Init();
                string win = "Histograms";
                CvInvoke.NamedWindow(win);

                Mat all_images = new Mat();
                CvInvoke.HConcat(new Mat[] { histR_image, histG_image, histB_image, histGray_image }, all_images);
                CvInvoke.Imshow(win, all_images);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            try{

                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                int h = Int32.Parse(height.Text.Trim());
                int w = Int32.Parse(width.Text.Trim());

                Mat image_resized = new Mat();

                CvInvoke.Resize(image, image_resized,
                    new Size(w, h),
                    interpolation: Inter.Cubic);

                imageList.Add(image_resized);
                panAndZoomPictureBox1.Image = image_resized.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "Resize";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, image_resized);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (undoIndex > 0)
            {
                // Decrement the current index
                undoIndex--;

                // Load the previous state of the list
                panAndZoomPictureBox1.Image = imageList[undoIndex].ToBitmap();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                string text = text2img.Text.Trim();
                Size imageSize = image.Size;
                Point center = new Point(imageSize.Width / 5, imageSize.Height / 5);
                CvInvoke.PutText(image,
                    text,
                    center,
                    FontFace.HersheyComplex,
                    1.0, new Bgr(0, 0, 0).MCvScalar);

                imageList.Add(image);
                panAndZoomPictureBox1.Image = image.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, image);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                double[,] tmatrix = new double[,] { { 0, 0, 0 }, { 0, 0, 0 } };
                Matrix<double> tmat = new Matrix<double>(tmatrix);
                Mat rmat = new Mat();
                CvInvoke.GetRotationMatrix2D(
                    new PointF(image.Width / 2, image.Height / 2),
                    90,
                    0.5, rmat);
                Mat img_t = new Mat();
                CvInvoke.WarpAffine(
                    image, img_t,
                    rmat,
                    new Size(image.Width, image.Height)
                    );

                imageList.Add(img_t);
                panAndZoomPictureBox1.Image = img_t.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, img_t);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                double[,] tmatrix = new double[,] { { 0, 0, 0 }, { 0, 0, 0 } };
                Matrix<double> tmat = new Matrix<double>(tmatrix);
                Mat rmat = new Mat();
                CvInvoke.GetRotationMatrix2D(
                    new PointF(image.Width / 2, image.Height / 2),
                    180,
                    0.5, rmat);
                Mat img_t = new Mat();
                CvInvoke.WarpAffine(
                    image, img_t,
                    rmat,
                    new Size(image.Width, image.Height)
                    );

                imageList.Add(img_t);
                panAndZoomPictureBox1.Image = img_t.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                 string win = "With Text";
                 CvInvoke.NamedWindow(win);

                 CvInvoke.Imshow(win, img_t);


                 CvInvoke.WaitKey(0);
                 CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                double[,] tmatrix = new double[,] { { 0, 0, 0 }, { 0, 0, 0 } };
                Matrix<double> tmat = new Matrix<double>(tmatrix);
                Mat rmat = new Mat();
                CvInvoke.GetRotationMatrix2D(
                    new PointF(image.Width / 2, image.Height / 2),
                    -90,
                    0.5, rmat);
                Mat img_t = new Mat();
                CvInvoke.WarpAffine(
                    image, img_t,
                    rmat,
                    new Size(image.Width, image.Height)
                    );

                imageList.Add(img_t);
                panAndZoomPictureBox1.Image = img_t.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, img_t);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                RangeF min_max = image.GetValueRange();
                double max = min_max.Max;
                double c = 255 / Math.Log(1 + max, Math.E);
                Mat img_log = new Mat();
                image.ConvertTo(image, DepthType.Cv32F);
                CvInvoke.Log(image, img_log);
                img_log *= c;
                image.ConvertTo(image, DepthType.Cv8U);
                img_log.ConvertTo(img_log, DepthType.Cv8U);

                imageList.Add(img_log);
                panAndZoomPictureBox1.Image = img_log.ToBitmap();

                undoIndex++;
                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, img_log);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex) {

                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                RangeF min_max = image.GetValueRange();
                double max = min_max.Max;
                double c = 255 / Math.Log(1 + max, Math.E);
                c = 1 * 255;
                double g = 0.5;
                Mat img_power = new Mat();
                image.ConvertTo(image, DepthType.Cv32F);
                CvInvoke.Pow(image / 255.0, g, img_power);
                img_power *= c;
                image.ConvertTo(image, DepthType.Cv8U);
                img_power.ConvertTo(img_power, DepthType.Cv8U);

                imageList.Add(img_power);
                panAndZoomPictureBox1.Image = img_power.ToBitmap();

                undoIndex++;
                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, img_power);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                Mat image_gray = new Mat();
                CvInvoke.CvtColor(image, image_gray, ColorConversion.Bgr2Gray);

                Mat image_eq = new Mat();
                CvInvoke.CLAHE(image_gray, 10, new Size(16, 16), image_eq);

                imageList.Add(image_eq);
                panAndZoomPictureBox1.Image = image_eq.ToBitmap();

                undoIndex++;
                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, image_eq);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                CvInvoke.CvtColor(image, image, ColorConversion.Bgra2Gray);

                Mat filtered = new Mat(image.Rows, image.Cols, image.Depth, image.NumberOfChannels);


                CvInvoke.BoxFilter(
                    src: image,
                    dst: filtered,
                    ddepth: image.Depth,
                    ksize: new Size(7, 7),
                    anchor: new Point(-1, -1)
                    );

                imageList.Add(filtered);
                panAndZoomPictureBox1.Image = filtered.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, filtered);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                CvInvoke.CvtColor(image, image, ColorConversion.Bgra2Gray);

                Mat filtered = new Mat(image.Rows, image.Cols, image.Depth, image.NumberOfChannels);


                CvInvoke.GaussianBlur(
                    src: image,
                    dst: filtered,
                    ksize: new Size(7, 7),
                    sigmaX: 1);

                imageList.Add(filtered);
                panAndZoomPictureBox1.Image = filtered.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, filtered);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {

                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                CvInvoke.CvtColor(image, image, ColorConversion.Bgra2Gray);

                Mat filtered = new Mat(image.Rows, image.Cols, image.Depth, image.NumberOfChannels);


                CvInvoke.Laplacian(
                   src: image,
                   dst: filtered,
                   ddepth: image.Depth);


                imageList.Add(filtered);
                panAndZoomPictureBox1.Image = filtered.ToBitmap();

                undoIndex++;
                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, filtered);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/

            }
            catch (Exception ex) {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                CvInvoke.CvtColor(image, image, ColorConversion.Bgra2Gray);

                Mat filtered = new Mat(image.Rows, image.Cols, image.Depth, image.NumberOfChannels);


                CvInvoke.Sobel(
                   src: image,
                   dst: filtered,
                   ddepth: image.Depth,
                   1,
                   1);

                imageList.Add(filtered);
                panAndZoomPictureBox1.Image = filtered.ToBitmap();

                undoIndex++;
                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);

                CvInvoke.Imshow(win, filtered);


                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                Mat bgr = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                Mat gray = new Mat();
                CvInvoke.CvtColor(bgr, gray, ColorConversion.Bgr2Gray);

                imageList.Add(gray);
                panAndZoomPictureBox1.Image = gray.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);
                CvInvoke.Imshow(win, gray);
                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/

            }
            catch (Exception ex) {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                Mat bgr = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                VectorOfMat vm = new VectorOfMat();
                CvInvoke.Split(bgr, vm);
                Mat z = Mat.Zeros(bgr.Rows, bgr.Cols, bgr.Depth, 1);

                Mat blue = new Mat();
                VectorOfMat blue_vm = new VectorOfMat(vm[0], z, z);
                CvInvoke.Merge(blue_vm, blue);

                Mat green = new Mat();
                VectorOfMat green_vm = new VectorOfMat(z, vm[1], z);
                CvInvoke.Merge(green_vm, green);

                Mat red = new Mat();
                VectorOfMat red_vm = new VectorOfMat(z, z, vm[2]);
                CvInvoke.Merge(red_vm, red);

                Mat[] all_images = new Mat[] { blue, green, red };

                for (int i = 0; i < all_images.Length; i++)
                {
                    CvInvoke.Init();
                    string win = "With Text";
                    CvInvoke.NamedWindow(win);
                    CvInvoke.Imshow(win, all_images[i]);
                    CvInvoke.WaitKey(0);
                    CvInvoke.DestroyAllWindows();
                }

            }
            catch (Exception ex) {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                Mat ymc = 255 - BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                VectorOfMat vm = new VectorOfMat();
                CvInvoke.Split(ymc, vm);
                Mat z = Mat.Zeros(ymc.Rows, ymc.Cols, ymc.Depth, 1);

                Mat yellow = new Mat();
                VectorOfMat yellow_vm = new VectorOfMat(z, vm[0], vm[0]);
                CvInvoke.Merge(yellow_vm, yellow);

                Mat magenta = new Mat();
                VectorOfMat magenta_vm = new VectorOfMat(vm[1], z, vm[1]);
                CvInvoke.Merge(magenta_vm, magenta);

                Mat cyan = new Mat();
                VectorOfMat cyan_vm = new VectorOfMat(vm[2], vm[2], z);
                CvInvoke.Merge(cyan_vm, cyan);

                Mat[] all_images = new Mat[] { yellow, magenta, cyan };

                for (int i = 0; i < all_images.Length; i++)
                {
                    CvInvoke.Init();
                    string win = "With Text";
                    CvInvoke.NamedWindow(win);
                    CvInvoke.Imshow(win, all_images[i]);
                    CvInvoke.WaitKey(0);
                    CvInvoke.DestroyAllWindows();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                Mat ymc = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);
                ymc.ConvertTo(ymc, DepthType.Cv32F);
                ymc /= 255.0;
                VectorOfMat vm = new VectorOfMat();
                CvInvoke.Split(ymc, vm);
                Mat z = Mat.Zeros(ymc.Rows, ymc.Cols, DepthType.Cv8U, 1);

                Mat black = new Mat();
                CvInvoke.Min(vm[0], vm[1], black);
                CvInvoke.Min(vm[2], black, black);

                // y = (y-k)/(255-k)
                Mat yellow = vm[0];
                yellow = 255 * Divide(yellow, black);
                yellow.ConvertTo(yellow, DepthType.Cv8U);
                VectorOfMat yellow_vm = new VectorOfMat(z, yellow, yellow);
                CvInvoke.Merge(yellow_vm, yellow);

                Mat magenta = vm[1];
                magenta = 255 * Divide(magenta, black);
                magenta.ConvertTo(magenta, DepthType.Cv8U);
                VectorOfMat magenta_vm = new VectorOfMat(magenta, z, magenta);
                CvInvoke.Merge(magenta_vm, magenta);

                Mat cyan = vm[2];
                cyan = 255 * Divide(cyan, black);
                cyan.ConvertTo(cyan, DepthType.Cv8U);
                VectorOfMat cyan_vm = new VectorOfMat(cyan, cyan, z);
                CvInvoke.Merge(cyan_vm, cyan);

                black *= 255;
                black.ConvertTo(black, DepthType.Cv8U);

                Mat[] all_images = new Mat[] { yellow, magenta, cyan, black };

                for (int i = 0; i < all_images.Length; i++)
                {
                    CvInvoke.Init();
                    string win = "With Text";
                    CvInvoke.NamedWindow(win);
                    CvInvoke.Imshow(win, all_images[i]);
                    CvInvoke.WaitKey(0);
                    CvInvoke.DestroyAllWindows();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private Mat Divide(Mat c, Mat k)
        {
            Image<Gray, float> color = c.ToImage<Gray, float>();
            Image<Gray, float> black = k.ToImage<Gray, float>();

            for (int i = 0; i < c.Rows; i++)
            {
                for (int j = 0; j < c.Cols; j++)
                {
                    if (black.Data[i, j, 0] == 1)
                        color.Data[i, j, 0] = 0;
                    else
                    {
                        color.Data[i, j, 0] = (color.Data[i, j, 0] - black.Data[i, j, 0]) / (1 - black.Data[i, j, 0]);
                    }
                }
            }

            return color.Mat;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                Matrix<byte> increase_lut = generate_gray_level_lut(new double[] { 0, 64, 128, 192, 255 }, new double[] { 0, 80, 160, 220, 255 });
                Matrix<byte> decrease_lut = generate_gray_level_lut(new double[] { 0, 64, 128, 192, 255 }, new double[] { 0, 50, 100, 150, 255 });


                CvInvoke.ConvertScaleAbs(image, image, 0.5, 0);

                //split
                VectorOfMat vm = new VectorOfMat();
                CvInvoke.Split(image, vm);

                //1- cold
                //change color map
                Mat new_b = new Mat();
                CvInvoke.LUT(vm[0], increase_lut, new_b);
                Mat new_g = vm[1];
                Mat new_r = new Mat();
                CvInvoke.LUT(vm[2], decrease_lut, new_r);

                //merge
                VectorOfMat new_vm = new VectorOfMat(new_b, new_g, new_r);
                Mat cold_image = new Mat();
                CvInvoke.Merge(new_vm, cold_image);

                imageList.Add(cold_image);
                panAndZoomPictureBox1.Image = cold_image.ToBitmap();

                undoIndex++;

                /*
                CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);
                CvInvoke.Imshow(win, cold_image);
                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                Matrix<byte> increase_lut = generate_gray_level_lut(new double[] { 0, 64, 128, 192, 255 }, new double[] { 0, 80, 160, 220, 255 });
                Matrix<byte> decrease_lut = generate_gray_level_lut(new double[] { 0, 64, 128, 192, 255 }, new double[] { 0, 50, 100, 150, 255 });


                CvInvoke.ConvertScaleAbs(image, image, 0.5, 0);

                //split
                VectorOfMat vm = new VectorOfMat();
                CvInvoke.Split(image, vm);


                Mat new_b = new Mat();
                CvInvoke.LUT(vm[0], decrease_lut, new_b);
                Mat new_g = vm[1];
                Mat new_r = new Mat();
                CvInvoke.LUT(vm[2], increase_lut, new_r);

                //merge
                VectorOfMat new_vm = new VectorOfMat(new_b, new_g, new_r);
                Mat warm_image = new Mat();
                CvInvoke.Merge(new_vm, warm_image);

                imageList.Add(warm_image);
                panAndZoomPictureBox1.Image = warm_image.ToBitmap();

                undoIndex++;

                /*CvInvoke.Init();
                string win = "With Text";
                CvInvoke.NamedWindow(win);
                CvInvoke.Imshow(win, warm_image);
                CvInvoke.WaitKey(0);
                CvInvoke.DestroyAllWindows(); */

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Matrix<byte> generate_gray_level_lut(double[] current, double[] target)
        {
            byte[] lut = new byte[256];

            if (current.Length != target.Length)
                throw new ArgumentException("inputs should be of the same size");

            double[,] equations_coefficient = get_equations_coefficient(current, target);

            for (int i = 0; i < lut.Length; i++)
            {
               
                int index = 0;
                for (int j = 0; j < current.Length - 2; j++)
                    if (i >= current[j] && i <= current[j + 1])
                    {
                        index = j;
                        break;
                    }
                
                double temp = equations_coefficient[index, 0] * i + equations_coefficient[index, 1];

                if (temp < 0)
                    temp = 0;
                if (temp > 255)
                    temp = 255;
                lut[i] = (byte)temp;
            }



            return new Matrix<byte>(lut);
        }
        private static double[,] get_equations_coefficient(double[] current, double[] target)
        {
            
            double[,] equations_coefficient = new double[current.Length - 1, 2];

            for (int i = 0; i < current.Length - 1; i++)
            {
                
                equations_coefficient[i, 0] = (target[i + 1] - target[i]) / (current[i + 1] - current[i]);
                
                equations_coefficient[i, 1] = target[i + 1] - equations_coefficient[i, 0] * current[i + 1];
            }

            return equations_coefficient;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.jpg, *.png, *.jfif) | *.jpg;*.png;*.jfif";

                ofd.Multiselect = true;

                ofd.CheckFileExists = true;


                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Image<Bgr, byte> logo = new Image<Bgr, byte>(ofd.FileName);
                    Mat logo_mat = logo.Mat;

                    Mat image = BitmapExtension.ToMat((Bitmap)panAndZoomPictureBox1.Image);

                    CvInvoke.Resize(logo_mat, logo_mat, new Size(100, 100));

                    int logo_w = logo_mat.Cols;
                    int logo_h = logo_mat.Rows;
                    Rectangle roi = new Rectangle(image.Cols - logo_w - 10, image.Rows - logo_h - 10, logo_w, logo_h);

                    Mat logoMask = new Mat(logo_mat.Size, DepthType.Cv8U, 3);
                    logoMask.SetTo(new MCvScalar(255.0, 255.0, 255.0));

                    CvInvoke.AddWeighted(new Mat(image, roi), 1.0, logo_mat, 1.0, 0.0, logo_mat);
                    CvInvoke.BitwiseAnd(logo_mat, logoMask, logo_mat);
                    CvInvoke.AddWeighted(new Mat(image, roi), 1.0, logo_mat, 1.0, 0.0, new Mat(image, roi));


                    imageList.Add(image);
                    panAndZoomPictureBox1.Image = image.ToBitmap();

                    undoIndex++;

                    /*CvInvoke.Init();
                    string win = "With Text";
                    CvInvoke.NamedWindow(win);
                    CvInvoke.Imshow(win, image);
                    CvInvoke.WaitKey(0);
                    CvInvoke.DestroyAllWindows();*/
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Jpeg Image|*.jpg";
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = sfd.FileName;
                if (!fileName.EndsWith(".jpg"))
                    fileName = Path.ChangeExtension(fileName, "jpg");
                panAndZoomPictureBox1.Image.Save(fileName);
            }

        }
    }
}
