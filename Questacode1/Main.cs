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
            Introduction lessons = new Introduction();
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
            panelLessons.Location = new Point(10, 100);
            panelLessons.Visible = true;

            panelProgress.Visible = false;
            panelQuizzes.Visible = false;
            panelGames.Visible = false;

        }
        private void qUIZZESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelQuizzes.Location = new Point(10, 100);
            panelQuizzes.Visible = true;

            panelProgress.Visible = false;
            panelLessons.Visible = false;
            panelGames.Visible = false;
        }

        private void gAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelGames.Location = new Point(10, 100);
            panelGames.Visible = true;

            panelProgress.Visible = false;
            panelLessons.Visible = false;
            panelQuizzes.Visible = false;

        }

        private void pROGRESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelProgress.Location = new Point(10, 100);
            panelProgress.Visible = true;

            panelGames.Visible = false;
            panelLessons.Visible = false;
            panelQuizzes.Visible = false;

        }
    }
}