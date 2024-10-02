using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    //1. Design a Class to represent the Question Object, Question is 
    public  class Question
    {
        public  string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public int Mark { get; set; }
  
        public Answers[] AnswerList { get; set; }
        public int RightAnswer { get; set; }

        public Question()
        {

        }
        public Question(string headerOfTheQuestion, string bodyOfTheQuestion, int mark,  Answers[] answerList, int rightList)
        {
            HeaderOfTheQuestion=headerOfTheQuestion;
            BodyOfTheQuestion=bodyOfTheQuestion;
            Mark=mark;
            AnswerList=answerList;
            RightAnswer=rightList;
        }
 
        public override string ToString()
        {
            return $"{HeaderOfTheQuestion}                 Mark=>{Mark}\n{BodyOfTheQuestion}";
        }

    }
   
   


}
