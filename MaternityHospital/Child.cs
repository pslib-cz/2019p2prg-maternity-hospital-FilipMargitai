﻿using System;
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
            Count = 1;
        }

        public string Name { get; }
        public double Weight { get; set;  }
        public int Count { get; set; }
        public double avgWeight()
        {
            return Weight / Count;
        }
    }
}
