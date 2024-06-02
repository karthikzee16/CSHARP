bool isValidAge;
int age;
//do while loop runs the code atleast once
do 
{
	Console.WriteLine("what is your age:");
	string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);
    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age");
       
    }
} while (isValidAge==false);

Console.WriteLine($"your age is {age}");


//while loop runs the code 0 or more number of times
while (true)
{


}
