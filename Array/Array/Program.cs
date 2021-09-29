using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
            Book b = new Book("Title","Tanvir",2.00);
            Console.WriteLine(b.Author);
            //Book b2 = new Book();
            var c = new JavaScriptSerializer().Serialize(b);
            Console.WriteLine(c);

            Book[] books= new Book[5];
            books[0] = new Book("Padma Nodir Majhi","Manik Ban",240.00);
            books[1] = b;
            c = new JavaScriptSerializer().Serialize(books);
            Console.WriteLine(c);
            var d = new JavaScriptSerializer().Deserialize<Book[]>(c);
            Console.WriteLine(d.Length);
            for (int i = 0; i < 2; i++) {
                d[i].Show();
                Console.WriteLine("-----------------------");
            }

            int[,] arr = new int[2, 7];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;

            int k = 1;
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 7; j++) {
                    arr[i, j] = k++;
                }
            }

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 7; j++) {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }



            /*numbers[0] = 1;
            numbers[1] = 2;

            int[] numbers2;
            numbers2 = new int[5];

            int[] numbers3 = new int[] { 1,2,3,4,5,6,7,8,9,0};
            int[] numbers4 =  { 1, 2, 3, 4, 4, 5, 6, 7 };*/



        }
    }
}
