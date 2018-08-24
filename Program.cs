using System;
using System.Collections.Generic;

public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get;}
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> currentEmployees = new List<Employee>();

    public Company (string name, DateTime creationDate)
    {
        Name = name;
        CreatedOn = creationDate;
    }

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
}

public class Employee
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string title { get; set; }
    public DateTime startDate { get; set; }


}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company bobSausages = new Company("Bob's Sausages", new DateTime(1987, 7, 4, 16, 10, 40));
        System.Console.WriteLine($"{bobSausages.Name} {bobSausages.CreatedOn}");
        // Create three employees

        Employee sethDana = new Employee()
        {
            firstName = "Seth",
            lastName = "Dana",
            title = "Head Dude",
            startDate = new DateTime(2017, 4, 23, 8, 0, 0)
        };

        Employee bobDole = new Employee()
        {
            firstName = "Bob",
            lastName = "Dole",
            title = "Boss Sasusage",
            startDate = new DateTime(1987, 7, 4, 16, 10, 40)
        };

        Employee janeSmith = new Employee()
        {
            firstName = "Jane",
            lastName = "Smith",
            title = "Sausage Chef",
            startDate = new DateTime(1989, 3, 3, 9, 15, 0)
        };

        // Assign the employees to the company
        bobSausages.currentEmployees.Add(sethDana);
        bobSausages.currentEmployees.Add(bobDole);
        bobSausages.currentEmployees.Add(janeSmith);
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */

        foreach (Employee emp in bobSausages.currentEmployees)
        {
            System.Console.WriteLine($"{emp.firstName} {emp.lastName} has been working at {bobSausages.Name} as {emp.title} since {emp.startDate} ");
        }
    }
}