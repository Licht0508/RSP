
namespace RSP
{
    
    internal class Judge
    {

        /// <summary>
        /// 判定用の関数
        /// </summary>
        /// <param name="Player_">Player</param>
        /// <param name="Enemy_">Enemy</param>
        public void JudgeRSP(Hand Player_, Hand Enemy_)
        {
           
            if(Player_ == Enemy_)
            {
                Console.WriteLine("引き分けです。");
                return;
            }

           if(IsWin(Player_, Enemy_))
            {
                Console.WriteLine("あなたの勝ちです。");
            }

            Console.WriteLine("敵の勝ちです。");
            return;
        }

        /// <summary>
        /// プレイヤーが勝利しているかどうか確認用の関数
        /// </summary>
        /// <param name="Player_">Player</param>
        /// <param name="Enemy_">Enemy</param>
        /// <returns>勝利時にtrue</returns>
        private bool IsWin(Hand Player_, Hand Enemy_)
        {
            if (Player_ == Hand.ROCK && Enemy_ == Hand.SCISSORS)
            {
                return true;
            }
            else if (Player_ == Hand.SCISSORS && Enemy_ == Hand.PAPER)
            {
                return true;
            }   
            else if (Player_ == Hand.PAPER && Enemy_ == Hand.ROCK)
            {
                return true;
            }
            return false;
        }
    }
}
