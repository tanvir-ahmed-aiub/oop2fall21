using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    //const,readonly,ref,out,static,params
    //var, dynamic
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a = 32;
            int c; //declaration
            c = 34; //assignment
            const int b=32;
            int x = 10; 
            int y = 12;

            Console.WriteLine("x={0} and y={1}", x, y); //10 and 12
            
            ServiceProvier.Swap(ref x, ref y);
            Console.WriteLine("x={0} and y={1}", x, y); //10 and 12

            int k;
            //Console.WriteLine("K = {0}", k);
            ServiceProvier.SetOut(out k);
            Console.WriteLine("K = {0}", k);

            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            Console.WriteLine(Student.Count);
            ServiceProvier.Add("Tanvir");
            ServiceProvier.Add("Tanvir",1);
            ServiceProvier.Add("Tanvir",1,2,3,4,5);
            ServiceProvier.Add("Tanvir",12,2);
            ServiceProvier.Add("Tanvir",1,1,4);



        }
    }
}
