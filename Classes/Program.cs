namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "Explorer";
            carOne.Year = 2025;

            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in the year {carOne.Year}");
        }
    }
}
