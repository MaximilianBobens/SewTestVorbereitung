namespace SewTestExeLast.RecUbungen;

public class Recs
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    //Summieren einer Liste von Zahlen:
    static int Sum(List<int> numbers, int index)
    {
        if (index == numbers.Count)
            return 0;
        else
            return numbers[index] + Sum(numbers, index + 1);
    }
    
    static string ReverseString(string str)
    {
        if (str == "")
            return str;
        else
            return ReverseString(str.Substring(1)) + str[0];
    }
    static bool IsPalindrome(string str)
    {
        if (str.Length <= 1)
            return true;
        else
        {
            if (str[0] != str[str.Length - 1])
                return false;
            else
                return IsPalindrome(str.Substring(1, str.Length - 2));
        }
    }
    static int Power(int x, int y)
    {
        if (y == 0)
            return 1;
        else
            return x * Power(x, y - 1);
    }
    //Berechnung der Quersumme:
    static int SumOfDigits(int number)
    {
        if (number == 0)
            return 0;
        else
            return number % 10 + SumOfDigits(number / 10);
    }
    static int FindMax(int[] arr, int index)
    {
        if (index == arr.Length - 1)
            return arr[index];
        else
        {
            int max = FindMax(arr, index + 1);
            return arr[index] > max ? arr[index] : max;
        }
    }
    static bool IsPrime(int num, int divisor)
    {
        if (num <= 2)
            return (num == 2);
        if (num % divisor == 0)
            return false;
        if (divisor * divisor > num)
            return true;
        return IsPrime(num, divisor + 1);
    }
    static int FindElement(int[] arr, int target, int index)
    {
        if (index >= arr.Length)
            return -1;
        if (arr[index] == target)
            return index;
        return FindElement(arr, target, index + 1);
    }
    
    static int PowerBaseNum(int baseNum, int exponent)
    {
        if (exponent == 0)
            return 1;
        return baseNum * PowerBaseNum(baseNum, exponent - 1);
    }
    
    static int LengthOfList(List<int> list)
    {
        if (list.Count == 0)
            return 0;
        list.RemoveAt(0);
        return 1 + LengthOfList(list);
    }
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }
    
}