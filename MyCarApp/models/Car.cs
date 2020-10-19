using System;
using System.Collections.Generic;
using System.Text;

namespace MyCarApp.models
{
    class Car
    {
        public string CarType;
        public string Manufacturer;
        public string Name;
        public string BuildYear;
        public string Color;

        public string toString()
        {
            return CarType + " ;" + Manufacturer + " ;" + Name + " ;" + BuildYear + " ;" + Color;
        }
    }
}
