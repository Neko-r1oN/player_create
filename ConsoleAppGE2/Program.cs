using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="パーティ情報"></param>
        static void Main(string[] args)
        {
            ///ループ用変数          
            int loop = 0;

            ///プレイヤー人数用変数           
            int PlayNum = 0;

            Console.Clear();

            ///プレイヤー人数設定
            while (loop == 0)
            {
                Console.Write("入力するプレイヤーの人数を入力してください＞");
                if (int.TryParse(Console.ReadLine(), out PlayNum))
                {
                    ///範囲内の人数
                    if (PlayNum <= 4 && PlayNum > 0)
                    {

                        ///ループを抜ける
                        loop++;
                    }
                    ///範囲外の人数
                    else
                    {
                        Console.WriteLine("入力された数値が上限より上、または認識されませんでした");

                    }
                }
                else
                {
                    Console.WriteLine("入力された数値が上限より上、または認識されませんでした");

                }
            }

            Console.Clear();

            // 配列を作成
            Player[] players = new Player[PlayNum];

            // インスタンス生成
            for (loop = 0; loop < PlayNum; loop++)
            {// プレイヤー人数分ループ
                players[loop] = new Player();
            }

            // ステータス入力
            for (loop = 0; loop < PlayNum; loop++)
            {

                Console.Write(loop + 1);
                Console.WriteLine("人目のステータスを入力");

                players[loop].CreatePlayer();

            }

            ///プレイヤー情報出力
            Console.Write("\nプレイヤー情報\n\n ");  // 文字列を表示
            for (loop = 0; loop < PlayNum; loop++)
            {
                //プレイヤー人数分ループ
                Console.Write("{0}人目\n", loop + 1);  // 文字列を表示

                // メソッド：出力
                players[loop].ShowPlayer();
            }

            Console.Write("\nエンターを押して閉じる");
            Console.ReadLine();

        }
    }
}
