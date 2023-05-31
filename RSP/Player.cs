namespace RSP
{
    internal class Player
    {

        public Input input;
        
        /// <summary>
        /// 出す手を決めるメソッド
        /// </summary>
        public void InputHand()
        {
            input.DetermineToPutHand();
        }

        /// <summary>
        /// Playerの現在の手確認用メソッド
        /// </summary>
        /// <returns>現在の手</returns>
        public Hand GetHand() { return input.hand; }

    }
}
