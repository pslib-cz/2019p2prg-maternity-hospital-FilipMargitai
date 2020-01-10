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
            List<Child> CommonNames = new List<Child> { };
            CommonNames.Add(ChildList[0]);
            for(int i = 0; i < ChildList.Count; i++)
            {
                for (int ii = 0; ii < CommonNames.Count; ii++)
                {
                    if (CommonNames[ii].Count < ChildList[i].Count)
                    {
                        CommonNames.RemoveAt(ii);
                        CommonNames.Add(ChildList[i]);
                    }
                    else if (CommonNames[ii].Count == ChildList[i].Count)
                    {
                        CommonNames.Add(ChildList[i]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            string MyOverride = "";
            foreach(Child child in CommonNames)
            {
                MyOverride += child.Name + " ";
            }
            for (int i = 0; i < CommonNames.Count; i++)
            {
                MyOverride += CommonNames[i].Name;
                if (CommonNames.Count != (i))
                {
                    MyOverride += ", ";
                }
                else
                {
                    break;
                }
            }
            return MyOverride;
        }

        public override string GetFatNames()
        {
            throw new NotImplementedException();
        }

        public override double GetFatWeight()
        {
            double weight = 0;
            foreach(Child child in ChildList)
            {
                if((child.Weight / (double)child.Count) > weight)
                {
                    weight = child.Weight / (double)child.Count;
                }
            }
            return weight;
        }
    }
}
