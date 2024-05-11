namespace PCCO104L.Demos.Inheritance
{
    // Must be an abstract class since it has abstract members (NormalAttack, SpecialAttack)
    public abstract class Hero : Person
    {
        public string Skill { get; set; }

        // Invokes Parent Class Constructor.
        public Hero(string name, string skill) : base(name)
        {
            Skill = skill;
        }

        // Abstract methods has no definition, SubClass is required create one.
        public abstract void NormalAttack();

        // Abstract methods has no definition, SubClass is required create one.
        public abstract void SpecialAttack();
    }
}
