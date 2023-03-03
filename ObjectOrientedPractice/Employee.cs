using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractice
{
    internal class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter the value for employee id");
            this.Id = Convert.ToInt32(Console.ReadLine());    // use this instead of employee because its in same project

            Console.WriteLine("Please enter the value for employee name");
            this.Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter the value for address");
            this.Address = Convert.ToString(Console.ReadLine());

        }
        public void ShowData()
        {
            Console.WriteLine("employee.Id=" + this.Id);
            Console.WriteLine("employee.Name=" + this.Name);
            Console.WriteLine("employee.Address=" + this.Address);
        }
    }
}
