// Define the record
using System.Runtime.CompilerServices;
using System.Security.Authentication;

record Person(string Name, int Age);
record Address(string Street, string City);
record Employee(string Name, Address EmployeeAddress);

public class RecordsExercise
{
    public static void Main()
    {
        RecordsExercise recordsExercise = new RecordsExercise();
        //recordsExercise.exercise1();
        recordsExercise.exercise2();
    }

    public void exercise1(){
               // Create two instances with identical data
        var person1 = new Person("John Doe", 30);
        var person2 = new Person("John Doe", 30);
        

        // Check for equality
        bool areEqual = person1 == person2;
        Console.WriteLine($"Are person1 and person2 equal? {areEqual}");

        Person person3 = person1 with {Age = 20};
        Console.WriteLine(person3);

        bool areEqual2 = person1 == person3;
        Console.WriteLine($"Are person1 and person2 equal? {areEqual2}");
    }

    public void exercise2()
    {
        var address = new Address("valby", "copenhagen");
        var employee = new Employee("Ferhat", address);

        Console.WriteLine($"Employee Name: {employee.Name}");
        Console.WriteLine($"Employee Address: {employee.EmployeeAddress.Street}, {employee.EmployeeAddress.City}");

        //ændre city
        var employee1 = employee with {EmployeeAddress = employee.EmployeeAddress with {City = "Amsterdam"}};
        Console.WriteLine($"Employee Address: {employee1.EmployeeAddress.Street}, {employee1.EmployeeAddress.City}");

        //equals
        bool equals = employee == employee1;
        Console.WriteLine(equals);
    }
}

