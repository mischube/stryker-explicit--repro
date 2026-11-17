namespace ClassLibrary1;

public class Class1
{
    public void Foo(bool shouldThrow)
    {
        if (shouldThrow)
        {
            throw new Exception();
        }

        Console.WriteLine("Hello World!");
    }
}