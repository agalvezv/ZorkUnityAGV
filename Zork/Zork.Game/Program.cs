using System;
using Zork.Common;

namespace Zork.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Common.Game game = Common.Game.LoadFromFile(gameFilename, output, input);
            
            while (game.IsRunning)
            {
                output.Write("> ");
                input.ProcessInput();
            }
            output.WriteLine("Thanks for playing!");
        }
        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}

/*
using System;
using Zork.Common;

namespace Zork.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Common.Game game = Common.Game.Load(gameFilename);
            Console.WriteLine("Welcome to Zork!");
            game.Run();
            Console.WriteLine("Thanks for playing!");
        }
        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
*/