namespace Builder_Pattern.Example2;

// The concrete Robot class based on the RobotPlan interface

public class Robot : IRobotPlan
{
    public string Head { get; set; }
    public string Torso { get; set; }
    public string Arms { get; set; }
    public string Legs { get; set; }

    public override string ToString()
    {
        return $"Head: {Head} Torso: {Torso} Arms: {Arms} Legs: {Legs}";
    }
}