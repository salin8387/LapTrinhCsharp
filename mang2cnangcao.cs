using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANG
{
    internal class mang2cnangcao
    {
        public static int[,] diem;
        public static string[] monhoc;
        public static string[] D = { "D1", "D2", "D3" };
       
        public static int i, j,m,n;
    }
    internal class nhapmang1
    {
        public void nhap2c()
        {
            Console.Write("Nhập số môn học:");// nhập số môn học
            mang2cnangcao.n=int.Parse(Console.ReadLine());
            mang2cnangcao.monhoc= new string[mang2cnangcao.n];
           mang2cnangcao.diem = new int[mang2cnangcao.n, 3];//khởi tạo mảng 2 chiều
            for (mang2cnangcao.i = 0; mang2cnangcao.i < mang2cnangcao.n; mang2cnangcao.i++)
            {
                Console.Write("Nhập môn thứ monhoc[{0}]: ", mang2cnangcao.i+1);
                mang2cnangcao.monhoc[mang2cnangcao.i] = Console.ReadLine();

                for (mang2cnangcao.j = 0; mang2cnangcao.j < 3; mang2cnangcao.j++)
                {
                    Console.Write(" Nhập điểm thứ diem {0}:", mang2cnangcao.j+1);

                    mang2cnangcao.diem[mang2cnangcao.i, mang2cnangcao.j] = int.Parse(Console.ReadLine());
                }
            }

        }
        public void inmang2c()
        {
            Console.WriteLine("\t\t D1 \t\t D2 \t\t D3");
            
            for (mang2cnangcao.i = 0; mang2cnangcao.i < mang2cnangcao.n; mang2cnangcao.i++)
            {
                Console.WriteLine(mang2cnangcao.monhoc[mang2cnangcao.i] + "\t\t");
                for (mang2cnangcao.j = 0; mang2cnangcao.j < 3; mang2cnangcao.j++)
                {
                    Console.Write("\t\t"+mang2cnangcao.diem[mang2cnangcao.i, mang2cnangcao.j] );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    }

