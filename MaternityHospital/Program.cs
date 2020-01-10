using System;
using static System.Console;

namespace MaternityHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var mhs1 = new <InsertClassName>();

            mhs1.AddChild("František", 3);
            mhs1.AddChild("Jan", 4);
            mhs1.AddChild("Petr", 5);
            mhs1.AddChild("Jan", 5);
            mhs1.AddChild("Petr", 6);
            mhs1.AddChild("Petr", 4);
            mhs1.AddChild("František", 8);
            mhs1.AddChild("Jan", 3.5);

            WriteLine($"Nejtlustší děti: {mhs1.GetFatNames()} (průměrně {mhs1.GetFatWeight()} kg)");
            WriteLine($"Nejběžnější jméno: {mhs1.GetCommonNames()}");

            ReadKey();
        }
    }
}
