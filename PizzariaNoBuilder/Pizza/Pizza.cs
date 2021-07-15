using PizzariaNoBuilder.Pizza.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PizzariaNoBuilder.Pizza
{
    public class Pizza
    {
        private readonly TamanhoPizza tamanhoPizza;
        private readonly TipoBordaPizza tipoBordaPizza;
        private readonly TipoMassaPizza tipoMassaPizza;
        private readonly List<string> ingredientes;

        public Pizza(TamanhoPizza tamanhoPizza, TipoBordaPizza tipoBordaPizza, TipoMassaPizza tipoMassaPizza, List<string> ingredientes)
        {
            this.tamanhoPizza = tamanhoPizza;
            this.tipoBordaPizza = tipoBordaPizza;
            this.tipoMassaPizza = tipoMassaPizza;
            this.ingredientes = ingredientes;
        }

        public override string ToString() => @$"
            Pizza com massa: {tipoMassaPizza}
            Tamanho: {tamanhoPizza}
            Tipo de borda: {tipoBordaPizza}
            Ingredientes: {ingredientes.Aggregate((i, j) => $"{i}, {j}")}";
    }
}
