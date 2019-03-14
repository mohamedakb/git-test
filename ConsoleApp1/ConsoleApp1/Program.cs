using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] toAddress = new string[] { "PHettiarachchi@patties.com.au" };
            try
            {
                //Notifications.SendEmail(toAddress, "GL Test", "GL Test");
                Notifications.SendEmail1();
                Console.WriteLine("Mail sent");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();
        }
    }
}
