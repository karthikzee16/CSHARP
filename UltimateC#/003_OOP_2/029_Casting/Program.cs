

//Cheddar is a Ingredient
//derived is a base
// UPCASTING  converting an object from DERIVED->BASE
Ingredient ingredient = new Cheddar(2, 12);

// DOWNCASTING  converting an object from BASE->DERIVED
//Cheddar cheddar = ingredient; // not every ingredient is cheddar



// "is" operator
// The is operator is used to check if some object is of a given type

Ingredient randomIngredient = GenerateRandomIngredient();
Console.WriteLine("is object? " + (ingredient is object)); // true
Console.WriteLine("is ingredient? " + (ingredient is Ingredient)); // true
Console.WriteLine("is cheddar? " + (ingredient is Cheddar)); // true
Console.WriteLine("is mozzarella? " + (ingredient is Mozzarella)); // false
Console.WriteLine("is tomato sauce? " + (ingredient is TomatoSauce)); // false



//null 

/*The null value is common for all classes.
For all of them it means the same: that a variable does not store any instance.
*/

Ingredient ingredient1 = null;
Console.WriteLine(ingredient1.Name); // runtime error "Object reference not set to an instance of an object"

if (ingredient1 is not null)  // checking if an object is not null
{
    Console.WriteLine(ingredient1.Name);

}


//"as" operator
/* as operator is used for type casting
 * in case of failure of explicit casting there will be an exception thrown
 * but by using "as",  failure will lead to null being assinged to the variable.
 * only works to cast nullable types (can not be used for ints)
 */

Ingredient ingredient2 = GenerateRandomIngredient();
//Cheddar cheddar = (Cheddar)ingredient; // explicit (failure will lead to exception)
Cheddar cheddar = ingredient2 as Cheddar; // using "as" (failure will lead to null assingment)

//int number = ingredient as int; //does not work as  int is not a nullable type

if (cheddar is not null)
{
    Console.WriteLine(cheddar.Name);

}
else
{
    Console.WriteLine("Conversion failed");
}

Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1, 4);
    if (number == 1) { return new Cheddar(2, 12); }
    if (number == 2) { return new TomatoSauce(2); }
    else return new Mozzarella(2);
}




public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }


    public virtual string Name => "Some Ingredient";
    public string PublicMethod() => "This is public method in Ingredient";


    /*Private methods can not be inherited*/
    private string PrivateMethod() => "This is Private method in Ingredient";

    protected string ProtectedMethod() => "This is Protected method in Ingredient";

    public override string ToString() => Name;
}



public class Cheddar : Ingredient
{

    /*To pass the parameter to base class we use base() */
    public Cheddar(int priceIfExtraTopping, int agedForMonth) : base(priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Cheddar class");
        AgedForMonth = agedForMonth;

    }


    // using member of base class using base.Name
    public override string Name =>
       $"{base.Name}, more specifically, " +
       $"a cheddar cheese aged for {AgedForMonth} months";


    public int AgedForMonth { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        //  Console.WriteLine(PrivateMethod()); //private methods can not be inherited.
        Console.WriteLine(ProtectedMethod()); //protected members can be used in the derived classes, but they can't be used outside.*/
    }


}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }

}

public class Mozzarella : Ingredient
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public string Name => "Mozzarella"; // NOT overriden
    public bool isLight { get; }
}

public class Pizza
{

    private List<Ingredient> _ingredients = new List<Ingredient> { };
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() =>
      $"This is a pizza with {string.Join(",", _ingredients)}";



}


