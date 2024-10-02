using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class PracticalExam : Exam
    {
        public List<Question> questions { get; set; }

        public PracticalExam(int timeOfExam, int numberOfQuestions): base(timeOfExam, numberOfQuestions)
        {
            questions = new List<Question>();
        }
        public void AddQuestion(Question question)
        {
            questions.Add(question);

        }
        public override void showExam()
        {
            Console.WriteLine("Exam Details: ");
            Console.WriteLine("           Practical Exam         ");
            Console.WriteLine($"The Time : {TimeOfExam} Minute");
            Console.WriteLine($"The Number Of Questions:{NumberOfQuestions} Question ");
            Console.WriteLine("_____________________________________");
            DisplayResults();
        }

        public string[] displayQuestions(out int grade, out int totalGrade)
        {
            grade = 0;
            totalGrade = 0;
            string[] UserAnswers = new string[questions.Count];
            int[] grades = new int[questions.Count];
            for (int i = 0; i<questions.Count; i++)
            {

                Console.WriteLine($"Q{i+1}) {questions[i]}");

                for (int j = 0; j < questions[i].AnswerList.Length; j++)
                {
                    Console.Write($"{j+1}.{questions[i].AnswerList[j].AnswerText}      ");
                }
                Console.WriteLine();
                Console.WriteLine("_____________________________________");

                int ans;
                while (!(int.TryParse(Console.ReadLine(), out ans) && (ans > 0 && ans < 3)))
                {
                    Console.WriteLine("Invalid Input Please Enter Your Answer From 1 to 3: ");
                }

                UserAnswers[i] = questions[i].AnswerList[ans-1].AnswerText;


                if (ans == questions[i].RightAnswer)
                    grade += questions[i].Mark;
                Console.WriteLine("=====================================");
                totalGrade += questions[i].Mark;

            }

            return UserAnswers;

        }

        private void DisplayResults()
        {

            int grade, totalGrade;

            string[] UserAnswersMCQ = displayQuestions(out grade, out totalGrade);



            Console.Clear();
            Console.WriteLine("Your Answers:");

            // Display results for MCQ
            for (int i = 0; i <questions.Count; i++)
            {

                Console.WriteLine($"Q{i+1}) {questions[i].BodyOfTheQuestion} :Your Answer is {UserAnswersMCQ[i]} And The Right Answer is {questions[i].AnswerList[questions[i].RightAnswer-1].AnswerText} ");

            }



           

        }






    }
    
}
