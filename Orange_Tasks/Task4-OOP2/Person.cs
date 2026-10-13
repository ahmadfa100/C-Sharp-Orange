using System;

namespace Task4_OOP2;

public class Person
{
    public string name;
    public int Age {get;set;}

    private string _internalCode;
    // It will not be accessed in the drived class due to the private access modifier.

    protected string SchoolName{get;set;}

    public void DisplayInfo()
    {
        Console.WriteLine($" Person's Name : {name} Person's Age : {Age}");
    }
}
