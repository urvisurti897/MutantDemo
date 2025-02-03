using MutantDemo;

namespace MutantDemo
{
    public static class Triangle
    {
        public static string IsoscelesTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string result;
            if ((firstSide == secondSide) || (secondSide == thirdSide) || (thirdSide == firstSide))
            {
                result = "The triangle is isosceles.";
            }
            else
            {
                result = "The triangle is NOT isosceles.";
            }
            return result;
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
            int firstSide = 4;
            int secondSide = 4;
            int thirdSide = 6;

            string result = Triangle.IsoscelesTriangle(firstSide, secondSide, thirdSide);
            Console.WriteLine(result);
        }
    }
}

