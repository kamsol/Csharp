using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        private static List<Employee> employee_list;

        static void Main(string[] args) {

            Console.WriteLine("--- This program show some examples of LINQ --- \n");



            var list = Enumerable.Range(0, 15);

            
            
            //Query style
            var oddNumber = from odd in list
                            where odd % 2 != 0
                            orderby odd descending
                            select odd;


            Console.WriteLine("--- Odd numbers  (descending order, 0-14) --- ");

            oddNumber.ToList().ForEach(odd => Console.WriteLine(odd));

            
            
            
            
            //linq to get all methods of string type 
            var allMthods = from s in typeof(string).GetMethods()
                            group s by s.Name into G
                            select new { Method_Name = G.Key, Method_Overload = G.Count() };

            Console.WriteLine("\n--- Strings available methods (skipr first 5 methods and then show only next five methods ---");
            foreach (var item in allMthods.Skip(5).Take(5))
            {
                Console.WriteLine(item);
            }

                       
            
            
            //Using lambda
            var evenNumber = list.Where(num => num % 2 == 0 && num <= 10);


            Console.WriteLine("--- Even numbers, 0-10 ---");

            foreach (var item in evenNumber)
            {
                Console.WriteLine(item);
            }


            var stringList = new List<string> { "88888888", "2", "kambiz", "333" };
            var lengthSum = stringList.Select( x => x.Length);

            Console.WriteLine("\n--- Length of strings ---");

            foreach (var item in lengthSum)
            {
                Console.WriteLine(item);
            }


            employee_list = new List<Employee>
        {
            new Employee{EmployeeID = 1, Name = "John Smith" , Title = "Manager", Salary = 60000},
            new Employee{EmployeeID = 2, Name = "Edward Burger" , Title = "Programmer", Salary = 55000},
            new Employee{EmployeeID = 2, Name = "Chris Mac" , Title = "Programmer", Salary = 55000},
            new Employee{EmployeeID = 3, Name = "Anthony Radd" , Title = "Accountant" , Salary = 50000},
            new Employee{EmployeeID = 4, Name = "Sara Style" , Title = "Secratary" , Salary = 40000},
        };

            
            
            // using let in query
            var high_salary_employees = from e in employee_list
                                        let tax_deducted_salary = e.Salary * .95
                                        where tax_deducted_salary > 50000
                                        select new { FirstName = e.Name.Split(' ')[0], Net_payment = tax_deducted_salary };

            Console.WriteLine("\n--- using let in query --- ");

            foreach (var item in high_salary_employees)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}

