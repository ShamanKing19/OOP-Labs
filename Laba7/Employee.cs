namespace Laba7;

public class Employee
{
    public Employee(string firstName, string secondName, string? email, string? phone, EmployeeRole[] roles, string[] languages)
    {
        FirstName = firstName;
        SecondName = secondName;
        Email = email;
        Phone = phone;
        Roles = roles;
        Languages = languages;
    }

    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public  EmployeeRole[] Roles { get; set; }
    public string[] Languages { get; set; }
    
}