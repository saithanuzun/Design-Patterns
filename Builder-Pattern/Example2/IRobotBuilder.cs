namespace Builder_Pattern.Example2;

public interface IRobotBuilder
{
    public void BuildRobotHead();
	
    public void BuildRobotTorso();
	
    public void BuildRobotArms();
	
    public void BuildRobotLegs();
	
    public Robot GetRobot();
}