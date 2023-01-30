using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class DependencyInjectionGood
    {
    }

    public interface IVehicleGood
    {
        void Start();
        void SpeedUp();
        void SpeedDown();
        void Stop();
    }

    public interface ITurnVehicle
    {
        void TurnLeft();
        void TurnRight();
    }

    public class CarGood : IVehicleGood
    {
        public void SpeedDown()
        {
            throw new NotImplementedException();
        }

        public void SpeedUp()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class BusGood : IVehicleGood
    {
        public void SpeedDown()
        {
            throw new NotImplementedException();
        }

        public void SpeedUp()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class VehicleServiceGood
    {
        private IVehicleGood vehicle;
        
        public VehicleServiceGood(IVehicleGood vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Drive()
        {

        }
    }
}
