void guessingGame()
{
    int randNum = new Random().Next(50, 76);
    int attempt = 1;
    int points = 0;

    Console.WriteLine("===== Guessing Game =====");

    while (true)
    {
        Console.WriteLine($"\n Your guess: {randNum} \n");
        Console.Write("Guess a number between 50 and 75: ");
        int guess = Convert.ToInt32(Console.ReadLine());
        if (guess == randNum)
        {
            Console.WriteLine("You guessed the number correctly!");

            if (attempt == 1)
            {
                points = 10;
            }
            else if (attempt == 2)
            {
                points = 7;
            }
            else if (attempt == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            break;
        }
                if (guess > randNum)
        {
            Console.WriteLine("Try a lower number.");
        }
        else if (guess < randNum)
        {
            Console.WriteLine("Try a higher number.");
        }

        attempt++;
    }

    Console.WriteLine($"Attempts: {attempt}");
    Console.WriteLine($"Points: {points}");
}

guessingGame();

Console.WriteLine("\n --------------- part 2 of School System------------------ \n");

void printNamesAndGrades()
{
    string[] names=  {"Ahmad","Sara","Omar","Lina","Yazan"};

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write(names[i] + "\t");
        }

    Console.WriteLine("\n ------ Now I will print the grades ---------- \n");

    int[] grades=  {85,92,68,75,90};

    foreach (int n in grades)
    {
        Console.Write(n + "\t");
    }

}
printNamesAndGrades();

void checkStudentName()
{
    string[] names=  {"Ahmad","Sara","Omar","Lina","Yazan"};
    Console.WriteLine("\nEnter the student name you want to search for:");
    string studentName = Console.ReadLine();
    int i = 0;
    bool found = false;

while (i < names.Length)
{
    if (studentName == names[i])
    {
        Console.WriteLine("Student Found!");
        found = true;
        break;
    }

    i++;
}

if (!found)
{
    Console.WriteLine("Student Not Found.");
}

}

checkStudentName();
void checkStudentResult()
{
    Console.WriteLine("Enter your grade please");
    int grade = Convert.ToInt32(Console.ReadLine());

    if(grade >= 90 && grade <= 100)
    {
        Console.WriteLine("Excellent");
    }
    else if(grade >= 80 && grade <= 89)
    {
        Console.WriteLine("Very Good");
    }
    else if(grade >= 70 && grade <= 79)
    {
        Console.WriteLine("Good");
    }
    else if(grade >= 60 && grade <= 69)
    {
        Console.WriteLine("Pass");
    }
    else
    {
        Console.WriteLine("Fail");
    }
}

checkStudentResult();

void displayMenu()
{
    int choice;

    do
    {
        Console.WriteLine("\n===== School System =====");
        Console.WriteLine("1. Display Students");
        Console.WriteLine("2. Search for Student");
        Console.WriteLine("3. Check Student Result");
        Console.WriteLine("4. Exit");

        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                printNamesAndGrades();
                break;

            case 2:
                checkStudentName();
                break;

            case 3:
                checkStudentResult();
                break;

            case 4:
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

    } while (choice != 4);
}

displayMenu();