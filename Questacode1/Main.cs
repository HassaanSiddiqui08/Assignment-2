using Questacode1.Lessons;

namespace Questacode1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ShowLoginForm();
            this.IsMdiContainer = true;
        }

        private void ShowLoginForm()
        {
            Login login = new Login();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                


            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

       

        private void introToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Introduction introduction = new Introduction();
            Utilities.SetupForm(introduction, panelLessons.Top, panelLessons.Left, panelLessons.Width);

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
            FirstProgram basic = new FirstProgram();
            Utilities.SetupForm(basic, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void operatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operators operators = new Operators();
            Utilities.SetupForm(operators, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void conditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conditions conditions = new Conditions();
            Utilities.SetupForm(conditions, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void loopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loops loops = new Loops();
            Utilities.SetupForm(loops, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void functionsAndMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethodsFunctions methods = new MethodsFunctions();
            Utilities.SetupForm(methods, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void arraysAndListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList arrayNList = new ArrayList();
            Utilities.SetupForm(arrayNList, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void graphicsAndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphicsAnimations graphicsAnimations = new GraphicsAnimations();
            Utilities.SetupForm(graphicsAnimations, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void creatingAGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateGame createGame = new CreateGame();
            Utilities.SetupForm(createGame, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            Utilities.SetupForm(variables, panelLessons.Top, panelLessons.Left, panelLessons.Width);

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            Utilities.SetupForm(progress, panelProgress.Top, panelProgress.Left, panelProgress.Width);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            Utilities.SetupForm(quizzes, panelLessons.Top, panelLessons.Left, panelLessons.Width);
        }
    }

}