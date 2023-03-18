/* What is the Factory Pattern ?
 * when method returns one of several possible classes that share a common superclass
 */

/* When to use this Patern?
 * when You dont know ahead of time what class object you need
 * when you dont want the user to have to know every subclass
 * to encapsulate object creation
 * when all of the potential classes are in the same subclass hierarchy
*/

public abstract class EnemyShip
{
    public String Name { get; set; }
    public int Speed { get; set; }
    public int Damage { get; set; }

    protected EnemyShip(string name, int speed, int damage)
    {
        Name = name;
        Damage = damage;
        Speed = speed;
    }

    public void FollowHeroShip()
    {
        Console.WriteLine(this.GetType() + " is following");
    }
}

public class UfoEnemyShip : EnemyShip
{
    public UfoEnemyShip() : base("Ufo enemy", 200, 100){}
}

public class RocketEnemyShip : EnemyShip
{
    public RocketEnemyShip() : base("Rocket Enemy", 500, 50){}
}

public class BigRocketEnemyShip : EnemyShip
{
    public BigRocketEnemyShip() : base("Big Rocket Enemy", 100, 1000){}
}

public class EnemyFactory
{
    public static EnemyShip? MakeEnemyShip(char type = '\0' ) => type switch
    {
        'U' => new UfoEnemyShip(),
        'B' => new BigRocketEnemyShip(),
        'R' => new RocketEnemyShip(),
         _ => null,
    };
}

class Program
{
    public static void Main(string[] args)
    {
        var enemy = EnemyFactory.MakeEnemyShip('B');
        
        if(enemy is not  null)
            enemy.FollowHeroShip();
        Console.WriteLine(enemy.Speed);
    }
}