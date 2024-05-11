namespace PCCO104L.Demos.Inheritance
{
    public class Multiply : BasicMath
    {
        // Overrides the current implementation BasicMath.Compute.
        public override void Compute(double num1, double num2)
        {
            Result = num1 * num2;
            Console.WriteLine($"The product of {num1} and {num2} is {Result}");
        }
    }
}
