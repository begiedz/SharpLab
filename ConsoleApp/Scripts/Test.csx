public class Person
{
    private int _age { get; set; } = 10;
    public int Age => _age;
    public Person() { }
    public Person(int age)
    {
        _age = age;
    }
}

var Dariusz = new Person();

var age = Dariusz.Age;

Console.WriteLine(age);
