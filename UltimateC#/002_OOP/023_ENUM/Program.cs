/* An enum type is a type that defines a set of named constants. */
/* enums are represented as integers under the hood. */
/* an enum declaration is a bit similar to a class declaration,
 * it CANNOT contain any fields, properties or methods. */

Season firstSeason = Season.Spring;

Console.WriteLine(firstSeason);
Console.WriteLine((int)firstSeason); // explicit casting



Position firstPosition = Position.first;
Console.WriteLine(firstPosition);
Console.WriteLine((int)firstPosition);

Position thirdPosition = Position.third;
Console.WriteLine(thirdPosition);
Console.WriteLine((int)thirdPosition);

Console.ReadLine();
public enum Season
{
    Spring, //0
    Summer, //1
    Autum,  //2
    Winter  //3 
    
}

public enum Position
{
    first = 1,  // We can also assign an integer of choice to each of the enum values.
    second,
    third
    
}

//an enum for HTTP codes where each value has a special number assigned.

public enum HttpCode
{
    Ok=200,
    NotFound = 404,
    InternalServerError =500
}
