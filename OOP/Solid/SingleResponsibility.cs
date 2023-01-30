using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid
{
    internal class SingleResponsibility
    {
    }

    //Bad way (Concrete(model) yapısı ile servis yapısı(hatta alakasız model için) bir arada olmamalı)...
    public class ProductBad
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }

        public void AddToCart() { }
    }

    //Good way...
    //Concrete/sabit/model yapı ayrı
    public class ProductGood
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }

    //Hizmet yapısı ayrı.
    public class CartService
    {
        public void AddToCart(ProductGood product)
        {

        }
    }
}
