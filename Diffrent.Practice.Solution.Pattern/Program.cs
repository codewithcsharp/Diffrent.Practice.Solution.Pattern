using Diffrent.Practice.Solution.Pattern.DataStructure;
using Diffrent.Practice.Solution.Pattern.DataStructure.SinglyLinkedList;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern.Interfaces;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.FactoryDesignPattern.Interfaces;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.RepositoryDesignPattern.Repository;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.SingletonDesignPattern;
using Diffrent.Practice.Solution.Pattern.Enumerations;
using Diffrent.Practice.Solution.Pattern.Enumerations.EnumsUsingExplicitValue;
using Diffrent.Practice.Solution.Pattern.Generics.GenericsUsingWhere;
using Diffrent.Practice.Solution.Pattern.Generics.GenericsWithoutUsingWhere;
using Diffrent.Practice.Solution.Pattern.ObjectOrientedPrograming.Abstaraction.Interfaces;
using Diffrent.Practice.Solution.Pattern.ObjectOrientedPrograming.Inheritance.BaseClasses;
using Diffrent.Practice.Solution.Pattern.ObjectOrientedPrograming.Inheritance.DerivedClasses;
using Diffrent.Practice.Solution.Pattern.ObjectOrientedPrograming.Inheritance.Interfaces;
using System.Text.Json;

