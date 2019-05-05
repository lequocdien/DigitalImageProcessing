using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class ImageSegmentation
    {
        #region Thresholding-Tìm ngưỡng
        /*Trả về giá trị trung bình 
         * giá trị trung bình này là giá trị ở bước 4 
         * tức là (giá trị trung bình phần nhỏ hơn NGƯỠNG + giá trị trung bình phần lớn hon NGƯỠNG)/2
         * Công thức giá trị trung bình: tổng các số hạng/số các số hạng
         * tổng các số hạng: 
         * số các số hạng: số lượng các pixel trong phần nhỏ hơn NGƯỠNG hoặc phần lớn
         */
        public static int getValueThresholdingAverage(int T_gues, int[] HistogramAnhGoc)
        {
            int average1 = 0;
            int average2 = 0;
            int sum1 = 0;
            int sum2 = 0;
            int soCacSoHang1 = 1;               //Bằng 1 để trách phải chia cho 0 về sau
            int soCacSoHang2 = 1;
            for (int i = 0; i < T_gues; i++)
            {
                sum1 = sum1 + i * HistogramAnhGoc[i];
                soCacSoHang1 = soCacSoHang1 + HistogramAnhGoc[i];
            }
            for (int i = T_gues; i < 256; i++)
            {
                sum2 = sum2 + i * HistogramAnhGoc[i];
                soCacSoHang2 = soCacSoHang2 + HistogramAnhGoc[i];
            }
            average1 = sum1 / soCacSoHang1;
            average2 = sum2 / soCacSoHang2;
            return (average1 + average2) / 2;
        }
        /*
         * Hàm so sánh giữa chỉ số của mảng và giá trị của mảng
         * sau đó trả về giá trị chênh lệch nhỏ nhất giữa
         * chỉ số và giá trị
         * 
         */
        public static int getValueDifference(int[] Thresholding)
        {
            int min = 255;
            for (int i = 0; i < Thresholding.Length; i++)
            {
                if (Math.Abs(i - Thresholding[i]) < min)
                {
                    min = Math.Abs(i - Thresholding[i]);
                }
            }
            return min;
        }

        public static int getValueThreshoding(int[] HistogramAnhGoc)
        {
            int[] Thresholding = new int[256];  //Mảng chứa T tương ứng với T-gues (T là giá trị ở bước 4)
            int minDifference = 0;
            for (int i = 0; i < 256; i++)
            {
                Thresholding[i] = getValueThresholdingAverage(i, HistogramAnhGoc);
            }
            minDifference = getValueDifference(Thresholding);
            /*
             * Tìm chỉ số i mà có giá trị chênh lệch giữa chỉ số và giá trị trong mảng Thresholding
             */
            for (int i = 0; i < Thresholding.Length; i++)
            {
                if (Math.Abs(i - Thresholding[i]) == minDifference)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }
        #endregion

        #region Bộ lọc điểm (Points Detection)
        /*
         *              -1  -1  -1
         *              -1  8   -1
         *              -1  -1  -1
         * 
         */
        public static int getValuePointsFilter(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = -1 * MatrixAnhGoc[x, y] - 1 * MatrixAnhGoc[x + 1, y] - 1 * MatrixAnhGoc[x + 2, y] - 1 * MatrixAnhGoc[x, y + 1] + 8 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x + 2, y + 1] - 1 * MatrixAnhGoc[x, y + 2] - 1 * MatrixAnhGoc[x + 1, y + 2] - 1 * MatrixAnhGoc[x + 2, y + 2];
            if (value < 0)
            {
                return 0;
            }
            else if (value > 255)
            {
                return 255;
            }
            else
            {
                return value;
            }
        }

        public static int[,] PointsFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[] HistogramAnhGoc = convertion.ConvertMatrixToHistogram(MaTranAnhGoc);
            int Thresholding = getValueThreshoding(HistogramAnhGoc);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = getValuePointsFilter(i, j, MaTranAnhGoc);
                    if (MaTranAnhDaXuLy[i + 1, j + 1] < Thresholding)
                    {
                        MaTranAnhDaXuLy[i + 1, j + 1] = 0;
                    }
                    else
                    {
                        MaTranAnhDaXuLy[i + 1, j + 1] = 255;
                    }
                }
            }

            return MaTranAnhDaXuLy;
        }

        #endregion

        #region Bộ lọc đường (Line Detection)
        /*
         *              -1  -1  2
         *              2   2   2
         *              -1   -1  -1
         */
        public static int getValueHorizontalFilter(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = -1 * MatrixAnhGoc[x, y] - 1 * MatrixAnhGoc[x + 1, y] - 1 * MatrixAnhGoc[x + 2, y] + 2 * MatrixAnhGoc[x, y + 1] + 2 * MatrixAnhGoc[x + 1, y + 1] + 2 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x, y + 2] - 1 * MatrixAnhGoc[x + 1, y + 2] - 1 * MatrixAnhGoc[x + 2, y + 2];
            if (value < 0)
            {
                return 0;
            }
            else if (value > 255)
            {
                return 255;
            }
            return value;
        }
        /*              -1  -1  2
         *              -1  2   -1
         *              2   -1  -1
         */
        public static int getValue45Filter1(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = -1 * MatrixAnhGoc[x, y] - 1 * MatrixAnhGoc[x + 1, y] + 2 * MatrixAnhGoc[x + 2, y] - 1 * MatrixAnhGoc[x, y + 1] + 2 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x + 1, y + 1] + 2 * MatrixAnhGoc[x, y + 2] - 1 * MatrixAnhGoc[x + 1, y + 2] - 1 * MatrixAnhGoc[x + 2, y + 2];
            if (value < 0)
            {
                return 0;
            }
            else if (value > 255)
            {
                return 255;
            }
            return value;
        }
        /*
         *              -1  2   -1
         *              -1  2   -1
         *              -1  2   -1
         */
        public static int getValueVerticalFilter(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = -1 * MatrixAnhGoc[x, y] + 2 * MatrixAnhGoc[x + 1, y] - 1 * MatrixAnhGoc[x + 2, y] - 1 * MatrixAnhGoc[x, y + 1] + 2 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x, y + 2] + 2 * MatrixAnhGoc[x + 1, y + 2] - 1 * MatrixAnhGoc[x + 2, y + 2];
            if (value < 0)
            {
                return 0;
            }
            else if (value > 255)
            {
                return 255;
            }
            return value;
        }
        /*
         *              2   -1  -1
         *              -1  2   -1
         *              -1  -1  2
         */
        public static int getValue45Filter2(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = 2 * MatrixAnhGoc[x, y] - 1 * MatrixAnhGoc[x + 1, y] - 1 * MatrixAnhGoc[x + 2, y] - 1 * MatrixAnhGoc[x, y + 1] + 2 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x + 1, y + 1] - 1 * MatrixAnhGoc[x, y + 2] - 1 * MatrixAnhGoc[x + 1, y + 2] + 2 * MatrixAnhGoc[x + 2, y + 2];
            if (value < 0)
            {
                return 0;
            }
            else if (value > 255)
            {
                return 255;
            }
            return value;
        }

        public static int[,] LinesFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[] HistogramAnhGoc = convertion.ConvertMatrixToHistogram(MaTranAnhGoc);
            int Thresholding = getValueThreshoding(HistogramAnhGoc);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = getValueHorizontalFilter(i, j, MaTranAnhGoc);
                }
            }
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = getValue45Filter1(i, j, MaTranAnhGoc);
                }
            }
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = getValueVerticalFilter(i, j, MaTranAnhGoc);
                }
            }
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = getValue45Filter2(i, j, MaTranAnhGoc);
                }
            }

            return MaTranAnhDaXuLy;
        }

        #endregion
    }
}
