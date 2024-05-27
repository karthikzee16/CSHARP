//capture users age from console

Console.Write("Please enter your age:");

bool isValidAge = int.TryParse(Console.ReadLine(),out int userAge);


if (isValidAge)
{ 
    //print how old they will be ib 25 years
    Console.WriteLine($"Your Age in 25 years from now will be: {userAge+25}");



    //print how old they were 25 year ago
    Console.WriteLine($"Your Age 25 years ago was: {userAge - 25}");
}

Console.ReadLine();