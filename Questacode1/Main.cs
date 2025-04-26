namespace Questacode1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void lessonsOveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // int x  = 0;
            Lessons lessons = new Lessons();
            lessons.Show();
        }
    }
}