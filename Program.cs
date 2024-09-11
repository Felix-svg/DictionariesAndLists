using System;
using System.Collections.Generic;

namespace ListObjects;

class Program
{
    static void Main(string[] args)
    {
        // Create student objects
        Student S1 = new(100, "Student", "One", "Tertiary", 'A');
        Student S2 = new(101, "Student", "Two", "High School", 'B');
        Student S3 = new(102, "Student", "Primary", "Tertiary", 'C');
        Student S4 = new(103, "Student", "Four", "PreSchool", 'D');

        // Create employee objects
        Employee E1 = new(200, "John", "Doe", 5000, "johndoe@email.com");
        Employee E2 = new(201, "Jane", "Doe", 4500, "janedoe@email.com");
        Employee E3 = new(202, "Matt", "Smith", 5500, "smith@email.com");
        Employee E4 = new(203, "Grusha", "Vashnadze", 6000, "vashnadze@email.com");

        // Create a dictionary of student objects
        Dictionary<int, Student> studentsDictionary = new Dictionary<int, Student>();

        // Add student object to the dictionary
        studentsDictionary.Add(S1.ID, S1);
        studentsDictionary.Add(S2.ID, S2);
        studentsDictionary.Add(S3.ID, S3);
        studentsDictionary.Add(S4.ID, S4);

        // iterate through keys and values of student dictionary
        foreach (KeyValuePair<int, Student> studentKeyValue in studentsDictionary)
        {
            Console.WriteLine(studentKeyValue.Key);
            Console.WriteLine(studentKeyValue.Value);
        }

        // iterate through keys of student dictionary
        foreach (int key in studentsDictionary.Keys)
        {
            Console.WriteLine($"ID: {key}");
        }

        // iterate through values of student dictionary
        foreach (var value in studentsDictionary.Values)
        {
            Console.WriteLine($"Name: {value.FirstName} {value.LastName}\nEducation Level: {value.Level}\nGrade: {value.Grade}");
            Console.WriteLine("_______________________________");
        }

        // Create a list of employee objects
        List<Employee> employeeList = new List<Employee>();

        // Add employee objects to the list
        employeeList.Add(E1);
        employeeList.Add(E2);
        employeeList.Add(E3);
        employeeList.Add(E4);

        // Retrieve items from the list
        Employee retrievedEmployee = employeeList[0];
        Console.WriteLine(retrievedEmployee.FirstName);

        // iterate through the list items using foreach loop
        int count = 1;
        foreach (Employee employee in employeeList)
        {
            Console.WriteLine($"Employee {count}\nID: {employee.ID}\nName: {employee.FirstName} {employee.LastName}\nEmail: {employee.Email}\nSalary: {employee.Salary}");
            Console.WriteLine("______________________________");
            count++;
        }

        // iterate through the list items using for loop
        for (int i = 0; i < employeeList.Count; i++)
        {
            Employee e = employeeList[i];
            Console.WriteLine($"Employee {i+1}\nID: {e.ID}\nName: {e.FirstName} {e.LastName}\nEmail: {e.Email}\nSalary: {e.Salary}");
            Console.WriteLine("______________________________");
        }
    }
}
