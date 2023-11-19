using FactoryPipsaÑomÑom.Products.Ingredients;

namespace FactoryPipsaÑomÑom.AbstractFactories.Abstractions
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggies[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}
