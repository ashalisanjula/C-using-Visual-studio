using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    internal class User
    {
        private string name;
        private string companyName;
        private int age;

        public User()
        {
            companyName = "ABC";
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get {return age;}
            set
            {
                if(value < 20)
                {
                    throw new ArithmeticException("Invalid Age");
                }
                age = value;
            }
        }
        
    }
}
