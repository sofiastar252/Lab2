namespace MyRootLib
{
    public class Class1
    {
        /// <summary>
        /// This method calculates the power of 2 for the given number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double MyRoot(double number)
        {
            double power;
            power = Math.Pow(number, 2);
            Console.WriteLine("The power of " + number + " is " + power);
            return power;
        }
    }
}
