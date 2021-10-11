using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class ServiceProvier
    {
        public static void Swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void SetOut(out int k) {
            k = 12;
            int j = 10 + k;
            //k = 121;
        }
        public static int Add(string name, params int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
        }
    }
}
