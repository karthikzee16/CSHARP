
TimeOnly opensAt = TimeOnly.Parse("8:00 AM");
Console.WriteLine(opensAt);

//only time portion is included
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(rightNow);

Console.ReadLine();