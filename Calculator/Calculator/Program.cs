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
            while (true)
            {
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
                switch (num3)
                {
                    case 1:
                        Console.WriteLine("是否进行字符串连接,是请按y，否则按n");
                        string str1 = Console.ReadLine();
                        if(str1.Equals("n"))
                            Console.WriteLine(add(num1, num2));
                        if (str1.Equals("y"))
                            Console.WriteLine(String.Concat(num1)+String.Concat(num2));
                        break;
                    case 2:
                        Console.WriteLine("是否进行字符串去除,是请按y，否则按n");
                        string str2 = Console.ReadLine();
                        if(str2.Equals("n"))
                            Console.WriteLine(add(num1, num2));
                        if (str2.Equals("y"))
                        {
                            string s1 = Convert.ToString(num1);
                            char[] c1 = s1.ToCharArray();
                            string s2 = Convert.ToString(num2);
                            char[] c2 = s1.ToCharArray();
                            int a=0;
                            if (c1.Length == 1)
                            {
                                for (int i = 0; i < c1.Length; i++)
                                {
                                    if (c1[i] != c2[0])
                                        a = i;
                                }
                                for (int i = 0; i < c1.Length; i++)
                                {
                                    if(a!=i)                                   
                                        Console.WriteLine(c1[i]);
                                }
                            }
                            else
                            {
                                //string str = "";
                                //str = num1.Replace(num2, "");
                                Console.WriteLine(s1.Replace(s2, ""));
                            }
                        }

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
        private static float add(float num1, float num2)
        {
            return num1 + num2;
        }
        private static float minus(float num1, float num2)
        {
            return num1 - num2;
        }
        private static float ride(float num1, float num2)
        {
            return num1 * num2;
        }
        private static float eliminate(float num1, float num2)
        {
            return num1 / num2;
        }
    }

}
