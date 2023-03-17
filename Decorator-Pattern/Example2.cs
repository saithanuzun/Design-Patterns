
interface IPizza
{
    String GetPizzaType();
}

class Pizza : IPizza
{
    public string GetPizzaType()
    {
        return "This is a normal Pizza";
    }
}

class PizzaDecorator : IPizza
{
    private IPizza pizza;

    public PizzaDecorator(IPizza pizza)
    {
        this.pizza = pizza;
    }
    public virtual string GetPizzaType()
    {
        return pizza.GetPizzaType();
    }
}

class CheeseDecorator : PizzaDecorator
{
    public CheeseDecorator(IPizza pizza) : base(pizza){}
    public override String GetPizzaType()
    {
        String type = base.GetPizzaType();
        type += "\r\n Extra Cheese Added";
        return type;
    }
}
class OnionDecorator : PizzaDecorator
{
    public OnionDecorator(IPizza pizza) : base(pizza){}
    public override String GetPizzaType()
    {
        String type = base.GetPizzaType();
        type += "\r\n Extra Onion Added";
        return type;
    }
}
class TomatoDecorator : PizzaDecorator
{
    public TomatoDecorator(IPizza pizza) : base(pizza){}
    public override String GetPizzaType()
    {
        String type = base.GetPizzaType();
        type += "\r\n Extra Tomato Added";
        return type;
    }
}