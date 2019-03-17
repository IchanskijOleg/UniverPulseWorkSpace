using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : AbstractFigure
    {
        public Triangle(Point apexA, Point apexB, Point apexC)
        {
            ApexA = apexA;
            ApexB = apexB;
            ApexC = apexC;
            //SideAB = new Line(ApexA, apexB);
            //SideAC = new Line(ApexA, apexC);
            //SideBC = new Line(ApexB, apexC);
        }

        public Point ApexA { get; set; }
        public Point ApexB { get; set; }
        public Point ApexC { get; set; }

        private Line sideAC;
        private Line sideAB;
        private Line sideBC;

        public Line SideAC
        {
            get
            {
                if (sideAC == null)
                    sideAC = new Line(ApexA, ApexC);
                return sideAC;
            }
        }
        public Line SideAB
        {
            get
            {
                if (sideAB == null)
                    sideAB = new Line(ApexA, ApexB);
                return sideAB;
            }
        }
        public Line SideBC
        {
            get
            {
                if (sideBC == null)
                    sideBC = new Line(ApexB, ApexC);
                return sideBC;
            }
        }

        public double GetLengthAC() { return SideAC.GetLength(); }
        public double GetLengthAB() { return SideAB.GetLength(); }
        public double GetLengthBC() { return SideBC.GetLength(); }
    }
}
