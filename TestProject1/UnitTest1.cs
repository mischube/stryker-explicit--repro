namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var class1 = new ClassLibrary1.Class1();

        class1.Foo(false);
    }

    [Test]
    [Explicit]
    public async Task Test2()
    {
        var class1 = new ClassLibrary1.Class1();

        class1.Foo(false);

        await Task.Delay(1000);
    }
}