class Program
{
    static void Main()
    {
        int[] num = { 1, 2, 3, 4, 5, 6, 7, };
        foreach (var item in num)
        {
            if (IsPrime(item))
            {
                Console.WriteLine("Prime no"+item);
            }
            else
            {
                Console.WriteLine(item + "Not Prime");
            }
        }


        Console.ReadLine();
    }
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num) ; i++)
        {
            if (num%i==0)
            {
                return false;
            }
        }
        return true;
    }
}