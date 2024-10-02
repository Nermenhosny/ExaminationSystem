using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class MCQ : Question
    {


        public MCQ(string header, string body, int mark, Answers[] answers, int correctAnswer) : base(header, body, mark, answers, correctAnswer)
        {
            AnswerList = new Answers[3];

        }


    }
}
