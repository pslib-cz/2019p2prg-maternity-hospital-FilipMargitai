using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MaternityHospital.Linq;

namespace MaternityHospital
{
    class ChildStats : BaseMHStats
    {
        public List<Child> ChildList = new List<Child> { };
        public override void AddChild(string name, double weight)
        {
            ChildList.Add(new Child(name, weight));
        }

        public List<AvgChild> GetAgregate()
        {
            var temp = ChildList.GroupBy(dite => dite.Name, (jmeno, decka) => new AvgChild(jmeno, decka.Sum(d => d.Weight), decka.Count()));

            return new List<AvgChild>(temp);
        }

        public double GetAverageWeight()
        {
            double result = 0;

            result = ChildList.Avg(dite => dite.Weight);

            return result;
        }

        // nahrazeno lambda operací
        //private double DejHmotnostDite(Child dite)
        //{
        //    return dite.Weight;
        //}

        public override string GetCommonNames()
        {
            return ChildList.Join(",");
        }

        public override string GetFatNames()
        {
            string Names = "";
           
            return Names;
        }

        public override double GetFatWeight()
        {
            double weight = 0;
           
            return weight;
        }
    }
}