using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte by = 255;
            // byte by2 = -155; // error 
            sbyte sb1 = -128;
            sbyte sb2 = 127;

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", by.GetType(), System.Byte.MaxValue, System.Byte.MinValue);
            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", sb1.GetType(), System.Byte.MaxValue, System.Byte.MinValue);

            //---------------------------------------------------------------------------------------------------------------------

            short s1 = -32768;
            short s2 = 32767;
            //short s3 = 35000; //error

            ushort us1 = 65535;
            //ushort us2 =-32000 //Error

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", s1.GetType(), System.UInt16.MaxValue, System.UInt16.MinValue);
            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", us1.GetType(), System.UInt16.MaxValue, System.UInt16.MinValue);

            //----------------------------------------------------------------------------------------------------------------------

            int i = -2147483648;
            int j = 2147483647;

            uint ui1 = 4294967295;

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", i.GetType(), System.UInt32.MaxValue, System.UInt32.MinValue);
            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", ui1.GetType(), System.UInt32.MaxValue, System.UInt32.MinValue);

            //---------------------------------------------------------------------------------------------------------------------------

            int hex = 0x2F;
            int binary = 0b_0010_1111;

            Console.WriteLine(hex);
            Console.WriteLine(binary);

            //_----------------------------------------------------------------------------------------------------------------------------------

            long l1 = -9223372036854775808;
            long l2 = 9223372036854775807;

            ulong ul1 = 18223372036854775808ul;
            ulong ul2 = 18223372036854775808UL;

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", l1.GetType(), System.UInt64.MaxValue, System.UInt64.MinValue);
            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", ul1.GetType(), System.UInt64.MaxValue, System.UInt64.MinValue);

            //_------------------------------------------------------------------------------------------------------------------------------

            float f1 = 123456.5F;
            float f2 = 1.123456f;

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", f1.GetType(), System.Single.MaxValue, System.Single.MinValue);

            //---------------------------------------------------------------------------------------------------------------------------

            double d1 = 12345678912345.5d;
            double d2 = 1.123456789123456d;

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", d1.GetType(), System.Double.MaxValue, System.Double.MinValue);

            //---------------------------------------------------------------------------------------------------------------------------

            decimal de1 = 123456789123456789123456789.5m;
            decimal de2 = 1.1234567891345679123456789123m;

            Console.WriteLine("Mximo de {0} y minimo {1} de {2}", de1.GetType(), System.Decimal.MaxValue, System.Decimal.MinValue);

            //---------------------------------------------------------------------------------------------------------------------------

            double d = 0.12e2;
            Console.WriteLine(d);  // 12;

            float f = 123.45e-2f;
            Console.WriteLine(f);  // 1.2345

            decimal m = 1.2e6m;
            Console.WriteLine(m);// 1200000


            Console.ReadLine();


        }
    }
}
