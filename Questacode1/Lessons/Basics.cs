using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questacode1.Lessons
{
    public partial class FirstProgram : Form
    {
        public FirstProgram()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.DoDragDrop(label1.Text, DragDropEffects.Move);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label2.DoDragDrop(label2.Text, DragDropEffects.Move);
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label3.DoDragDrop(label3.Text, DragDropEffects.Move);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the dragged data is text
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                // Allow the drop operation
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                // Disallow the drop operation
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            // Get the dragged text
            string draggedText = (string)e.Data.GetData(DataFormats.Text);

            // Update the drop target (e.g., the Panel's Controls or a Label within the Panel)
            // For a Panel, you might add a Label to it:
            Label newLabel = new Label();
            newLabel.Text = draggedText;
            newLabel.Dock = DockStyle.Fill;  // Make it fill the panel
            panel1.Controls.Clear();    // Clear any previous content
            panel1.Controls.Add(newLabel);

            //Or if the dropPanel1 is actually a Label
            //dropPanel1.Text = draggedText;

            //You might want to check here if the draggedText is the correct answer
            if (draggedText == "static")
            {
                //do something
            }
        }
    }
}
