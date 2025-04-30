using Questacode1.Lessons;

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
            Introduction introduction = new Introduction();
            introduction.Left = panelLessons.Left + panelLessons.Width + 10;
            introduction.Top = panelLessons.Top + 35;
            introduction.Show();
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

        private void basicInputOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basic basic = new Basic();
            basic.Left = panelLessons.Left + panelLessons.Width + 10;
            basic.Left = panelLessons.Left + panelLessons.Width + 10;
            basic.Top = panelLessons.Top + 35;
            basic.Show();
        }

        private void operatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operators operators = new Operators();
            operators.Left = panelLessons.Left + panelLessons.Width + 10;
            operators.Left = panelLessons.Left + panelLessons.Width + 10;
            operators.Top = panelLessons.Top + 35;
            operators.Show();
        }

        private void conditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conditions conditions = new Conditions();
            conditions.Left = panelLessons.Left + panelLessons.Width + 10;
            conditions.Left = panelLessons.Left + panelLessons.Width + 10;
            conditions.Top = panelLessons.Top + 35;
            conditions.Show();
        }

        private void loopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loops loops = new Loops();
            loops.Left = panelLessons.Left + panelLessons.Width + 10;
            loops.Left = panelLessons.Left + panelLessons.Width + 10;
            loops.Top = panelLessons.Top + 35;
            loops.Show();
        }

        private void functionsAndMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodsFunctions methods = new MethodsFunctions();
            methods.Left = panelLessons.Left + panelLessons.Width + 10;
            methods.Left = panelLessons.Left + panelLessons.Width + 10;
            methods.Top = panelLessons.Top + 35;
            methods.Show();
        }

        private void arraysAndListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList();
            array.Left = panelLessons.Left + panelLessons.Width + 10;
            array.Left = panelLessons.Left + panelLessons.Width + 10;
            array.Top = panelLessons.Top + 35;
            array.Show();
        }

        private void graphicsAndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicsAnimations graphicsAnimations = new GraphicsAnimations();
            graphicsAnimations.Left = panelLessons.Left + panelLessons.Width + 10;
            graphicsAnimations.Left = panelLessons.Left + panelLessons.Width + 10;
            graphicsAnimations.Top = panelLessons.Top + 35;
            graphicsAnimations.Show();
        }

        private void creatingAGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame createGame = new CreateGame();
            createGame.Left = panelLessons.Left + panelLessons.Width + 10;
            createGame.Left = panelLessons.Left + panelLessons.Width + 10;
            createGame.Top = panelLessons.Top + 35;
            createGame.Show();
        }
    }

}