class Program
{
    static void Main()
    {

        string Name = "Akash";
        char[] Sample = Name.ToCharArray();
        
        Console.WriteLine(Sample);
        for (int i = Sample.Length; i <= 0; i--)
        {
            Console.Write(Sample[i]+"Name");
        }
        Console.WriteLine();
        Console.WriteLine("Good Morning");


        Console.ReadLine();
    }
}