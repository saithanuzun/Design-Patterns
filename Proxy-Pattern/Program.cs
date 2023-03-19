/* What is the Proxy design pattern ?
 * provide a class which will limit access to another class
 * you may do this for security reasons
*/
interface IService
{
    void Login(string username);
}

class Service : IService
{
    public void Login(string username)
    {
        Console.WriteLine($"you are logged in. {username}");
    }
}

class Proxy : IService
{
    private IService service;

    public Proxy(IService service)
    {
        this.service = service;
    }
    public void Login(string username)
    {
        if (!string.Equals(username, "saithanuzun"))
        {
            Console.WriteLine($"Username({username}) is wrong");
            return;
        }
        
        service.Login(username);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        IService service = new Service();
        IService proxy = new Proxy(service);
        
        proxy.Login("sait");
        proxy.Login("saithanuzun");
    }
}