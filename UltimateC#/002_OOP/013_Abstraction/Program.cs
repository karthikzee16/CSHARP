
/* Encapsulation:
 * bundling data with methods that operate on it in the same class
 * data hiding is not possible without encapsualtion
 */



// creating object with parameterless constructor (default constructor)
var rectangle1 = new PrivateRectangle();

// unable to access non public memebers due to data hiding
//Console.WriteLine(rectangle1._height);  
//Console.WriteLine(rectangle1._width);  


// default constructor is used only if we do not write our own constructor
//var otherRectangle = new PublicReactangle();

// default value of uninitialized int is 0
//Console.WriteLine(otherRectangle.Height);  //0
//Console.WriteLine(otherRectangle.Width);  //0

var otherRectangle = new PublicReactangle(10,20);
Console.WriteLine(otherRectangle.Height);  
Console.WriteLine(otherRectangle.Width);
Console.WriteLine("Circumference:" + otherRectangle.CalculateCircumference());
Console.WriteLine("Area:" + otherRectangle.CalcualteArea());

var othersRectangle2 = new PublicReactangle(30,40);
Console.WriteLine(othersRectangle2.Height);
Console.WriteLine(othersRectangle2.Width);
Console.WriteLine("Circumference:" + othersRectangle2.CalculateCircumference());
Console.WriteLine("Area:" + othersRectangle2.CalcualteArea());


Console.ReadLine();


/*-------------------------------------------*/

// Good practise: Class names should start with capital letter.

class PublicReactangle
{
    // Public access modifier members can be accessed everywhere
    // make a member public only if it is necessary.
    // This is because making class members public can be a source of risk.
    

    
    // Defining fields of class
    // Good practise: field names should be nouns.


    // Good practise: public field names should start with capital letter.
    public int Width;
    public int Height;

    


    /* Constructor (code snipet ctor+TAB)
     * 1) must be named the same as the type it belongs to.
     * 2) it doesn't have the return type declared, which was always the case for other methods.
     * 3) constructors can only be called at the moment of object's creation.
     *    There is no way to call them in any other context.
     * 4) Constucrtors access modifier should be public.
     */


    public PublicReactangle(int width, int height)
    {
        //assigning value to Fields of a class
        Width = width; 
        Height= height;
    }




    // Defining methods of class
    // Good practise: name of method stating with a verb(action)
    public int CalculateCircumference()
    {
        return 2 * (Width + Height);
    }

   public int CalcualteArea() 
    {
        return Width * Height;
    }
}


class PrivateRectangle
{
    // Private access modifier members can only be accessed from within the class it belongs to.
    // In C# the default access modifier is always the most restrictive in given context.
    // For classes the default access modifier is public
    // data hiding - Making the members of a class non-public is called data hiding.

    // Good practise: private field names should start with underscore(_)
    int _width;
    int _height;

}




//Console.WriteLine("Checking if this works");


/* 
 * placing any code below the class will not work
 * since each piece of code should be inside a class
 * due to top level statements in latest C#,
 * After defining a class ,this statement will be outside the class and will not work.
 * */

