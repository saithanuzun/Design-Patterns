namespace Builder_Pattern.Example1;

public class EmployeeBuilder
{
    private Employee Employee {get;set;}

    public EmployeeBuilder()
    {
        Employee = new Employee();
    }

    public EmployeeBuilder SetFirstName(string firstName)
    {
        Employee.FirstName = firstName;
        return this;
    }
    
    public EmployeeBuilder SetLastName(string lastName)
    {
        Employee.LastName = lastName;
        return this;
    }
    
    public EmployeeBuilder SetEmailAddress(string emailAddress)
    {
        Employee.EmailAddress = emailAddress;
        return this;
    }

    public EmployeeBuilder SetUserName(string userName)
    {
        Employee.Username = userName;
        return this;
    }

    public Employee BuildEmployee()
    {
        return Employee;
    }
}