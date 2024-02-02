using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {0, 1, 2, 3, 4 };
            Right right = new Right();
            int K = 2;
            int M = 0;
            while (M < K)
            {
                right.RigthRotate(arr);
                M++;
            }
            

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
    public class Right
    {
        public void RigthRotate(int[] arr)
        {
            int x = arr[arr.Length - 1];
            for (int i = (arr.Length - 1); i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = x;
        }
    }
}