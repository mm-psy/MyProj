namespace MyProjTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    [Test]
    public void MyInt_GetSet_WorksCorrectly()
    {
        // Arrange
        var obj = new MyClass();

        // Act
        obj.MyInt = 123;

        // Assert
        Assert.That(obj.MyInt, Is.EqualTo(123));
    }
    [Test]
    public void MyString_GetSet_WorksCorrectly()
    {
        // Arrange
        var obj = new MyClass();

        // Act
        obj.MyString = "test string";

        // Assert
        Assert.That(obj.MyString, Is.EqualTo("test string"));
    }
    [Test]
    public void AlwaysFail()
    {
        // Arrange
        var obj = new MyClass();

        // Act
        obj.MyInt = 1;

        // Assert
        Assert.That(obj.MyInt, Is.EqualTo(5));
    }
}
