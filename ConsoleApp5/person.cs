using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class person
    {
    
        public string firstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string email
        {
            get { return email; }
            set
            {        
                    email = value;  
            }
        }
            public void GetFullName(string firstName,string lastName)
        {
            Console.WriteLine($"fullname is {firstName} {lastName}");
        }
        public void Print(string firstName,string lastName,string email)
        {
            Console.WriteLine($"fullname is {firstName} {lastName} ");
            if (email.Contains("@") == true && email.EndsWith("com") == true)
            { Console.WriteLine($"email is {email}"); }
            else
            {

                Console.WriteLine("Worang value");
            }

        }
    }
}
