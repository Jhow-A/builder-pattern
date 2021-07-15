using PizzariaNoBuilder.Pizza.Enums;
using System;
using System.Collections.Generic;

namespace PizzariaNoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Pizza.Pizza(
                tipoMassaPizza: TipoMassaPizza.Fina,
                tipoBordaPizza: TipoBordaPizza.Normal,
                tamanhoPizza: TamanhoPizza.Grande,
                ingredientes: new List<string> { "Mussarela", "Molho de tomate", "Oregano"});

            Console.WriteLine(pizza.ToString());
        }
    }
}
