class BaseClass
{
    public virtual void DisplayMessage()
    {
        Console.WriteLine("This is the Base Class method");
    }
}


class DerivedClass : BaseClass
{
    public override void DisplayMessage()
    {
        Console.WriteLine("This is the Derived Class method");
    }
}

class Program
{
    static void Main()
    {
        BaseClass obj = new DerivedClass();
        obj.DisplayMessage();
    }
}
