using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollaborativeWhiteboard.Controls
{
    public partial class DrawingToolsPanel : UserControl
    {
        private Color selectedColor;
        private int selectedBrushSize;

        public DrawingToolsPanel()
        {
            InitializeComponent();
            selectedColor = Color.Black;
            selectedBrushSize = 5; // Default brush size
            InitializeDrawingTools();
        }

        private void InitializeDrawingTools()
        {
            // Initialize color selection buttons and brush size options
            // Example: Create buttons for colors and a numeric up-down for brush size
        }

        public Color SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; }
        }

        public int SelectedBrushSize
        {
            get { return selectedBrushSize; }
            set { selectedBrushSize = value; }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            // Handle color selection
            Button colorButton = sender as Button;
            if (colorButton != null)
            {
                SelectedColor = colorButton.BackColor;
            }
        }

        private void BrushSizeChanged(object sender, EventArgs e)
        {
            // Handle brush size change
            NumericUpDown brushSizeSelector = sender as NumericUpDown;
            if (brushSizeSelector != null)
            {
                SelectedBrushSize = (int)brushSizeSelector.Value;
            }
        }
    }
}