using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Questacode1
{
    public static class Utilities
    {
        public static void SetupForm(Form form, int top, int left, int width)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Left = width + 10;
            form.Top = top + 35;
            form.Show();
        }

        public static void LoadFile(string fileName)
        { 
        
        }
    }
}
