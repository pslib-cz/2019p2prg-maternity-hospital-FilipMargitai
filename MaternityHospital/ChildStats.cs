using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            var temp = ChildList.GroupBy((dite) => (dite.Name), (jmeno, decka) => (new AvgChild(jmeno, 0 /*todo*/, decka.Count())));

            return new List<AvgChild>();
        }

        public override string GetCommonNames()
        {
            return "";
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