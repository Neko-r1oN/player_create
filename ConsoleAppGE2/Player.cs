using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGE2
{
    class Player
    {

        private bool i = true;
        private string name = "";
        private int attack = 0;
        private int defense = 0;
       
        /// <summary>
        /// ステータス入力処理
        /// </summary>
        public void CreatePlayer()
        {

            Console.Write("\n名前を入力＞ ");  // 文字列を表示
            this.name = Console.ReadLine();     // 名前の入力

            /// 攻撃力入力
            while (i == true)
            {

                Console.Write("攻撃力を入力＞");
                if (int.TryParse(Console.ReadLine(), out attack))
                {
                    i = false;
                }
                else if (attack > 100 || attack <= 0)
                {
                    Console.WriteLine("入力された数値が上限より上、または認識されませんでした");


                }

            }
            ///防御力入力
            while (i == false)
            {
                Console.Write("防御を入力＞");
                if (int.TryParse(Console.ReadLine(), out defense))
                {
                    i = true;
                }
                else if (defense > 100 || defense <= 0)
                {
                    Console.WriteLine("入力された数値が上限より上、または認識されませんでした");


                }
                else
                {
                    Console.WriteLine("入力された数値が上限より上、または認識されませんでした");


                }
            }
            Console.Clear();

        }
        /// <summary>        
        /// 出力処理
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defense"></param>
        /// <param name="luck"></param>
        public void ShowPlayer()
        {

            Console.WriteLine("名前：{0}, 攻撃力：{1}, 防御力：{2}\n", name, attack, defense);
        }

    }
}


