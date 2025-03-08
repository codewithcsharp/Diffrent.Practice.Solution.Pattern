namespace Diffrent.Practice.Solution.Pattern.Generics.GenericsWithoutUsingWhere
{
    public class AggregateFunction<T>
    {
        public static T Add(T a, T b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a), "Parameter cannot be null");
            if (b == null) throw new ArgumentNullException(nameof(b), "Parameter cannot be null");
            return (dynamic)a + (dynamic)b;
        }
        public static T Subtract(T a, T b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a), "Parameter cannot be null");
            if (b == null) throw new ArgumentNullException(nameof(b), "Parameter cannot be null");
            return (dynamic)a - (dynamic)b;
        }
        public static T Multiply(T a, T b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a), "Parameter cannot be null");
            if (b == null) throw new ArgumentNullException(nameof(b), "Parameter cannot be null");
            return (dynamic)a * (dynamic)b;
        }
        public static T Divide(T a, T b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a), "Parameter cannot be null");
            if (b == null) throw new ArgumentNullException(nameof(b), "Parameter cannot be null");
            return (dynamic)a / (dynamic)b;
        }
    }
}
