using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SimpsonsTriviaGame
{
    public partial class frmSimpsonsTrivia : Form
    {
        public static char gameType = 'N';
        public static int numOfQuestions = 0;
        public static int maxNumberOfQuestions;
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SimpsonsTriviaGameDB"].ConnectionString;

        public frmSimpsonsTrivia()
        {
            InitializeComponent();
        }

        private void frmSimpsonsTrivia_Load(object sender, EventArgs e)
        {
            CountAllQuestions();
            UpdateHowManyDisplay();
        }

        private void UpdateHowManyDisplay()
        {
            radAll.Text = maxNumberOfQuestions.ToString();
            rad10.Text = (maxNumberOfQuestions * 0.1).ToString("N0");
            rad25.Text = (maxNumberOfQuestions * 0.25).ToString("N0");
            rad50.Text = (maxNumberOfQuestions * 0.5).ToString("N0");
            rad75.Text = (maxNumberOfQuestions * 0.75).ToString("N0");
        }

        private void CountAllQuestions()
        {
            string selectStatement = "SELECT COUNT(*) FROM QuestionTable ";
            if (gameType == 'M' || gameType == 'S' || gameType == 'T')
                selectStatement += "WHERE Type=@type";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@type", gameType.ToString());
                try
                {
                    connection.Open();
                    maxNumberOfQuestions = (int)selectCommand.ExecuteScalar();
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameType(sender, e);
            HowManyQuestions(sender, e);
            int[] questionList = new int[maxNumberOfQuestions];
            questionList = CreateQuestionList();
            frmTriviaCard newGame = new frmTriviaCard();
            newGame.SetupTriviaCards(gameType, numOfQuestions, questionList);
            newGame.ShowDialog(this);
        }

        private int[] CreateQuestionList()
        {
            List<int> id = new List<int>();
            string selectStatement = "SELECT QuestionID FROM QuestionTable ";
            if (gameType == 'M' || gameType == 'S' || gameType == 'T')
                selectStatement += "WHERE Type=@type";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                selectCommand.Parameters.AddWithValue("@type", gameType.ToString());
                try
                {
                    connection.Open();
                    SqlDataReader selectReader = selectCommand.ExecuteReader();

                    while (selectReader.Read())
                    {
                        id.Add(Convert.ToInt32(selectReader["QuestionID"]));
                    }

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                
            }

            Random rnd = new Random();
            int qNum;
            int[] questionList = new int[numOfQuestions];
            for (int i = 0; i < numOfQuestions; i++)
            {
                qNum = rnd.Next(0, id.Count);
                questionList[i] = id[qNum];
                id.RemoveAt(qNum);
            }
            return questionList;
        }

        private void GameType(object sender, EventArgs e)
        {
            if (radMultiChoice.Checked)
                gameType = 'M';
            if (radSingleAnswer.Checked)
                gameType = 'S';
            if (radTrueOrFalse.Checked)
                gameType = 'T';
            if (radMix.Checked)
                gameType = 'A';

            CountAllQuestions();
            UpdateHowManyDisplay();
        }

        private void HowManyQuestions(object sender, EventArgs e)
        {
            if (rad10.Checked)
                numOfQuestions = int.Parse(rad10.Text);
            if (rad50.Checked)
                numOfQuestions = int.Parse(rad50.Text);
            if (rad25.Checked)
                numOfQuestions = int.Parse(rad25.Text);
            if (rad75.Checked)
                numOfQuestions = int.Parse(rad75.Text);
            if (radAll.Checked)
                numOfQuestions = maxNumberOfQuestions;
            if (radRandom.Checked)
            {
                Random random = new Random();
                numOfQuestions = random.Next(1, maxNumberOfQuestions + 1);
            }
        }
    }
}
