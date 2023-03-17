namespace Builder_Pattern.Example2;

public interface IRobotPlan
{
	public String Head  { get; set; }
	public String Torso { get; set; }
	public String Arms { get; set; }
	public String Legs { get; set; }
}