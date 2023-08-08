#region Break And Continue 

using System.Collections;

/*class program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i==5)
            {

                // continue;
                break;
               
            }
            Console.Write(i);
        }
        Console.WriteLine("----------------------------------------");


        int[] num = new int[10] ;
        num[0] = 1;
        //num[1] = "Shyam";
        // type safe

        ArrayList arreylist = new ArrayList();
        arreylist.Add("Shyam");
        arreylist.Add(1);
        // any type of values we can store in arrelist collection
        foreach (var item in arreylist)
        {
            Console.WriteLine(item+" ");
        }
        


        Console.ReadLine();
    }
}*/


#endregion
#region Params
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 50, 25, 32 ,1514,494,94,949,494,949};
        int num = Add(1,3,2,5);
        Console.WriteLine("Addition is :- "+num);
        Console.ReadLine();
    }
    public static int Add(params int[] numbers)
    {
        int Total = 0;
        if (numbers != null)
        {
            foreach (var i in numbers)
            {
                Total += i;
            }
          /*  for (int i = 0; i < numbers.Length; i++)
            {
                Total += i;
            }*/
        }
        return Total;
    }
}

#endregion
#region

#endregion
#region

#endregion
#region

#endregion
#region


#endregion