using PizzaBuilder.Product.Enums;
using System.Collections.Generic;

namespace PizzaBuilder.ConcreteBuilder
{
    public sealed class PizzaMussarela : Builder.PizzaBuilder
    {
        public override void IncluirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Mussarela", "Molho de tomate", "Oregano"};
        }

        public override void PrepararMassa()
        {
            pizza.TipoBordaPizza = TipoBordaPizza.Recheada;
            pizza.TipoMassaPizza = TipoMassaPizza.Normal;
            pizza.TamanhoPizza = TamanhoPizza.Grande;
        }
    }
}
