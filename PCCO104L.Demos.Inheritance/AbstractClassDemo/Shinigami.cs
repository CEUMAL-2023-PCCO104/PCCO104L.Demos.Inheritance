namespace PCCO104L.Demos.Inheritance
{
    public class Shinigami : Hero
    {
        // Invokes Parent Class Constructor.
        public Shinigami(string name, string skill) : base(name, skill)
        { }

        // Required to implement ParentClass Abstract Methods.
        public override void NormalAttack()
        {
            Console.WriteLine($"{Name} - Used Katana Attack");
        }

        // Required to implement ParentClass Abstract Methods.
        public override void SpecialAttack()
        {
            Console.WriteLine($"{Name} - Used Bankai Special Attack: {Skill}");
        }
    }
}
