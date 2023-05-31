using System;

namespace RSP
{

    public enum Hand
    {
        ROCK,
        SCISSORS,
        PAPER
    }
    class Input
    {
        
        public Hand hand;

        private Input()
        {
            hand = Hand.ROCK;
        }

        /// <summary>
        /// 入力を受け付けるメソッド
        /// </summary>
        private string AcceptEntry()
        {
            Console.Write("Please enter Rock, Scissors or Paper : ");
            string str = Console.ReadLine();
            return str;
        }

        /// <summary>
        /// 入力から手を出す手を判別するメソッド
        /// </summary>
        private Hand DetermineFromEntry(string str)
        {
            // 入力された手に応じて変数に格納する値を変更する
            switch (str)
            {
                case "Rock":
                    hand = Hand.ROCK;
                    break;
                case "Scissors":
                    hand = Hand.SCISSORS;
                    break;
                case "Paper":
                    hand = Hand.PAPER;
                    break;
                default:
                    break;
            }

            return hand;
        }

        /// <summary>
        /// 出す手を決定するメソッド
        /// </summary>
        /// <returns>出す手</returns>
        public Hand DetermineToPutHand()
        {
            string str = AcceptEntry();
            return DetermineFromEntry(str);
        }
    }
}