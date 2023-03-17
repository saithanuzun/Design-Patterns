
class Program
{
    public static void Main(string[] args)
    {
        //actionFilters and Middlewares are good examples for this pattern
        
        //Example 1
        Laptop myLaptop = new Laptop();
        LaptopDecorator appleLaptop = new AppleLaptop();
        appleLaptop.CloseLid();
        appleLaptop.OpenLid();
        
        //Example 2
        IPizza pizza = new Pizza();
        IPizza cheeseDecorator = new CheeseDecorator(pizza);
        IPizza onionDecorator = new OnionDecorator(cheeseDecorator);
        IPizza tomatoDecorator = new TomatoDecorator(onionDecorator);

        Console.WriteLine(tomatoDecorator.GetPizzaType());

    }
}