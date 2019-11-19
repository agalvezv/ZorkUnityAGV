using Zork.Builder.FormsFolder;
namespace Zork.Builder
{
    partial class ZorkBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RoomList = new System.Windows.Forms.ListBox();
            this.NewRoomButton = new System.Windows.Forms.Button();
            this.ListOfRooms = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.RoomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RoomNameBox = new System.Windows.Forms.TextBox();
            this.NeighborsBox = new System.Windows.Forms.GroupBox();
            this.neighborViewSouth = new Zork.Builder.NeighborView();
            this.neighborViewWest = new Zork.Builder.NeighborView();
            this.neighborViewEast = new Zork.Builder.NeighborView();
            this.neighborViewNorth = new Zork.Builder.NeighborView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.RoomInfoGroupBox.SuspendLayout();
            this.DescriptionBox.SuspendLayout();
            this.NeighborsBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomList
            // 
            this.RoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RoomList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RoomList.FormattingEnabled = true;
            this.RoomList.Location = new System.Drawing.Point(1, 33);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(238, 576);
            this.RoomList.TabIndex = 0;
            // 
            // NewRoomButton
            // 
            this.NewRoomButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewRoomButton.Location = new System.Drawing.Point(53, 576);
            this.NewRoomButton.Name = "NewRoomButton";
            this.NewRoomButton.Size = new System.Drawing.Size(143, 23);
            this.NewRoomButton.TabIndex = 3;
            this.NewRoomButton.Text = "Add New";
            this.NewRoomButton.UseVisualStyleBackColor = false;
            this.NewRoomButton.Click += new System.EventHandler(this.NewRoomButton_Click);
            // 
            // ListOfRooms
            // 
            this.ListOfRooms.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListOfRooms.DataSource = this.roomsBindingSource;
            this.ListOfRooms.DisplayMember = "Name";
            this.ListOfRooms.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ListOfRooms.FormattingEnabled = true;
            this.ListOfRooms.Location = new System.Drawing.Point(13, 98);
            this.ListOfRooms.Name = "ListOfRooms";
            this.ListOfRooms.Size = new System.Drawing.Size(214, 472);
            this.ListOfRooms.TabIndex = 6;
            this.ListOfRooms.ValueMember = "Description";
            this.ListOfRooms.SelectedIndexChanged += new System.EventHandler(this.ListOfRooms_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.ViewModels.GameViewModel);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchBar.Location = new System.Drawing.Point(12, 69);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(213, 20);
            this.SearchBar.TabIndex = 7;
            // 
            // RoomInfoGroupBox
            // 
            this.RoomInfoGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RoomInfoGroupBox.Controls.Add(this.DeleteButton);
            this.RoomInfoGroupBox.Controls.Add(this.RoomNameLabel);
            this.RoomInfoGroupBox.Controls.Add(this.DescriptionBox);
            this.RoomInfoGroupBox.Controls.Add(this.RoomNameBox);
            this.RoomInfoGroupBox.Controls.Add(this.NeighborsBox);
            this.RoomInfoGroupBox.Location = new System.Drawing.Point(245, 27);
            this.RoomInfoGroupBox.Name = "RoomInfoGroupBox";
            this.RoomInfoGroupBox.Size = new System.Drawing.Size(397, 582);
            this.RoomInfoGroupBox.TabIndex = 10;
            this.RoomInfoGroupBox.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.Location = new System.Drawing.Point(302, 536);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Room";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Location = new System.Drawing.Point(31, 26);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(69, 13);
            this.RoomNameLabel.TabIndex = 8;
            this.RoomNameLabel.Text = "Room Name:";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Controls.Add(this.textBox1);
            this.DescriptionBox.Location = new System.Drawing.Point(26, 85);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(354, 109);
            this.DescriptionBox.TabIndex = 7;
            this.DescriptionBox.TabStop = false;
            this.DescriptionBox.Text = "Room Description:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 83);
            this.textBox1.TabIndex = 0;
            // 
            // RoomNameBox
            // 
            this.RoomNameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RoomNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.RoomNameBox.Location = new System.Drawing.Point(30, 42);
            this.RoomNameBox.Name = "RoomNameBox";
            this.RoomNameBox.Size = new System.Drawing.Size(347, 20);
            this.RoomNameBox.TabIndex = 6;
            // 
            // NeighborsBox
            // 
            this.NeighborsBox.Controls.Add(this.neighborViewSouth);
            this.NeighborsBox.Controls.Add(this.neighborViewWest);
            this.NeighborsBox.Controls.Add(this.neighborViewEast);
            this.NeighborsBox.Controls.Add(this.neighborViewNorth);
            this.NeighborsBox.Location = new System.Drawing.Point(26, 217);
            this.NeighborsBox.Name = "NeighborsBox";
            this.NeighborsBox.Size = new System.Drawing.Size(354, 291);
            this.NeighborsBox.TabIndex = 5;
            this.NeighborsBox.TabStop = false;
            this.NeighborsBox.Text = "Neighbors";
            // 
            // neighborViewSouth
            // 
            this.neighborViewSouth.Direction = Zork.Common.Directions.South;
            this.neighborViewSouth.Location = new System.Drawing.Point(6, 151);
            this.neighborViewSouth.Name = "neighborViewSouth";
            this.neighborViewSouth.Size = new System.Drawing.Size(340, 69);
            this.neighborViewSouth.TabIndex = 11;
            // 
            // neighborViewWest
            // 
            this.neighborViewWest.Direction = Zork.Common.Directions.West;
            this.neighborViewWest.Location = new System.Drawing.Point(6, 215);
            this.neighborViewWest.Name = "neighborViewWest";
            this.neighborViewWest.Size = new System.Drawing.Size(340, 69);
            this.neighborViewWest.TabIndex = 10;
            // 
            // neighborViewEast
            // 
            this.neighborViewEast.Direction = Zork.Common.Directions.East;
            this.neighborViewEast.Location = new System.Drawing.Point(6, 85);
            this.neighborViewEast.Name = "neighborViewEast";
            this.neighborViewEast.Size = new System.Drawing.Size(340, 69);
            this.neighborViewEast.TabIndex = 9;
            // 
            // neighborViewNorth
            // 
            this.neighborViewNorth.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.neighborViewNorth.Direction = Zork.Common.Directions.North;
            this.neighborViewNorth.Location = new System.Drawing.Point(6, 19);
            this.neighborViewNorth.Name = "neighborViewNorth";
            this.neighborViewNorth.Size = new System.Drawing.Size(340, 69);
            this.neighborViewNorth.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Zork World(*json)|*.json";
            this.openFileDialog.Title = "Select Zork World";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(654, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "&File:";
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openGameToolStripMenuItem.Text = "Open Game...";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.openGameToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Zork World(*json)|*.json";
            this.SaveFileDialog.Title = "Save game file";
            // 
            // ZorkBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(654, 611);
            this.Controls.Add(this.RoomInfoGroupBox);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ListOfRooms);
            this.Controls.Add(this.NewRoomButton);
            this.Controls.Add(this.RoomList);
            this.Controls.Add(this.menuStrip);
            this.MaximizeBox = false;
            this.Name = "ZorkBuilder";
            this.Text = "ZorkBuilder";
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.RoomInfoGroupBox.ResumeLayout(false);
            this.RoomInfoGroupBox.PerformLayout();
            this.DescriptionBox.ResumeLayout(false);
            this.DescriptionBox.PerformLayout();
            this.NeighborsBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.Button NewRoomButton;
        private System.Windows.Forms.ListBox ListOfRooms;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.GroupBox RoomInfoGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.GroupBox DescriptionBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox NeighborsBox;
        private NeighborView neighborViewSouth;
        private NeighborView neighborViewWest;
        private NeighborView neighborViewEast;
        private NeighborView neighborViewNorth;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        public System.Windows.Forms.TextBox RoomNameBox;
    }
}

