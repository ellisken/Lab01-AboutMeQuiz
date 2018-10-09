using System;

namespace AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define questions and answers
            string[] questions = {
                "How old was I when I got my driver's license?",
                "T or F: I can wiggle my ears.",
                "T or F: I like cats more than dogs.",
                "What is the last name of my favorite author?",
                "T or F:I've had to different legal names. "
            };

            string[] answers = {
                "16",
                "false",
                "true",
                "Nabokov",
                "T"
            };

            //Ask each question and get score

            //Display score to user


        }


        //Asks the given question and returns the user's answer
        static string AskQuestionGetAnswer(string question)
        {
            //Ask question
            Console.WriteLine(question);

            //Get answer
            string answer = Console.ReadLine();

            return answer;
        }


        //Checks the user's answer against the real answer. Returns true if
        //there's a match, otherwise returns false
        static bool CheckAnswer(string answer, string userInput)
        {
        }


        //Determines whether another point should be added
        //and returns the new, updated score
        static int UpdateScore(bool correctAnswer)
        {
            int score = 0;
            return score;
        }
    }

   
}
