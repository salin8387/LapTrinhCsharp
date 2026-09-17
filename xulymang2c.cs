using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANG
{
    class xulymang2c
    {
       
        public static int[,] diem = new int[2, 3];
        public static string[] monhoc = { "LTC#.Net", "Toán" };
        public static int i, j;
    }
    class nhapmang()
    {
        public void nhapmang2c()
        {
            for(xulymang2c.i=0;xulymang2c.i<2;xulymang2c.i++)
            {
                Console.Write(" Tên môn thứ {0}:", xulymang2c.i+1);
                Console.WriteLine(xulymang2c.monhoc[xulymang2c.i]);
                for(xulymang2c.j=0; xulymang2c.j<3; xulymang2c.j++)
                {
                    Console.WriteLine("Nhập điểm D{0}:", xulymang2c.j+1);
                    xulymang2c.diem[xulymang2c.i, xulymang2c.j] = int.Parse(Console.ReadLine());
                }    
                
            }    
        }
       
        
        public void inpmang2c()
        {
            Console.WriteLine(" danh sách điểm vừa nhập: ");
            Console.WriteLine("Tên môn");
            Console.WriteLine("\t D1 \t D2 \t D3");


            for (xulymang2c.i = 0; xulymang2c.i < 2; xulymang2c.i++)
            {
                Console.WriteLine(xulymang2c.monhoc[xulymang2c.i]);
                for (xulymang2c.j = 0; xulymang2c.j < 3; xulymang2c.j++)
                {
                    Console.Write("\t" + xulymang2c.diem[xulymang2c.i,xulymang2c.j]);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
