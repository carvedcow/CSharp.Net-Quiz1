using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Net_Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your name :
            //Chun Fei Johnny Tiu 0777813

            //1 - Which Statement is correct ?
            //a.Properties of anonymous types will be read - only properties so you cannot change their values.
            //b.A dynamic type escapes type checking at run time.
            //c.Struct can declare a default constructor like a class
            //d. Partial classes can have different class names.
            Console.WriteLine("1- ============================================================");
            Console.WriteLine("A. Properties of anonymous types will be read - only properties so you cannot change their values.");

            //2- Create a class Name is as Employee(id, name, salary)
            //a.Use a generic collection to put 5 employees in that. (Use optional data)
            //b.Iterate through the collection and Write the name of the employee in the console.
            //c.Use delegate to find the lowest and highest salary among the employee
            Console.WriteLine();
            Console.WriteLine("2- ============================================================");
            List<Employee> lEmployees = new List<Employee>();
            lEmployees.Add(new Employee(1, "John", 10000));
            lEmployees.Add(new Employee(2, "Jones", 20000));
            lEmployees.Add(new Employee(3, "Jim", 30000));
            lEmployees.Add(new Employee(4, "Jimmy", 25000));
            lEmployees.Add(new Employee(5, "Jason", 15000));

            Console.WriteLine("Employee names inside lEmployees List:");
            lEmployees.ForEach(emp => Console.WriteLine(emp.name));

            CalculateSalary maxSalary = highestSalary;
            CalculateSalary minSalary = lowestSalary;
            Console.WriteLine($"Highest salary within lEmployees: {maxSalary(lEmployees)}");
            Console.WriteLine($"Lowest salary within lEmployees: { minSalary(lEmployees)}");


            //3- Use Tuple to create an object which has 3 fields (name, age, address) and print the fields in the console.
            //a.User Interpolation => $””
            //b.Use Format ({0})
            Console.WriteLine();
            Console.WriteLine("3- ============================================================");
            var person = Tuple.Create<string, int, string>("John", 30, "Montreal");
            Console.WriteLine("name: {0}", person.Item1);
            Console.WriteLine($"age: {person.Item2}       address:{person.Item3}");

            //4- Use Dictionary to keep the values of Information of 5 employees in question 2.
            //a.Use employeeId as the key and the office address as the value.
            Console.WriteLine();
            Console.WriteLine("4- ============================================================");
            Dictionary<int, string> empList = new Dictionary<int, string>();
            empList.Add(1, "John");
            empList.Add(2, "Jones");
            empList.Add(3, "Jim");
            empList.Add(4, "Jimmy");
            empList.Add(5, "Jason");

            foreach (KeyValuePair<int, string> e in empList)
            {
                Console.WriteLine("Key: {0}, Value:{1}", e.Key, e.Value);
            }

            //5- Create a Generic Class the only accepts class reference
            Console.WriteLine();
            Console.WriteLine("5- ============================================================");

            // MyGenericClass<int> genericInt;
            MyGenericClass<string> genericString;
            Console.WriteLine("MyGenericClass cannot accept <int> as a type but accepts <string> since only <string> is a reference type.");

            //6- Use Extension method for integer to check if the number is dividable by 3
            Console.WriteLine();
            Console.WriteLine("6- ============================================================");

            int i = 5;
            int j = 6;
            Console.WriteLine($"5 is dividable by 3: { i.IsDividableBy(3)}");
            Console.WriteLine($"6 is dividable by 3: { j.IsDividableBy(3)}");

            //7- Write a method that has one string parameter.By Using predicate check if that string has vowel sounds and print all the vowel sounds in the output.
            Console.WriteLine();
            Console.WriteLine("7- ============================================================");

            ArrayList vowels = new ArrayList() { "a", "e", "i", "o", "u" };
            Predicate<string> containsVowels = (string s) =>
            {
                bool result = false;
                foreach (string v in vowels)
                {
                    if (s.Contains(v))
                    {
                        Console.WriteLine($"'{v}'");
                        result = true;
                    }
                }
                return result;
            };

            string s = "hello";
            if (containsVowels(s))
            {
                Console.WriteLine($"The string '{s}' contains vowel(s)");
            }
            else
            {
                Console.WriteLine($"The string '{s}' contains no vowels");
            }

            //8- (Bonus) Use Event/Func/Action/delegate with 2 classes (student, RegisterStudentOperation). If
            //the student graduates, notifies the RegisterStudentOperation and Prints a message in the
            //console.
            Console.WriteLine();
            Console.WriteLine("8- ============================================================");
        }

        // 2- methods ============================================================
        public delegate int CalculateSalary(List<Employee> listEmployees);
        public static int highestSalary(List<Employee> listEmployee)
        {
            int highestSalary = 0;
            foreach (Employee e in listEmployee) 
            {
                if (e.salary > highestSalary)
                {
                    highestSalary = e.salary;
                }
            }
            return highestSalary;
        }

        public static int lowestSalary(List<Employee> listEmployee)
        {
            int lowestSalary = int.MaxValue;
            foreach (Employee e in listEmployee)
            {
                if (e.salary < lowestSalary)
                {
                    lowestSalary = e.salary;
                }
            }
            return lowestSalary;
        }

    }
}
