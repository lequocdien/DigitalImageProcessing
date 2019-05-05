using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    interface IConvertion
    {
        int[,] ConvertBitmapToMatrixGray(Bitmap bm);
        Bitmap ConvertMatrixToBitmap(int[,] Matrananhcanchuyen);
        int[] ConvertMatrixToHistogram(int[,] matrananhxamcanchuyen);
        int[,] ConvertMatrixGrayToMatrixBlack_White(int[,] matrananhxamcanchuyen);
    }
}
