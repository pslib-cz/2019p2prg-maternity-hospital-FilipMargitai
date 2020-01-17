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
                bool c = false;
                for (int i = 0; i < ChildList.Count; i++)
                {
                    if (ChildList[i].Name == name)
                    {
                        ChildList[i].Weight += weight;
                        ChildList[i].Count += 1;
                        c = true;
                        break;
                    }
                }
                if(c == false)
                {
                    ChildList.Add(new Child(name, weight));
                }
            }
        }

        public override string GetCommonNames()
        {
            
        }

        public override string GetFatNames()
        {
            string Names = "";
            foreach(Child child in ChildList)
            {
                if(child.avgWeight() == GetFatWeight())
                {
                    if(Names == "")
                    {
                        Names += child.Name;
                    }
                    else
                    {
                        Names += ", " + child.Name;
                    }
                }
            }
            return Names;
        }

        public override double GetFatWeight()
        {
            double weight = 0;
            foreach(Child child in ChildList)
            {
                if(child.avgWeight() > weight)
                {
                    weight = child.avgWeight();
                }
            }
            return weight;
        }
    }
}
