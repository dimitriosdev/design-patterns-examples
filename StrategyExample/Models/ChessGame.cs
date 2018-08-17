using StrategyExample.Contracts;

namespace StrategyExample.Models
{
    public class ChessGame
    {
        private IComputerPlayer computerPlayer;
        public IComputerPlayer ComputerPlayer
        {
            get { return computerPlayer; }
            set { computerPlayer = value; }
        }

        public void Move()
        {
            computerPlayer.MakeMove();
        }
    }
}
