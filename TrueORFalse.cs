using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class TrueOrFalse : Question
    {

   

        public TrueOrFalse(string header, string body, int mark, Answers[] answers, int correctAnswer): base(header, body, mark, answers, correctAnswer )
        {
            answers= new Answers[]
            {
                new Answers(1 , " True"),
                new Answers(2, "False")
            };
            RightAnswer = correctAnswer;
        }


      

    }
}
