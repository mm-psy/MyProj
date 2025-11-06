// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json; // Add this using directive

Console.WriteLine("Hello, World!");
string user = "admin";
string password = "admin123";

var myClassInstance = new MyClass { MyInt = 42, MyString = "Hello" };

var admin = new { Username = user, Password = password };

string myClassJson = JsonConvert.SerializeObject(myClassInstance);
Console.WriteLine("Serialized MyClass JSON: " + myClassJson);

System.Console.WriteLine("Admin Credentials: " + JsonConvert.SerializeObject(admin));