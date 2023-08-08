using System.Linq;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        /* List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
         //  List<int> Nums = new List<int>s { 1, 2, 3, 4, 5, 6 };

         IEnumerable<int> numbers = Numbers.Select(a => a * 2);
         foreach (var item in numbers)
         {
             Console.Write(item + " ");
         }
         Console.WriteLine();

         //  IEnumerable<int> Oddnumbers = Numbers.Where(a=>a%2==0);
         IEnumerable<int> Oddnumbers = from Num in numbers
                                       select Num * 2;
         foreach (int number in Oddnumbers)
         {
             Console.Write("Odd Numbers " + number + " ");
         }
         Console.WriteLine();
         IEnumerable<int> Evernumbers = Numbers.Where(a => a % 2 != 0);
         foreach (int number in Evernumbers)
         {
             Console.WriteLine("Even Numbers" + number + " ");
         }
         Console.WriteLine();*/

        /*   List<Student> students = new List<Student>()
           {
                new Student(){Id=1,Name="Shrikant",Age=24,City="Gondia",Gender="Male"},
                new Student(){Id=2,Name="Akash",Age=27,City="Yavatmal",Gender="Male" },
                new Student(){Id=3,Name="Aniket",Age=26,City="Amravati",Gender="Male"},
                new Student(){Id=4,Name="Sadhna",Age=23,City="Nashik", Gender = "Female"},
                new Student(){Id=5,Name="Priya",Age=24,City="Nashik", Gender = "Female"},
                new Student(){Id=6,Name="Vishal",Age=29,City="Amravati", Gender = "Male"},
                new Science(){Id=7,Name="Gaurav",Age=22,City="Nagpur", Gender = "Male",Section="Science"}
           };

           Console.WriteLine("List OF All Students");
           foreach (var item in students)
           {
               Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
           }
           Console.WriteLine();*/

        /*   Console.WriteLine("Find the Student by id");
           Console.WriteLine("Enter the id"); 
           int id= int.Parse(Console.ReadLine());

           IEnumerable<Student> SdByID = *//*students.Where(x => x.Id == id);*//* from n in students where n.Id == id select n;
           Console.WriteLine($"Details of Students where id = {id}");
           foreach (var item in SdByID)
           {
               Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
           }
           Console.WriteLine()*/
        /*   Console.WriteLine("Find the Student by id");
           Console.WriteLine("Enter the id");
           int id = int.Parse(Console.ReadLine());

           IEnumerable<Student> SdByID = *//*students.Where(x => x.Id == id);*//* from n in students where n.Id == id select n;
           Console.WriteLine($"Details of Students where id = {id}");
           foreach (var item in SdByID)
           {
               Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
           }
           Console.WriteLine();

           var studentscience = students.OfType<Science>();
           Console.WriteLine($"Details of Students where type is science");
           foreach (var item in studentscience)
           {
               Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
           }
           Console.WriteLine();*/


        /*  List<Student> students = new List<Student>()
          {
               new Student(){Id=1,Name="Shrikant",Age=24,City="Gondia",Gender="Male"},
               new Student(){Id=2,Name="Akash",Age=27,City="Yavatmal",Gender="Male" },
               new Student(){Id=3,Name="Aniket",Age=26,City="Amravati",Gender="Male"},
               new Student(){Id=4,Name="Sadhna",Age=23,City="Nashik", Gender = "Female"},
               new Student(){Id=5,Name="Priya",Age=24,City="Nashik", Gender = "Female"},
               new Student(){Id=6,Name="Vishal",Age=29,City="Amravati", Gender = "Male"},
           //    new Science(){Id=7,Name="Gaurav",Age=22,City="Nagpur", Gender = "Male",Section="Science"}
          };

          Console.WriteLine("List OF All Students");
          foreach (var item in students)
          {
              Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
          }
          Console.WriteLine();

          //   List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 12, 11, 8 };
          //  num.Reverse();
          *//*      var result=students.OrderBy(x => x.Name).ThenBy(x=>x.Age);
                  foreach (var item in result)
                  {
                      Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
                  }
          */
        /*
        var result = students.OrderBy(x => x.City).ToLookup(x => x.City);
        var result1 = from n in students
                      orderby n.City
                      group n by n.City;

        foreach (var item in result)
        {

            if (item.Count() >= 2)
            {
                Console.WriteLine("City:-" + item.Key + " " + item.Count());
                foreach (var std in item)
                {
                    Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
                }
            }


        }
        Console.WriteLine("-------------TAKE---------");
        var res = students.Take(2);

        foreach (var std in res)
        {
            Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
        }
        Console.WriteLine("---------TAKEWHILE-----------------");
        var res1 = students.TakeWhile(a=>a.Id<3);

        foreach (var std in res1)
        {
            Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
        }
        Console.WriteLine("-----------TAKELAST---------------");
        var res2 = students.TakeLast(2).OrderByDescending(a=>a.Id);

        foreach (var std in res2)
        {
            Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
        }
        Console.WriteLine("--------------------------");


        Console.WriteLine("-------------SKIP---------");
         res = students.Skip(2).Take(1);

        foreach (var std in res)
        {
            Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
        }
        Console.WriteLine("---------SKIPWHILE-----------------");
         res1 = students.SkipWhile(a => a.Id < 3);

        foreach (var std in res1)
        {
            Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
        }
        Console.WriteLine("-----------SKIPLAST---------------");
         res2 = students.SkipLast(2).OrderByDescending(a => a.Id);

        foreach (var std in res2)
        {
            Console.WriteLine($"ID:{std.Id}  Name:{std.Name}  Gender:{std.Gender}  Age:{std.Age}  City:{std.City}");
        }
        Console.WriteLine("--------------------------");*/


        /*

         --- find the highest number or second third any numbers okay


         */

        /*   List<int> numbers = new List<int>();
           int a=0;
           for (int i=1;i<=50;i++)
           {
               a=a+i;
               numbers.Add(a);
           }
           foreach (var item in numbers)
           {
               Console.Write(item+",");
           }
           Console.WriteLine(" ---------------");
           var result = numbers.OrderByDescending(a=>a).Skip(3).Take(1);
           foreach (var item in result)
           {
               Console.Write(item+",");
           }*/


        /*  List<int> num = new List<int>();
          num.Add(20);
          num.Add(30);
          num.Add(50);
          num.Add(25);
          students.Sort(new StudentHelper());


          foreach (var item in students)
          {
              Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
          }*/

        /*  List<Student> students = new List<Student>()
               {
                    new Student(){Id=1,Name="Shrikant",Age=24,City="Gondia",Gender="Male"},
                    new Student(){Id=2,Name="Akash",Age=27,City="Yavatmal",Gender="Male" },
                    new Student(){Id=3,Name="Aniket",Age=26,City="Amravati",Gender="Male"},
                    new Student(){Id=4,Name="Sadhna",Age=23,City="Nashik", Gender = "Female"},
                    new Student(){Id=5,Name="Priya",Age=24,City="Nashik", Gender = "Female"},
                    new Student(){Id=6,Name="Vishal",Age=29,City="Amravati", Gender = "Male"},
                    new Science(){Id=7,Name="Gaurav",Age=22,City="Nagpur", Gender = "Male",Section="Science"}
               };

                Console.WriteLine("List OF All Students");
                foreach (var item in students)
                {
                    Console.WriteLine($"ID:{item.Id}  Name:{item.Name}  Gender:{item.Gender}  Age:{item.Age}  City:{item.City}");
                }
                Console.WriteLine();

                IEnumerable<string> name = students.Select(x => x.City);
                var res = name.Where(a => a== "Amravati");



                int s = res.Count();
                Console.WriteLine(s);*/

        /*      List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6 };
              IEnumerable<int> list = num.Select(i => i);
              int m1 = num.Sum();
              Console.WriteLine(m1);
              m1 = num.Count();
              Console.WriteLine(m1);
              double x = num.Average();
              Console.WriteLine(x);

              bool m = num.SequenceEqual(list);
              Console.WriteLine(m);
              bool b = num.All(a => a > 5);
              Console.WriteLine(b);
              b = num.Contains(5);
              Console.WriteLine(b);*/
        #region Element Operator

        /*  List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
          int a = num.ElementAt(2);
          int b = num.FirstOrDefault(a=>a>3);
          Console.WriteLine(b);

          Console.WriteLine(a);*/

     
        

        #endregion

        Console.ReadLine();
    }
}


class A
{
    protected void PrintA()
    {
        Console.WriteLine("called");
    }
}
class B : A
{
    new protected void PrintA()
    {
        Console.WriteLine("called");
    }
}


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string City { get; set; }
}
class StudentHelper : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

class Science : Student
{
    public string Section;

    public Science()
    {
        Section = "Science";
    }
}