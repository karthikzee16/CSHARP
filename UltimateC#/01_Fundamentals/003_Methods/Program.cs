
// methods can be used before they are declared.

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice); 

// if method is not defined ,VS can generate it using Quick Actions & Refactorings


//Refactoring IsLong()

/*bool IsLong(string input)
{
    if (input.Length > 10)
    {
        return true;
    }
    else return false;

}*/

/* Code Refactoring*/
/* The process of improving the code quality without altering its behavior.*/

bool IsLong(string input)
{
    return input.Length > 10;
}


/* C# is statically typed language
 * during the compilation, the compiler checks if there are no type mismatches in our code
   so we won't experience runtime errors related to type mismatch.*/

/* Skiping 
30. Methods - part 3 - parameters types and the return type. Static typing in C#
4min
Start
Quiz 4: Methods and typing
Play
31. Parsing a string to an int (int.Parse method)
3min
Play
32. The first exception
2min
Play
33. Adding a new project to a solution
3min
Play
34. Assignments - Introduction
2min
Play
35. Assignment - Simple Calculator - Description and requirements
2min
Start
36. Assignment - Simple Calculator - It's time for you to implement it
1min
Play
37. Assignment - Simple Calculator - Solution
12min
Play
38. String interpolation
3min
Start
Coding Exercise 5: String interpolation - FormatDate
Play
39. Switch statement
8min
Start
Coding Exercise 6: Switch statement - DescribeDay
Play
40. Char
2min
Play
41. A need for loops
2min
Play
42. While loop - part 1
3min
Play
43. += and ++ operators. Infinite loops
4min
Play
44. While loop - part 2
3min
Start
Coding Exercise 7: While loop - CalculateSumOfNumbersBetween
Play
45. Do...while loop
4min
Start
Coding Exercise 8: Do-while loop - RepeatCharacter
Play
46. For loop
6min
Start
Coding Exercise 9: For loop - Factorial
Play
47. Break
3min
Play
48. Continue
6min
Start
Quiz 5: Break and continue
Play
49. Nested loops
2min
Play
50. Loops performance
*/