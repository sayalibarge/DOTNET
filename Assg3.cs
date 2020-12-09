using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Create an array of Employee class objects
//        Accept details for all Employees
//        Display the Employee with highest Salary
//        Accept EmpNo to be searched.Display all details for that employee.
namespace Assg3_Q1
{
    class Emp
    {
        private int empno;
        private decimal salary;
        private string name;
        private string dept;

        public Emp(int empno,decimal salary,string name,string dept)
        {
            this.empno = empno;
            this.salary = salary;
            this.name = name;
            this.dept = dept;

                 
        }
        public override string ToString()
        {
            return string.Concat("Empno : " ,empno,  "Salary : " , salary, "Name : ",name, "Dept:",dept);

        }
        public decimal Salary
        {
            get
            {
                return salary;
            }

        }
        public int Empno
        {
            get
            {
                return empno;
            }
        }

    }
    class Que1
    {
        static void Main2()
        {

            Console.WriteLine("enter size of array:");
            Emp[] arr = new Emp[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("enter empno:");
                int empno = Convert.ToInt32(Console.ReadLine());


                Console.Write("enter name:");
                string name = Console.ReadLine();

                Console.Write("enter salary:");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("enter dept no:");
                string dept = Console.ReadLine();


                Emp e = new Emp(empno, salary, name, dept);
                arr[i] = e;
                Console.WriteLine();

            }
            foreach(Emp e in arr)
            {
                Console.WriteLine(e.ToString());
            }
            decimal sal;
            sal = arr[0].Salary;

            foreach(Emp item in arr)
            {
                if(item.Salary > sal)
                {
                    sal = item.Salary;
                }
            }
            Console.WriteLine("max sal:"+sal);

            Console.WriteLine("enter empno:");
            int no = Convert.ToInt32(Console.ReadLine());

            foreach (Emp item in arr)
            {
                if (item.Empno == no)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.ReadLine();


        }
    }

    
}  

//2.CDAC has certain number of batches. each batch has certain number of students
//         accept number of batches from the user. for each batch accept number of students.
//         create an array to store mark for each student. 
//         accept the marks.
//         display the marks.
//Create a struct Student with the following properties. Put in appropriate validations.
//string Name
//int RollNo
//decimal Marks
//Create a parameterized constructor.
//Create an array to accept details for 5 students


namespace Assg3_Q2
{
    class Que2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of batches : ");
            int batches = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[batches][];

            Console.WriteLine("no of batches: " + arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter no of students of batch {0} ", i);
                int sizeStd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("size of std: " + sizeStd);
                int[] marks = new int[sizeStd];

                Console.WriteLine("Enter marks of students of batch {0} ", i);
                for (int j = 0; j < sizeStd; j++)
                {
                    marks[j] = Convert.ToInt32(Console.ReadLine());
                }
                arr[i] = marks;

            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

/*
3. Create a struct Student with the following properties. Put in appropriate validations.
string Name
int RollNo
decimal Marks

Create a parameterized constructor.

Create an array to accept details for 5 students
*/

namespace Assg3_Q3
{
    class Que3
    {


        static void Main3()
        {
            Console.WriteLine("Enter no of student:");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] s = new Student[size];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Student Roll no");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Student Mark");
                decimal mark = Convert.ToDecimal(Console.ReadLine());
                Student s1 = new Student(no, name, mark);
                s[i] = s1;
            }
            foreach (Student a in s)
            {
                Console.WriteLine(a.RollNo + " " + a.Name + " " + a.Mark);
            }
            Console.ReadLine();


        }
    }
    public struct Student
    {
        string name;
        private int rollno;
        decimal marks;

        public string Name
        {
            set
            {

                if (value != null)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return name;
            }
        }
        public int RollNo
        {
            set
            {
                if (value > 0)
                {
                    this.rollno = value;
                }

            }
            get
            {
                return this.rollno;
            }
        }
        public decimal Mark
        {
            set
            {
                if (value > 0)
                {
                    this.marks = value;
                }
            }
            get
            {
                return marks;
            }
        }
        public Student(int roll, string name, decimal mark)
        {



            this.rollno = roll;
            this.name = name;
            this.marks = mark;
        }
    }
}
