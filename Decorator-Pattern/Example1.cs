// 1950s
public class Computer
{
    public void Start()
    {
        Console.WriteLine($"{GetType().Name} is starting");
    }

    public void ShutDown()
    {
        Console.WriteLine($"{GetType().Name} is shutting down");
    }
}

// 1970s
public class Laptop: Computer
{
    public void OpenLid()
    {
        Console.WriteLine($"{GetType().Name}'s lid is opening");
    }

    public void CloseLid()
    {
        Console.WriteLine($"{GetType().Name}'s lid is closing");
    }
}

public class LaptopDecorator : Laptop
{
    public virtual void OpenLid()
    {
        Console.WriteLine("base laptop decorator");
        base.OpenLid();
    }

    public virtual void CloseLid()
    {
        base.CloseLid();
        Console.WriteLine("base laptop decorator");
    }
}


public class DellLaptop : LaptopDecorator
{
    public override void CloseLid()
    {
        base.CloseLid();
        Console.WriteLine("Dell Laptop is sleeping");
    }

    public override void OpenLid()
    {
        Console.WriteLine("Dell Laptop is waking up");
        base.OpenLid();
    }
}

class AppleLaptop : LaptopDecorator
{
    public override void CloseLid()
    {
        base.CloseLid();
        Console.WriteLine("Apple Laptop is sleeping");
    }

    public override void OpenLid()
    {
        Console.WriteLine("Apple Laptop is waking up");
        base.OpenLid();
    }
}