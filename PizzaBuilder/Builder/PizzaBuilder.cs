using PizzaBuilder.Product;

namespace PizzaBuilder.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public void CriarPizza() => pizza = new Pizza();

        public Pizza GetPizza() => pizza;

        public abstract void PrepararMassa();
        public abstract void IncluirIngredientes();
    }
}
