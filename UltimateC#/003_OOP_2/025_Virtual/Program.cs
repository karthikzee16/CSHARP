/*Virtual :
 virtual method or property may be modified in the inheriting types(Derived class)*/

/* virtual and override keywords are not access modifiers; they are used to 
 * support polymorphism and method overriding in object-oriented programming.*/


//cheddar is a ingredient
Cheddar cheddar = new Cheddar();
Console.WriteLine(cheddar.Name); //"Cheddar Chesse"



/*Refer virtual.png*/
//GenralType variable = new SpecificType();
//Ingredeient is Base Class (General Type)
//Cheddar is Derived Class(Specific Type)

//variable of type ingredient but it stores object of type cheddar
Ingredient ingredient = new Cheddar();
//The actual type of the object is not known at compile time

//if Name is  NOT (virtual/override)
//Console.WriteLine(ingredient.Name);  //"Some Ingredient" 

//virtual keyword specifies what object you actually have in the variable and call the
//method defined in this inheriting object if you find one.

//if Name is (virtual/override)
Console.WriteLine(ingredient.Name); //"Cheddar Chesse"

Console.WriteLine("Creating list of ingredients");
//List of type ingredients
List<Ingredient> ingredients = new List<Ingredient> 
{ 
    new Cheddar(),      // Cheddar.Name is  overriden so it prints "Cheddar Cheese"
    new Mozzarella(),  // Mozzarella.Name is NOT overriden so it prints "Some Ingredient"
    new TomatoSauce() // TomatoSauce.Name is  overriden so it prints "Tomato sauce"

};

//the loop variable is of type ingredient 
//but we do not want to use the implementaion of Name from Ingredient class
//We override Name in derived classes, so implementation of specific derived types are used.
foreach (var item in ingredients)
{
    Console.WriteLine(item.Name);

}




Console.ReadLine();


public class Ingredient
{
    public virtual string Name => "Some Ingredient";
    public string PublicMethod() => "This is public method in Ingredient";


    /*Private methods can not be inherited*/
    private string PrivateMethod() => "This is Private method in Ingredient";

    protected string ProtectedMethod() => "This is Protected method in Ingredient";
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
    public string Name => "Mozzarella";
    public bool isLight { get; }
}

public class Pizza
{
    
    private List<Ingredient> _ingredients = new List<Ingredient> { };
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public string Describe() =>
      $"This is a pizza with {string.Join(",", _ingredients)}";


}

