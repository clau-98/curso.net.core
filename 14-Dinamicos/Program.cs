using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int miEntero = 0;
            dynamic miDynamicVar = 1;
            Console.WriteLine(miEntero.GetType());
            Console.WriteLine(miDynamicVar.GetType());

            dynamic miDynamicVar1 = 100;
            Console.WriteLine("value :{0} type: {1}", miDynamicVar1, miDynamicVar1.GetType());


             miDynamicVar1= "Hello World";
            Console.WriteLine("value :{0} type: {1}", miDynamicVar1, miDynamicVar1.GetType());

            miDynamicVar1 = true;
            Console.WriteLine("value :{0} type: {1}", miDynamicVar1, miDynamicVar1.GetType());

             miDynamicVar1 = DateTime.Now;
            Console.WriteLine("value :{0} type: {1}", miDynamicVar1, miDynamicVar1.GetType());

            dynamic d1 = 100;
            int i = d1;

            d1 = "Hello";
            string greet = d1;

            d1 = DateTime.Now;
            DateTime dt = d1;

            dynamic estudiante = new Estudiante();
            estudiante.DisplayStudentInfo(10);
            Console.ReadLine();
        }
    }
}
