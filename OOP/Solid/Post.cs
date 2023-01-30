using OOP.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid
{
    public class Post : Base
    {
        public DateTime PublishDate { get; set; }
        public string HtmlContent { get; set; }
        public string Author { get; set; }

        public bool IsProjectDiscriminator { get; set; }
    }

    public class Project : Post
    {
        //Bunun yerine Post sınıfına ayır edici alan eklenir.
    }
}
