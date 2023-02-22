using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_SD43_Task
{
    abstract internal class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public Question[] QuestionList { get; set; }

        protected AnswerList StudentAnswers { get; set; }

        public Exam(int time, int numberOfQuestions, Question[] questionList)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            QuestionList = questionList;
            
        }

        public abstract void showExam();
        
    }

    class practiceExam : Exam
    {
        public practiceExam(int time, int numberOfQuestions, Question[] questionList) : base(time, numberOfQuestions, questionList)
        {
        }

        public override void showExam()
        {
            StudentAnswers= new AnswerList(new string[NumberOfQuestions]);
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"{i + 1}){QuestionList[i].ToString()}");
                Console.WriteLine("===");
                Console.Write("Your Answer: ");
                var x = Console.ReadLine();
                StudentAnswers.list[i] = x;
                Console.WriteLine($"Correct Answer is : {QuestionList[i].mod_answer.ToString()}");
            }
        }
    }
    class finalExam : Exam
    {
        public finalExam(int time, int numberOfQuestions, Question[] questionList) : base(time, numberOfQuestions, questionList)
        {
        }

        public override void showExam()
        {
            StudentAnswers = new AnswerList(new string[NumberOfQuestions]);
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"{i + 1}){QuestionList[i].ToString()}");
                Console.WriteLine("===");
                Console.Write("Your Answer: ");
                var x = Console.ReadLine();
                StudentAnswers.list[i] = x;
            }
        }
        public double ExamCorrection ()
        {
            var counter = 0;
            var totalGrade = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                
                if (QuestionList[i].mod_answer.ToString() == StudentAnswers.list[i])
                {
                    counter += QuestionList[i].Marks;
                    totalGrade += QuestionList[i].Marks;
                }
                else
                {
                    totalGrade += QuestionList[i].Marks;
                }
            }
            return ((double)counter/totalGrade)*100;
        }
    }
}
