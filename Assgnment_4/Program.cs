using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgnment_4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Assignment = 4*/

            List<Employee> authors = new List<Employee>();
            int userid = 0;
            Validations val = new Validations();
            while (true)
            {
                Console.Write("1-Add" + "\n" +
                    "2-Delete" + "\n" +
                    "3-Show " + "\n" +
                    "4-Exit" + "\n" +
                    "5-Update" + "\n");

                int value = val.CheckId();
                    switch (value)
                    {
                        case 1:
                            {
                                Console.WriteLine("Add Operation");
                                Console.WriteLine("Enter the details");
                                Console.WriteLine();

                                Console.WriteLine("NAME");
                                var b = val.CheckString();
                                Console.WriteLine("DEPT.");
                                var c = val.CheckString();
                            Console.WriteLine("technolody");
                                var d = val.CheckString();
                            Console.WriteLine("company Name");
                                var e = val.CheckString();
                            userid++;
                                Employee obj = new Employee(b, c, d, e, userid);
                                authors.Add(obj);
                                break;

                            }
                        case 2:
                            {
                                Console.WriteLine("Delete Operation");
                                Console.WriteLine("enter the index you want to remove : ");
                                var index = int.Parse(Console.ReadLine());
                                var itemToRemove = authors.Single(r => r.Userid == index);
                                authors.Remove(itemToRemove);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Show Table");
                                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", "ID", "Name", "DEPT.", "TECHNOLOGY", "COMPANY_NAME");
                                foreach (var item in authors)
                                {
                                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}", item.Userid, item.Name, item.Department, item.Technology, item.Company_name);
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Exit");
                                return;
                            }
                        case 5:
                            {
                                Console.WriteLine("update operation");
                                Console.WriteLine("enter the index you have to update ");
                                var updateId = int.Parse(Console.ReadLine());
                                var updateObj = authors.FirstOrDefault(x => x.Userid == updateId);
                                Console.WriteLine("UserId Found");
                                Console.WriteLine("Please Input the new values");
                                Console.WriteLine("Enter Name");
                                string nameInput = Console.ReadLine();
                                updateObj.Name = nameInput;
                                Console.WriteLine("ENTER DEPT.");
                                string deptinput = Console.ReadLine();
                                updateObj.Department = deptinput;
                                Console.WriteLine("ENTER TECHNOLOGY");
                                string technologyinput = Console.ReadLine();
                                updateObj.Technology = technologyinput;
                                Console.WriteLine("ENTER COMPANYNAME");
                                string companyinput = Console.ReadLine();
                                updateObj.Company_name = companyinput;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please Enter Valid input");
                                break;
                            }
                    }
               
                Console.ReadLine();
            }
        }
    }
}
