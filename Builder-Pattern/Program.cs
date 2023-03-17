using Builder_Pattern.Example1;
using Builder_Pattern.Example2;

class Program
{
    static void Main(String[] args)
    {
        //Example1
        EmployeeBuilder builder = new EmployeeBuilder();
        var employee = builder
            .SetFirstName("Sait Han")
            .SetLastName("Uzun")
            .SetEmailAddress("saithan.uzun@gmail.com")
            .SetUserName("saithanuzun")
            .BuildEmployee();
        
        Console.WriteLine(employee.ToString());


        //Example2
        IRobotBuilder oldStyleRobot = new OldRobotBuilder();
        RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);

        robotEngineer.MakeRobot();
        Robot robot = robotEngineer.GetRobot();
        
        Console.WriteLine(robot.ToString());
    }
}