namespace Diffrent.Practice.Solution.Pattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your input choice to run the program :");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 40)
                    break;
                switch (choice)
                {
                    case 1:
                        #region Reverse array of an Integer

                        int parseIntegerInput = int.Parse(Console.ReadLine()!);
                        int[] array = new int[parseIntegerInput];
                        for (int i = 0; i < parseIntegerInput; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine()!);
                        }
                        var arrays = StringProgram.ReverseArray(array);
                        Console.WriteLine(string.Join(' ', arrays));

                        #endregion
                        break;
                    case 2:
                        #region Reverse a String Input - C#

                        string stringReverseInput = Console.ReadLine()!;
                        string rev = StringProgram.ReverseString(stringReverseInput);

                        Console.WriteLine(rev);

                        #endregion
                        break;
                    case 3:
                        #region Combine two String Array Inputs into Single Array - C#

                        string firstStringArrayInput = Console.ReadLine()!;
                        string[] firstArray = new string[firstStringArrayInput.Length];
                        string secondStringArrayInput = Console.ReadLine()!;
                        string[] secondArray = new string[secondStringArrayInput.Length];
                        string[] finalArray = StringProgram.CombineTwoArray(firstArray!, secondArray!);

                        for (int i = 0; i < finalArray.Length; i++)
                        {
                            Console.WriteLine(finalArray[i] + " ");
                        }

                        #endregion
                        break;
                    case 4:
                        #region Reverse a Sentance of Strings - C#

                        string stringWordInput = Console.ReadLine()!;
                        string[] reverseStringWordArray = StringProgram.ReverseStringWord(stringWordInput);

                        for (int i = 0; i <= reverseStringWordArray.Length - 1; i++)
                        {
                            Console.Write(reverseStringWordArray[i] + " ");
                        }

                        #endregion
                        break;
                    case 5:
                        #region Find the fixed Charector from given String - C#

                        string stringWord = Console.ReadLine()!;
                        char fixedcharector = char.Parse(Console.ReadLine()!);
                        int index = StringProgram.FindIndexOfCharector(stringWord, fixedcharector);

                        Console.WriteLine(index);

                        #endregion
                        break;
                    case 6:
                        #region Check Is Number is Even Number - C#

                        int findEvenNumber = int.Parse(Console.ReadLine()!);
                        string result = StringProgram.IsEven(findEvenNumber);

                        Console.WriteLine(result);

                        #endregion
                        break;
                    case 7:
                        #region Check Is Number Armstrong Number - C#

                        int findArmstrongNumber = int.Parse(Console.ReadLine()!);
                        string ArmstrongNumber = StringProgram.IsArmStrong(findArmstrongNumber);
                        Console.WriteLine(ArmstrongNumber);

                        #endregion
                        break;
                    case 8:
                        #region Check Is String is Pelindrom or Not - C#

                        string pelindromeInputstring = Console.ReadLine()!;
                        string OutputPelindrome = StringProgram.IsPelindrome(pelindromeInputstring);
                        Console.WriteLine(OutputPelindrome);

                        #endregion
                        break;
                    case 9:
                        #region Find the Common Prefix from an String Array - C#

                        string commonInputString = Console.ReadLine()!;
                        string[] commonInputStringArray = commonInputString.Split(',');

                        string commonOutputResult = StringProgram.CommonString(commonInputStringArray);
                        Console.WriteLine(commonOutputResult);

                        #endregion
                        break;
                    case 10:
                        #region Find Duplicate Frequency in the given String - C#

                        string duplicateInputString = Console.ReadLine()!;
                        char[] duplicateOutputArray = StringProgram.DuplicateFrequency(duplicateInputString);

                        for (int i = 0; i <= duplicateOutputArray.Length - 1; i++)
                        {
                            Console.Write(duplicateOutputArray[i] + " ");
                        }

                        #endregion
                        break;
                    case 11:
                        #region Find the Common item from the given two Integer Array - C#

                        int[] lstUser = StringProgram.SecondMaxElement();
                        for (int i = 0; i < lstUser.Length; i++)
                        {
                            Console.WriteLine(lstUser[i]);
                        }

                        #endregion
                        break;
                    case 12:
                        #region Reverse a string without using inbuilt method - C#

                        string StringInput = Console.ReadLine()!;
                        string ReverseStringOutput = StringProgram.ReverseWithoutInbuiltString(StringInput);
                        Console.WriteLine(ReverseStringOutput);

                        #endregion
                        break;
                    case 13:
                        #region Print Even Number Peramid

                        int Even = int.Parse(Console.ReadLine()!);
                        StringProgram.PrintEvenPeramid(Even);

                        #endregion
                        break;
                    case 14:
                        #region Print Odd Number Peramid

                        int Odd = int.Parse(Console.ReadLine()!);
                        StringProgram.PrintOddPeramid(Odd);

                        #endregion
                        break;
                    case 15:
                        #region Print left Star Peramid
                        int Left = int.Parse(Console.ReadLine()!);
                        StringProgram.PrintLeftStarPeramid(Left);
                        #endregion
                        break;
                    case 16:
                        #region Print Right Star Peramid
                        int Right = int.Parse(Console.ReadLine()!);
                        StringProgram.PrintRightStarPeramid(Right);
                        #endregion
                        break;
                    case 17:
                        #region Print Star Parllel
                        int Parllel = int.Parse(Console.ReadLine()!);
                        StringProgram.PrintStarParllel(Parllel);
                        #endregion
                        break;
                    case 18:
                        #region Print Down Star
                        int Down = int.Parse(Console.ReadLine()!);
                        StringProgram.PrintDownStar(Down);
                        #endregion
                        break;
                    case 19:
                        #region Swap Number Using Third Variable
                        int a = int.Parse(Console.ReadLine()!);
                        int b = int.Parse(Console.ReadLine()!);
                        Console.WriteLine(a + " " + b);
                        StringProgram.SwapNumberUsingThirdVariable(a, b);
                        Console.WriteLine(a + " " + b);
                        #endregion
                        break;
                    case 20:
                        #region Swap Number Without Using Third Variable
                        int x = int.Parse(Console.ReadLine()!);
                        int y = int.Parse(Console.ReadLine()!);
                        Console.WriteLine(x + " " + y);
                        StringProgram.SwapNumberWithoutUsingThirdVariable(x, y);
                        Console.WriteLine(x + " " + y);
                        #endregion
                        break;
                    case 21:
                        #region Swap Number Using Third Variable In Genric
                        int X = int.Parse(Console.ReadLine()!);
                        int Y = int.Parse(Console.ReadLine()!);
                        Console.WriteLine(X + " " + Y);
                        StringProgram.SwapNumberUsingThirdVariableInGenric(ref X, ref Y);
                        Console.WriteLine(X + " " + Y);
                        #endregion
                        break;
                    case 22:
                        #region Is Monotalic Array
                        string userInput = Console.ReadLine()!;
                        string[] inputArray = userInput.Split(' ');
                        int[] integerArray = new int[inputArray.Length];

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (int.TryParse(inputArray[i], out int number))
                            {
                                integerArray[i] = number;
                            }
                            else
                            {
                                Console.WriteLine($"Invalid input: '{inputArray[i]}' is not a valid integer.");
                                return;
                            }
                        }

                        string OutputString = StringProgram.IsMonotalic(integerArray);
                        Console.WriteLine(OutputString);
                        #endregion
                        break;
                    case 23:
                        #region Occrence of Character
                        string str = Console.ReadLine()!;
                        StringProgram.OccrenceChar(str);
                        #endregion
                        break;
                    case 24:
                        #region Two Sums
                        int target = 6;
                        int[] numbers = { 3, 2, 4 };
                        StringProgram.TwoSums(numbers, target);
                        #endregion
                        break;
                    case 25:
                        #region Tuple Practice problem in C#
                        // 1. Technique of accessing tuple
                        var person1 = Tuple.Create("Abhitosh Kumar", 1);
                        Console.WriteLine($"Name : {person1.Item1} and Age : {person1.Item2}");

                        // 2. Technique of accessing tuple using named elements
                        var person2 = (Name: "Rohit Sharma", Age: 28);
                        Console.WriteLine($"Name : {person2.Name} and Age : {person2.Age}");

                        // 3. Technique of accessing tuple using function
                        var (Name, Age) = StringProgram.CheckTypeOfData();

                        // Display the retrieved data
                        Console.WriteLine($"Name: {Name}, Age: {Age}");
                        #endregion
                        break;
                    case 26:
                        #region Tuple - Find max and min value in C#
                        int[] arr = { 1, 2, 3, 4, 5, 6 };

                        var FindOutput = StringProgram.FindMinMax(arr);

                        Console.WriteLine($"Minimum value : {FindOutput.Item1}");

                        Console.WriteLine($"Maximum value : {FindOutput.Item2}");

                        #endregion
                        break;
                    case 27:
                        #region Remove Duplicates from an Array
                        int[] sortedArray = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };

                        // Call the function to remove duplicates
                        int[] uniqueArray = StringProgram.RemoveDuplicates(sortedArray);

                        Console.WriteLine("Array with duplicates removed:");
                        foreach (int num in uniqueArray)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                        #endregion
                        break;
                    case 28:
                        #region Find Second Largest element in Array in C#
                        int[] arrOut = { 2, 4, 3, 8, 6, 9, 13 };
                        int outputSecondLargest = StringProgram.FindSecondLargest(arrOut);
                        Console.WriteLine("Second largest number is: " + outputSecondLargest);  // Output: 9
                        #endregion
                        break;
                    case 29:
                        #region Shift pair numbers in last - Array
                        int[] pair = { 2, 2, 2, 4, 5, 6, 7, 1, 1, 1, 8, 9, 10, 1 };
                        Console.WriteLine("Original Array:");
                        StringProgram.PrintShiftPairNumbersInLast(pair);

                        int[] shiftedArray = StringProgram.ShiftPairNumbersInLast(pair);
                        Console.WriteLine("\nArray after shifting elements with multiple occurrences to end:");
                        StringProgram.PrintShiftPairNumbersInLast(shiftedArray);
                        #endregion
                        break;
                    case 30:
                        #region Find the longest subarrays in the Array

                        int[] longArrayInput = { 5, 3, 10, 2, 1, 20 };
                        List<int[]> Output = StringProgram.LongestSubArray(longArrayInput);
                        Console.WriteLine(Output);
                        Console.WriteLine("Maximum Subarrays where the first element is greater than the second:");
                        foreach (var subarray in Output)
                        {
                            Console.Write("{ " + string.Join(", ", subarray) + " }");
                        }

                        #endregion
                        break;
                    case 31:
                        #region Print Combination on Array
                        int[] arrayInput = { 1, 2, 3, 4, 5, 6, 8, 11, 10, 9, 7 };
                        int arrayIndex = 12;
                        var output = StringProgram.PrintCombination(arrayInput, arrayIndex);

                        foreach (var i in output)
                        {
                            Console.WriteLine($"[{i[0]},,{i[1]}]");
                        }
                        #endregion
                        break;
                    case 32:
                        #region Print Sum of string Itrate Integers - Total

                        string strInput = "xayz20yt5ttu10";
                        int intOutput = StringProgram.SumStringItrateInteger(strInput);
                        Console.WriteLine(intOutput);

                        #endregion
                        break;
                    case 33:
                        #region Polymerphism Implementation - Interface

                        IA Ab = new InterfaceImplementation();
                        int objA = Ab.IAPrint(1);
                        Console.WriteLine(objA);
                        int obj1 = Ab.IPrint(13);
                        Console.WriteLine(obj1);

                        InterfaceImplementation bc = new();
                        int objB = ((IA)bc).IAPrint(1);
                        Console.WriteLine(objB);
                        int obj2 = ((IA)bc).IPrint(13);
                        Console.WriteLine(obj2);

                        #endregion
                        break;
                    case 34:
                        #region Merge Two Shorted Array - Array

                        int[] first = { 1, 2, 3, 4, 5, 6, 7 };
                        int[] second = { 8, 9, 10, 11, 12, 13, 14 };

                        int[] finalOutput = StringProgram.MergeTwoShortedArray(first, second);

                        foreach (int i in finalOutput)
                        {
                            Console.Write(i + " ");
                        }

                        #endregion
                        break;
                    case 35:
                        #region Find second heighest integer - Integer

                        int[] inputFindSecondHeighestInteger = { 1, 2, 3, 4, 5, 6, 7, 0, 17, 15, 23, 24 };
                        int outputFindSecondHeighestInteger = StringProgram.FindSecondHeighestInteger(inputFindSecondHeighestInteger);
                        Console.WriteLine(outputFindSecondHeighestInteger);

                        #endregion
                        break;
                    case 36:
                        #region Short an Array : Shorting Technique - Quick Short

                        int[] inputQuickShort = { 1, 2, 3, 4, 5, 6, 7, 20, 17, 15, 23, 24 };

                        int[] outputQuickShort = StringProgram.QuickShort(inputQuickShort);

                        foreach (int i in outputQuickShort)
                        {
                            Console.Write(i + " ");
                        }

                        #endregion
                        break;
                    case 37:
                        #region Output of Polymerphism - Polymerphism

                        BaseClass baseClass = new();
                        baseClass.ShowInDerived();
                        baseClass = new DerivedClassImplementation();
                        baseClass.ShowInDerived();

                        #endregion
                        break;
                    case 38:
                        #region Find middle index element from node list - Linkedlist

                        SingleLinkedList list = new();
                        SingleLinkedList.Add(ref list.Head!, 1);
                        SingleLinkedList.Add(ref list.Head, 2);
                        SingleLinkedList.Add(ref list.Head, 3);
                        SingleLinkedList.Add(ref list.Head, 5);
                        SingleLinkedList.Add(ref list.Head, 7);
                        SingleLinkedList.Add(ref list.Head, 40);
                        SingleLinkedList.Add(ref list.Head, 60);
                        SingleLinkedList.Add(ref list.Head, 100);
                        SingleLinkedList.Add(ref list.Head, 4);

                        int middleElement = SingleLinkedList.FindMiddleIndexFromNodeList(ref list.Head!);
                        Console.WriteLine($"Middle Element from the Node List : {middleElement}");

                        #endregion
                        break;
                    case 39:
                        #region Check Node is Circular - Linkedlist

                        Node Head = new Node(1);
                        Head.Next = new Node(2);
                        Head.Next.Next = new Node(3);
                        Head.Next.Next.Next = new Node(4);
                        Head.Next.Next.Next.Next = Head.Next; // Creates a loop

                        // Checking if the linked list is circular
                        Console.WriteLine(SingleLinkedList.IsCircularLinkedList(Head));

                        // Creating a non-circular linked list for testing
                        Node head2 = new Node(1);
                        head2.Next = new Node(2);
                        head2.Next.Next = new Node(3);
                        head2.Next.Next.Next = new Node(4);

                        // Checking if the linked list is circular
                        Console.WriteLine(SingleLinkedList.IsCircularLinkedList(head2));

                        //int middleElement = SingleLinkedList.FindMiddleIndexFromNodeList(ref list.Head!);
                        //Console.WriteLine($"Middle Element from the Node List : {middleElement}");

                        #endregion
                        break;
                    case 40:
                        #region Check Longest consecutive subsequence length
                        int[] longArray = { 1, 9, 3, 10, 4, 20, 2 };
                        Console.WriteLine("Longest consecutive subsequence length is " + StringProgram.FindLongestSub(longArray));
                        #endregion
                        break;
                    case 41:
                        #region Calculate arithmetic Addition operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + ArithmeticOperation<int>.Add(2, 5));
                        #endregion
                        break;
                    case 42:
                        #region Calculate arithmetic Sustract operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + ArithmeticOperation<int>.Subtract(2, 5));
                        #endregion
                        break;
                    case 43:
                        #region Calculate arithmetic Multiply operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + ArithmeticOperation<int>.Multiply(2, 5));
                        #endregion
                        break;
                    case 44:
                        #region Calculate arithmetic Division operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + ArithmeticOperation<int>.Divide(2, 5));
                        #endregion
                        break;
                    case 45:
                        #region Calculate Aggregate Addition operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + AggregateFunction<int>.Add(2, 5));
                        #endregion
                        break;
                    case 46:
                        #region Calculate Aggregate Sustract operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + AggregateFunction<int>.Subtract(2, 5));
                        #endregion
                        break;
                    case 47:
                        #region Calculate Aggregate Multiply operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + AggregateFunction<int>.Multiply(2, 5));
                        #endregion
                        break;
                    case 48:
                        #region Calculate Aggregate Division operation in Generic class
                        Console.WriteLine("Arithmetic operation in Generic class " + AggregateFunction<int>.Divide(2, 5));
                        #endregion
                        break;
                    case 49:
                        #region Factory Design Pattern Code Changes Example
                        NotificationFactory emailNotification = new EmailNotificationFactory();
                        emailNotification.Notify("");
                        Console.WriteLine("Arithmetic operation in Generic class " + AggregateFunction<int>.Divide(2, 5));
                        #endregion
                        break;
                    case 50:
                        #region Singleton Design Pattern Code Changes Example
                        SingletonInstance instance  = SingletonInstance.Instance;
                        Console.WriteLine("Singleton class Instance " + instance);
                        #endregion
                        break;
                        case 51:
                        #region Enumeration Example Code Changes demonstration
                        OperationOnEnumeration operationOnEnumeration = new() { EventDay = Enumeration.Monday, EventName = "Project Managment" };
                        string jsonSerialization = JsonSerializer.Serialize(operationOnEnumeration);
                        Console.WriteLine($"Enumeration Example Code Changes demonstration { jsonSerialization }");
                        #endregion
                        break;
                    case 52:
                        #region Repository Design Pattern Code Changes Example
                        var productRepository = new ProductRepository();
                        foreach (var product in productRepository.GetAll()) 
                        {
                            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                        }
                        #endregion
                        break;
                    case 53:
                        #region Builder Design Pattern Code Changes
                        BankAccountDirector director = new BankAccountDirector();
                        IBankAccountBuilder builder = new BankAccountBuilder();

                        // Create a Savings Account
                        BankAccount savingsAccount = director.BuildSavingsAccount(builder);
                        Console.WriteLine("Savings Account Created:\n" + savingsAccount);

                        Console.WriteLine("\n-----------------------------\n");

                        // Create a Current Account
                        BankAccount currentAccount = director.BuildCurrentAccount(builder);
                        Console.WriteLine("Current Account Created:\n" + currentAccount);
                        #endregion
                        break;
                    default:
                        Console.WriteLine("Choose correct option: Something went wrong");
                        break;
                }
            }
        }
    }
}

