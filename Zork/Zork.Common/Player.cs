using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace Zork.Common
{
    public class Player
    {
        private int mscore;
        private int mMove;

        public event EventHandler<int> ScoreChanged;
        public event EventHandler<int> MoveChanged;

        public World World { get; }

        [JsonIgnore]

        public Room Location { get; private set; }


        public int Moves { get; set; }

        public int ZorkMoves
        {
            get => mMove;
            set
            {
                mMove = value;

            }

        }


        public int Score
        {
            get => mscore;
            set
            {
                mscore = value;
                ScoreChanged?.Invoke(this, mscore);


            }
        }


        [JsonIgnore]

        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove)
            {
                Location = destination;
                ZorkMoves++;
            }

            return isValidMove;
        }

    }
}