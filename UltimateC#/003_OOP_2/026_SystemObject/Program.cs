//System.Object is base class for all object types

//Object class defined in the System namespace is the ultimate base class of all .NET classes.
//It is the root of the type hierarchy.


//Cheddar is derived from Object

Cheddar cheddar = new Cheddar();

// the ToString method that is defined in the System.Object class
// is simply returning a string with the type's full name
Console.WriteLine(cheddar);
// Cheddar

Console.WriteLine(new List<int>());
//System.Collections.Generic.List`1[System.Int32]
//if ToString method is not overidden then it simply returns a string with the
//type's full name (includes namespace)


/*we CAN override the ToString() method in derived classes*/

Pizza pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozzarella());

Console.WriteLine(pizza.ToString());
// printing _ingredients implicitly calls the ToString method of each element.


Console.ReadLine();


public class Ingredient
{
    public virtual string Name => "Some Ingredient";
    public string PublicMethod() => "This is public method in Ingredient";


    /*Private methods can not be inherited*/
    private string PrivateMethod() => "This is Private method in Ingredient";

    protected string ProtectedMethod() => "This is Protected method in Ingredient";

    public override string ToString() => Name;
}



public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
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
    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }

}

public class Mozzarella : Ingredient
{
    public string Name => "Mozzarella"; // NOT overriden
    public bool isLight { get; }
}

public class Pizza
{

    private List<Ingredient> _ingredients = new List<Ingredient> { };
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() =>
      $"This is a pizza with {string.Join(",", _ingredients)}"; 
    // printing _ingredients implicitly calls the ToString method of each overriden element


    
}


