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


            //menuStrip2.Visible = true;
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void introToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lessonsOveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
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
            DialogResult result ;
            result = MessageBox.Show("Are you sure you want to exit", "Confirm exit", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}