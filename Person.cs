class Person
{
    //attributes 
    protected string? Name;
    protected int Age;

    //Method to show data
    protected void ShowPerson()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}