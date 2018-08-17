using StrategyExample.Models;
using System;

namespace StrategyExample
{
    /// <summary>
    /// strategy pattern is it allows you to choose the behavior of the application at runtime.
    /// You only need to define the behaviors as strategy classes, and the client code can simply
    /// choose any of the classes to exhibit the behavior.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var game = new ChessGame();
            game.ComputerPlayer = new AComputerPlayer();
            game.Move();

            game.ComputerPlayer = new BComputerPlayer();
            game.Move();

            game.ComputerPlayer = new CComputerPlayer();
            game.Move();

            Console.ReadKey();
        }
    }
}
