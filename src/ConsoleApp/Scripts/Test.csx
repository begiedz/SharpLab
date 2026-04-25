var dariusz = new Person();
var age = dariusz.Age;
Console.WriteLine(age);

public class Person
{
    private int AgeValue { get; set; } = 10;
    public int Age = AgeValue;

    public Person() { }
    public Person(int age)
    {
        AgeValue = age;
    }
}
