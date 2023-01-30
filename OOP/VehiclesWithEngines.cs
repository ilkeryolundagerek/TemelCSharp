using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class VehiclesWithEngines
    {
    }

    public interface IEngine
    {
        string Start();
    }

    public interface IVehicle
    {
        string Drive();
    }

    public class Diesel : IEngine
    {
        public string Start()
        {
            return "Diesel engine started.";
        }
    }

    public class Gasoline : IEngine
    {
        public string Start()
        {
            return "Gasoline engine started";
        }
    }

    public class Electricity : IEngine
    {
        public string Start()
        {
            return "Electric engine started";
        }
    }

    public class Motorcycle : IVehicle
    {
        private IEngine engine;

        public Motorcycle(IEngine engine)
        {
            this.engine = engine;
        }

        public string Drive()
        {
            return engine.Start()+" Motorcycle driving";
            
        }
    }

    public class Automobile : IVehicle
    {
        private IEngine engine;

        public Automobile(IEngine engine)
        {
            this.engine = engine;
        }

        public string Drive()
        {
            return engine.Start() + " Automobile driving";
        }
    }

    public class Boat : IVehicle
    {
        private IEngine engine;

        public Boat(IEngine engine)
        {
            this.engine = engine;
        }

        public string Drive()
        {
            return engine.Start() + " Boat driving";
        }
    }
}
