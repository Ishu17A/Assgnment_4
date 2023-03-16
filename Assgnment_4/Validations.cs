using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assgnment_4
{
    public class Validations
    {
        public int CheckId()
        {
            int res;
            while(!int.TryParse(Console.ReadLine(), out  res))
            {
                Console.WriteLine("Please Provide Valid Input");
            }
            return res;
        }
        public string CheckString()
        {
            string user = Console.ReadLine();
            string pattern = @"^[A-Za-z\s]+$";
            while(!Regex.IsMatch(user, pattern))
            {
                Console.WriteLine("Invalid");
                user = Console.ReadLine();
            }
            return user;
        }
    }
}
