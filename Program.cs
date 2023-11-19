using FactoryPipsaÑomÑom.FactoryMethods;
using FactoryPipsaÑomÑom.Products.Pizzas;

namespace FactoryPipsaÑomÑom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaStore tjStore = new TJPizzaStore();
            Pizza pizza;

            pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");
            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza + "\n");
            pizza = tjStore.OrderPizza("cheese");
            Console.WriteLine("Juan ordered a " + pizza + "\n");
            
            
            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");
            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza + "\n");
            pizza = tjStore.OrderPizza("clam");
            Console.WriteLine("Juan ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");
            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza + "\n");
            pizza = tjStore.OrderPizza("pepperoni");
            Console.WriteLine("Juan ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza + "\n");
            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza + "\n");
            pizza = tjStore.OrderPizza("veggie");
            Console.WriteLine("Juan ordered a " + pizza + "\n");
        }
    }

} 