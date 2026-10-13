using System;

namespace Task4_OOP2;

public class Teacher:Person
{
    public string Subject{get;set;}

    public Teacher() : base(){
        
    }

    public void DisplayTeacherInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Subject : {Subject}");
    }
}
