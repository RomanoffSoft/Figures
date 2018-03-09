using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace TestFigures
{
    [TestClass]
    public class TestFiguresAreas
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            double expected = 24;
            double actual = triangle.CalcArea();
            Assert.AreEqual(expected, actual, "Area not calcaulated correctly");
        }
        [TestMethod]
        public void TestRightTriangleArea()
        {
            RightTriangle rtriangle = new RightTriangle(3, 4, 5);
            double expected = 6;
            double actual = rtriangle.CalcArea();
            Assert.AreEqual(expected, actual, "Area not calculated correctly");
        }
        [TestMethod]
        public void TestCircleArea()
        {
            Circle circle = new Circle(8);
            double expected = 201.0619;
            double actual = Math.Round(circle.CalcArea(),4);
            Assert.AreEqual(expected,actual,"Area not calculated correctly");
        }
    }
}
