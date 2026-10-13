using System;

namespace Task4_OOP2;

public class Student:Person
{

    public int Grade{get;set;}

    public int StudentId;

    public void setStudentId(int id)
    {
        StudentId = id;
    }

    public int getstudentId()
    {
        return StudentId;
    }

    void printStudentName()
    {
        Console.WriteLine($"School's name : {SchoolName}");
    }

}
