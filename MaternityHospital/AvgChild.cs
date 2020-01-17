using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital
{
    class AvgChild
    {
        public AvgChild(string name, double weight, int count)
        {
            Name = name;
            SumWeight = weight;
            Count = count;
        }
        public AvgChild(string name, double weight) : this(name, weight, 1) { }

        public double AvgWeight => (SumWeight / Count);

        public void Add(double weight)
        {
            Count++;
            SumWeight += weight;
        }

        public string Name { get; }
        public double SumWeight { get; set; }
        public int Count { get; set; }
        
    }
}
