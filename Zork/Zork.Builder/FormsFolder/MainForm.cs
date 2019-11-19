using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Zork.Common;
using Newtonsoft.Json;
using Zork.Builder.ViewModels;
using Zork.Builder.FormsFolder;

namespace Zork.Builder
{
    public partial class ZorkBuilder : Form
    {

        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private GameViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    gameViewModelBindingSource.DataSource = mViewModel;
                }
            }

        }

        private bool isWorldLoaded 
        { 
            get => mIsWorldLoaded;
            set => mIsWorldLoaded = value;
                                     
        }

        public ZorkBuilder()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            isWorldLoaded = false;
        }

        private void NewRoomButton_Click(object sender, EventArgs e)
        {
            using(AddNewRoomForm addRoomForm = new AddNewRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void ListOfRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = RoomList.SelectedItem != null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)ListOfRooms.SelectedItem);
                ListOfRooms.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }

        }


        #region Main Menu
        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                isWorldLoaded = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = SaveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion Main Menu

        private GameViewModel mViewModel;
        private bool mIsWorldLoaded;
    }
}
