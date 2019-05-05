using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class PointProcessing
    {
        public static int[,] PointProcessingNegative(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhXam = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaNegative = new int[MaTranAnhXam.GetLength(0), MaTranAnhXam.GetLength(1)];
            for (int i = 0; i < MaTranAnhXam.GetLength(0); i++)
            {
                for (int j = 0; j < MaTranAnhXam.GetLength(1); j++)
                {
                    MaTranAnhDaNegative[i, j] = 255 - MaTranAnhXam[i, j];
                }
            }
            return MaTranAnhDaNegative;
        }

        public static int[,] PointProcessingThresholding(Bitmap bm, IConvertion convertion, double threshold)
        {
            int[,] MaTranAnhXam = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaThresholding = new int[MaTranAnhXam.GetLength(0), MaTranAnhXam.GetLength(1)];
            for (int i = 0; i < MaTranAnhXam.GetLength(0); i++)
            {
                for (int j = 0; j < MaTranAnhXam.GetLength(1); j++)
                {
                    if(MaTranAnhXam[i,j] < threshold)
                    {
                        MaTranAnhDaThresholding[i, j] = 0;
                    }
                    else
                    {
                        MaTranAnhDaThresholding[i, j] = 255;
                    }
                }
            }
            return MaTranAnhDaThresholding;
        }

        public static int[,] PointProcessingLogarit(Bitmap bm, IConvertion convertion, double c)
        {
            int[,] MaTranAnhXam = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaLogarit = new int[MaTranAnhXam.GetLength(0), MaTranAnhXam.GetLength(1)];
            for (int i = 0; i < MaTranAnhXam.GetLength(0); i++)
            {
                for (int j = 0; j < MaTranAnhXam.GetLength(1); j++)
                {
                    MaTranAnhDaLogarit[i, j] = (int)(c * Math.Log10(1 + MaTranAnhXam[i, j]*1.0));
                }
            }
            return MaTranAnhDaLogarit;
        }

        public static int[,] PointProcessingPower(Bitmap bm, IConvertion convertion, double c)
        {
            double lamda = 4;
            int[,] MaTranAnhXam = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MaTranAnhDaPower = new int[MaTranAnhXam.GetLength(0), MaTranAnhXam.GetLength(1)];
            for (int i = 0; i < MaTranAnhXam.GetLength(0); i++)
            {
                for (int j = 0; j < MaTranAnhXam.GetLength(1); j++)
                {
                    MaTranAnhDaPower[i, j] = (int)(c*Math.Pow(MaTranAnhXam[i,j], lamda));
                }
            }
            return MaTranAnhDaPower;
        }
    }
}
