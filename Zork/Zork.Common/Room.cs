using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Zork.Common
{
    //[JsonConverter(typeof(RoomConverter))]
    public class Room : IEquatable<Room> , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]

       //changed private to public set. Don't kill me 
       //JK
       public string Name { get; /* private */ set; }

       [JsonProperty(Order = 2)]
       public string Description { get; /* private */ set; }

        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborsNames { get; set; }

        [JsonIgnore]
        public IReadOnlyDictionary<Directions, Room> Neighbors { get; private set; }

        public static bool operator == (Room lhs, Room rhs)
        {
            if(ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            if (lhs is null || rhs is null)
            {
                return false;
            }

            return lhs.Name == rhs.Name;
        }

        public Room() :
            this(string.Empty, string.Empty, new Dictionary<Directions, string>())
        {
        }

        public Room(string name, string description, Dictionary<Directions, string> neighborNames)
        {
            Name = name;
            Description = description;
            NeighborsNames = neighborNames;
            Neighbors = new Dictionary<Directions, Room>();
        }


        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborsNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room)).ToDictionary(pair => pair.Direction, pair => pair.Room);
    }
}
