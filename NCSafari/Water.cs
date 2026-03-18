using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NCSafari
{
    public class Water: SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is ISwim swimmingAnimal)
                {
                    swimmingAnimal.Swim();
                }
            }
            

        }
    }
}
