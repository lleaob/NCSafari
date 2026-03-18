namespace NCSafari
{
    internal class Program
    {
        public static void Main()
        {
            List<Animal> animalsToSee = new List<Animal>
            {
                new Tiger(70),
                new Goose(5.2f),
                new Bat(0.9f),
                new Goose(4),
                new Tiger(90),
                new Penguin(15.8f)
            };

            animalsToSee.Sort(new CompareWeight(true));
            animalsToSee.ForEach(animal => Console.WriteLine($"{animal.GetType().Name} - {animal.Weight}kg"));

            //animalsToSee.Sort(new CompareWeight(false));
            //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));

        }
    }
}
