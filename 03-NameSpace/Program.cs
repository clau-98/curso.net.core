using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NameSpace
{
    internal class Program
    {
     static void Main(string[] args)
        {
            School.Student student = new School.Student();
            School.Course course = new School.Course();

            School.Education.Student student1 = new School.Education.Student();
            School.Education.Course course1 = new School.Education.Course();
        }
    }
}
