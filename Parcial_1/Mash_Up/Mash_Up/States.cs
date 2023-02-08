using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mash_Up
{
    public class States
    {
        public List<PointF> Sts;
        public PointF Centroid, Last;

        public States()
        {
            Sts = new List<PointF>();
        }

        public void AddS(PointF point)
        {
            Centroid = new PointF();
            Sts.Add(point);

            for (int p = 0; p < Sts.Count; p++)
            {
                Centroid.X += Sts[p].X;
                Centroid.Y += Sts[p].Y;
            }
            Last = point;

            Centroid.X /= Sts.Count;
            Centroid.Y /= Sts.Count;
        }

        public void NewState()
        {
        }
    }
}
