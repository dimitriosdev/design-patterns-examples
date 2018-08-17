using StrategyExample.Contracts;
using System;

namespace StrategyExample.Models
{
    public class BComputerPlayer : IComputerPlayer
    {
        void IComputerPlayer.MakeMove()
        {
            Console.WriteLine("Computer made an Medium move.");
        }
    }
}
