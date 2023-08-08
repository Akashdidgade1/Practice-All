//class Program
//{
//    static void Main()
//    {
//        Shape s = new Rectangle();
//        s.Area();
//        Teacher t1 = new Teacher();

//        foreach (var item in count(10))
//        {
//            Console.WriteLine(item);
//        }

//        Console.WriteLine(t1.GetType().FullName + " " + t1.GetType().Name);

//        Student[] students =
//   {
//        new Student(){Id=1,StudentName="Akashay"},
//        new Student(){Id=2,StudentName="Kartik"},
//        new Student(){Id=3,StudentName="Satish"},
//    };

//        Institute i1 = new Institute(students);
//        Student name = i1[2];
//        Console.WriteLine(name.Id + " " + name.StudentName);

//        Person p1 = new Person();
//        p1.specialityEmployee();
//        p1.Speciality();
//        Console.ReadLine();
//    }
//    //yeild



//    static IEnumerable<int> count(int num)
//    {
//        for (int i = 0; i <= num; i++)
//        {
//            yield return i;
//        }
//    }
//}
////Extension Method
//class Person
//{
//    public void Speciality()
//    {
//        Console.WriteLine("person");
//    }
//}
//static class Employee
//{
//    public static void specialityEmployee(this Person p)
//    {
//        Console.WriteLine("Emplyee type Person");
//        Console.WriteLine(p);
//    }
//}



//class Student
//{
//    public int Id { get; set; }
//    public string StudentName { get; set; }

//}

//class Institute
//{
//    private Student[] _student;
//    public string instituteNAme;

//    public Institute(Student[] student)
//    {
//        _student = student;
//    }
//    /*
//        public string this[int rn]
//        {
//            get
//            {
//                for (int i = 0; i < _student.Length; i++)
//                {
//                    if (_student[i].Id==rn)
//                    {
//                        return _student[i].StudentName;
//                    }
//                }
//                return "not found";
//            }
//        }*/
//    public Student this[int rn]
//    {
//        get
//        {
//            for (int i = 0; i < _student.Length; i++)
//            {
//                if (_student[i].Id == rn)
//                {
//                    return _student[i];
//                }
//            }
//            return null;
//        }
//    }

//}









//sealed class Teacher
//{
//    public Teacher()
//    {

//    }
//    public void PrintA()
//    {
//        Console.WriteLine("PrintA Called");
//    }
//}


//abstract class Shape
//{
//    public Shape()
//    {
//        Console.WriteLine("Shape Constructor called");
//    }
//    public abstract void Area();
//}

//class Rectangle : Shape
//{
//    public Rectangle()
//    {
//        Console.WriteLine("Rectangle class Constructor called");
//    }
//    public override void Area()
//    {
//        Console.WriteLine("Area: Length * Width");
//    }
//}


class program
{
    static void Main()
    {
        //Student s1 = new Student();
        //s1.PrintB();

        //String s = "Akash";
        //s.PrintC();
        Student[] s = new Student[]
        {
         new Student(){Rollnumber=1,Name="Akash",Gender="Male"},
         new Student(){Rollnumber=2,Name="Akansha",Gender="Female"},
         new Student(){Rollnumber=3,Name="Akashay",Gender="Male"}

        };

        Institute n1 = new Institute(s);
        string a = n1[2];
        Console.WriteLine(a);

        Student history = n1["Akansha"];
        Console.WriteLine($"Id : {history.Rollnumber}, Name: {history.Name}, Gender:{history.Gender}");


        Console.ReadLine();

    }


}
#region Extenstion Method
//class Student
//{

//    public static void PrintA()
//    {
//        Console.WriteLine("Print() is called");

//    }

//}

//static class StudentHelper
//{

//    public static void PrintB(this Student s)
//    {
//        Console.WriteLine("PrintB is Called()");

//    }

//    public static void PrintC(this String name)
//    {
//        Console.WriteLine("PrintB is Called()");

//    }

//}
#endregion

# region Indexer

class Student
{
    public int Rollnumber { get; set; }
    public string Name { get; set; }

    public string Gender { get; set; }


}

class Institute
{
    public string InstituteName = "V#Tech";

    Student[] _s1;

    public Institute(Student[] s1)
    {
        _s1 = s1;
    }

    public string this[int id]
    {
        get
        {
            for (int i = 0; i < _s1.Length; i++)
            {
                if (_s1[i].Rollnumber == id)
                {
                    return _s1[i].Name ;
                }



            }

            return null;
        }
    }

    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _s1.Length; i++)
            {
                if (_s1[i].Name == name)
                {
                    return _s1[i];
                }



            }

            return null;
        }
    }
}


#endregion
