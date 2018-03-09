using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure tri = new Triangle(6, 8, 10);
            Figure tri2 = new Triangle(7, 10, 12);
            Figure crc = new Circle(5);
            List<Figure> Figures = new List<Figure> { tri,tri2, crc };
            Console.WriteLine(CalcAreaOfFigures(Figures));
        }
        // Этот метод ничего не знает о том, какие именно фигуры 
        // находятся в коллекции figures , но считает их площадь
        static double CalcAreaOfFigures(List<Figure> figures)
        {
            double area = 0;
            foreach (Figure figure in figures)
            {
                area += figure.CalcArea();
            }
            return area;
        }
    }
}
