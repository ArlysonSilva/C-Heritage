using System.Security.Cryptography.X509Certificates;

class Collaborator : Person
{
    //Attributes
    private string? _position;
    private double _salary;
    //Constructor
    public Collaborator(string name, int age, string position, double salary)
    {
        Name = name;
        Age = age;
        _position = position;
        _salary = salary;

        ShowPerson();
        ShowCollaborator();
    }
    //Method to show data
    private void ShowCollaborator()
    {
        Console.WriteLine($"Position: {_position}");
        Console.WriteLine($"Salary: {_salary}");
    }
}