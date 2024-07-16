using System;
using System.Numerics;

static string Describe(object someObject)
{
    //your code goes here
    if (someObject is int) { return $"Int of value {Convert.ToInt32(someObject)}"; }
    if (someObject is double) { return $"Double of value {Convert.ToDouble(someObject)}"; }
    if (someObject is decimal) { return $"Decimal of value {Convert.ToDecimal(someObject)}"; }

     return null;

}
    