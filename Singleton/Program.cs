
class Singleton
{
    private static Singleton instance = null; 
    public static Singleton Instance => instance ?? (instance = new Singleton());
    public string Car { get; set; }
    private Singleton()
    {
        
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //var mysingleton = new Singleton(); //private Constructor
        var mySingleton = Singleton.Instance;
        mySingleton.Car = "BMW";
        var mySingleton2 = Singleton.Instance;
        Console.WriteLine(mySingleton2.Car);//output: BMW
        
        
    }
}