using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid
{
    internal class OpenClose
    {
    }

    //Bad way...
    public class RectangleBad
    {
        public int A { get; set; }
        public int B { get; set; }

        //Yapıcı metot (Constructor) : Hiç yazılmazsa boş haliyle varlığı kabul ediğlir. new operatörü ile nesne oluşturmak için çağırılan kısımdır. Eğer oluşturulsa boş hali varmış gibi kabul edilmez.
        public RectangleBad(int a, int b)
        {
            A = a;
            B = b;
        }
    }

    public class CircleBad
    {
        public double r { get; set; }
        public double PI { get; set; }

        public CircleBad(double r, double pI)
        {
            this.r = r;
            PI = pI;
        }
    }

    public class ShapeCalcBad
    {
        public double CalcRectanglePerimeter(RectangleBad rectangle)
        {
            return 2 * (rectangle.A + rectangle.B);
        }

        public double CalcCirclePerimeter(CircleBad circle)
        {
            return 2 * circle.r * circle.PI;
        }
    }

    //Good way..
    public interface IShapeGood
    {
        double CalcPerimeter();
    }

    public class RectangleGood : IShapeGood
    {
        public int A { get; set; }
        public int B { get; set; }

        //Yapıcı metot (Constructor) : Hiç yazılmazsa boş haliyle varlığı kabul ediğlir. new operatörü ile nesne oluşturmak için çağırılan kısımdır. Eğer oluşturulsa boş hali varmış gibi kabul edilmez.
        public RectangleGood(int a, int b)
        {
            A = a;
            B = b;
        }

        public double CalcPerimeter()
        {
            return 2 * (A + B);
        }
    }

    public class CircleGood : IShapeGood
    {
        public double r { get; set; }
        public double PI { get; set; }

        public CircleGood(double r, double pI)
        {
            this.r = r;
            PI = pI;
        }

        public double CalcPerimeter()
        {
            return 2 * r * PI;
        }
    }

    public class TriangleGood:IShapeGood
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public TriangleGood(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalcPerimeter()
        {
            return A + B + C;
        }
    }

    public class ShapeCalcGood
    {
        public double CalculatePerimeter(IShapeGood shape)
        {
            return shape.CalcPerimeter();
        }
    }
}
