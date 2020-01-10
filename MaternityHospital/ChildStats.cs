using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital
{
    class ChildStats : BaseMHStats
    {
        private Dictionary<string, double> ChildDictionary = new Dictionary<string, double>();
        public override void AddChild(string name, double weight)
        {
            ChildDictionary.Add(name, weight);
        }

        public override string GetCommonNames()
        {
            List<string> CommonNames = new List<string> { };
            int NameCount = 0;
            for(int i = 0; i < ChildDictionary.Count; i++)
            {

            }
        }

        public override string GetFatNames()
        {
            throw new NotImplementedException();
        }

        public override double GetFatWeight()
        {
            throw new NotImplementedException();
        }
    }
}
