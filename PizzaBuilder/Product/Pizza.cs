using PizzaBuilder.Product.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBuilder.Product
{
    public class Pizza
    {
        public TamanhoPizza TamanhoPizza { get; set; }
        public TipoBordaPizza TipoBordaPizza { get; set; }
        public TipoMassaPizza TipoMassaPizza { get; set; }
        public List<string> Ingredientes { get; set; }

        public override string ToString() => @$"
            Pizza com massa: {TipoMassaPizza}
            Tamanho: {TamanhoPizza}
            Tipo de borda: {TipoBordaPizza}
            Ingredientes: {Ingredientes.Aggregate((i, j) => $"{i}, {j}")}";
    }
}
