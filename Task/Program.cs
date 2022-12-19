namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Azerbaijan = new Country("Azerbaijan");
            City Baku = new City("Baku", 2000);
            Azerbaijan.AddCity(Azerbaijan, Baku);
            Azerbaijan.FindAllByPopulation(1, 2001);

        }
    }
}