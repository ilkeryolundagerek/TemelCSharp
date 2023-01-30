using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    //Soyut sınıflar (abstract): Bir sınıfn new operatörü ile üretilememsini sağlar. Sadece kalıtım alınabilirler.
    public abstract class Base
    {
        public int Id;
        public string Title;
        public string Description;
        public DateTime CreateDate;
        public bool Active;
        public bool IsDeleted;

        public void Print()
        {
            //...
        }
    }

    public abstract class SubBase : Base
    {
        public DateTime UpdateDate;
        public DateTime DeleteDate;
    }


    //Arabirim kalıtımı: Bir sınıf başka bir sanıfı kalıtım alabilirken, arabirimlerin sınırı yoktur.
    public interface IProduct
    {
        void GetInfo();
    }
    //Bir sınıf başka bir sınıfta ihtiyaç duyduğu özellik için miras alabilir. Bu işlen sadece bir sınıflar sınırlıdır.
    //sealed (mühürlü): Bu özelliğe sahip sınıflar kalıtım alınamaz. New operatörü ile örneklenebilir.
    public sealed class Product : SubBase, IProduct
    {
        public decimal Price;
        public bool IsInCampaign;
        public double CampaignRate;

        public void GetInfo()
        {
            throw new NotImplementedException();
        }
    }

    public sealed class Category : Base { }

    public sealed class Brand : Base
    {
        public string Logo;
        public string Website;
    }

    //public class SubProduct : Product { }
}
