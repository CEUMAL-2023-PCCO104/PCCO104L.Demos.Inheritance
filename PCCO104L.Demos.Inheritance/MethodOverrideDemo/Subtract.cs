namespace PCCO104L.Demos.Inheritance
{
    public class Subtract : BasicMath
    {
        // Overrides the current implementation BasicMath.Compute.
        public override void Compute(double num1, double num2)
        {
            Result = num1 - num2;
            Console.WriteLine($"The difference of {num1} and {num2} is {Result}");
        }
    }
}
