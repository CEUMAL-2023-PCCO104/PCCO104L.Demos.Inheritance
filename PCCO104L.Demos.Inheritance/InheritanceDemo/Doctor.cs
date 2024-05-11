namespace PCCO104L.Demos.Inheritance
{
    public class Doctor : Person
    {
        public string Hospital { get; set; }

        public Doctor(string name, string hospital) : base(name)
        {
            Hospital = hospital;
        }

        public void CheckUp()
        {
            Console.WriteLine($"{Name} duties at {Hospital}");
        }
    }
}
