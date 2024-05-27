Console.Write("What is your age:");
string? ageText = Console.ReadLine();

//treats int as a string and performs string concetanation
Console.WriteLine(ageText + 15);  //2715

//parse as int
int age = int.Parse(ageText);
Console.WriteLine(age + 15); //42

/* if user input is not a number -> int.Parse() throws exception and program crashes
   so we use int.TryParse() , it returns a boolean value
   if outcome is true we perform the operation
   if outcome is false program does not crash.*/

bool isValidNumber = int.TryParse(ageText, out int age2);
if (isValidNumber) 
{
    Console.WriteLine($"Valid number enetered, Age 15 years from now is: {age2 + 15}");
    
}


Console.ReadLine();

double testDouble = age; // implicit type conversion from int to double
// decimal testDecimal = testDouble; //implicit conversion from double to decimal is not possible
decimal testDecimal = (decimal)testDouble; // explicit type conversion from double to decimal



 