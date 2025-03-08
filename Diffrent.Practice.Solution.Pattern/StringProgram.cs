using System.Text.RegularExpressions;

namespace Diffrent.Practice.Solution.Pattern
{
    public class StringProgram
    {
        #region Reverse array of an Integer
        public static int[] ReverseArray(int[] array)
        {
            int reverse = array.Length - 1;
            int[] revArr = new int[array.Length];
            for (int i = reverse; i >= 0; i--)
            {
                revArr[i] = array[reverse - i];
            }
            return revArr;
        }

        #endregion

        #region Reverse a String
        public static string ReverseString(string str)
        {
            string revStr = "";
            char[] chars = str.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                revStr += chars[i];
            }
            return revStr;
        }
        #endregion

        #region Combine two String Array into Single Array.
        public static string[] CombineTwoArray(string[] a, string[] b)
        {
            string[] c = new string[a.Length + b.Length];

            string[] maxLength = a.Length > b.Length ? a : b;
            string[] minLength = a.Length > b.Length ? b : a;

            int temp = 0;
            int temp1 = minLength.Length;
            for (int i = 0; i < maxLength.Length; i++)
            {
                if (i < minLength.Length)
                {
                    c[temp] = minLength[i];
                    temp++;
                }
                if (i < maxLength.Length)
                {
                    c[temp1++] = maxLength[i];
                    temp1++;
                }
            }
            return c;
        }
        #endregion

