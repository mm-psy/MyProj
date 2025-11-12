// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json; // Add this using directive

Console.WriteLine("Hello, World!");

var myClassInstance = new MyClass { MyInt = 42, MyString = "Hello" };

string myClassJson = JsonConvert.SerializeObject(myClassInstance);
Console.WriteLine("Serialized MyClass JSON: " + myClassJson);

string password = GeneratePassword();
Console.WriteLine("Generated Password: " + password);

string GeneratePassword()
{
    // BAD: Password is generated using a cryptographically insecure RNG
    Random gen = new Random();
    string password = "mypassword" + gen.Next();

    return password;
}