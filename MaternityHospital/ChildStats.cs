using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital
{
    class ChildStats : BaseMHStats
    {
        public List<Child> ChildList = new List<Child> { };
        public override void AddChild(string name, double weight)
        {
            if(ChildList.Count < 1)
            {
                ChildList.Add(new Child(name, weight));
            }
            else
            {
                for (int i = 0; i < ChildList.Count; i++)
                {
                    if (ChildList[i].Name == name)
                    {
                        ChildList[i].Weight += weight;
                        ChildList[i].Count += 1;
                    }
                    else
                    {
                        ChildList.Add(new Child(name, weight));
                        break;
                    }
                }
            }
        }

        public override string GetCommonNames()
        {
            List<int> CommonNames = new List<int> { };
            for(int i = 0; i < ChildList.Count; i++)
            {
                if(CommonNames)
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
