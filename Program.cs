using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. decimal SimpleInterest(decimal P, decimal N, decimal R) -> returns calculated SimpleInterest
namespace Assg5_Q1
{
    class Program
    {
        static void Main1(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> o1 = (p, n, r) => (p * n * r) / 100;
            Console.WriteLine("Simple Interest :" + o1(2000, 100, 5));
            Console.ReadLine();
        }
    }
}
//2. bool IsGreater(int a, int b) -> returns true if a is > b
namespace Assg5_Q2
{
    class Program
    {
        static void Main2()
        {
            Func<int, int, bool> o2 = (a, b) => a > b;
            Console.WriteLine(o2(200, 100));
            Console.ReadLine();
        }
    }
}
//3. decimal GetBasic(Employee e) -> returns the Basic salary of the employee
namespace Assg5_Q3
{
    class Program
    {
        static void Main3(string[] args)
        {
            Employee e = new Employee();
            Func<Employee, decimal> o3 = emp => emp.getBasic(e);
            Console.WriteLine("Basic salary of Employee is : " + o3(e));
            Console.ReadLine();
        }
    }

    class Employee
    {
        public decimal basic = 1500;

        public decimal getBasic(Employee emp)
        {
            return emp.basic;
        }
    }

}
//4. bool IsEven(int num) -> returns true if the number is an even number
namespace Assg5_Q4
{
    class Program
    {
        static void Main4(string[] args)
        {
            Predicate<int> o = a => a % 2 == 0;
            Console.WriteLine(o(6));
            Console.ReadLine();
        }
    }
}
//5. bool IsGreaterThan10000(Employee e) -> returns true if the Basic Salary is > 10000

namespace Assg5_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Predicate<Employee> o5 = emp => emp.IsGreaterThan10000(e);
            Console.WriteLine("IsGreater = " + o5(e));
            Console.ReadLine();
        }
        class Employee
        {
            public decimal basic = 15000;

            public decimal getBasic(Employee emp)
            {
                return emp.basic;
            }

            public bool IsGreaterThan10000(Employee emp1)
            {
                return emp1.basic > 10000;
            }
        }

    }
}
