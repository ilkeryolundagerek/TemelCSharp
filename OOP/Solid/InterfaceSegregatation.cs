using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid
{
    internal class InterfaceSegregatation
    {
    }

    //Bad way...
    public interface IEmployeeBad
    {
        void Produce();
        void Manage();
        void Drive();
        void Record();
    }

    public class EmployeeBad : IEmployeeBad
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Manage()
        {
            throw new NotImplementedException();
        }

        public void Produce()
        {
            throw new NotImplementedException();
        }

        public void Record()
        {
            throw new NotImplementedException();
        }
    }

    //Good way..
    public interface IProducer { void Produce(); }
    public interface IDriver { void Drive(); }
    public interface IManager { void Manage(); }
    public interface IRecorder { void Record(); }

    public class ProduceManager : IProducer, IManager
    {
        public void Manage()
        {
            throw new NotImplementedException();
        }

        public void Produce()
        {
            throw new NotImplementedException();
        }
    }

    public class CompanyDriver : IDriver
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class Recorder : IRecorder
    {
        public void Record()
        {
            throw new NotImplementedException();
        }
    }
}
