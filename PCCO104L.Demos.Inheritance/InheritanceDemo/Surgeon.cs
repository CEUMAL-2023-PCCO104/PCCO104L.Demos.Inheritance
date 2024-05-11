namespace PCCO104L.Demos.Inheritance
{
    public class Surgeon : Doctor
    {
        public Surgeon(string name, string hospital) : base(name, hospital)
        { }

        public void Operate()
        {
            Console.WriteLine($"{Name} is operating at {Hospital}.");
        }
    }
}
