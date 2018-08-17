using System;
using StrategyExample.Contracts;

namespace StrategyExample.Models
{
    public class AComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer made an Easy move.");
        }
    }
}
