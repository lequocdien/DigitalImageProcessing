using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class SpatialFiltering
    {
        private static void BubbleSort(int [] arr)
        {
            int tmp;
            for(int i= 0; i < arr.Length-1; i++)
            {
                for(int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

        #region Min
        //MinFilter là ma trận 3x3
        //Lấy giá trị Min của ma trận 3x3 bắt đầu tại vị trí (x,y) (Điều kiện: x,y <= chiều rộng, chiều dài của ma trân ảnh gốc)
        private static int GetValueMin(int x, int y, int[,] MatrixAnhGoc)
        {
            int Min = 255;
            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    if (Min > MatrixAnhGoc[i, j])
                    {
                        Min = MatrixAnhGoc[i, j];
                    }
                }
            }
            return Min;
        }

        public static int[,] MinFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = GetValueMin(j, i, MaTranAnhGoc);
                }
            }
            return MaTranAnhDaXuLy;
        }

        #endregion

        #region Max

        private static int GetValueMax(int x, int y, int[,] MatrixAnhGoc)
        {
            int Max = 0;
            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    if (Max < MatrixAnhGoc[i, j])
                    {
                        Max = MatrixAnhGoc[i, j];
                    }
                }
            }
            return Max;
        }

        public static int[,] MaxFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = GetValueMax(j, i, MaTranAnhGoc);
                }
            }
            return MaTranAnhDaXuLy;
        }

        #endregion

        #region Median


        private static int GetValueMedian(int x, int y, int[,] MatrixAnhGoc)
        {
            int[] arr = new int[9];             //Mảng 1 chiều sẽ chứa 9 phần tử của ma trận bộ lọc Median
            int k = 0;
            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    arr[k] = MatrixAnhGoc[i, j];
                    k = k + 1;
                }
            }
            BubbleSort(arr);
            return arr[4];
        }

        public static int[,] MedianFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = GetValueMedian(j, i, MaTranAnhGoc);
                }
            }
            //Console.WriteLine("Ma tran anh Median Filter");
            //for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0); i++)
            //{
            //    for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) ; j++)
            //    {
            //        Console.Write(MaTranAnhDaXuLy[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            return MaTranAnhDaXuLy;

        }
        #endregion

        #region Averaging Filter

        private static int GetValueAveraging(int x, int y, int[,] MatrixAnhGoc)
        {
            int sum = 0;
            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    sum = sum + MatrixAnhGoc[i, j];
                }
            }
            return sum / 9;
        }

        public static int[,] AveragingFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = GetValueAveraging(j, i, MaTranAnhGoc);
                }
            }

            return MaTranAnhDaXuLy;
        }

        #endregion

        #region Weighted Averaging Filter

        private static int GetValueWeightedAveraging(int x, int y, int[,] MatrixAnhGoc)
        {
            return (MatrixAnhGoc[x, y] + 2 * MatrixAnhGoc[x + 1, y] + MatrixAnhGoc[x + 2, y] + 2 * MatrixAnhGoc[x, y + 1] + 4 * MatrixAnhGoc[x + 1, y + 1] + 2 * MatrixAnhGoc[x + 2, y + 1] + MatrixAnhGoc[x, y + 2] + MatrixAnhGoc[x + 1, y + 2] + MatrixAnhGoc[x + 2, y + 2]) / 16;
        }

        public static int[,] WeightedAveragingFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = GetValueWeightedAveraging(i, j, MaTranAnhGoc);
                }
            }

            return MaTranAnhDaXuLy;
        }

        #endregion

        #region Laplac

        private static int GetValueLaplac(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = (MatrixAnhGoc[x + 1, y] + MatrixAnhGoc[x, y + 1] - 4 * MatrixAnhGoc[x + 1, y + 1] + MatrixAnhGoc[x + 2, y + 1] + MatrixAnhGoc[x + 1, y + 2]);
            if (value < 0)
            {
                return 0;
            }
            else if(value > 255)
            {
                return 255;
            }
            else
            {
                return value;
            }
            
        }

        public static int[,] LaplacFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhDaXuLy.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i + 1, j + 1] = GetValueLaplac(i, j, MaTranAnhGoc);
                }
            }

            return MaTranAnhDaXuLy;
        }

        #endregion  

        #region Sobel
        
        /*
                        Ma trận Sobel 1:
                           -1   -2  -1
                           0    0   0
                           1    2   1
        */

        private static int getValueSobel1(int x, int y, int[,] MatrixAnhGoc)   
        {
            int value = -1 * MatrixAnhGoc[x, y] - 2 * MatrixAnhGoc[x + 1, y] - 1 * MatrixAnhGoc[x + 2, y] + 1 * MatrixAnhGoc[x, y + 2] + 2 * MatrixAnhGoc[x + 1, y + 2] + 1 * MatrixAnhGoc[x + 2, y + 2];
            //if(value < 0)
            //{
            //    return 0;
            //}
            //else if (value > 255)
            //{
            //    return 255;
            //}
            return value;

        }

        /*
                        Ma trận Sobel 2:
                           -1   0   1
                           -2   0   2
                           -1   0   1
        */

        private static int getValueSobel2(int x, int y, int[,] MatrixAnhGoc)
        {
            int value = -1 * MatrixAnhGoc[x, y] + 1 * MatrixAnhGoc[x + 2, y] - 2 * MatrixAnhGoc[x, y + 1] + 2 * MatrixAnhGoc[x + 2, y + 1] - 1 * MatrixAnhGoc[x, y + 2] + 1 * MatrixAnhGoc[x + 2, y + 2];
            //if (value < 0)
            //{
            //    return 0;
            //}
            //else if (value > 255)
            //{
            //    return 255;
            //}
            return value;
        }

        public static int[,] SobelFilter(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            int[,] MaTranQuaBoLocSobel1 = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            int[,] MaTranQuaBoLocSobel2 = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MaTranAnhGoc.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranQuaBoLocSobel1[i + 1, j + 1] = getValueSobel1(i, j, MaTranAnhGoc);
                    MaTranQuaBoLocSobel2[i + 1, j + 1] = getValueSobel2(i, j, MaTranAnhGoc);
                }
            }
            for (int i = 0; i < MaTranAnhGoc.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < MaTranAnhDaXuLy.GetLength(1) - 2; j++)
                {
                    MaTranAnhDaXuLy[i, j] = MaTranQuaBoLocSobel1[i, j] + MaTranQuaBoLocSobel2[i, j];
                    if (MaTranAnhDaXuLy[i, j] < 0)
                    {
                        MaTranAnhDaXuLy[i, j] = 0;
                    }
                    else if (MaTranAnhDaXuLy[i, j] > 255)
                    {
                        MaTranAnhDaXuLy[i, j] = 255;
                    }
                }
            }
            return MaTranAnhDaXuLy;

        }
        #endregion

















    }
}
