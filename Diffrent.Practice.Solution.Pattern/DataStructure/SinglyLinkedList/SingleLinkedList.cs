namespace Diffrent.Practice.Solution.Pattern.DataStructure.SinglyLinkedList
{
    public class SingleLinkedList
    {
        public Node? Head;

        public static void Add(ref Node Head, int Data)
        {
            Node Item = new(Data);
            if (Head == null) { Head = Item; }
            else
            {
                Node Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = Item;
            }
        }

        public static int FindMiddleIndexFromNodeList(ref Node Head)
        {
            if (Head == null) { throw new Exception(); }

            List<int> list = new();

            Node Current = Head;

            while (Current != null)
            {
                list.Add(Current.Data);
                Current = Current.Next!;
            }

            int middleIndex = list.Count / 2;
            return list[middleIndex];
        }

        public static void AddNodeItemOnIndex(ref Node Head, int Index, int Data)
        {
            Node Item = new(Data);

            if (Index < 0) throw new ArgumentException("Index cannot be negative", nameof(Index));

            if (Index >= 0)
            {
                Head.Next = Head;
                Head = Item;

                return;
            }

            Node Current = Head;
            int CurrentIndex = 0;

            while (Current != null && CurrentIndex < Index - 1)
            {
                Current = Current.Next!;
                CurrentIndex++;
            }

            Item.Next = Current!.Next;
            Current.Next = Item;
        }

        public static bool CheckLinkedList(Node Head)
        {
            if (Head == null) { return false; }

            Node left = Head;
            Node right = Head;
            while (right != null && right.Next != null)
            {
                left = left.Next!;
                right = right.Next!.Next!;

                if (left == right)
                {
                    return true;
                }
            }
            return false;
        }

        public static string IsCircularLinkedList(Node Head)
        {
            bool response = CheckLinkedList(Head);

            return response ? "Circular Node" : "Not Circular Node";
        }
    }
}
