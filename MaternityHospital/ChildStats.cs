using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital
{
    class ChildStats : BaseMHStats
    {
        private List<Child> ChildList = new List<Child> { };
        public override void AddChild(string name, double weight)
        {
            for (int i = 0; i <= ChildList.Count; i++)
            {
                if (ChildList[i].Name == name)
                {
                    ChildList[i].
                }
            }
        }

        public override string GetCommonNames()
        {
            List<int> CommonNames = new List<int> { };
            for(int i = 0; i < ChildList.Count; i++)
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
