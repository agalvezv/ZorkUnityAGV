using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork.Builder.FormsFolder;

namespace Zork.Builder.FormsFolder
{
    public partial class AddNewRoomForm : Form
    {

        public string RoomName
        {
            get => AddRoomNameTextBox.Text;
            set => AddRoomNameTextBox.Text = value;
        }
        public AddNewRoomForm()
        {
            InitializeComponent();
            AcceptButton.Enabled = false;
        }

        private void AddNewRoomForm_Load(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AcceptButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
