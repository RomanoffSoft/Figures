using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Figure
    {
        public abstract double CalcArea();
    }

    public class Triangle : Figure
    {
        double _sideA, _sideB, _sideC;

        public double SideA { get { return _sideA; } }
        public double SideB { get { return _sideB; } }
        public double SideC { get { return _sideC; } }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Incorrect input parameters");
            }

            if (sideA + sideB < sideC ||
                sideA + sideC < sideB ||
                sideB + sideC < sideA)
            {
                throw new ArgumentException("Triangle with such sides does not exist");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double CalcArea()
        {
            //Geron`s formula
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }

    //прямоугольный треугольник
    public class RightTriangle : Triangle
    {
        public RightTriangle(double sideA, double sideB, double sideC)
            : base(sideA, sideB, sideC)
        {
            //check if triangle actually right
            if (!IsTriangleRight())
            {
                throw new ArgumentException("Triangle cannot be right with such side lengths");
            }
        }

        private bool IsTriangleRight()
        {
            List<double> Sides = new List<double>() { SideA, SideB, SideC };
            Sides.Sort();
            if (Sides[2] * Sides[2] == Sides[0] * Sides[0] + Sides[1] * Sides[1])
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override double CalcArea()
        {
            List<double> Sides = new List<double>() { SideA, SideB, SideC };
            Sides.Sort();
            return Sides[0] * Sides[1] * 0.5;
        }

    }
    public class Circle : Figure
    {
        private double _radius;
        public double Radius { get { return _radius; } }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

}
