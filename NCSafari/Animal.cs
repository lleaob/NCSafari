using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public abstract class Animal
    {
       // Float to store weight
        public float Weight { get; set; }
        public Animal(float weight)
        {
            Weight = weight;
        }
        public abstract void MakeSound();
    }
}
