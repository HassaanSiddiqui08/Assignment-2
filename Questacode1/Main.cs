namespace Questacode1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void introToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Lessons lessons = new Lessons();
            lessons.Show();
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit", "Confirm exit", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void lessonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLessons.Visible = true;
        }
    }
}