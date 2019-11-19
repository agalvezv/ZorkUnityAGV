using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder
{
    public partial class NeighborView : UserControl
    {
        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                DirectionLabel.Text = mDirection.ToString();
            }
        }

        public NeighborView()
        {
            InitializeComponent();
        }

        private Directions mDirection;
    }
}
