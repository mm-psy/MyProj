// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json; // Add this using directive

Console.WriteLine("Hello, World!");

var myClassInstance = new MyClass { MyInt = 42, MyString = "Hello" };

string myClassJson = JsonConvert.SerializeObject(myClassInstance);
Console.WriteLine("Serialized MyClass JSON: " + myClassJson);