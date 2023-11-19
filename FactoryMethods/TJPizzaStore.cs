using FactoryPipsaÑomÑom.AbstractFactories;
using FactoryPipsaÑomÑom.AbstractFactories.Abstractions;
using FactoryPipsaÑomÑom.Products.Pizzas;

namespace FactoryPipsaÑomÑom.FactoryMethods
{
    internal class TJPizzaStore :PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new TJPizzaIngredientFactory();
            
            switch (item)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory) { Name = "Tijuana Style Cheese Pizza"};
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory) { Name = "Tijuana Style Veggie Pizza" };
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory) { Name = "Tijuana Style Clam Pizza" };
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory) { Name = "Tijuana Style Pepperoni Pizza" };
                    break;
            }
            return pizza;
        }
    }
}
