namespace Zork.Builder.FormsFolder
{
    partial class AddNewRoomForm
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
            this.AddRoomNameTextBox = new System.Windows.Forms.TextBox();
            this.AddRoomLabel = new System.Windows.Forms.Label();
            this.CancelRoomButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddRoomNameTextBox
            // 
            this.AddRoomNameTextBox.Location = new System.Drawing.Point(12, 42);
            this.AddRoomNameTextBox.Name = "AddRoomNameTextBox";
            this.AddRoomNameTextBox.Size = new System.Drawing.Size(326, 20);
            this.AddRoomNameTextBox.TabIndex = 0;
            this.AddRoomNameTextBox.TextChanged += new System.EventHandler(this.AddRoomNameTextBox_TextChanged);
            // 
            // AddRoomLabel
            // 
            this.AddRoomLabel.AutoSize = true;
            this.AddRoomLabel.Location = new System.Drawing.Point(13, 23);
            this.AddRoomLabel.Name = "AddRoomLabel";
            this.AddRoomLabel.Size = new System.Drawing.Size(69, 13);
            this.AddRoomLabel.TabIndex = 1;
            this.AddRoomLabel.Text = "Room Name:";
            // 
            // CancelRoomButton
            // 
            this.CancelRoomButton.Location = new System.Drawing.Point(263, 70);
            this.CancelRoomButton.Name = "CancelRoomButton";
            this.CancelRoomButton.Size = new System.Drawing.Size(75, 23);
            this.CancelRoomButton.TabIndex = 2;
            this.CancelRoomButton.Text = "&Cancel";
            this.CancelRoomButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(182, 70);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "&Ok";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AddNewRoomForm
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelRoomButton;
            this.ClientSize = new System.Drawing.Size(350, 105);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.CancelRoomButton);
            this.Controls.Add(this.AddRoomLabel);
            this.Controls.Add(this.AddRoomNameTextBox);
            this.MaximizeBox = false;
            this.Name = "AddNewRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Room";
            this.Load += new System.EventHandler(this.AddNewRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddRoomNameTextBox;
        private System.Windows.Forms.Label AddRoomLabel;
        private System.Windows.Forms.Button CancelRoomButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}