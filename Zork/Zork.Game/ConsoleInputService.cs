using System;
using System.Collections.Generic;
using System.Text;
using Zork.Common;

namespace Zork.Game
{
    internal class ConsoleInputService : IInputService
    {
        public event EventHandler<string> InputReceived;

        public void ProcessInput()
        {
            string inputString = Console.ReadLine().Trim();

            
            InputReceived?.Invoke(this, inputString);

            // if (inputreceived !=null) {  inputreceived,,,,, equiv

        }
    }
}
