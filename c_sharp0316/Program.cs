using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp0316
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("請輸入你的分數");
            score = Convert.ToInt32(Console.ReadLine());
            string result = score >= 60 ? "及格" : "不及格";
            Console.WriteLine("這次你{0}",result);
            Console.ReadLine();
        }
    }
}
