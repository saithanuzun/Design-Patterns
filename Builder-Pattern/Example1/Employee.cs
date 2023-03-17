namespace Builder_Pattern.Example1;

public class Employee
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String EmailAddress { get; set; }
    public String Username { get; set; }

    public override String ToString()
    {
        return $"FullName: {FirstName} {LastName} EmailAddress: {EmailAddress} UserName: {Username}";
    }
        
}