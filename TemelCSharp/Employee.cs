using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemelCSharp
{
    public class Employee
    {
        public string Firstname;
        public string Lastname;
    }


    //interface (arabirim): Atandığı sınıfı bir şablon kullanamya zorlayan manifesto yapısıdır.
    public interface IEmployeeService
    {
        //Erişim belirleyicisiz ve gövdesiz metotlar belirlenir. 
        void Report();
        void Record();
        void Drive();
        void Manage();

        //Property yapılarıda zorlanabilir.
        string Department { get; set; }
        string City { get; }
    }

    public class EmployeeService : IEmployeeService
    {
        public string Department { get; set; }

        public string City { get; }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Manage()
        {
            throw new NotImplementedException();
        }

        public void Record()
        {
            throw new NotImplementedException();
        }

        public void Report()
        {
            throw new NotImplementedException();
        }
    }
}
