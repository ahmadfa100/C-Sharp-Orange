Console.WriteLine("Please Enter you data");

Console.WriteLine("Enter your name: ");
string studentName = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int studentAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your grade: ");
double studentGrade = Convert.ToDouble( Console.ReadLine());

Console.WriteLine("Enter your average: ");
double studentAverage = Convert.ToDouble(Console.ReadLine()) ;

Console.WriteLine("Enter your gender: ");
string studentGender = Console.ReadLine();


Console.WriteLine("===== Student Report =====");

Console.WriteLine($"Name :{studentName}");
Console.WriteLine($"age :{studentAge}");
Console.WriteLine($"average :{studentAverage}");
Console.WriteLine($"gender :{studentGender}");

Console.WriteLine("===== Name Information =====");

Console.WriteLine("Original Name : "+studentName);
Console.WriteLine("Uppercase : "+studentName.ToUpper());
Console.WriteLine("Lowercase : "+studentName.ToLower());
Console.WriteLine("First Character : "+studentName[0]);

Console.WriteLine("===== Grade Information =====");

Console.WriteLine("Original Average: " + studentAverage);
Console.WriteLine("Bonus Mark: 5" );
double newStudentAverage = studentAverage+5;
Console.WriteLine("New  Average: " + studentAverage);

string result = studentGrade >= 50 ? "Result Passed" : "Result Failed";

Console.WriteLine(result);


Console.WriteLine("================================\n* STUDENT SUMMARY *\n================================");

Console.WriteLine($"Welcome {studentName.ToUpper()}");
Console.WriteLine($"Name:  {studentName}");
Console.WriteLine($"Age {studentAge}");
Console.WriteLine($"Grade {studentGrade}");
Console.WriteLine($"Average {studentAverage}");
Console.WriteLine($"New Average {newStudentAverage}");
Console.WriteLine($"Gender {studentGender}");
Console.WriteLine($"Result {result}");
