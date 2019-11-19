/*using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Zork.Common;


namespace Zork
{
  
    public class RoomConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(Room));
​
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            dynamic jsonObject = JObject.Load(reader);
​
            string name = jsonObject["Name"];
            string description = jsonObject["Description"];
            Dictionary<Directions, string> neighborNames = jsonObject["Neighbors"].ToObject<Dictionary<Directions, string>>();
​
            return new Room(name, description, neighborNames);
        }
​
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Room room = (Room)value;
            JToken neighborNames = JToken.FromObject(room.Neighbors.ToDictionary(pair => pair.Key, pair => pair.Value.Name), serializer);
​
            JObject roomObject = new JObject
            {
                { nameof(Room.Name), room.Name },
                { nameof(Room.Description), room.Description },
                { nameof(Room.Neighbors), neighborNames }
            };
​
            roomObject.WriteTo(writer);
        }
    }
    
}
*/


