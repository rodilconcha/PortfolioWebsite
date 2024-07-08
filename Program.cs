
using System;
interface IQuittable
{
    void Quit();
}
class Employee : IQuittable
{
    public string Name { get; set; }

    // Implement the Quit() method
    public void Quit()
    {
        Console.WriteLine($"{Name} has quit the job.");
    }
}
static void Main(string[] args)
{
    Employee employee = new Employee { Name = "John" };
    IQuittable quittableEmployee = employee;

    // Call Quit() using polymorphism
    quittableEmployee.Quit();

    // Output: "John has quit the job."
}