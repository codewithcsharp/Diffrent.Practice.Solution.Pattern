namespace Diffrent.Practice.Solution.Pattern.Delegates
{
    public class Delegates
    {
        public delegate void Print(int value);
        public static int FindMissingNumber(int[] arr)
        {
            int actualLength = arr.Length + 1;
            int actualsumofarray = arr.Sum();
            int totalsumofarray = actualLength * (actualLength + 1) / 2;
            
            //int totalsumofarray = actualLength * (actualLength + 1) / 2;
            int actualtotal = 0;
            foreach (var item in arr)
            {
                actualtotal = actualtotal + item;
            }
            int missingNumber = totalsumofarray - actualsumofarray;
            //int missingNumber = totalsumofarray - actualtotal;
            return missingNumber;
        }


    }
}
