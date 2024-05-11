namespace PCCO104L.Demos.Inheritance
{
    public class Ninja : Hero
    {
        // Invokes Parent Class Constructor.
        public Ninja(string name, string skill) : base(name, skill)
        { }

        // Required to implement ParentClass Abstract Methods.
        public override void NormalAttack()
        {
            Console.WriteLine($"{Name} - Used Shuriken Attack");
        }

        // Required to implement ParentClass Abstract Methods.
        public override void SpecialAttack()
        {
            Console.WriteLine($"{Name} - Used Ninja Special Attack: {Skill}");
        }
    }
}
