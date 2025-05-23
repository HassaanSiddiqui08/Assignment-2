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
    public partial class WelcomeScreenForm : Form
    {
        public WelcomeScreenForm()
        {
            InitializeComponent();
            var filePath = Utilities.GetPath("learning.gif");
            Utilities.PlaySound("laughing.wav");
            animatedGifPictureBox.Image = Image.FromFile(filePath);
            closeTimer.Start(); 
        }

        // Event handler for the timer tick
        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop(); 
            this.Close();      
        }

        // Event handler for key presses on the form
        private void WelcomeScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                closeTimer.Stop(); 
                this.Close();      
            }
        }

       
        private void startButton_Click(object sender, EventArgs e)
        {
            closeTimer.Stop(); 
            this.Close();      
        }

      protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (closeTimer != null)
            {
                closeTimer.Dispose();
            }
        }
    }
}
