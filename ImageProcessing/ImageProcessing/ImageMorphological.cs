using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class ImageMorphological
    {
        #region Hit - Gian anh
        /*
         *          Structuring Element
         *          0   1   0
         *          1   1   1
         *          0   1   0
         */
        public static bool isHit(int x, int y, int[,] MatrixBlack_White)
        {
            if (MatrixBlack_White[x, y - 1] == 255 || MatrixBlack_White[x - 1, y] == 255 || MatrixBlack_White[x, y] == 255 || MatrixBlack_White[x + 1, y] == 255 || MatrixBlack_White[x, y + 1] == 255)
            {
                return true;
            }
            return false;
        }
        public static int[,] hit(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MatrixBlack_White = convertion.ConvertMatrixGrayToMatrixBlack_White(MaTranAnhGoc);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MatrixBlack_White.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixBlack_White.GetLength(1); j++)
                {
                    MaTranAnhDaXuLy[i, j] = 0;
                }
            }
            for (int i = 1; i < MatrixBlack_White.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < MatrixBlack_White.GetLength(1) - 1; j++)
                {
                    if (isHit(i, j, MatrixBlack_White))
                    {
                        MaTranAnhDaXuLy[i, j] = 255;
                    }
                }
            }

            return MaTranAnhDaXuLy;
        }
        #endregion

        #region Fit - Co anh
        /*
         *          Structuring Element
         *          0   1   0
         *          1   1   1
         *          0   1   0
         */
        public static bool isFit(int x, int y, int[,] MatrixBlack_White)
        {
            if (MatrixBlack_White[x, y - 1] == 255 && MatrixBlack_White[x - 1, y] == 255 && MatrixBlack_White[x, y] == 255 && MatrixBlack_White[x + 1, y] == 255 && MatrixBlack_White[x, y + 1] == 255)
            {
                return true;
            }
            return false;
        }
        public static int[,] fit(Bitmap bm, IConvertion convertion)
        {
            int[,] MaTranAnhGoc = convertion.ConvertBitmapToMatrixGray(bm);
            int[,] MatrixBlack_White = convertion.ConvertMatrixGrayToMatrixBlack_White(MaTranAnhGoc);
            int[,] MaTranAnhDaXuLy = new int[MaTranAnhGoc.GetLength(0), MaTranAnhGoc.GetLength(1)];
            for (int i = 0; i < MatrixBlack_White.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixBlack_White.GetLength(1); j++)
                {
                    MaTranAnhDaXuLy[i, j] = 0;
                }
            }
            for (int i = 1; i < MatrixBlack_White.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < MatrixBlack_White.GetLength(1) - 1; j++)
                {
                    if (isFit(i, j, MatrixBlack_White))
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
