namespace Zork.Builder
{
    partial class NeighborView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NorthGroupBox = new System.Windows.Forms.GroupBox();
            this.NeighborComboBox = new System.Windows.Forms.ComboBox();
            this.DirectionLabel = new System.Windows.Forms.Label();
            this.NorthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NorthGroupBox
            // 
            this.NorthGroupBox.Controls.Add(this.NeighborComboBox);
            this.NorthGroupBox.Controls.Add(this.DirectionLabel);
            this.NorthGroupBox.Location = new System.Drawing.Point(3, 3);
            this.NorthGroupBox.Name = "NorthGroupBox";
            this.NorthGroupBox.Size = new System.Drawing.Size(340, 61);
            this.NorthGroupBox.TabIndex = 5;
            this.NorthGroupBox.TabStop = false;
            // 
            // NeighborComboBox
            // 
            this.NeighborComboBox.FormattingEnabled = true;
            this.NeighborComboBox.Location = new System.Drawing.Point(65, 24);
            this.NeighborComboBox.Name = "NeighborComboBox";
            this.NeighborComboBox.Size = new System.Drawing.Size(269, 21);
            this.NeighborComboBox.TabIndex = 6;
            // 
            // DirectionLabel
            // 
            this.DirectionLabel.AutoSize = true;
            this.DirectionLabel.Location = new System.Drawing.Point(6, 27);
            this.DirectionLabel.Name = "DirectionLabel";
            this.DirectionLabel.Size = new System.Drawing.Size(49, 13);
            this.DirectionLabel.TabIndex = 5;
            this.DirectionLabel.Text = "Direction";
            // 
            // NeighborView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NorthGroupBox);
            this.Name = "NeighborView";
            this.Size = new System.Drawing.Size(347, 69);
            this.NorthGroupBox.ResumeLayout(false);
            this.NorthGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NorthGroupBox;
        private System.Windows.Forms.ComboBox NeighborComboBox;
        private System.Windows.Forms.Label DirectionLabel;
    }
}
