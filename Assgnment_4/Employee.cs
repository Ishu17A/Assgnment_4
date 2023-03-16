using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgnment_4
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Technology { get; set; }
        public string Company_name { get; set; }
        public int Userid { get; set; }

        public Employee(string name, string department, string technology, string companyName, int userid)
        {
            this.Name = name;
            this.Department = department;
            this.Technology = technology;
            this.Company_name = companyName;
            this.Userid = userid;
        }
    }
}
