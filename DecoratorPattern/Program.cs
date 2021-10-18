using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage b = new Caramel(new Coffee());
            Console.WriteLine($"{b.Description()} costs: {b.Cost()}$");

            Beverage sc = new SojaMilk(b);
            Console.WriteLine($"{sc.Description()} costs: {sc.Cost()}$");

            Beverage chocolate = new Chocolate(sc);
            Console.WriteLine($"{chocolate.Description()} costs: {chocolate.Cost()}$");

            Beverage mocca = new Caramel(new Chocolate(new Chocolate(new SojaMilk(new Espresso()))));
            Console.WriteLine($"{mocca.Description()} costs: {mocca.Cost()}$");
        }
    }
}
