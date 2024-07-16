/*Single Responisbility Principle*/
/*A class should be responsible for only one thing*/


/*To move a class to its own file Quick Refactoring -> "Move type to .cs"*/


/* Name spcae declares a scope that contains a set of related types */

using _022_SRP; // does not import all the types of DataAccess
using _022_SRP.DataAccess;// must use fully qualified namespace

/* Stopwatch is part of System.Diagnostic
/* it was declared globally in StringsTextualRepository class file */
var stopwatch = Stopwatch.StartNew(); 

var names = new Names(); // Names class is in same namespace so no using directive is required
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();
// StringsTextualRepository class is in other namespace, so using directive  _022_SRP.DataAccess is required

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile=  stringsTextualRepository.ReadFromTextFile(path);
    // names.ReadFromTextFile(); //fetches names from text file 
    //Read contents of textfile and adds it to list of _names
    names.AddNames(stringsFromFile);


}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    // names.WriteToTextFile();
    stringsTextualRepository.WriteToTextFile(path,names.All);
}
Console.WriteLine(new NamesFormater().Format(names.All));

Console.ReadLine();


#region old

/*
public class NamesOld
{
    private readonly List<string> _names = new List<string>();


    //takes name as input and adds it to list _names
    public void AddName(string name)
    {
        if (IsValidName(name))
        {
            _names.Add(name);
        }
    }


    //takes name as input and checks if name is valid
    private bool IsValidName(string name)
    {
        return
            name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }




    //Read contents of textfile and adds it to list of _names
    public void ReadFromTextFile()
    {
        var fileContents = File.ReadAllText(BuildFilePath());
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        foreach (var name in namesFromFile)
        {
            AddName(name);
        }
    }


    //Write contents to a textfile
    public void WriteToTextFile() =>
        File.WriteAllText(BuildFilePath(), Format());


    // FilePath
    public string BuildFilePath()
    {
        //we could imagine this is much more complicated
        //for example that path is provided by the user and validated
        return "names.txt";
    }


    //retuns names separated by newlines
    public string Format() 
    {
       string result =  string.Join(Environment.NewLine, _names);
        return result;
    }
}
        
*/
#endregion