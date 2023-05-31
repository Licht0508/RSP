using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSP
{
    internal class Player
    {

        public Input input;

        /// <summary>
        /// Playerコンストラクタ
        /// </summary>
        Player()
        {
            input = new Input();
        }
        
        /// <summary>
        /// 出す手を決めるメソッド
        /// </summary>
        public void InputHand()
        {
            input.InputHand();
        }

        /// <summary>
        /// Playerの現在の手確認用メソッド
        /// </summary>
        /// <returns>現在の手</returns>
        public Hand GetHand() { return input.hand; }

    }
}
