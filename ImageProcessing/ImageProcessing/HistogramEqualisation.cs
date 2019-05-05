using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class HistogramEqualisation
    {
       public static int[,] Equalisation (IConvertion convertion, Bitmap bm)
        {
            int[,] MaTranAnh = convertion.ConvertBitmapToMatrixGray(bm);
            int[] Histogram = convertion.ConvertMatrixToHistogram(MaTranAnh);
            int sum = 0;
            int[] SumOfHist = new int[256];
            for (int i = 0; i<Histogram.Length; i++)
            {
                sum = sum + Histogram[i];
                SumOfHist[i] =sum;
            }
            double area = bm.Width * bm.Height;
            double dm = 255;
            int k;
            int[,] MaTranAnhDaCanBangHistogram = new int[bm.Height, bm.Width];
            for (int i = 0; i < bm.Height; i++)
            {
                for (int j = 0; j < bm.Width; j++)
                {
                    k = MaTranAnh[i, j];
                    MaTranAnhDaCanBangHistogram[i, j] =(int)((dm / area) * SumOfHist[k]);
                }
                
            }
            return MaTranAnhDaCanBangHistogram;
        }
    }
}
