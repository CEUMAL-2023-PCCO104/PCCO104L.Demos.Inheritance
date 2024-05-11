namespace PCCO104L.Demos.Inheritance
{
    public class BasicMath
    {
        public double Result { get; protected set; }
        
        public virtual void Compute(double num1, double num2)
        {
            Result = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {Result}");
        }
    }
}
