
/* golobal directives imports the namespaace globaly in all files of the project*/
global using System.Diagnostics;

/*we can declare all global directives in a GlobalUsings.cs file*/
using System; // System is declared globally in the GlobalUsings.cs class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//different namespace
namespace _022_SRP.DataAccess
{

    // Creating class for ReadFromTextFile() and WriteToTextFile()
    class StringsTextualRepository
    {
        //Read contents of textfile
        public List<string> ReadFromTextFile(string filePath)
        {

            var fileContents = File.ReadAllText(filePath);
            return fileContents.Split(Environment.NewLine).ToList();



        }


        //Write contents to a textfile
        public void WriteToTextFile(string filePath, List<string> names) =>
            File.WriteAllText(filePath, string.Join(Environment.NewLine, names));

    }
}
