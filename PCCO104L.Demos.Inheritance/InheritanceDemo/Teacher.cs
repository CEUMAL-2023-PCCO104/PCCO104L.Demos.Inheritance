namespace PCCO104L.Demos.Inheritance
{
    public class Teacher : Person
    {
        public string School { get; set; }

        public Teacher(string name, string school) : base(name)
        {
            School = school;
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} teaches at {School}");
        }
    }
}
