
var rect = new Rectangle(5, 10);
/* readonly field can only be accessed at declaration or in the constructor*/
// rect.Height = 10;



Console.ReadLine();

class Rectangle
{

    /* readonly
     * 
     * A readonly field can only be assigned a value at declaration or in the constructor
     * We use readonly fields when we want a field never to change after it has been set in
     * the constructor, it is fine if its value is evaluated at runtime.
     * 
     * Making all fields of an object readonly makes the whole object immutable.
     * Immutability means that once an object is created, it will never be modified.
     */

    /* Good practise: readonly all those fields that we don't ever intend to modify 
                      after they are first set in the constructor.*/

    public readonly int Width;
    public readonly int Height;


    /* const
     * We use const fields for things with a constant value known at compilation time
     * and can never be modified afterward.
     */

    const int NumberOfSides = 4;

    // Adding constructor validation 

    public Rectangle(int width, int height)
    {  
        // if width or height is non positive

       const int defaultValueIfNonPositive = 1;

        #region coderepition
        
          
          
          //if (height <= 0)
          //{
          //    Console.WriteLine("height must be a positive number.");
          //    Height = defaultValueIfNonPositive;
          //}
          //else
          //{

          //    Height = height;
          //}

          
          //if (Width < 0)
          //{
          //    Console.WriteLine("Width must be a positive number.");
          //    Width = defaultValueIfNonPositive;
          //}

          //else
          //{
          //    Width = width;
          //}

          
        #endregion


        /* if variable name changes then the value of "string" also needs to be changed 
           so we use nameof() instead
        */

        //Width = GetLengthOrDefault(width, "Width");
        //Height = GetLengthOrDefault(height, "Height");

        /* nameof() returns the variable name in string format
         * example: nameof(Width)=>"Width"
         */

        Width = GetLengthOrDefault(width, nameof(Width));
        Height = GetLengthOrDefault(height, nameof(Height));



    }

    // To fix code repition
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

