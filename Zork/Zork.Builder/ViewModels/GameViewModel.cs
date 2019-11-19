using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;
using System.Runtime.CompilerServices;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public GameViewModel()
        {
            Rooms = new BindingList<Room>();
        }

        public Game Game 
        {

            get => mGame;
            set
            {
                if (mGame != value)
                {
                    mGame = value;
                    if (mGame != null && mGame.World != null && mGame.World.Rooms != null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, mGame);
            }
        }

        private Game mGame;
    }
}
