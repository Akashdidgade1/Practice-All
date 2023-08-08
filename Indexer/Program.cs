/*
            --- THORY -----
    0) Arrey type class 
    0)  
 
 *//*
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Student[] std = new Student[]
        {
           new Student(){Id=1,Name="Akshay",Gender="Male",Age=25},
           new Student(){Id=2,Name="Gaurav",Gender="Male",Age=24},
           new Student(){Id=3,Name="Prashant",Gender="Male",Age=21},
           new Student(){Id=4,Name="Gaurav",Gender="Male",Age=29},
           new Student(){Id=5,Name="Ujwal",Gender="Male",Age=19},
        };

        Institute inst = new Institute(std);

        //   string name = inst[4];// return string int se name chahiye
        Student name = inst["Ujwal"];
        Console.WriteLine(name.Name + " age is " + name.Age + "  and gender is " + name.Gender);
        Console.ReadLine();
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
}
public class Institute
{
    public String InstituteName { get; set; }
    Student[] _student;

    public Institute(Student[] std)
    {
        _student = std;
        InstituteName = "Vhash TEch";
    }
    public Student this[int id]
    {
        get
        {
            for (int i = 0; i < _student.Length; i++)
            {
                if (_student[i].Id == id)
                {

                    return _student[i];
                }

            }
            return null;
        }
    }
    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _student.Length; i++)
            {
                if (_student[i].Name == name)
                {

                    return _student[i];
                }

            }
            return null;
        }
    }

}*/
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}


public class Institute
{
    public Student[] _students;
    public string InstituteName;

    public Institute(Student[] students)
    {
        _students = students;
        InstituteName = "Siksha Is Raksha";
    }
    public Student this[int id]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Id == id)
                {
                    return _students[i];
                }
            }
            return null;
        }
    }
    public Student this[string name]
    {
        get
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Name == name)
                {
                    return _students[i];
                }
            }
            return null;

        }
    }
}
class Program
{
    static void Main()
    {
        Student[] std = new Student[]
        {
            new Student(){Id=1,Name="Akash",Age=20},
            new Student(){Id=2,Name="Vishal",Age=30},
            new Student(){Id=3,Name="Prashant",Age=25},
        };
        Institute ints = new Institute(std);
        Student name = ints[2];
        Console.WriteLine(name.Name+ " "+ name.Age);



        Console.ReadLine();
    }
}
