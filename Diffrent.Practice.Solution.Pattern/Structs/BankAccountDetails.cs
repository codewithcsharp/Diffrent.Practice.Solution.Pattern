namespace Diffrent.Practice.Solution.Pattern.Structs
{
    public struct BankAccountDetails(int x, int y, string name)
    {
        public int X = x;
        public int Y = y;
        public string name = name;

        public readonly void Display()
        {
            Console.WriteLine($"BankAccountDetails Co-Ordinates: ({X}, {Y})");
        }
    }
}
