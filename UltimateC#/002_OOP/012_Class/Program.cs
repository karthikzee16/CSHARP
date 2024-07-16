/* OOP
 * OOP, is focused on the concept of objects containing data and methods.
 * more flexible as OOP gives us ways to adjust the behavior of classes to changing needs.
 * The code is also easier to understand, and the responsibility of a single class is simpler to grasp/

/* APIE (Fundamental concepts of OOP)
 * Abstraction -
 * Polymorphism -
 * Inheritance -
 * Encapsulation - 
 */

/* Class
 * A class is like a blueprint based on which we can create many objects, also called instances.
 */

//using DateTime class constructor to create new datetime
DateTime internationalPizzaDay23 = new DateTime(2023, 2, 9);

//accessing DateTime objects attributes
Console.WriteLine($"year is : {internationalPizzaDay23.Year}");
Console.WriteLine($"month is : {internationalPizzaDay23.Month}");
Console.WriteLine($"day is : {internationalPizzaDay23.Day}");
Console.WriteLine($"day of the week is : {internationalPizzaDay23.DayOfWeek}");

//using DateTime methods 
var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);//adds 1 year

Console.WriteLine($"year is : {internationalPizzaDay24.Year}");
Console.WriteLine($"month is : {internationalPizzaDay24.Month}");
Console.WriteLine($"day is : {internationalPizzaDay24.Day}");
Console.ReadLine();



/* Abstraction
 * Abstraction means that classes expose only essential data and methods 
 * and hide the underlying details.
 */

// We can only operate on the public members of the class.
// example DateTime.dateData is not public (it was meant to be unaccessible)

// internationalPizzaDay23.dateData 


 

