/* This code shows 2 ways to use Property fields*/

/* Most common use case is to have public getter and private settor */



/* Field */
/* 1) Fields are like variables
 * 2) Single access modifier
 * 3) Has no seperate getter and setter
 * 4) Should always be private 
 * 5) Can not be overridden in derived class
 */


/* Property */
/* 1) Property are like methods
 * 2) Separate access modifier for getter and settor
 * 3) Has seperate getter and setter and both can be removed if required
 * 4) Can be public
 * 5) Can be overridden in derived class
 * 
 */

var squareOld = new SquareOld(5);
Console.WriteLine("Side is " + squareOld.Side); // getter is executed
//squareOld.Side = 15; // not executed since settor is private


var squareNew = new SquareNew(5);
Console.WriteLine("Side is " + squareNew.Side); // getter is executed
//squareNew.Side = 15; // not executed since settor is private

Console.ReadLine();

class SquareNew
{
    /* codesnippet = "prop"*/

    /* property */
    /* public getter and private settor
     * validation for setting a value can be added in constructor.
     */

    // public int Side { get; set; }
    public int Side
    {
        get;
        private set;
    }

    public SquareNew(int side)
    {
        Side = GetLengthOrDefault(side, nameof(Side));

    }

    private int GetLengthOrDefault(int length, string name)
    {

        int defaultValueIfNonPositive = 1;
        if (length < 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;

    }
}
class SquareOld
{
    /* codesnippet = "propfull"*/
    #region oldsyntax 

    /* old syntax = (backing field + property) */

    /* Field */
    private int _side; //backing field

    /* Property */
    public int Side
    {
        get
        {
            return _side;
        }

        private set
        {
            /* settor with validation */
            /* value holds the value that needs to be assigned to the property using the settor */
            if (value > 0)
            {
                _side = value;
            }
        }
    }

    #endregion

    public SquareOld(int side)
    {
        Side = GetLengthOrDefault(side, nameof(Side));

    }

    private int GetLengthOrDefault(int length, string name)
    {
        /* readonly field can only be accessed at declaration or in the constructor */
        // Height = 4;

        int defaultValueIfNonPositive = 1;
        if (length < 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;

    }
}




