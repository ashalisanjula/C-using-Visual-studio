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

        
    }
}
