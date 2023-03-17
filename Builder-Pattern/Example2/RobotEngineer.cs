namespace Builder_Pattern.Example2;

// The director / engineer class creates a Robot using the
// builder interface that is defined (OldRobotBuilder)

public class RobotEngineer
{
    private IRobotBuilder robotBuilder;

    public RobotEngineer(IRobotBuilder _robotBuilder)
    {
        robotBuilder = _robotBuilder;
    }

    public Robot GetRobot()
    {
        return robotBuilder.GetRobot();
    }

    public void MakeRobot()
    {
        robotBuilder.BuildRobotHead();
        robotBuilder.BuildRobotTorso();
        robotBuilder.BuildRobotArms();
        robotBuilder.BuildRobotLegs();
    }
}