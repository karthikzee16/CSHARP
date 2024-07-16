/* Variable
 * A variable is a name of a placeholder which is used to store some value
 */


//"ctrl + D" duplicates current line

Console.WriteLine("Hello World");
Console.WriteLine("[S] See all TODOs");
Console.WriteLine("[A] Add a TODO");
Console.WriteLine("[R] Remove a TODO");
Console.WriteLine("[E] Exit");

//string variable userInput stores value "A"
string userInput = "A";
Console.WriteLine(userInput);

Console.WriteLine("Please enter any string:");
//string variable userInput is reassigned the value which is entered using ReadLine();
userInput = Console.ReadLine();
Console.WriteLine(userInput);

/* Variable names convention*/

/* keywords can't be used as variable names.
 * to use keyword as variable name use @
 * Names can contain letters, digits and the underscore character (_), 
 * but the first character cannot be a digit.
 * C# is case sensitive. thus "count" and "Count" refer to two different variables.
 */

string @class = "first";


/* lowerCamel case 
 * is the standard followed for naming variable names 
 * The variable names should be meanigful and precise */

string thisSenteneceIsWrittenInLowerCamelCase; // Declaration

thisSenteneceIsWrittenInLowerCamelCase = "test"; // Initialization

string anotherVariable = "test too"; // Declaration & Initialization


/*Renaming variables*/

/* "ctrl+RR" to rename all occurences of a variable
 */



Console.ReadKey();