        #region Reverse a Sentance of Strings.
        public static string[] ReverseStringWord(string word)
        {
            string[] rev = new string[word.Trim().Split().Length];
            int temp = 0;
            string[] arr = word.Trim().Split();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rev[temp] = arr[i];
                temp++;
            }
            return rev;
        }
        #endregion

        #region Find the fixed Charector from given String.
        public static int FindIndexOfCharector(string word, char index)
        {
            char[] arr = word.ToCharArray();
            int temp = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                temp = arr[i] == index ? i : 0;
            }
            return temp;
        }
        #endregion

        #region Is Number is Even Number
        public static string IsEven(int num)
        {
            string res = num % 2 == 0 ? "Even" : "ODD";
            return res;
        }
        #endregion

        #region Is Number is Prime Number
        public static string IsPrime(int num)
        {
            string res = "";
            if (num == 1 || num == 2)
            {
                res = "PRIME";
            }
            int n = num % 2 == 0 ? num / 2 : num / 2 + 1;
            for (int i = 2; i <= n; i++)
            {
                int rem = num % i;
                res = rem == 0 ? "NOT PRIME" : "PRIME";
            }
            return res;
        }
        #endregion

        #region Is Number Armstrong Number
        public static bool CheckArmstrong(int num)
        {
            int result = 0;
            int temp = num;
            int count = CountDigit(num);
            while (num > 0)
            {

                int digit = num % 10;
                num /= 10;
                result += (int)System.Math.Pow(digit, count);
            }
            return temp == result;
        }
        static int CountDigit(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }
            return count;
        }
        public static string IsArmStrong(int num)
        {
            var res = CheckArmstrong(num);
            var result = res ? "Armstrong" : "Non-Armstrong";
            return result;
        }
        #endregion

        #region Is String is Pelindrom or Not
        public static string CheckPelindrome(string str)
        {
            string revStr = "";
            char[] arr = str.ToCharArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                revStr += arr[i];
            }
            return revStr;
        }

        public static string IsPelindrome(string str)
        {
            string temp = str;
            string rev = CheckPelindrome(str);
            return temp == rev ? "Pelindrome" : "Not-Pelindrome";
        }
        #endregion

        #region Find the Common Prefix from an String Array
        public static string CommonString(string[] str)
        {
            Array.Sort(str);
            char[] start = str[0].ToArray();
            char[] end = str[^1].ToArray();
            System.Text.StringBuilder prefix = new();
            for (int i = 0; i <= start.Length - 1; i++)
            {
                if (start[i] != end[i])
                {
                    break;
                }
                prefix.Append(start[i]);
            }
            return prefix.ToString();
        }
        #endregion

        #region Find Duplicate Frequency in the given String
        public static char[] DuplicateFrequency(string str)
        {
            char[] arr = str.ToLower().ToArray();
            List<char> duplicates = new();

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                char currentChar = arr[i];
                bool isDuplicate = false;
                if (duplicates.Contains(currentChar))
                {
                    continue;
                }

                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (currentChar == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate)
                {
                    duplicates.Add(currentChar);
                }
            }
            return duplicates.ToArray();
        }

        #endregion

        #region Find the Common item from the given two Integer Array

        public static int[] SecondMaxElement()
        {
            int[] l1 = { 1, 7, 50, 100 };
            Array.Sort(l1);
            int[] l2 = { 200, 250, 50, 7, 90 };
            Array.Sort(l2);

            int[] lst = new int[System.Math.Min(l1.Length, l2.Length)];
            int temp = 0, i = 0, j = 0;

            while (i < l1.Length && j < l2.Length)
            {
                if (l1[i] == l2[j])
                {
                    lst[temp] = l1[i];
                    temp++;
                    i++;
                    j++;
                }
                else if (l1[i] < l2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            Array.Resize(ref lst, temp);
            return lst;
        }

        #endregion

        #region Reverse a string without using inbuilt method

        public static string ReverseWithoutInbuiltString(string str)
        {
            // Output : KPMG TO WELCOME
            int count = 0;
            int wordstart = 0;
            string[] words = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    words[count++] = str.Substring(wordstart, i - wordstart);
                    wordstart = i + 1;
                }
            }
            words[count++] = str.Substring(wordstart);

            string reverse = "";

            for (int i = count - 1; i >= 0; i--)
            {
                reverse += words[i] + ' ';
            }


            return reverse;
        }

        #endregion

        #region Print Odd Number Peramid
        public static void PrintOddPeramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i * 2; j += 2)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Print Even Number Peramid
        public static void PrintEvenPeramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(2 * j + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Print Left Star Peramid
        public static void PrintLeftStarPeramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Print Right Star Peramid
        public static void PrintRightStarPeramid(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n - i - 1; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Print Star Parllel
        public static void PrintStarParllel(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Print Down Star
        public static void PrintDownStar(int n)
        {
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }

                for (int k = i; k <= n; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        #endregion

        #region Swap Number Using Third Variable
        public static void SwapNumberUsingThirdVariable(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        #endregion

        #region Swap Number Without Using Third Variable
        public static void SwapNumberWithoutUsingThirdVariable(int x, int y)
        {
            x = x + y - x;
            y = y + x - y;
        }

        #endregion

        #region Swap Number Using Third Variable In Genric <T>
        public static void SwapNumberUsingThirdVariableInGenric<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        #endregion

        #region Check Array is Monotonic or Not Monotonic
        public static string IsMonotalic(int[] arr)
        {
            bool Isinc = true;
            bool Isdec = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    Isinc = false; ;
                }
                if (arr[i] > arr[i + 1])
                {
                    Isdec = false; ;
                }
            }
            return Isinc | Isdec ? "Monotonic" : "Not Monotonic";
        }

        #endregion

        #region Find Occurence Char in String
        public static void OccrenceChar(string str)
        {
            Dictionary<char, int> CharCounts = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (CharCounts.ContainsKey(str[i]))
                {
                    CharCounts[str[i]]++;
                }
                else
                {
                    CharCounts.Add(str[i], 1);
                }
            }

            foreach (var c in CharCounts)
            {
                Console.WriteLine($"'{c.Key}' : {c.Value}");
            }
        }

        #endregion

        #region Find the Number Occurring Odd Number of Times in C#
        public static void FindOddOccurrence(int[] arr)
        {
            // int[] arr = { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };
            // Output : 5
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (pairs.ContainsKey(arr[i]))
                {
                    pairs[arr[i]]++;
                }
                else
                {
                    pairs[arr[i]] = 1;
                }
            }
            foreach (var item in pairs)
            {
                if (item.Value % 2 != 0)
                {
                    Console.WriteLine($"'{item.Key}' : {item.Value}");
                }
            }
        }

        #endregion

        #region Two Sum - Indices of the two numbers such that they add up to target
        public static int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int, int> result = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int targetValue = target - nums[i];
                if (result.ContainsKey(targetValue))
                {
                    return new int[] { result[targetValue], i };
                }
                if (!result.ContainsKey(nums[i]))
                {
                    result.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No two sum");
        }

        #endregion

        #region Tuple - Practice problem in C#
        public static (string Name, int Age) CheckTypeOfData()
        {
            return ("Yuvraj Singh", 25);
        }

        #endregion

        #region Tuple - Find max and min value in C#
        public static (int, int) FindMinMax(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int currentItem in arr)
            {
                if (currentItem < min || currentItem > max)
                {
                    min = currentItem;
                    max = currentItem;
                }
            }
            return (min, max);
        }

        #endregion

        #region Remove Duplicates from an Array
        public static int[] RemoveDuplicates(int[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[index])
                {
                    index++;
                    arr[index] = arr[i];
                }
            }
            int[] uniqueArray = new int[index + 1];
            Array.Copy(arr, uniqueArray, index + 1);
            return uniqueArray;
        }

        #endregion

        #region Find Second Largest element in Array in C#
        public static int FindSecondLargest(int[] arr) // 2, 4, 3, 8, 6, 9, 13 - 9
        {
            int first = int.MinValue;
            int second = int.MinValue;
            foreach (int currentItem in arr)
            {
                if (currentItem > first)
                {
                    second = first;
                    first = currentItem;
                }
                else if (currentItem > second && currentItem != first)
                {
                    second = currentItem;
                }
            }
            return second;
        }
        #endregion

        #region Find the missing number in a given integer array containing numbers from 1 to n with one number missing.
        public static int FindMissingNumber(int[] arr)
        {
            int actualArrayLength = arr.Length + 1;
            int actualTotal = actualArrayLength * (actualArrayLength + 1) / 2;
            int currentTotal = 0;
            foreach (int currentItem in arr)
            {
                currentTotal = currentTotal + currentItem;
            }
            return actualTotal - currentTotal;
        }
        #endregion

        #region Yes - USER



        #endregion

        #region Shift pair numbers in last - Array
        public static int[] ShiftPairNumbersInLast(int[] arr)
        {
            // Occurence
            Dictionary<int, int> occurence = new();
            foreach (int currentItem in arr)
            {
                if (occurence.ContainsKey(currentItem))
                    occurence[currentItem]++;
                else
                    occurence[currentItem] = 1;
            }


            // Multiple occurence
            List<int> multipleOccurence = new();
            foreach (var currentItem in occurence)
            {
                if (currentItem.Value > 1)
                {
                    multipleOccurence.Add(currentItem.Key);
                }
            }

            int[] newShiftedArray = new int[arr.Length];
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            foreach (int num in arr)
            {
                if (multipleOccurence.Contains(num))
                {
                    newShiftedArray[endIndex] = num;
                    endIndex--;
                }
                else
                {
                    newShiftedArray[startIndex] = num;
                    startIndex++;
                }
            }
            return newShiftedArray;
        }

        public static void PrintShiftPairNumbersInLast(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Determine if any two integers in array sum to given integer

        public static bool SumOfTwoGivenIntegerToTarget(int[] arr, int target)
        {
            bool result = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int num = arr[i] + arr[i + 1];
                if (num == target)
                    result = true;
                else
                    result = false;
            }
            return result;
        }
        #endregion

        #region Find the longest subarrays in the Array
        public static List<int[]> LongestSubArray(int[] arr)
        {
            List<int[]> longestSubArrays = new();
            List<int[]> finalArrayCollection = new();
            for (int i = 0; i < arr.Length; i++)
            {
                List<int> currentArrayItem = new() { arr[i] };
                int k = currentArrayItem.Count;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > currentArrayItem[k - 1])
                    {
                        currentArrayItem.Add(arr[j]);
                    }
                }
                if (currentArrayItem.Count > 1)
                {
                    finalArrayCollection.Add(currentArrayItem.ToArray());
                }

                int maxLength = 0;

                foreach (int[] currentArray in finalArrayCollection)
                {
                    if (currentArray.Length > maxLength)
                    {
                        maxLength = currentArray.Length;
                        longestSubArrays.Clear();
                        longestSubArrays.Add(currentArray);
                    }
                    else if (currentArray.Length == maxLength)
                    {
                        longestSubArrays.Add(currentArray);
                    }
                }
            }
            return longestSubArrays;
        }

        #endregion

        #region Print Traget Combination - Arrays

        public static List<int[]> PrintCombination(int[] arr, int target)
        {
            // {1,2,3,4,5,6,8,11,10,9,7}
            // target Output : 12 --> combination of two numbers
            List<int[]> finalResult = new();
            //int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        finalResult.Add(new int[] { arr[i], arr[j] });
                    }
                }
            }

            return finalResult;
        }

        #endregion

        #region Print Traget Combination Number - Array


        public static List<int[]> PrintTragetCombination(int[] arr, int target)
        {
            // {1,2,3,4,5,6,8,11,10,9,7}
            // target Output : 12 --> combination of n numbers
            List<int[]> finalCombinations = new();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {

                }
            }
            return finalCombinations;
        }


        #endregion

        #region Print Sum of string Itrate Integers - Total

        public static int SumStringItrateInteger(string str)
        {
            int sum = 0;
            MatchCollection match = Regex.Matches(str, @"\d+");
            foreach (int i in match.Select(v => int.Parse(v.Value)))
            {
                sum = sum + i;
            }

            return sum;
        }

        #endregion

        #region Merge Two Shorted Array - Array

        // int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        // int[] b = { 8, 9, 10, 11, 12, 13, 14, 15 };
        public static int[] MergeTwoShortedArray(int[] arr, int[] brr)
        {
            int[] finalArray = new int[arr.Length + brr.Length];

            int arrLength = arr.Length;
            int brrLength = brr.Length;

            int i = 0; int j = 0; int k = 0;

            while (i < arrLength && j < brrLength)
            {
                if (arr[i] < brr[j])
                {
                    finalArray[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    finalArray[k] = brr[j];
                    k++;
                    j++;
                }
            }

            while (i < arrLength)
            {
                finalArray[k] = arr[i];
                k++;
                i++;
            }

            while (j < brrLength)
            {
                finalArray[k] = brr[j];
                k++;
                j++;
            }

            return finalArray;
        }

        #endregion

        #region Find second highest iteger from an Array - Array
        public static int FindSecondHeighestInteger(int[] arr)
        {
            int highest = int.MinValue;
            int secondHighest = int.MinValue;
            foreach (int i in arr)
            {
                if (i > highest)
                {
                    secondHighest = highest;
                    highest = i;
                }
                else if (i > secondHighest && i < highest)
                {
                    secondHighest = i;
                }
            }
            return secondHighest;
        }
        #endregion

        #region Short an Array : Shorting Technique - Bubble Short

        // int[] array = { 1, 2, 3, 4, 5, 6, 7, 0, 17, 15, 23, 24 };
        public static int[] BubbleShort(int[] arr)
        {
            return arr;
        }

        #endregion

        #region Short an Array : Shorting Technique - Quick Short

        // int[] array = { 1, 2, 3, 4, 5, 6, 7, 0, 17, 15, 23, 24 };

        public static int[] QuickShort(int[] arr)
        {
            QuickShort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void QuickShort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickShort(arr, left, pivotIndex - 1);
                QuickShort(arr, pivotIndex, right);
            }
        }


        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }

            }
            return left;
        }

        #endregion

        #region Find common item in two list - List Problem
        public static List<int> FindCommonItem()
        {
            List<int> l1 = new() { 1, 2, 3, 4, 5, 6 };
            List<int> l2 = new() { 5, 6, 7, 8, 9, 10 };
            List<int> common = l2.Where(item => l1.Contains(item)).ToList();
            return common;
        }

        #endregion

        #region Find middle index element from node list - Linkedlist

        // Find middle index element from node list of the Linked List

        //StringProgram..SingleLinkedList list = new SingleLinkedList();
        //linkedLst.Add(1);
        //list.Add(3);

        List<int> ints = new() { 1, 2, 3, 5, 7, 40, 60, 100, 4 };

        #endregion

        #region Find the Longest Sub Sequence Array - Array

        public static int FindLongestSub(int[] arr)
        {
            int logestSubArray = 0;
            HashSet<int> result = new(arr);
            foreach (var i in arr)
            {
                if (!result.Contains(i - 1))
                {
                    int current = i;
                    int curentItem = 1;
                    while (result.Contains(current + 1))
                    {
                        current++;
                        curentItem++;
                    }
                    logestSubArray = System.Math.Max(logestSubArray, curentItem);
                }
            }
            return logestSubArray;
        }

        #endregion
    }
}