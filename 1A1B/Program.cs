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
                    arryRndnum[i]=Convert.ToString(rand.Next(0,9));//共10個數字
                    if (arryRndnum[0] == "0")//第一個亂數=0 (不能=0)
                    {
                        arryRndnum[0]= Convert.ToString(rand.Next(1,9));//???
                    }
                    for(int j = 0; j < i; j++)//
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
                for(int k = 1; k != 0; k++)
                {
                    int a = 0, b = 0;
                    Console.WriteLine("---");
                    Console.WriteLine("請輸入不重複的4個數字");
                    string playNum =Console.ReadLine();
                    Console.WriteLine(playNum);
                    for(int j = 0; j < 4; j++)
                    {
                        plNum[j] = Convert.ToString(playNum[j]);
                    }
                    for(int i = 0; i < 4; i++)
                    {
                        for(int j = 0; j < 4; j++)
                        {
                            if (playNum[j]== playNum[i])
                            {
                                if (i == j)
                                {
                                    a++;
                                }
                                else
                                {
                                    b++;
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
                string yn = Console.ReadLine();
                if (yn == "no")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
