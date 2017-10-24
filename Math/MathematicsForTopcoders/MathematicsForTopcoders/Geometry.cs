using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsForTopcoders
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public struct Rectangle
    {
        public Point BottomLeftPoint { get; set; }
        public Point TopRightPoint { get; set; }
    }

    public class Geometry
    {
        public bool AreRectanglesIntersect(Rectangle R1, Rectangle R2)
        {
            return !((Math.Max(R1.BottomLeftPoint.X, R2.BottomLeftPoint.X) > Math.Min(R1.TopRightPoint.X, R2.TopRightPoint.X)) ||
                (Math.Max(R1.BottomLeftPoint.Y, R2.BottomLeftPoint.Y) > Math.Min(R1.TopRightPoint.Y, R2.TopRightPoint.Y)));
        }

        public Rectangle CalculateIntersectedRectangle(Rectangle R1, Rectangle R2)
        {
            Rectangle R3 = new Rectangle();
            Point bottomLeftPoint = new Point();
            Point topRightPoint = new Point();
            double x3 = Math.Max(R1.BottomLeftPoint.X, R2.BottomLeftPoint.X);
            double y3 = Math.Max(R1.BottomLeftPoint.Y, R2.BottomLeftPoint.Y);
            bottomLeftPoint.X = x3;
            bottomLeftPoint.Y = y3;
            R3.BottomLeftPoint = bottomLeftPoint;
            double x4 = Math.Min(R1.TopRightPoint.X, R2.TopRightPoint.X);
            double y4 = Math.Min(R1.TopRightPoint.Y, R2.TopRightPoint.Y);
            topRightPoint.X = x4;
            topRightPoint.Y = y4;
            R3.TopRightPoint = topRightPoint;
            return R3;
        }

        public double CalculateAreaOfLatticePolygon(int numberOfLatticsPointInBoundary, int numberofInteriorLatticePolygon)
        {
            ///
            /// numberOfLatticsPointInBoundary = B
            /// numberOfLatticsPointInBoundary = I
            /// formula : Area = (B/2) + I -1
            ///
            return (numberOfLatticsPointInBoundary / 2) + numberOfLatticsPointInBoundary - 1;
        }

    }
}
