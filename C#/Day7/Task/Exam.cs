using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7_SD43_Task
{
    abstract internal class Exam :ICloneable,IComparable
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public QuestionList QuestionList { get; set; }

        
        public Dictionary<Question,string> studentAns { get; set; }
        //protected AnswerList StudentAnswers { get; set; }

        public Exam(int time, int numberOfQuestions, QuestionList questionList)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            QuestionList = questionList;
            
        }

        public abstract void showExam();

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }

    class practiceExam : Exam
    {
        public practiceExam(int time, int numberOfQuestions, QuestionList questionList) : base(time, numberOfQuestions, questionList)
        {
        }

        public new object Clone()
        {
            QuestionList temp = new QuestionList();
            for (int i = 0; i < this.QuestionList.Count; i++)
            {
                temp.Add(this.QuestionList[i]);
            }
            return new practiceExam(this.Time, this.NumberOfQuestions, temp);
        }

        public override void showExam()
        {
            //StudentAnswers= new AnswerList(new List<string>(NumberOfQuestions));
            studentAns= new Dictionary<Question, string>();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"{i + 1}){QuestionList[i].ToString()}");
                Console.WriteLine("===");
                Console.Write("Your Answer: ");
                var x = Console.ReadLine();
                //StudentAnswers.list[i] = x;
                studentAns[QuestionList[i]] = x;
                Console.WriteLine($"Correct Answer is : {QuestionList[i].mod_answer.ToString()}");
            }
        }
        public new int CompareTo(object? obj)
        {
            if(obj == null) return -1;
            if( obj is practiceExam ex)
            {
                if(ex==this)   return 0;
                if (ex.NumberOfQuestions > this.NumberOfQuestions) return 1;
                else if (ex.NumberOfQuestions < this.NumberOfQuestions) return -1;
                else return 0;
            }
            else { return -1; }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is practiceExam ex)
            {
                if (ex == this) return true;
                if (ex.Time == this.Time && ex.NumberOfQuestions == this.NumberOfQuestions && ex.QuestionList == this.QuestionList) return true;
                else return false;
            }
            else
            { return false; }

        }
    }
    class finalExam : Exam
    {
        public finalExam(int time, int numberOfQuestions, QuestionList questionList) : base(time, numberOfQuestions, questionList)
        {
        }

        public override void showExam()
        {
            //StudentAnswers = new AnswerList(new List<string>(NumberOfQuestions) );
            studentAns = new Dictionary<Question, string>();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine("=============================");
                Console.WriteLine($"{i + 1}){QuestionList[i].ToString()}");
                Console.WriteLine("===");
                Console.Write("Your Answer: ");
                var x = Console.ReadLine();
                studentAns[QuestionList[i]] = x;
                //StudentAnswers.list[i] = x;
            }
        }
        public double ExamCorrection ()
        {
            var counter = 0;
            var TotalGrade = 0;
            foreach (KeyValuePair<Question,string> item in studentAns)
            {
                if (item.Key.mod_answer.ToString() == item.Value)
                { counter += item.Key.Marks;
                   TotalGrade += item.Key.Marks;
                }
                else
                {
                    TotalGrade += item.Key.Marks;
                }
            }
           


            return ((double)counter/TotalGrade)*100;
        }
        public new object Clone()
        {
            QuestionList temp = new QuestionList();
            for (int i = 0; i < this.QuestionList.Count; i++)
            {
                temp.Add(this.QuestionList[i]);
            }
            return new finalExam(this.Time, this.NumberOfQuestions, temp);
        }
        public new int CompareTo(object? obj)
        {
            if (obj == null) return -1;
            if (obj is finalExam ex)
            {
                if (ex == this) return 0;
                if (ex.NumberOfQuestions > this.NumberOfQuestions) return 1;
                else if (ex.NumberOfQuestions < this.NumberOfQuestions) return -1;
                else return 0;
            }
            else { return -1; }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is finalExam ex)
            {
                if (ex == this) return true;
                if (ex.Time == this.Time && ex.NumberOfQuestions == this.NumberOfQuestions && ex.QuestionList==this.QuestionList) return true;
                else return false;
            }else
            { return false; }
            
        }
    }
}
