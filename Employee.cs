using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Net_Quiz1
{
    class Employee
    {
        //2- Create a class Name is as Employee(id, name, salary)
        //a.Use a generic collection to put 5 employees in that. (Use optional data)
        //b.Iterate through the collection and Write the name of the employee in the console.
        //c.Use delegate to find the lowest and highest salary among the employee
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        
    }
}
