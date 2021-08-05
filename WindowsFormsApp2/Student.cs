using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    

    public class Student
    {
        public string studentNo = "";
        public string firstName = "";
        public string secondName = "";
        public Student(string number, string first, string second)
        {
            studentNo = number;
            firstName = first;
            secondName = second;
        }
    }
}
