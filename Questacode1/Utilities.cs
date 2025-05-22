using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Questacode1
{
    public static class Utilities
    {
        public static bool isParent = false; //check if its parent or student
        public static void SetupForm(Form form, int top, int left, int width)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Width = 1200;
            form.Height = 800;
            form.Left = width + 10;
            form.Top = top + 35;
            form.BackColor = Color.LightCyan;
            form.Show();
        }

        public static void LoadFile(RichTextBox rBox, string fileName)
        {
            string path = Directory.GetCurrentDirectory() + "\\Lessons\\files\\";
            rBox.LoadFile(path + fileName);
        }

        public static void PlaySound(string fileName)
        {
            string path = Directory.GetCurrentDirectory() + "\\Sounds\\";
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = path + fileName;
            soundPlayer.Play();

        }

        
    }
}
