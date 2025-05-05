using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questacode1
{
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();

            //string path = Directory.GetCurrentDirectory() + "\\Lessons\\files\\";
            //string fileName = "Introduction.rtf";
            //this.richTextBox1.LoadFile(path + fileName);

            Utilities.LoadFile(richTextBox1, "Introduction.rtf");
        }

        private void grpCodeEditor_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.LinkText) { UseShellExecute = true });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
