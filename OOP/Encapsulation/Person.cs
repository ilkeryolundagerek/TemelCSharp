using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Person
    {
        public string Title { get; set; }

        private string firstname;
        public string Firstname
        {
            get
            {
                if (string.IsNullOrEmpty(firstname))
                {
                    return "John/Jane";
                }
                else
                {
                    return firstname;
                }
            }
            set
            {
                if (value.Length >= 3)
                {
                    firstname = value;
                }
            }
        }

        private string middlename;
        public string Middlename { get { return middlename; } set { middlename = value; } }

        private string lastname;
        public string Lastname
        {
            get
            {
                if (string.IsNullOrEmpty(lastname))
                {
                    return "Doe";
                }
                else
                {
                    return lastname;
                }
            }
            set
            {
                if (value.Length >= 3)
                {
                    lastname = value;
                }
            }
        }

        private int height;
        public int Height
        {
            get { return height > 0 ? height : 1; }
            set { height = value > 0 ? value : 1; }
        }
        private double weight;
        public double Weight
        {
            get { return weight > 0 ? weight : 1; }
            set { weight = value > 0 ? value : 1; }
        }

        //Readonly property: Sadece okunabilir mülktür.
        public string Fullname { get { return Firstname + " " + Middlename + " " + Lastname; } }
    }
}
