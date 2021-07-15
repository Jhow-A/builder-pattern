using PizzaBuilder.ConcreteBuilder;
using PizzaBuilder.Director;
using System;

namespace PizzaBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaria = new Pizzaria(new PizzaCalabresa());
            pizzaria.MontarPizza();

            var pizzaCalabresa = pizzaria.GetPizza();
            Console.WriteLine(pizzaCalabresa.ToString());

            pizzaria = new Pizzaria(new PizzaMussarela());
            pizzaria.MontarPizza();

            var pizzaMussarela = pizzaria.GetPizza();
            Console.WriteLine(pizzaMussarela.ToString());
        }
    }
}
