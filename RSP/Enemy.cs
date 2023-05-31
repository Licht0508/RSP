using System;

namespace RSP
{
    class Enemy
    {   

        private Hand _hand;

        private Random _random;

        /// <summary>
        /// Constructor
        /// </summary>
        public Enemy()
        {
            _random = new Random();
            _hand = Hand.ROCK;
        }

        /// <summary>
        /// 1以上10未満の値を返すメソッド
        /// </summary>
        /// <returns>1以上10未満のランダムな値</returns>
        private int GenerateRandomNumber() => _random.Next(1, 10);

        /// <summary>
        /// 3で割った余りを返すメソッド
        /// </summary>
        /// <param name="num">余り</param>
        private int FindRemainer(int num) => num % 3;

        /// <summary>
        /// 手を出す手を判別するメソッド
        /// </summary>
        private Hand DetermineFromRandom(int num)
        {
            // 入力された手に応じて変数に格納する値を変更する
            switch (num)
            {
                case (int)Hand.ROCK:
                    _hand = Hand.ROCK;
                    break;
                case (int)Hand.SCISSORS:
                    _hand = Hand.SCISSORS;
                    break;
                case (int)Hand.PAPER:
                    _hand = Hand.PAPER;
                    break;
                default:
                    break;
            }

            return _hand;
        }

        /// <summary>
        /// 出す手を決定するメソッド
        /// </summary>
        /// <returns>出す手</returns>
        public Hand DetermineToPutHand()
        {
            int num = GenerateRandomNumber();
            int handNo = FindRemainer(num);
            return DetermineFromRandom(handNo);
        }
    }
}