
/* use of many static members can impact performance so use static with caution*/

var nonStaticCalculator1 = new NonStaticCalculator();

// Add() is static method and it is called on the Class as a whole, instead of an instance.
Console.WriteLine($"1+2 is {NonStaticCalculator.Add(1, 2)}");
//Console.WriteLine($"1+2 is {nonStaticCalculator.Add(1, 2)}"); // will not work on an instance

/* each instance of Calculator class is same (since there is no constructor or Property/fields for this class)*/
var nonStaticCalculator2 = new NonStaticCalculator();


/* Can not create an instance of static classes*/
// var staticCalculator = new StaticCalculator();

/* The static method is called on the class, instead of an instance*/
Console.WriteLine($"2-1 is {StaticCalculator.Subtract(2, 1)}");


var nonstaticRectangle1= new NonStaticRectangle(1,2);
Console.WriteLine("");

/* each instance of rectangle class is different*/
var nonstaticRectangle2 = new NonStaticRectangle(4, 7);
Console.WriteLine("");



Console.ReadLine();

/*NEED FOR STATIC */

/* This Calculator class does not have any data fields which could differntiate two or more calculator objects
 * so its better to call the methods on the Calculator class itself, instead of a calculator object
 * it is acheived using  use static Calculator class.
 * All memeber of a static class should also be static*/



/* non static class is STATEFUL */
class NonStaticCalculator
{

    // Non staic calss can contain static methods
    // Add is the only static member of this class
    public static int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;
}

/*  static class is STATELESS */
static class StaticCalculator
{

    /* Static methods belongs to a class as a whole, not to any specific instance
     * static methods will not have access to instance data(fields,proerties,methods)
     * 
     */
   
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;
}




/* non static class is STATEFUL */
class NonStaticRectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    /* static fields and properties are used when we need to share a single member between all
       class instances. */ 

    public static int countOfInstances =0; // can not be non static 
    public NonStaticRectangle(int width, int height)
    {
        Width = width;
        Height = height;
        countOfInstances++;
    }


    /*All const fields are implicitly static*/
    public const int NumberOfSides = 4;


    /* since static methods are called on a class instead of an instance
     * so static methods can not access (non static members of an instance)
     */

    public static string Describe() =>
           // Height is non static property and cannot be accessed inside static method
           // $" A plane Figure with four straight sides height: {Height}}"; 

           // NumberOfSides is const(implicitly static) and can be accessed inside static method
           $" A plane Figure with four straight sides NumberOfSides: {NumberOfSides}"; 

}

/* staic class is STATELESS*/
static class StaticRectangle
{
    /* All memeber of a static class should also be static */

    public static int Width { get; set; }
    public static int Height { get; set; }

    /*All const fields are implicitly static*/
    public const int NumberofSides = 4;

    /* static class cannot have instance constructor */
    //public StaticRectangle(int width, int height)
    //{
    //    Width = width;
    //    Height = height;
    //}

}