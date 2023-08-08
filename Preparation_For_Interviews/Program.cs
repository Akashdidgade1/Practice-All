#region Var Object Dynamic
//var

/*var a = 10;
a = a + 10;
a = "sample";
Console.WriteLine(a);*/
//dynamic

/*dynamic a = 10;
a = a + 10;
a = "sample";
Console.WriteLine(a);*/
//Object

/*object a = 10;
a = a + 10;//compile time error 
a = "sample";
Console.WriteLine(a);*/

// Ternary Operator 
/*
int a = 10;
int b = 10;
string result = (a == b) ? "Equal" : "Not Equal";
Console.WriteLine(result);



// Nullable and Non Nullable  
int? num = null;
int j = num??0;
Console.WriteLine(j);


Console.ReadLine();*/

#endregion

#region Method Parameter

/*class Program
{
    static void Main()
    {
        // before calling the method we need to assignning 
        *//* int a = 10, b = 2, sum, sub, mul, div;
         Operation(a, b, out sum, out sub, out mul, out div);
         Console.WriteLine("Additio:-" +
             "  "+sum+"\n"+
            "Subtaraction:-  " + sub + "\n"+
            "Multiplication:- " + mul + "\n"+
            "Division:-  " + div + "\n");*//*


        int[] num ={1,2 ,5,8,10};
        PrintSum(num);
        Console.ReadLine();
    }

    static void PrintSum(params int[]num)
    {
        if (num !=null)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Empty arrey");
        }
    }
    static void Operation(int a, int b, out int sum,
        out int sub, out int mul, out int div)
    {
        sum = a + b;
        sub = a - b;
        mul = a * b;
        div = a / b;
    }
}*/


#endregion
#region Delegates
/*public delegate void sample();
public delegate void sample2(sample d);
class Program
{
    static void Main()
    {
        sample s1 = new sample(Customer.Print1);
        s1();

        sample del = Customer.Print1;
        del += Customer.Print2;
        del();

        Console.ReadLine();
    }
}

class Customer
{
    public static void Print1()
    {
        Console.WriteLine("Print 1 called");
    }
    public static void Print2()
    {
        Console.WriteLine("Print 2 called");
    }
    public static void Print3(sample s1)
    {
        s1();
        Console.WriteLine("Print  3 Parametrised called");
    }
}*/

#endregion
#region Singlton Class


class Program
{
    static void Main()
    {
       Customer c1= new  Customer.Instance();



        Console.ReadLine();
    }
}

sealed class Customer
{
    private static Customer _obj;
    private static readonly object _objLock = new object(); 
    private Customer()
    {

    }
    public static Customer Instance
    {
        get
        {
            if (_obj == null)
            {
                lock (_objLock)
                {
                    _obj = new Customer();
                }
              
            }


            return _obj;
        }
    }



}
#endregion
#region
#endregion