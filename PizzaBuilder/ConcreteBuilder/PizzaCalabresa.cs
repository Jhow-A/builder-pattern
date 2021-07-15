using PizzaBuilder.Product.Enums;
using System;
using System.Collections.Generic;

namespace PizzaBuilder.ConcreteBuilder
{
    public sealed class PizzaCalabresa : Builder.PizzaBuilder
    {
        public override void IncluirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Calabresa em fatias", "Molho de tomate" };
        }

        public override void PrepararMassa()
        {
            pizza.TipoBordaPizza = TipoBordaPizza.Normal;
            pizza.TipoMassaPizza = TipoMassaPizza.Grossa;
            pizza.TamanhoPizza = TamanhoPizza.Grande;
        }
    }
}
