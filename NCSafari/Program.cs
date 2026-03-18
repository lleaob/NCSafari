using System.Globalization;

namespace NCSafari
{
    internal class Program
    {
        public static void Main()
        {
            //List<Animal> animalsToSee = new List<Animal>
            //{
            //    new Tiger(70),
            //    new Goose(5.2f),
            //    new Bat(0.9f),
            //    new Goose(4),
            //    new Tiger(90),
            //    new Penguin(15.8f)
            //};

            //animalsToSee.Sort(new CompareWeight(true));
            //animalsToSee.ForEach(animal => Console.WriteLine($"{animal.GetType().Name} - {animal.Weight}kg"));

            //animalsToSee.Sort(new CompareWeight(false));
            //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));

            Tiger pumpkin = new Tiger((float)100.4); //Casting the number into a float as Animal Weight is a float
            CultureInfo culture = new CultureInfo("es-ES");

            pumpkinWeightFormatter = new WeightFormatter(pumpkin, culture);


        }
    }
}
