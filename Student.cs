using System;

namespace ListObjects;

class Student
{
    // Student class fields
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Level { get; set; }
    public char Grade { get; set; }

    // Student class constructor
    public Student(int id,string firstName, string lastName, string level, char grade)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Level = level;
        Grade = grade;
    }
}
