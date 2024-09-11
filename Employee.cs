using System;

namespace ListObjects;

class Employee
{
    // Employee class fields
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public string Email { get; set; }

    // Employee class constructor
    public Employee(int id, string firstName, string lastName, decimal salary, string email)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        Email = email;
    }
}
