using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class DependencyInjectionBad
    {
    }

    public interface IVehicleBad
    {
        void Start();
        void SpeedUp();
        void SpeedDown();
        void Stop();
    }

    public class CarBad : IVehicleBad
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
    public class BusBad : IVehicleBad
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

    public class VehicleServiceBad
    {
        private CarBad carBad;
        private BusBad busBad;

        public VehicleServiceBad()
        {
            this.carBad = new CarBad();
            this.busBad = new BusBad();
        }

        public void DriveCar()
        {
            this.carBad.Start();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.Stop();
        }

        public void DriveBus()
        {
            this.carBad.Start();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedUp();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.SpeedDown();
            this.carBad.Stop();
        }
    }
}
