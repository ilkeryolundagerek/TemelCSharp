using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Solid;
using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p1 = new Person();
            p1.Firstname = "ali";
            p1.Middlename = "h";
            Console.WriteLine(p1.Firstname);
            Console.WriteLine(p1.Middlename);
            Console.WriteLine(p1.Lastname);
            Console.WriteLine(p1.Fullname);
            //p1.Fullname = "merhaba";
            */

            /*
            Product p1 = new Product();
            Category c1 = new Category();
            Brand b1 = new Brand();
            //Base @base = new Base();
            //SubBase subBase = new SubBase();
            */
            /*
            CircleGood c1 = new CircleGood(3, Math.PI);
            RectangleGood r1 = new RectangleGood(4, 6);
            TriangleGood t1 = new TriangleGood(2, 5, 4);
            ShapeCalcGood calc = new ShapeCalcGood();
            Console.WriteLine(calc.CalculatePerimeter(c1));
            Console.WriteLine(calc.CalculatePerimeter(r1));
            Console.WriteLine(calc.CalculatePerimeter(t1));
            */
            /*
            List<IMessageWay> ways = new List<IMessageWay>
            {
                new SMSGood(),
                new SMSGood(),
                new SMSGood(),
                new WhistleGood(),
                new WhistleGood(),
                new EMailGood(),
                new SMSGood(),
                new WhistleGood(),
                new EMailGood(),
                new EMailGood()
            };

            MessageCenterGood msgCenter = new MessageCenterGood(ways);
            msgCenter.SendAllMessage();
            */

            Automobile ad1 = new Automobile(new Diesel());
            Console.WriteLine(ad1.Drive());
            Automobile ag1 = new Automobile(new Gasoline());
            Console.WriteLine(ag1.Drive());
            Automobile ae1 = new Automobile(new Electricity());
            Console.WriteLine(ae1.Drive());

        }
    }
}
