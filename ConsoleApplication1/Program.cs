using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        private static float num1;
        private static float num2;
        private static int num3;
        static void Main(string[] args)
        {
            while(true){
            while (true)
            {
                Console.WriteLine("请输入两个数"); 
                try
                {
                    Console.Write("请输入第一个数：");
                    num1 = float.Parse(Console.ReadLine());
                    Console.Write("请输入第二个数：");
                    num2 = float.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }           
            Console.WriteLine("请选择要进行的算法：\t1.加法\t2.减法\t3.乘法\t4.除法");
            num3 = int.Parse(Console.ReadLine());
            switch (num3) { 
                case 1:
                    Console.WriteLine(add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(minus(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(ride(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(eliminate(num1, num2));
                    break;           
            }
            Console.WriteLine("是否继续运算，继续请按y，退出请按n，按Enter确定");
            string str = Console.ReadLine();
            if (str.Equals("n"))
                break;
}

        }
        private static float add(float num1,float num2){
            return num1 + num2;        
        }
        private static float minus(float num1, float num2)
        {
            return num1 - num2;
        }
        private static float ride(float num1, float num2)
        {
            return num1*num2;
        }
        private static float eliminate(float num1, float num2)
        {
            return num1 / num2;
        }
    }
    
}
