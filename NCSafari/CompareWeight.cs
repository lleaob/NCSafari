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
        public bool Descending = false; //no get or set as this is being used only internally 
        public CompareWeight(bool descending) { Descending = descending; } //constructor

        public int Compare(Animal firstAnimal, Animal secondAnimal) //
        {
            int result = firstAnimal.Weight.CompareTo(secondAnimal.Weight);

            Console.WriteLine(firstAnimal.Weight + " VS " + secondAnimal.Weight + " " + result + "\n");
            return Descending ? -result : result;
        }
    }
}
