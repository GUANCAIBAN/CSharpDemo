using System;
using System.IO;
namespace CSharpDemo
{
    class Demo1
    {
        public void byte2file() {
            byte[] dllarray = new byte[] { 0x4d, 0x5a };
            FileStream fsWrite = File.Create("file");
            fsWrite.Write(dllarray, 0, dllarray.Length);

        }
    }
    class executeDemo {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Demo1 D1 = new Demo1();
            D1.byte2file();

        }

    }
}
