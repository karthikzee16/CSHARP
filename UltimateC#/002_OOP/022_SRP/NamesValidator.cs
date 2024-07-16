/*Single Responisbility Principle*/
/*A class should be responsible for only one thing*/


/*To move a class to its own file Quick Refactoring -> "Move type to .cs"*/

//Creating class for IsValidName()
class NamesValidator
{
    public bool IsValidName(string name)
    {
        return
            name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}


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