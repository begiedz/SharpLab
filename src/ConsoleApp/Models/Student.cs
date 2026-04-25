namespace ConsoleApp.Classes
{
    public class Student
    {
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        private void Hello(string ToWho)
        {
            Console.WriteLine($"Hello {ToWho}, I am {Name} {Surname}, Age {Age}");
        }
        public void Greet(string ToWho) { Hello(ToWho); }
    }
}