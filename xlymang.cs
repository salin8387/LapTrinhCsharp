using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANG
{
    internal class xlymang
    {
        
        public static int[] a;
        public static int i, tong = 0;
        private static int n;
       protected static void nhapmang()
        {
            Console.WriteLine("Nhập số phần tử của mảng:");
            n = int.Parse(Console.ReadLine());
            xulymang.a = new int[n];// sau khi nhập n sẽ tạo mảng
            for (xulymang.i = 0; xulymang.i < n; xulymang.i++)
            {
                Console.WriteLine("Nhập phần tử thứ a[{0}]", xulymang.i);
                xulymang.a[xulymang.i] = int.Parse(Console.ReadLine());
                xulymang.tong = xulymang.tong + xulymang.a[xulymang.i];
            }
        }
        public void inmang()
        {
            Console.WriteLine("Mảng vừa nhập là:");
            for (xulymang.i = 0; xulymang.i < n; xulymang.i++)
            {
                Console.WriteLine(xulymang.a[xulymang.i]);
            }
            Console.WriteLine("Tổng các phân tử trong mảng là: {0}", xulymang.tong);
            Console.ReadLine();
        }
    }
}
