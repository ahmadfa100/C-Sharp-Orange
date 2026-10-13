using Task4_OOP2;

Person p1 = new Person();


// they will casue error due to the access modifiers. (We are in the main, and they are protected and private)
//p1.ScchoolName;
//p1._internalCode;

Student s1 = new Student();
s1.name = "Ahmad";
s1.Age = 25;
s1.Grade = 12;
s1.setStudentId(1234);
s1.DisplayInfo();

Console.WriteLine("\n now Student 2");

Student s2 = new Student();
s2.name = "Ali";
s2.Age = 20;
s2.Grade = 10;
s2.setStudentId(5678);
s2.DisplayInfo();

Teacher t1 = new Teacher();
t1.name = "Mohammed";
t1.Age = 30;
t1.Subject = "Math";


Console.WriteLine("Now School Report");
SchoolReport report = new SchoolReport("Student Report");
report.DisplayReportTitle();