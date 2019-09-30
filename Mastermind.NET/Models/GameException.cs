using System;

namespace Mastermind.NET.Models
{
  public class GameException : Exception
  {
    public GameException(string message) : base(message)
    {
    }
  }
}
