//Expression bodied method

class Square
{
   
    public int Side;

    // method with single expression 

    //public int CalcualteArea()
    //{
    //    return 4 * Side;

    //}


    //Expression bodied method can be used only for methods with single expression 
    // (=> is lambda operator)
    public int CalcualteArea()=> 4 * Side;
    
}

// Expression: something that evaluates to a value.
// Statement : something that does not evaluate to a value, but can perform a task