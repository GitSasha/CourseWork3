using System;
using PIZZAZZ.Dishes;
using PIZZAZZ.Decorators;

namespace PIZZAZZ
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDish fourcheesepizza = new CheeseRicotta(new CheeseParmesan(new CheeseMozarella(new CheeseBrie(new SauceCream(new Pizza())))));
            BaseDish margheritapizza = new Oregano(new Basil(new Tomatos(new CheeseMozarella(new SauceTomato(new Pizza())))));
            BaseDish suprimpizza = new Pickles(new Leek(new Olives(new MushroomsChampignon(new Sausages(new Salami(new CheeseMozarella(new SauceTomato(new Pizza()))))))));
            BaseDish caesarpizza = new Tomatos(new Lettuce(new MeatChicken(new CheeseParmesan(new CheeseMozarella(new SauceCream(new Pizza()))))));
            BaseDish fourseasonspizza = new Tomatos(new PepperBulgarian(new Olives(new MushroomsChampignon(new SalamiPepperoni(new MeatSmokedChicken(new MeatHam(new MeatBacon(new CheeseMozarella(new SauceTomato(new Pizza()))))))))));
            BaseDish bavarianpizza = new SalamiPepperoni(new MeetBeef(new SausagesBavarian(new CheeseMozarella(new SauceTomato(new Pizza())))));
            BaseDish pepperonipizza = new Oregano(new Basil(new SalamiPepperoni(new CheeseMozarella(new SauceTomato(new Pizza())))));
            BaseDish hawaiianpizza = new Oregano(new Basil(new Pineapple(new MeatGrilledChicken(new CheeseMozarella(new SauceTomato(new Pizza()))))));
            BaseDish italianpizza = new Tomatos(new MushroomsChampignon(new MeatGrilledChicken(new CheeseParmesan(new CheeseMozarella(new SauceCream(new Pizza()))))));
            BaseDish seapizza = new Tomatos(new Lemon(new SeaSquid(new SeaShrimp(new SeaMussels(new CheeseMozarella(new SauceCream(new Pizza())))))));
            BaseDish vegeterianpizza = new Oregano(new Basil(new Leek(new PepperBulgarian(new Tomatos(new MushroomsChampignon(new CheeseMozarella(new SauceTomato(new Pizza()))))))));

            Console.WriteLine("----- PIZZAZZ's MENU -----");
            Console.WriteLine();
            Console.WriteLine("Four cheese pizza: {0}. Price: {1}", fourcheesepizza.GetDescription(), fourcheesepizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("four seasons pizza: {0}. Price: {1}", fourseasonspizza.GetDescription(), fourseasonspizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Margherita: {0}. Price: {1}", margheritapizza.GetDescription(), margheritapizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Suprim: {0}. Price: {1}", suprimpizza.GetDescription(), suprimpizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Caesar: {0}. Price: {1}", caesarpizza.GetDescription(), caesarpizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Pepperoni: {0}. Price: {1}", pepperonipizza.GetDescription(), pepperonipizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Bavarian pizza: {0}. Price: {1}", bavarianpizza.GetDescription(), bavarianpizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Hawaiian pizza: {0}. Price: {1}", hawaiianpizza.GetDescription(), hawaiianpizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Italian pizza: {0}. Price: {1}", italianpizza.GetDescription(), italianpizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Sea pizza: {0}. Price: {1}", seapizza.GetDescription(), seapizza.GetCost());
            Console.WriteLine();
            Console.WriteLine("Vegeterianpizza: {0}. Price: {1}", vegeterianpizza.GetDescription(), vegeterianpizza.GetCost());
            Console.WriteLine();
        }
    }
}
