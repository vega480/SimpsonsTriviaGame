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

namespace SimpsonsTriviaGame
{
    public partial class frmTriviaCard : Form
    {
        public static char gameType = 'N';
        public static char card = 'N';
        public static int correctTotal = 0;
        public static int numOfQuestions = 0;
        public static int currentQuestion = 1;
        public static int[] questions;
        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SimpsonsTriviaGameDB"].ConnectionString;
        private static List<TriviaCard> questionList;

        public int CorrectTotal
        {
            get { return correctTotal; }
        }

        public frmTriviaCard()
        {
            InitializeComponent();
        }

        public void SetupTriviaCards(char type, int num, int[] qList)
        {
            gameType = type;
            numOfQuestions = num;
            questions = qList;
        }

        private void frmTriviaCard_Load(object sender, EventArgs e)
        {
            correctTotal = 0;
            currentQuestion = 1;
            txtCorrectAnswer.Text = string.Empty;
            this.AcceptButton = btnSubmit;
            BuildTriviaCards();
            ChangeCardDisplay(questionList[currentQuestion - 1].Type);
            prgBarQuestions.Value = currentQuestion;
            prgBarQuestions.Maximum = numOfQuestions;
            this.Text = "The Simpsons Trivia Question: " +
                        currentQuestion.ToString() +
                        " of " +
                        numOfQuestions.ToString();
        }

        private void BuildTriviaCards()
        {
            questionList = new List<TriviaCard>();
            foreach (int card in questions)
            {
                string selectStatement = "SELECT QuestionID, Question, Answer, Option1, Option2, Type FROM QuestionTable WHERE QuestionID=@qID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.AddWithValue("@qID", card);
                    connection.Open();
                    SqlDataReader selectReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                    if (selectReader.Read())
                    {
                        TriviaCard newCard = new TriviaCard();
                        newCard.ID = Convert.ToInt32(selectReader["QuestionID"]);
                        newCard.Question = selectReader["Question"].ToString();
                        newCard.Answer = selectReader["Answer"].ToString();
                        newCard.Type = Convert.ToChar(selectReader["Type"]);
                        if (selectReader["Answer"].ToString() == "False")
                            newCard.Option1 = selectReader["Option1"].ToString();
                        if (selectReader["Type"].ToString() == "M")
                        {
                            newCard.Option1 = selectReader["Option1"].ToString();
                            newCard.Option2 = selectReader["Option2"].ToString();
                        }
                        questionList.Add(newCard);
                    }  
                }
            }
        }

        private void ChangeCardDisplay(char card)
        {
            txtQuestion.Text = "Card# " + questionList[currentQuestion - 1].ID.ToString() + Environment.NewLine 
                             + questionList[currentQuestion - 1].Question;
            switch (card)
            {
                case 'M':
                    RandomizeOptions();
                    grpBxSelections.Visible = true;
                    radOption1T.Visible = true;
                    radOption2.Visible = true;
                    radOption3F.Visible = true;
                    lblEntryResult.Visible = false;
                    txtEntryResult.Visible = false;
                    prgBarQuestions.Value = currentQuestion;
                    ActiveControl = radOption1T;
                    break;
                case 'S':                 
                    grpBxSelections.Visible = false;
                    radOption1T.Visible = false;
                    radOption2.Visible = false;
                    radOption3F.Visible = false;
                    lblEntryResult.Visible = true;
                    txtEntryResult.Visible = true;
                    prgBarQuestions.Value = currentQuestion;
                    ActiveControl = txtEntryResult;
                    break;
                case 'T':
                    grpBxSelections.Visible = true;
                    radOption1T.Visible = true;
                    radOption1T.Text = "True";
                    radOption2.Visible = false;
                    radOption3F.Visible = true;
                    radOption3F.Text = "False";
                    lblEntryResult.Visible = false;
                    txtEntryResult.Visible = false;
                    prgBarQuestions.Value = currentQuestion;
                    ActiveControl = radOption1T;
                    break;
                default:
                    break;
            }
        }

