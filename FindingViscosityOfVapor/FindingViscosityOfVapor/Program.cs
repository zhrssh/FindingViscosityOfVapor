// Application: Finding Viscosity of Vapor Console-based
// Programmed by: Zherish Galvin Mayordo
//
// This application finds the viscosity of vapor in varying temperatures.

namespace VaporViscosity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProgramStart();
        }

        public static void ProgramStart()
        {
            // System
            float c1, c2, c3, c4;
            float maxTemperature = 373.15f;
            float result;

            Console.WriteLine("This application finds the viscosity of vapor from 0 to 100 degree Celsius.");
            Console.WriteLine("Enter the values: ");
            Console.Write("\nC1: ");
            c1 = float.Parse(Console.ReadLine());
            Console.Write("\nC2: ");
            c2 = float.Parse(Console.ReadLine());
            Console.Write("\nC3: ");
            c3 = float.Parse(Console.ReadLine());
            Console.Write("\nC4: ");
            c4 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nEntered values:" + "\nC1: " + c1 + "\nC2: " + c2 + "\nC3: " + c3 + "\nC4: " + c4);

            for (float i = 273.15f; i <= maxTemperature; i = i + 10)
            {
                float numerator = c1 * (float)Math.Pow(i, c2);
                float denominator = 1f + (c3 / i) + (c4 / (float)Math.Pow(i, 2));
                result = numerator / denominator;

                Console.WriteLine("Temperature: " + i + " Result: " + result);
            }
        }
    }
}
