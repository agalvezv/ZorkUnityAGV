using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class Game
    {
        public World World { get; set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; private set; }

        [JsonIgnore]
        public CommandManager CommandManager { get; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }

        public IOutputService Output { get; private set; }

        public IInputService Input { get; private set; }
        public Game()
        {
            Command[] commands =
            {
                new Command("LOOK", new string[] { "LOOK", "L" },
                    (game, commandContext) => Output.WriteLine($"{game.Player.Location.Name }\n{game.Player.Location.Description}")),

                new Command("QUIT", new string[] { "QUIT", "Q" },
                    (game, commandContext) => game.IsRunning = false),

                new Command("NORTH", new string[] { "NORTH", "N" }, MovementCommands.North),

                new Command("SOUTH", new string[] { "SOUTH", "S" }, MovementCommands.South),

                new Command("EAST", new string[] { "EAST", "E" }, MovementCommands.East),

                new Command("WEST", new string[] { "WEST", "W" }, MovementCommands.West),

                new Command("REWARD", new string[] {"REWARD", "R" }, Reward),

                new Command("SCORE", "SCORE", Reward)
            };

            CommandManager = new CommandManager(commands);

        }

        private static void Reward(Game game, CommandContext commandContext)
        {

            game.Player.Score++;
            game.Output.WriteLine("You have been rewarded one point!");
            //event less costly in certain circumstances
            //update location, score, moves
        }

        private static void Score(Game game, CommandContext commandContext)
        {
            game.Output.WriteLine($"Your score would be {game.Player.Score}, in {game.Player.Moves} move(s).");

        }
        //block method. blocking call
        public static Game LoadFromFile(string filename, IOutputService output, IInputService input)
        {
            return Load(File.ReadAllText(filename), output, input);
        }
        //adapter design pattern
        //things that appear over and over again in code

        public static Game Load(string jsonString, IOutputService output, IInputService input)
        {
            Game game = JsonConvert.DeserializeObject<Game>(jsonString);
            game.Output = output;
            game.Input = input;
            game.Player = game.World.SpawnPlayer();
            game.IsRunning = true;
            game.Input.InputReceived += game.InputReceived;
            //output.WriteLine("Welcome to Zork!");
            //game.CommandManager.PerformCommand(game, "LOOK");

            return game;
        }

        private void InputReceived(object sender, string inputString)
        {
            Room previousRoom = Player.Location;
            if (CommandManager.PerformCommand(this, inputString))
            {
                Player.Moves++;

                if (previousRoom != Player.Location)
                {
                    CommandManager.PerformCommand(this, "LOOK");
                }


            }
            else
            {
                Output.WriteLine("That is not a verb I rec.");

            }

        }
    }
}




