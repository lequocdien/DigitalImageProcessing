using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;
namespace ImageProcessing
{
    class mChart
    {
        private static GraphPane gp = null;
        public static void ChartBar(int [] HistogramCanVe, ZedGraphControl zg)
        {
            zg.GraphPane.CurveList.Clear();
            zg.Visible = false;
            gp = zg.GraphPane;
            gp.Title = "Biểu đồ Histogram";
            gp.XAxis.Title = "Giá trị màu";
            gp.YAxis.Title = "Số lượng";
            PointPairList point = new PointPairList();
            for (int i = 0; i < 256; i++)
            {
                point.Add(i, HistogramCanVe[i]);

            }
            gp.AddBar("Histogram", point, Color.Black);
            zg.AxisChange();
            zg.Visible = true;
        }
    }
}
