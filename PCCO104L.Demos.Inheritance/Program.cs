namespace PCCO104L.Demos.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Demo
            /*
             * Simple instance of a class
             */
            Person naruto = new Person("Naruto");
            naruto.SayHello();
            Divider();

            /*
             * Creates Hierarchical Inheritance, Single Inheritance
             */
            Teacher kakashi = new Teacher("Kakashi", "Konoha University");
            kakashi.SayHello();
            kakashi.Teach();
            Divider();

            /*
             * Creates Hierarchical Inheritance, Single Inheritance
             */
            Doctor sakura = new Doctor("Sakura", "Konoha Hospital");
            sakura.SayHello();
            sakura.CheckUp();
            Divider();

            /*
             * Creates a Multi Level Inheritance
             */
            Surgeon tsunade = new Surgeon("Tsunade", "Konoha Hospital");
            tsunade.SayHello();
            tsunade.CheckUp();
            tsunade.Operate();
            Divider();

            /*
             * Creates a parent object based on child class definition.
             * Parent object will still not be able to access child class members.
             */
            Doctor ino = new Surgeon("Ino", "Konoha Hospital");
            ino.SayHello();
            ino.CheckUp();
            #endregion

            #region Abstract Class Demo
            /*
             * Implement Parent Abstract Methods.
             */
            //Ninja naruto = new Ninja("Naruto", "Rasengan");
            //naruto.NormalAttack();
            //naruto.SpecialAttack();
            //Divider();

            //Shinigami ichigo = new Shinigami("Ichigo", "Getsuga tensho");
            //ichigo.NormalAttack();
            //ichigo.SpecialAttack();
            #endregion

            #region Method Override Demo
            /*
             * Parent Method override examples.
             */
            //Add sum = new Add();
            //sum.Compute(1, 1);
            //Divider();

            //Subtract difference = new Subtract();
            //difference.Compute(5, 2);
            //Divider();

            //Multiply product = new Multiply();
            //product.Compute(5, 5);
            //Divider();

            //Divide quotient = new Divide();
            //quotient.Compute(10, 2);
            //Divider();
            #endregion
        }

        /*
         * Creates output divider
        */
        static void Divider()
        {
            Console.WriteLine("******************");
        }
    }
}
