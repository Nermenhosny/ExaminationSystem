using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set;}
        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }
        public abstract void showExam();

       
    }
}
