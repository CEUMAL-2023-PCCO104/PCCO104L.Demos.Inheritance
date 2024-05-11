namespace PCCO104L.Demos.Inheritance
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {
            Console.WriteLine("Person Constructor is executed.");
        }

        public Person(string name)
        {
            Name = name;
        }

        public void SayHello()
        {
            Console.WriteLine($"Instance of: {this}");
            Console.WriteLine($"Hello my name is: {Name}");
        }
    }
}
