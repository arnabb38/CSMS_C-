using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMSRepository
{
    public class VehicleRep
    {
        private string category;
        private string carID;
        private string modelName;
        //private string carClass;
        //private string fuel;
        private string engine;
        //private string release;
        private string color;
        private string seat;
        private string cost;
        private string date;


        public string Category
        {
            set { category = value; }
            get { return category; }
        }

        public string CarID
        {
            set { carID = value; }
            get { return carID; }
        }

        public string ModelName
        {
            set { modelName = value; }
            get { return modelName; }
        }

        //public string CarClass
        //{
        //    set { carClass = value; }
        //    get { return carClass; }
        //}

        //public string Fuel
        //{
        //    set { fuel = value; }
        //    get { return fuel; }
        //}

        public string Engine
        {
            set { engine = value; }
            get { return engine; }
        }

        //public string Release
        //{
        //    set { release = value; }
        //    get { return release; }
        //}

        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        public string Cost
        {
            set { cost = value; }
            get { return cost; }
        }

        public string Seat
        {
            set { seat = value; }
            get { return seat; }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
