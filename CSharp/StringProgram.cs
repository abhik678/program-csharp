﻿namespace CSharp
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
                result += (int)Math.Pow(digit, count);
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

            int[] lst = new int[Math.Min(l1.Length, l2.Length)];
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
            return (Isinc | Isdec) ? "Monotonic" : "Not Monotonic";
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
                if ((currentItem < min) || (currentItem > max))
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
            foreach(int currentItem in arr)
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
            foreach(int currentItem in arr)
            {
                currentTotal = currentTotal + currentItem;
            }
            return actualTotal - currentTotal;
        }
        #endregion

        #region Yes - USER



        #endregion
    }
}
