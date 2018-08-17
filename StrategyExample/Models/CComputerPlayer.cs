using StrategyExample.Contracts;
using System;

namespace StrategyExample.Models
{
    public class CComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer made an Difficult move.");
        }
    }
}
