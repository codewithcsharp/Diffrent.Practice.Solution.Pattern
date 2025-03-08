namespace Diffrent.Practice.Solution.Pattern.Generics.GenericsUsingWhere
{
    public class ArithmeticOperation<T> where T : struct
    {
        public static T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        public static T Subtract(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }
        public static T Multiply(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }
        public static T Divide(T a, T b)
        {
            return (dynamic)a / (dynamic)b;
        }
    }
}
