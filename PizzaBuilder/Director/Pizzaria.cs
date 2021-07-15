using PizzaBuilder.Product;

namespace PizzaBuilder.Director
{
    public class Pizzaria
    {
        private readonly Builder.PizzaBuilder builder;

        public Pizzaria(Builder.PizzaBuilder builder)
        {
            this.builder = builder;
        }

        // Construct
        public void MontarPizza()
        {
            builder.CriarPizza();
            builder.PrepararMassa();
            builder.IncluirIngredientes();
        }

        public Pizza GetPizza() => builder.GetPizza();
    }
}
