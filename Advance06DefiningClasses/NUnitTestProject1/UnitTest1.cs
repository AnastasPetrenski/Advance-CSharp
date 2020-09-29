//using NUnit.Framework;

//namespace NUnitTestProject1
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public void Test1()
//        {
//            Assert.Pass();
//        }
//    }
//}
using System;
using System.Reflection;
using NUnit.Framework;
using System.Linq;
using DefiningClasses;

[TestFixture]
public class Test_000_001
{
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidatePersonClass()
    {
        Type personType = GetType("Person");
        FieldInfo[] fields = personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        int fieldCount = fields.Length;

        Assert.That(fieldCount == 2);

        PropertyInfo[] properties = personType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        int propertyCount = properties.Length;

        Assert.That(propertyCount == 2);
    }

    private static Type GetType(string typeName)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == typeName);

        return type;
    }
}