namespace MANG
{
    internal class Program:xlymang
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //  nhapxulymang xl = new nhapxulymang();
            //  xl.nhapmang();
            // xl.inmang();
            //xlymang p = new xlymang();
            //  nhapmang();
            // p.inmang();
            //  nhapmang m2c = new nhapmang();
            // m2c.nhapmang2c();
            //  m2c.inpmang2c();
            nhapmang1 nm=new nhapmang1();
            nm.nhap2c();
            nm.inmang2c();



        }
    }
}
