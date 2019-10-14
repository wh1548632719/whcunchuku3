using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {   Caculate cac = new Caculate();
            string str = "";
            string result = "";
            Console.WriteLine("请输入第一个字符串");
            cac.m = Console.ReadLine();
            str = cac.m;
            result = System.Text.RegularExpressions.Regex.Replace(str, @"[0-9]+", "");
            if (string.IsNullOrEmpty(result))
            {
                cac.x = Convert.ToInt32(str);
                Console.WriteLine("请输入符号");
                cac.symbol = char.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个字符串");
                cac.z = Console.ReadLine();
                str = cac.z;
                for (int i = 0; i < str.Length; i++)
                {
                    result = System.Text.RegularExpressions.Regex.Replace(str, @"[0-9]", " ");

                }
                if (!string.IsNullOrEmpty(result))
                {

                    cac.y = Convert.ToInt32(str);
                    Console.WriteLine("计算结果是{0}", cac.Cac(cac.x, cac.y));
                }
                else
                {
                    Console.WriteLine("计算结果是{0}", cac.Cac(ref cac.m, ref cac.z));
                }

            }
            else
            {
                Console.WriteLine("请输入符号");
                cac.symbol = char.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个字符串");
                cac.z = Console.ReadLine();
                Console.WriteLine("计算结果是{0}", cac.Cac(ref cac.m, ref cac.z));
            }
        }
      
        class Caculate
        {
            public int x, y;
            public string m, z;

            public char symbol;
            public int Cac(int a, int b)
            {
                if (symbol == '+')
                {
                    return x + y;
                }
                else
                {
                    return x - y;
                }
            }
            public  string Cac(ref string a,ref string b)
            {
                if (symbol== '+')
                {
                    return m + z;
                }
                else
                    return m.Replace(z, " ");
            }                       
        }
    }
}
