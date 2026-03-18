using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class CompareWeight : IComparer<Animal>
    {
        public bool Descending = false;
        public CompareWeight(bool descending) { Descending = descending; } //constructor

        public int Compare(Animal firstAnimal, Animal secondAnimal) //implementing the Compare method (from the IComparer built-in interface)
        {
            int result = firstAnimal.Weight.CompareTo(secondAnimal.Weight);

            Console.WriteLine(firstAnimal.Weight + " VS " + secondAnimal.Weight + " " + result + "\n");
            return Descending ? -result : result;
        }
    }
}
