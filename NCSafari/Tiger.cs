using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Tiger : PantheraBigCat, IHunt
    {
        public Tiger(float weight) : base(weight) { }

        //We have to implemnt IMove method Move() by declaring it, otherwise error

        public void Hunt()
        {
            Console.WriteLine(this.GetType().Name + "Tiger is hunting!");
        }

    }
}
