﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_
{
    class Car
    {
        public Car(string nameCar, string descriptionCar)
        {
            NameCar = nameCar;
            CountryCode = descriptionCar;
        }

        public string NameCar { get; set; }
        public string CountryCode { get; set; }
    }
}
