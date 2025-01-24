namespace MyMinLib
{
    public class Class1
    {
        public static double Min(double a, double b)
        {
            return a < b ? a : b;
        }

        public static double Min(double a, double b, double c)
        {
            return Min(Min(a, b), c);
        }
    }
}
