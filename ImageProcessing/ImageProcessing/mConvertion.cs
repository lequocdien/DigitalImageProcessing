using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class mConvertion:IConvertion
    {
        public int[,] ConvertBitmapToMatrixGray(Bitmap bm)
        {
            Color mau;
            int[,] MaTranAnhXam = new int[bm.Height, bm.Width];
            for (int i = 0; i < bm.Height; i++)
            {
                for (int j = 0; j < bm.Width; j++)
                {
                    mau = bm.GetPixel(i, j);
                    MaTranAnhXam[i, j] = (mau.R + mau.G + mau.B) / 3;
                }
            }
            return MaTranAnhXam;
        }

        public Bitmap ConvertMatrixToBitmap(int[,] Matrananhcanchuyen)
        {
            Bitmap bm = new Bitmap(Matrananhcanchuyen.GetLength(1), Matrananhcanchuyen.GetLength(0));
            int giatrimau;
            for (int i = 0; i < Matrananhcanchuyen.GetLength(0); i++)
            {
                for (int j = 0; j < Matrananhcanchuyen.GetLength(1); j++)
                {
                    giatrimau = Matrananhcanchuyen[i, j];
                    bm.SetPixel(i, j, Color.FromArgb(giatrimau, giatrimau, giatrimau));
                }
            }
            return bm;
        }

        public int[] ConvertMatrixToHistogram(int[,] matrananhxamcanchuyen)
        {
            int giatrimau;
            int[] hist = new int[256];
            for (int i = 0; i < 256; i++)
            {
                hist[i] = 0;
            }
            for (int i = 0; i < matrananhxamcanchuyen.GetLength(0); i++)
            {
                for (int j = 0; j < matrananhxamcanchuyen.GetLength(1); j++)
                {
                    giatrimau = matrananhxamcanchuyen[i, j];
                    hist[giatrimau] = hist[giatrimau] + 1;
                }

            }
            return hist;
        }

        public int[,] ConvertMatrixGrayToMatrixBlack_White(int[,] matrananhxamcanchuyen)
        {
            int[,] MatrixBlack_White = new int[matrananhxamcanchuyen.GetLength(0), matrananhxamcanchuyen.GetLength(1)];
            for (int i = 0; i < matrananhxamcanchuyen.GetLength(0); i++)
            {
                for (int j = 0; j < matrananhxamcanchuyen.GetLength(1); j++)
                {
                    if(matrananhxamcanchuyen[i,j] < 126)
                    {
                        MatrixBlack_White[i, j] = 0;
                    }
                    else
                    {
                        MatrixBlack_White[i, j] = 255;
                    }
                }

            }
            return MatrixBlack_White;
        }

    }
}
