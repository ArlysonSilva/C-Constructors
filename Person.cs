class Person
{
    //First construtor
    public Person()
    {
        Console.WriteLine("Hello Luna");
    }

    //Second construtor
    public Person(string name)
    {
        Console.WriteLine($"Hello {name}");

    }
    //Third constructor
    public Person(string name, int age)
    {
        Console.WriteLine($"Hello {name} do you have {age} years old");
    }
}