using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A1B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int z=1;z!=0;z++)
            {
                string[] arryRndnum = new string[4]; //亂數陣列
                string[] plNum = new string[4]; //猜數字陣列

                Random rand = new Random(); //隨機亂數
                for(int i = 0; i < 4; i++) //隨機亂數跑四次
                {
                    arryRndnum[i]=Convert.ToString(rand.Next(0,9));//共10個數字，字串轉陣列
                    if (arryRndnum[0] == "0")//第一個亂數=0 (不能=0)
                    {
                        arryRndnum[0]= Convert.ToString(rand.Next(1,9));//跑1-10隨機亂數，字串轉陣列
                    }
                    for(int j = 0; j < i; j++)//arryRndnum[0] != "0"跑迴圈 
                    {
                        if (arryRndnum[j]== arryRndnum[i]) 
                        {
                            j = 0;
                            arryRndnum[i] =Convert.ToString(rand.Next(0,9));
                        }
                    }
                    Console.WriteLine(arryRndnum[i]);
                }

                Console.WriteLine("歡迎來到1A1B猜數字遊戲");
                for(int k = 1; k != 0; k++)//玩家輸入，次數不限
                {
                    int a = 0, b = 0;//宣告int型態的a、b變數
                    Console.WriteLine("---");
                    Console.WriteLine("請輸入不重複的4個數字");
                    string playNum =Console.ReadLine();//讀取玩家輸入的四個數字
                    Console.WriteLine(playNum);
                    for(int j = 0; j < 4; j++)
                    {
                        plNum[j] = Convert.ToString(playNum[j]);
                    }
                    for(int i = 0; i < 4; i++)
                    {
                        for(int j = 0; j < 4; j++)
                        {
                            if (plNum[j] == arryRndnum[i])
                            {
                                if (i == j)
                                {
                                    a = a + 1;
                                }
                                else
                                {
                                    b = b + 1;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"判定結果是{a}A{b}B");
                    if (a == 4)
                    {
                        Console.WriteLine("恭喜你!猜對了!!!");
                        break;
                    }
                }

                Console.WriteLine("是否要繼續遊玩?(yes/no)");
                string yn = Console.ReadLine();//讀取輸入
                if (yn == "no")//如果輸入no
                {
                    break;//跳出最外框迴圈程式
                }
            }
            Console.ReadKey();
        }
    }
}