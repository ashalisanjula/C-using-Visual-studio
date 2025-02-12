using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    internal class StringIndeexerType
    {
        private string[] strArray = new string[10];
        public string this[int index]
        {
            get
            {
                if(index <0 || index >= strArray.Length)
                {
                    throw new ArgumentOutOfRangeException("index out of Range");
                }
                return strArray[index];
            }
            set { 
                if(index<0 || index >= strArray.Length)
                {
                    throw new ArgumentOutOfRangeException("index out of Range");
                    
                }
                else
                {
                    strArray[index] = value;
                }
            }
        }
    }
}
