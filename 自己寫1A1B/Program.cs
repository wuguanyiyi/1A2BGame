using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自己寫1A1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1A1B猜數字

            // 
            string[] arrRnd = new string[4];//宣告一個arrRnd陣列
            Random rnd = new Random();//隨機亂數
            for(int i = 0; i < 4; i++)//亂數跑四次
            {
                if(i== 0)
                arrRnd[i] = Convert.ToString(rnd.Next(0,9));//10個數字，字串轉換成陣列
            }

            Console.ReadKey();
        }
    }
}
