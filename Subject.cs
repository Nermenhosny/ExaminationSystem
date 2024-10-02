using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam02
{

    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam exam { get; set; }

        FinalExam FinalExamInstance;

        PracticalExam PracticalExamInstance;

        public Subject(int subjectId, string subjectName)
        {
            SubjectId=subjectId;
            SubjectName=subjectName;

        }

        public void CreateExam()
        {
            //Exam Details
            Console.WriteLine("Please Enter The type Of Exam You Want To Create(1 for practical and 2 for Final): ");
            int ExamType;
            while (!(int.TryParse(Console.ReadLine(), out ExamType) && (ExamType == 1 || ExamType == 2)))
            {
                Console.WriteLine("Invalid Input Please Enter 1 for practical and 2 for Final: ");
            }
            Console.WriteLine("Please Enter The Time Of Exam In Minutes: ");
            int TimeOfExam;
            while (!(int.TryParse(Console.ReadLine(), out TimeOfExam)))
            {
                Console.WriteLine("Invalid Input Please Enter the Time Of Exam In Minutes: ");
            }
            Console.WriteLine("Please Enter The Number Of Questions You Wanted To Create: ");
            int NumberOfQuestions;
            while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions))
            {
                Console.WriteLine("Invalid Input Please Enter Valid Questions Number: ");
            }
            int cnt = NumberOfQuestions;
            int i = 1;
            Console.Clear();
            if (ExamType == 1)
            {
                //Practical Exam
                PracticalExamInstance = new PracticalExam(TimeOfExam, NumberOfQuestions);
                exam = PracticalExamInstance;
                while (cnt > 0 )
                {
                    Answers[] Choices = new Answers[3];
                    Console.WriteLine("Choose One Answer Question: ");
                    string HeaderOfTheQuestion = "Choose One Answer";

                    Console.WriteLine($"Please Enter The Body Of Question{i}: ");
                    string QuestionBody = Console.ReadLine();

                    Console.WriteLine("Please Enter The Mark Of The Question: ");
                    int mark;

                    while (!int.TryParse(Console.ReadLine(), out mark))
                    {
                        Console.WriteLine("Invalid Input Please Valid Mark ");
                    }
                    Console.WriteLine("The Choices Of Question: ");
                    for (int choiceNumber = 1; choiceNumber <= 3; choiceNumber++)
                    {
                        Console.WriteLine($"Please Enter The Choice Number {choiceNumber}: ");
                        Choices[choiceNumber-1]= new Answers(choiceNumber, Console.ReadLine());
                    }



                    Console.WriteLine("Please Specify The Right Answer From 1 to 3: ");
                    int RightAnswer;

                   while (!(int.TryParse(Console.ReadLine(), out RightAnswer) && (RightAnswer >= 1 && RightAnswer <= 3)))

                   {
                            Console.WriteLine("Invalid Input Please Enter Valid Right Answer From 1 to 3: ");
                   }
                    Question question = new Question(HeaderOfTheQuestion, QuestionBody, mark, Choices, RightAnswer);
                    PracticalExamInstance.AddQuestion(question);

                    i++;
                    cnt--;
                    Console.Clear();
                }



            }

            else
            {
                //Final Exam
                FinalExamInstance = new FinalExam(TimeOfExam, NumberOfQuestions);
                exam = FinalExamInstance;
                while (cnt > 0)
                {
                    Answers[] trueOrfalse = new Answers[2] { new Answers(1, "True"), new Answers(1, "False") };

                    Console.WriteLine($"Please Choose The type Of Question Number{i} (1 for True Or False and 2 for MCQ): ");
                    int QuestionsType;
                    while (!(int.TryParse(Console.ReadLine(), out QuestionsType) ||(QuestionsType == 1 || QuestionsType == 2)))
                    {
                        Console.WriteLine("Invalid Input Please Enter 1 for True Or False and 2 for MCQ ");
                    }
                    Console.Clear();
                    if (QuestionsType == 1)
                    {
                        //TrueFalse Question
                        Console.WriteLine("True | False Question: ");
                        string HeaderOfTheQuestion = "True | False Question";

                        Console.WriteLine("Please Enter The Body Of Question: ");
                        string QuestionBody = Console.ReadLine();

                        Console.WriteLine("Please Enter The Mark Of Question: ");
                        int mark;
                        while (!int.TryParse(Console.ReadLine(), out mark))
                        {
                            Console.WriteLine("Invalid Input Please Enter Valid Mark: ");
                        }

                        Console.WriteLine("Please Enter The Right Answer Of Question (1 For True and 2 For False): ");
                        int RightAnswer;
                        while (!(int.TryParse(Console.ReadLine(), out RightAnswer) && (RightAnswer > 0 && RightAnswer < 3)))
                        {
                            Console.WriteLine("Invalid Input Please Enter (1 For True and 2 For False): ");
                        }

                        Question question = new Question(HeaderOfTheQuestion, QuestionBody, mark, trueOrfalse, RightAnswer);
                        FinalExamInstance.AddQuestion(question);

                        i++;
                        Console.Clear();
                    }
                    else
                    {
                        //MCQ quetion

                        Answers[] Choices = new Answers[3];
                        Console.WriteLine("Choose One Answer Question: ");
                        string HeaderOfTheQuestion = "Choose One Answer";

                        Console.WriteLine("Please Enter The Body Of Question: ");
                        string QuestionBody = Console.ReadLine();

                        Console.WriteLine("Please Enter The Mark Of Question: ");
                        int mark;

                        while (!int.TryParse(Console.ReadLine(), out mark))
                        {
                            Console.WriteLine("Invalid Input Please Valid Mark ");
                        }
                        Console.WriteLine("The Choices Of Question: ");
                        for (int choiceNumber = 1; choiceNumber <= 3; choiceNumber++)
                        {
                            Console.WriteLine($"Please Enter The Choice Number {choiceNumber}: ");
                            Choices[choiceNumber-1]= new Answers(choiceNumber, Console.ReadLine());
                        }



                        Console.WriteLine("Please Specify The Right Answer From 1 to 3: ");
                        int RightAnswer;
                        while (!(int.TryParse(Console.ReadLine(), out RightAnswer) && (RightAnswer >= 1 && RightAnswer <= 3)))
                        {
                            Console.WriteLine("Invalid Input Please Enter Valid Right Answer From 1 to 3: ");
                        }
                        Question question = new Question(HeaderOfTheQuestion, QuestionBody, mark, Choices, RightAnswer);
                        FinalExamInstance.AddQuestion(question);

                        i++;
                        Console.Clear();
                    }

                    cnt--;

                }


            }


        }


        public override string ToString()
        {
            return $"SubjectId=>{SubjectId} ,SubjectName=>{SubjectName}";
        }



       



    }
}