        private void RandomizeOptions()
        {
            List<string> options = new List<string>();
            Random rnd = new Random();
            int rndOption;
            options.Add(questionList[currentQuestion - 1].Answer);
            options.Add(questionList[currentQuestion - 1].Option1);
            options.Add(questionList[currentQuestion - 1].Option2);

            rndOption = rnd.Next(0, options.Count);
            radOption1T.Text = options[rndOption];
            options.RemoveAt(rndOption);

            rndOption = rnd.Next(0, options.Count);
            radOption2.Text = options[rndOption];
            options.RemoveAt(rndOption);

            rndOption = rnd.Next(0, options.Count);
            radOption3F.Text = options[rndOption];
            options.RemoveAt(rndOption);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Close")
            {
                this.Close();
                return;
            }

            txtCorrectAnswer.Text = string.Empty;
            CheckAnswer(questionList[currentQuestion - 1].Type);
            currentQuestion++;

            if (currentQuestion <= numOfQuestions)
            {
                ChangeCardDisplay(questionList[currentQuestion - 1].Type);
                if (currentQuestion == numOfQuestions)
                    btnSubmit.Text = "Finish";
                this.Text = "The Simpsons Trivia Question: " +
                            currentQuestion.ToString() +
                            " of " +
                            numOfQuestions.ToString();
            }
            else
            {
                grpBxSelections.Visible = false;
                radOption1T.Visible = false;
                radOption2.Visible = false;
                radOption3F.Visible = false;
                lblEntryResult.Visible = false;
                txtEntryResult.Visible = false;
                ShowResults();
                btnSubmit.Text = "Close";
            }
        }

        private void ShowResults()
        {
            double score = (double)correctTotal / (double)numOfQuestions;
            string quip = string.Empty;

            if (score == 1)
                quip = "Well played Brad, well played!";
            if (score < 1 && score > 0.89)
                quip = "Keep up the good work and watch more!";
            if (score < 0.9 && score > 0.79)
                quip = "Very good, just try harder next time.";
            if (score < 0.8 && score > 0.69)
                quip = "Pay attention more while watching, you are missing out.";
            if (score < 0.7 && score > 0.59)
                quip = "Not bad, for an average person";
            if (score < 0.6 && score > 0.49)
                quip = "Really? Come on guess better.";
            if (score < 0.5 && score > 0.39)
                quip = "Now you are just toying with me aren't you?";
            if (score < 0.4 && score > 0.29)
                quip = "This is not funny, open your eyes.";
            if (score < 0.3 && score > 0.19)
                quip = "Oh come on! A monkey can do better.";
            if (score < 0.2 && score > 0.09)
                quip = "Did you even look before you clicked?";
            if (score < 0.1 && score > 0)
                quip = "Seriously? Do you even watch the Simpsons?";
            if (score == 0)
                quip = "(╯°□°）╯︵ ┻━┻";

            txtQuestion.Text = quip + Environment.NewLine + "You answered: " + correctTotal.ToString() +
                             " out of " + numOfQuestions.ToString() +
                             " correct.\nYour Score: " + score.ToString("P0");
        }

        private void CheckAnswer(char t)
        {
            switch (t)
            {
                case 'M':
                    if (radOption1T.Checked &&
                        radOption1T.Text == questionList[currentQuestion - 1].Answer ||
                        radOption2.Checked &&
                        radOption2.Text == questionList[currentQuestion - 1].Answer ||
                        radOption3F.Checked &&
                        radOption3F.Text == questionList[currentQuestion - 1].Answer)
                    {
                        correctTotal++;
                        txtCorrectAnswer.Text = "Correct!";
                    }
                    else
                        txtCorrectAnswer.Text = "Wrong, it was " + questionList[currentQuestion -1].Answer;
                    break;
                case 'T':
                    if (radOption1T.Checked && questionList[currentQuestion - 1].Answer == "True")
                    {
                        correctTotal++;
                        txtCorrectAnswer.Text = "Correct!";
                    }
                    else
                        if (radOption3F.Checked && questionList[currentQuestion - 1].Answer == "False")
                        {
                            correctTotal++;
                            txtCorrectAnswer.Text = "Correct! " + questionList[currentQuestion - 1].Option1; ;
                        }
                        else
                            txtCorrectAnswer.Text = "Wrong. Correct Answer: " + questionList[currentQuestion - 1].Answer;
                    break;
                case 'S':
                    WordChecker.WordChecker check = new WordChecker.WordChecker();
                    if (check.CompareAllLetters(questionList[currentQuestion - 1].Answer, txtEntryResult.Text) > 0.59)
                    {
                        txtCorrectAnswer.Text = string.Empty;
                        correctTotal++;
                        txtCorrectAnswer.Text = "Correct!";
                    }
                    else
                    {
                        txtCorrectAnswer.Text = "Wrong. Correct Answer: " + questionList[currentQuestion - 1].Answer;
                        //For testing purpose
                        //txtCorrectAnswer.Text += " " + (check.CompleteCheck(questionList[currentQuestion - 1].Answer, txtEntryResult.Text)).ToString("P");
                    }
                    txtEntryResult.Text = string.Empty;
                    break;
                default:
                    break;
            }
            lblResults.Text = "Total Correct: " + correctTotal.ToString();
        }
    }
}
