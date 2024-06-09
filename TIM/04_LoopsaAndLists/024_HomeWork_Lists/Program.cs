bool isLast = false;
List<string> studentList = new List<string>();

while (!isLast) 
{
   Console.WriteLine("Enter Student Name  (type 'exit' to quit)");

   string student =  Console.ReadLine();

    if (String.IsNullOrEmpty(student)) 
    {
        continue;
    }
    else if (student.ToLower().Equals("exit"))
    {
        isLast = true;
    }
    else
    {
        studentList.Add(student);
        Console.WriteLine($"{student} is added to list");
    }
   

}


for (int i = 0; i < studentList.Count; i++) 
{
    Console.WriteLine($"Student at postition {i+1} is {studentList[i]}");
}

Console.ReadLine();