using System;
using System.Collections.Generic;
using System.Text;

namespace MaternityHospital
{
    abstract class BaseMHStats
    {
            public abstract void AddChild(string name, double weight);

            public abstract string GetCommonNames();

            public abstract double GetFatWeight();

            public abstract string GetFatNames();
    }
}
