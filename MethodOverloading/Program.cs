namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int number1, int number2)

        {
            return number1 + number2;
        }

        public static decimal Add(decimal numberOne, decimal numberTwo)

        {
            return numberOne + numberTwo;
        }

        public static string Add(int numOne, int numTwo, bool isMoney)
        {
            var sum = numOne + numTwo;

            if (isMoney && sum > 1)
            {
                return $"{sum} dollars";
            }
            
            else if (isMoney && sum == 1)
            {
                return $"{sum} dollar";
            }
            else return sum.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.2m, 2.2m));
            Console.WriteLine(Add(1,2,true));
        }
    }
}
