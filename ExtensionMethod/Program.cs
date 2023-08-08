#region Theory
/*
    Extension method allows yours to ineject additional methods without modifing ,deriving or recompling the original class ,struct or interface.
    To add an Aditional methods:-  
    i dont han an class right now :-
    Here we use inheritance concept:- 
    

    Struct:- values type : wht if its not class its struct then  :- not performs an inheritance
    that time we need extension Methods
    
    Inheritance :- parents class functionality 
                    not apply on  sealed class
                    structs not follows extension Method

    Need an Staic class  :-  Memebrs Should be Static :- and methods Shoulds Static and these are extension methods
    and binds these to original class
    
 */

#endregion

using System.Text;

//class Program
//{
//    public void Func1()
//    {
//        Console.WriteLine("this is First Fuction");
//    }
//    public void Func2()
//    {
//        Console.WriteLine("this is Second Fuction");
//    }
//    static void Main()
//    {
//        Program p = new Program();
//        p.Func1();
//        p.Func2();

//        Console.ReadLine();
//    }
//    //private static string getHash(string text)
//    //{
//    //    // SHA512 is disposable by inheritance.  
//    //    using (var sha256 = SHA256.Create())
//    //    {
//    //        // Send a sample text to hash.  
//    //        varhashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
//    //        // Get the hashed string.  
//    //        returnBitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
//    //    }
//    //}
//}



