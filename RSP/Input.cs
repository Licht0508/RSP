using System;

namespace RSP
{
    class Input
    {
        public enum Hand
        {
            ROCK,
            SCISSORS,
            PAPER
        }
        public Hand hand = Hand.ROCK;

        /// <summary>
        /// 出す手を入力するメソッド
        /// </summary>
        public void InputHand()
        {
            bool canFinish = false;
            while (!canFinish)
            {
                Console.Write("Please enter Rock, Scissors or Paper : ");
                string str = Console.ReadLine();
                // 入力された手に応じて変数に格納する値を変更する
                switch (str)
                {
                    case "Rock":
                        hand = Hand.ROCK;
                        canFinish = true;
                        break;
                    case "Scissors":
                        hand = Hand.SCISSORS;
                        canFinish = true;
                        break;
                    case "Paper":
                        hand = Hand.PAPER;
                        canFinish = true;
                        break;
                    default:
                        canFinish = false;
                }
            }
        }
    }
}