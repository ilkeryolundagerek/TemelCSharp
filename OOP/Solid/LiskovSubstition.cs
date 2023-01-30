using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid
{
    internal class LiskovSubstition
    {
    }
    //Bad way..
    public class LiskovRectangleBad
    {
        public int A { get; set; }
        public int B { get; set; }
        public LiskovRectangleBad(int a, int b)
        {
            A = a;
            B = b;
        }
    }

    public class LiskovSquareBad:LiskovRectangleBad
    {
        //Yapıcı metot kalıtımında, parent sınıf parametreli yapıcı metotkullanıyorsa onu kalıtım alan sınıflardan o parametreleri bekler. child yapıları base() metodunu yapıcıya ekleyere cevap verir.
        public LiskovSquareBad(int a) : base(a, a)
        {

        }
    }

    //Good way...
    public class LiskovRectangleGood
    {
        public int A { get; set; }
        public int B { get; set; }
        
        public LiskovRectangleGood(int a, int b)
        {
            A = a;
            B = b;
        }

        public bool IsSquare()
        {
            return A == B;
        }
    }
}
