
namespace RSP
{
    enum RSPKIND
    { 
        ROCK,
        SCESERSE,
        PAPER
    }

    internal class Judge
    {
        /// <summary>
        /// 判定用の関数
        /// </summary>
        /// <param name="Player_">Player</param>
        /// <param name="Enemy_">Enemy</param>
        public void JudgeRSP(RSPKIND Player_, RSPKIND Enemy_)
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
        private bool IsWin(RSPKIND Player_, RSPKIND Enemy_)
        {
            if (Player_ == RSPKIND.ROCK && Enemy_ == RSPKIND.SCESERSE)
            {
                return true;
            }
            else if (Player_ == RSPKIND.SCESERSE && Enemy_ == RSPKIND.PAPER)
            {
                return true;
            }
            else if (Player_ == RSPKIND.PAPER && Enemy_ == RSPKIND.ROCK)
            {
                return true;
            }
            return false;
        }
    }
}
