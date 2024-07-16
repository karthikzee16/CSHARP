/* Polymorphism is the provision of a single interface to entities of different types.
In other words, there is a generic concept of something and this concept can be 
made concrete by multiple types.*/


/* protected access modifier 
 * protected members can be used in the derived classes, but they can't be used outside.*/



var pizza = new Pizza();


pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());
Console.WriteLine(pizza.Describe());


//cheddar is a ingredient
Cheddar cheddar = new Cheddar();
cheddar.PublicMethod();
//cheddar.PrivateMethod(); //Private members can not be inherited 
//cheddar.ProtectedMethod(); //Protected members can't be used outside the class*/
Console.WriteLine(cheddar.Name); 

//variable of type ingredient but it stores object of type cheddar
//(cheddar is an ingredient)

Ingredient ingredient = new Cheddar();

//ingredient.Name;
//Name Property is not present in Ingredient Class but it is Present in Cheddar class
//The actual type of the object is not known at compile time





Console.ReadLine();

public class Pizza
{
    //private List<???> _ingredients = new List<???> { };
    //What type of objects should the _ingredients list hold?

    //public void AddIngredient(T ingredient) => _ingredients.Add(ingredient);

    //public string Describe() =>
    //    $"This is a pizza with {string.Join(",", _ingredients)}";


    // It would be great if this list could store some general ingredient objects.
    // so we define an Ingredient class and all the ingredient types inherit from this ingredient class

    private List<Ingredient> _ingredients = new List<Ingredient> { };
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() =>
      $"This is a pizza with {string.Join(",", _ingredients)}";


}


public class Ingredient
{
    public string PublicMethod() => "This is public method in Ingredient";


    /*Private methods can not be inherited*/
    private string PrivateMethod() => "This is Private method in Ingredient";

    protected string ProtectedMethod() => "This is Protected method in Ingredient";
}


/* Inheritance */
/*Inheritance allows us to share common logic or data between related types while still allowing some customization.*/


// ":" means  "is a" and is used for inheritance
//Cheddar is a Ingredient
//Cheddar inherits all the members of the Ingredient class
//Ingredient is a Base class and Cheddar is Derived class

/*The base type contains the data and methods common to the related types.

Still, each derived type can have its own members, which the base type and other derived types do not contain.

Moreover, in the case of methods and properties, the derived type can decide to provide its own implementation,

instead of using the one from the base class.*/

/* members of the base class are inherited by the derived classes if they are public or protected*/

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
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
    public string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }

}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella";
    public bool isLight { get; }
}