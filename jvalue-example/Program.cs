using Newtonsoft.Json.Linq;
using System;

namespace jvalue_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonString = @"{""Firstname"":""Stuart"",""Surname"":""Preston""}";
            dynamic json = JValue.Parse(jsonString);
            Console.WriteLine("Hello {0} {1}", json.Firstname, json.Surname);
        }
    }
}