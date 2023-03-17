namespace Builder_Pattern.Example2;

public class OldRobotBuilder : IRobotBuilder
{
    private Robot robot;

    public OldRobotBuilder()
    {
        robot = new Robot();
    }

    public void BuildRobotHead()
    {
        robot.Head = "Head";
    }

    public void BuildRobotTorso()
    {
        robot.Torso = "Torso";
    }

    public void BuildRobotArms()
    {
        robot.Arms = "Arms";
    }

    public void BuildRobotLegs()
    {
        robot.Legs = "Legs";
    }

    public Robot GetRobot()
    {
        return robot;
    }
}