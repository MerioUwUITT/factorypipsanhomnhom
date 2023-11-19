using FactoryPipsaÑomÑom.AbstractFactories.Abstractions;
using FactoryPipsaÑomÑom.Products.Ingredients;

namespace FactoryPipsaÑomÑom.AbstractFactories
{
    internal class TJPizzaIngredientFactory :IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new OaxacaCheese();
        }

        public IClams CreateClam()
        {
            return new SoftShellClams();
        }

        public IDough CreateDough()
        {
            return new SpicyDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new ChorizoPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new DelValleTomatoPuree();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = { new Jalapeño(), new RedOnion(), new Mushroom(), new GreenPepper()};
            return veggies;
        }
    }
}
