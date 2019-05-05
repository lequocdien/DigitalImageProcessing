using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace ImageProcessing
{
    public partial class DigitalImageProcessing : Form
    {
        mConvertion cv = new mConvertion();
        private static Bitmap sbm = null;

        public DigitalImageProcessing()
        {
            InitializeComponent();
        }


        #region Open

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbm = mFile.OpenFile();
            if(sbm != null && sbm.Width == sbm.Height)
            {
                picBox_AnhGoc.Image = sbm;
                mConvertion cv = new mConvertion();
                int[,] MaTranAnhGoc = cv.ConvertBitmapToMatrixGray(sbm);
                int[] Histogram = cv.ConvertMatrixToHistogram(MaTranAnhGoc);
                mChart.ChartBar(Histogram, zedGraphControl1);
                //for (int i = 0; i < Histogram.Length; i++)
                //{
                //    Console.WriteLine(Histogram[i]);
                //}
            }
            else
            {
                MessageBox.Show("Chỉ chấp nhận ảnh vuông ^_^", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        //Sự kiện khi click vào Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mFile.SaveFile(picBox_AnhDaXuLy);
        }
        //Sự kiện khi click vào Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
        }
        #endregion

        #region View

        private void sizeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                MessageBox.Show("Width: " + sbm.Width +"px"+ "\n" + "Height: " + sbm.Height + "px", "Thông tin ảnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void matrixGrayLevelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                
                int[,] MaTranAnhXam = cv.ConvertBitmapToMatrixGray(sbm);
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream("MaTranAnhXam.txt", FileMode.Truncate, FileAccess.Write);
                    sw = new StreamWriter(fs, UTF8Encoding.UTF8);
                    for (int i = 0; i < MaTranAnhXam.GetLength(0); i++)
                    {
                        sw.Write("|\t");
                        for (int j = 0; j < MaTranAnhXam.GetLength(1); j++)
                        {
                            sw.Write(MaTranAnhXam[i, j] + "\t");
                        }
                        sw.WriteLine("|");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Flush();
                        sw.Close();
                        sw.Dispose();
                    }
                    if (fs != null)
                    {
                        fs.Close();
                        fs.Dispose();
                    }
                }
                string path = Application.StartupPath + "\\MaTranAnhXam.txt";
                Process.Start("notepad.exe", path);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Image Enhancement

        #region Histogram Equalisation
        private void histogramEqualisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh sau khi cân bằng Histogram";
                groupBox4.Text = "Histogram của ảnh sau khi cân bằng";
                int[,] MaTranAnhDaCanBangHistogram = HistogramEqualisation.Equalisation(new mConvertion(), sbm);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhDaCanBangHistogram);
                int[] HistogramDaCanBang = cv.ConvertMatrixToHistogram(MaTranAnhDaCanBangHistogram);
                mChart.ChartBar(HistogramDaCanBang, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Point Enhancement
        private void negativeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh Negative";
                groupBox4.Text = "Histogram của ảnh Negative";
                int[,] MaTranAnhNegative = PointProcessing.PointProcessingNegative(sbm, new mConvertion());
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhNegative);
                int[] HistogramAnhNegative = cv.ConvertMatrixToHistogram(MaTranAnhNegative);
                mChart.ChartBar(HistogramAnhNegative, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thresholdingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                fmInput fm = new fmInput();
                fm.ShowDialog();
                groupBox3.Text = "Ảnh Thresholding";
                groupBox4.Text = "Histogram của ảnh Thresholding";
                int[,] MaTranAnhThresholding = PointProcessing.PointProcessingThresholding(sbm, new mConvertion(), fm.getInput());
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhThresholding);
                int[] HistogramAnhThresholding = cv.ConvertMatrixToHistogram(MaTranAnhThresholding);
                mChart.ChartBar(HistogramAnhThresholding, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logarithmicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                fmInput fm = new fmInput();
                fm.ShowDialog();
                groupBox3.Text = "Ảnh Logarit";
                groupBox4.Text = "Histogram của ảnh Logarit";
                int[,] MaTranAnhLogarit = PointProcessing.PointProcessingLogarit(sbm, new mConvertion(), fm.getInput());
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhLogarit);
                int[] HistogramAnhLogarit = cv.ConvertMatrixToHistogram(MaTranAnhLogarit);
                mChart.ChartBar(HistogramAnhLogarit, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                fmInput fm = new fmInput();
                fm.ShowDialog();
                groupBox3.Text = "Ảnh Power";
                groupBox4.Text = "Histogram của ảnh Power";
                int[,] MaTranAnhPower = PointProcessing.PointProcessingPower(sbm, new mConvertion(), fm.getInput());
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhPower);
                int[] HistogramAnhPower = cv.ConvertMatrixToHistogram(MaTranAnhPower);
                mChart.ChartBar(HistogramAnhPower, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitPlaneSlicingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Spatical Filtering
        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua bộ lọc Min Filter";
                groupBox4.Text = "Histogram của ảnh qua bộ lọc Min Filter";
                int[,] MaTranAnhQuaMinFilter = SpatialFiltering.MinFilter(sbm, cv);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaMinFilter); ;
                int[] HistogramAnhQuaMinFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaMinFilter);
                mChart.ChartBar(HistogramAnhQuaMinFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua bộ lọc Max Filter";
                groupBox4.Text = "Histogram của ảnh qua bộ lọc Max Filter";
                int[,] MaTranAnhQuaMaxFilter = SpatialFiltering.MaxFilter(sbm, cv);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaMaxFilter); ;
                int[] HistogramAnhQuaMaxFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaMaxFilter);
                mChart.ChartBar(HistogramAnhQuaMaxFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua bộ lọc Median Filter";
                groupBox4.Text = "Histogram của ảnh qua bộ lọc Median Filter";
                int[,] MaTranAnhQuaMedianFilter = SpatialFiltering.MedianFilter(sbm, cv);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaMedianFilter);
                int[] HistogramAnhQuaMedianFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaMedianFilter);
                mChart.ChartBar(HistogramAnhQuaMedianFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void averagingFilterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua bộ lọc Averaging Filter";
                groupBox4.Text = "Histogram của ảnh qua bộ lọc Averaging Filter";
                int[,] MaTranAnhQuaAvaragingFilter = SpatialFiltering.AveragingFilter(sbm, cv);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaAvaragingFilter); ;
                int[] HistogramAnhQuaMedianFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaAvaragingFilter);
                mChart.ChartBar(HistogramAnhQuaMedianFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void weightedAveragingFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Weighted Averaging Filter";
                groupBox4.Text = "Histogram của ảnh qua Weighted Averaging Filter";
                int[,] MaTranAnhQuaWeightedAvaragingFilter = SpatialFiltering.WeightedAveragingFilter(sbm, cv);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaWeightedAvaragingFilter); ;
                int[] HistogramAnhQuaWeightedMedianFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaWeightedAvaragingFilter);
                mChart.ChartBar(HistogramAnhQuaWeightedMedianFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void laplacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Laplac Filter";
                groupBox4.Text = "Histogram của ảnh qua Laplac Filter";
                int[,] MaTranAnhQuaLaplacFilter = SpatialFiltering.LaplacFilter(sbm, cv);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaLaplacFilter);
                int[] HistogramAnhQuaLaplacFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaLaplacFilter);
                mChart.ChartBar(HistogramAnhQuaLaplacFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sharpenedLaplacToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                int pixel;
                groupBox3.Text = "Ảnh qua Sharpened Laplac Filter";
                groupBox4.Text = "Histogram của ảnh qua Sharpened Laplac Filter";
                int[,] MaTranAnhGoc = cv.ConvertBitmapToMatrixGray(sbm);
                int[,] MaTranAnhQuaLaplacFilter = SpatialFiltering.LaplacFilter(sbm, cv);
                int[,] MaTranAnhQuaSharpenedLaplacFilter = new int[sbm.Height, sbm.Width];
                for (int i = 0; i < MaTranAnhGoc.GetLength(0) - 2; i++)
                {
                    for (int j = 0; j < MaTranAnhGoc.GetLength(1) - 2; j++)
                    {
                        pixel = MaTranAnhGoc[i, j] - MaTranAnhQuaLaplacFilter[i, j];
                        if (pixel < 0)
                        {
                            pixel = 0;
                        }
                        else if (pixel > 255)
                        {
                            pixel = 255;
                        }
                        MaTranAnhQuaSharpenedLaplacFilter[i, j] = pixel;
                    }
                }
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaSharpenedLaplacFilter);
                int[] HistogramAnhQuaSharpenedLaplacFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaSharpenedLaplacFilter);
                mChart.ChartBar(HistogramAnhQuaSharpenedLaplacFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Sobel Filter";
                groupBox4.Text = "Histogram của ảnh qua Sobel Filter";
                int[,] MaTranAnhQuaSobelFilter = SpatialFiltering.SobelFilter(sbm, cv);
                int[] HistogramAnhQuaSobelFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaSobelFilter);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaSobelFilter);
                mChart.ChartBar(HistogramAnhQuaSobelFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Image Segmentation

        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Dectect Points";
                groupBox4.Text = "Histogram của ảnh qua Dectect Points";

                int[,] MaTranAnhQuaPointsFilter = ImageSegmentation.PointsFilter(sbm, cv); ;
                int[] HistogramAnhQuaPointsFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaPointsFilter);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaPointsFilter);
                mChart.ChartBar(HistogramAnhQuaPointsFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Dectect Lines";
                groupBox4.Text = "Histogram của ảnh qua Dectect Lines";

                int[,] MaTranAnhQuaLinesFilter = ImageSegmentation.LinesFilter(sbm, cv); ;
                int[] HistogramAnhQuaLinesFilter = cv.ConvertMatrixToHistogram(MaTranAnhQuaLinesFilter);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaLinesFilter);
                mChart.ChartBar(HistogramAnhQuaLinesFilter, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Image Morphological 

        private void hitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Hit";
                groupBox4.Text = "Histogram của ảnh qua Hit";

                int[,] MaTranAnhQuaHit = ImageMorphological.hit(sbm, cv); ;
                int[] HistogramAnhQuaHit = cv.ConvertMatrixToHistogram(MaTranAnhQuaHit);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaHit);
                mChart.ChartBar(HistogramAnhQuaHit, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sbm != null)
            {
                groupBox3.Text = "Ảnh qua Fit";
                groupBox4.Text = "Histogram của ảnh qua Fit";

                int[,] MaTranAnhQuaFit = ImageMorphological.fit(sbm, cv); ;
                int[] HistogramAnhQuaFit = cv.ConvertMatrixToHistogram(MaTranAnhQuaFit);
                picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhQuaFit);
                mChart.ChartBar(HistogramAnhQuaFit, zedGraphControl2);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region About

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
        #endregion









        //private void grayLevelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (sbm != null)
        //    {
        //        groupBox3.Text = "Ảnh mức xám";
        //        groupBox4.Text = "Histogram của ảnh mức xám";
        //        int[,] MaTranAnhXam = cv.ConvertBitmapToMatrixGray(sbm);
        //        picBox_AnhDaXuLy.Image = cv.ConvertMatrixToBitmap(MaTranAnhXam);
        //        int[] HistogramAnhXam = cv.ConvertMatrixToHistogram(MaTranAnhXam);
        //        mChart.ChartBar(HistogramAnhXam, zedGraphControl2);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
