using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital
{
    class Child
    {
        public Child(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; set;  }
    }
}
