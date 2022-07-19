using ExceptionHomework.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHomework.Auth
{
    public class Account
    {
        public static void Login(string name, int pascode)
        {
            try
            {
                string n = "fidash.13";
                int m = 12345;

                if (pascode == m && (name == n))
                {
                    throw new LoginException("Girish olundu");
                }
                Console.WriteLine("Girish olunmadi");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
