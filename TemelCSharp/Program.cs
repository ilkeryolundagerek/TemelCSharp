using System;
using Data.Repository;

namespace TemelCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primitive Data Types: Sayı temelli olup stqandart olan yapılardır.
            //Tamsayılar: byte, short, int, long(l), sbyte, ushort, uint, ulong(l)
            //Floating Point: float(f), double(d?)
            //Boolean: bool (true(1), false(0))
            //Karakter: char (A: 65, a: 97)

            //Reference Data Types: İlkel tiplerden üretilen gelişmiş veri tipleridir.
            //string: Karakter katarı/dizisi olarak bilinir.
            //decimal(m): Floatin point veri tiplerinin tutarlı hale getirlmesinden oluşturulur.
            //object: C# gibi dillerde her ürün/veri tipi/kütüphane bu yapıyı temel alır.
            Console.WriteLine("Hello World!");
            Car car01 = new Car();
            Car car02 = new Car();
            car01.NoReturnNoParameter();
            car01.NoReturnWithParameter("ilker");
            Console.WriteLine(car01.WithReturnNoParameter());
            Console.WriteLine(car01.WithReturnWithParameter("ilker"));
            car01.Brand = "Honda";
            car01.IsInSale = false;
            Car.Gasoline = 100;
            Console.WriteLine(Car.Gasoline);
            car01.Driving();
            car01.Driving();
            car01.Driving();
            car01.VType = VehicleType.Automobile;
            car01.EType = EngineType.Gaseoline;
            car02.Driving();
            car02.Driving();
            Car.Drive();
            Console.WriteLine(Car.Gasoline);
        }
    }
}

namespace Data.Repository
{
    //Nesne Türleri:
    //Class (sınıf): En çok kullanılan nesne türüdür, kendi veri tiplerimizi genellik bu yapıdan üretiriz.
    //Interface (arabirim): Atandığı sınıf nesnelerine bir manifesto olarak tanımlanabilir. 
    //Enum (numaralandırılmış): Sabit numaralandırılmış veriler tutmayı sağlar.

    //<Erişim Belirleyicisi (Access Modifier)> <Kullanım Türü (abstract(soyut),sealed(concrete), yazılmazsa ikiside)> <static/non-static> <Nesne Adı>{}

    //Erişim belirleyici: Nesne yapılarında iki tür erişim belirleyici vardır.
    //public: Her türlü erişime açık anlamına gelir. Diğer yapılar bu nesneye erşimde bir sorun yaşamaz.
    //internal: Aynı runtime/program içerisinde erişime açık anlamına gelir. Yazılmama durumu da aynı noktaya varır.
    public class Car
    {
        //Nesne mülkleri için erişim belirleyiciler:
        //public: Her türlü erişime açık anlamına gelir. Diğer yapılar bu mülke erişimde bir sorun yaşamaz.
        //internal: Aynı runtime/program içerisinde erişime açık anlamına gelir. Yazılmama durumu da aynı noktaya varır.
        //private: Her türlü dış erişime kapalıdır, sadece nesne içerisinde kullanım sağlanır.
        //protected: Sadece bu nesneden türeyen nesnelerin erişimlerine açıktır.

        //Fields (alanlar): 
        private string brand;
        protected int _model;
        public bool IsInSale;
        public static int Gasoline;
        public VehicleType VType;
        public EngineType EType;
        //Properties (mülkler): OOP kurallarına bağlı olarak kayıt alma,verme yapılarında kapsüllemeye/izolasyona uğratılabilir.
        public string Owner { get; set; }
        public string Brand { get { return brand; } set { brand = value; } }

        //Methods: Nesnemize özel işlevsel yapılardır. Genel olarak sadece bir işlevi olan kullanılabilir bir bilgi veren veya vermeyen (void), bizden bilgi almaya ihtiyacı olan veya olmayan yapılarıdır.
        public void NoReturnNoParameter()
        {
            Console.WriteLine("No Return Data, No Parameter.");
        }

        public void NoReturnWithParameter(string name)
        {
            Console.WriteLine("No Return Data, With This Parameter:" + name);
        }

        public string WithReturnNoParameter()
        {
            return "With Return Data, No Parameter";
        }

        public string WithReturnWithParameter(string name)
        {
            return "With Return Data, With This Parameter:" + name;
        }

        public static void Drive()
        {
            Car.Gasoline -= 10;
        }

        public void Driving()
        {
            Car.Drive();
        }
    }

    public enum VehicleType { Automobile, Motorcycle, Bus, Truck, Boat }
    public enum EngineType { Diesel = 10, Gaseoline, Electricity }
    public enum HttpStatusCode { OK = 200, Create = 201, PageNotFound = 404, InternalServerError = 500, PermenentRedirection = 301 }


}