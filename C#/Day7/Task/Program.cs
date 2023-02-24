namespace D7_SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Attempt to work with text write
            // Question[] list1 =
            //{
            //     new TrueOrFalse("body1", 10, "header1", new Answer("true")),
            //     new TrueOrFalse("body2", 10, "header2", new Answer("false")),
            //     new TrueOrFalse("body3", 10, "header3", new Answer("true")),
            //     new ChooseOne("body4",10,"header4",new Answer("a"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
            //     new ChooseOne("body5",10,"header5",new Answer("b"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
            //     new ChooseOne("body6",10,"header6",new Answer("c"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
            //     new ChooseAll("body7",10,"header7",new Answer("a,b"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
            //     new ChooseAll("body8",10,"header8",new Answer("b,c"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
            //     new ChooseAll("body9",10,"header9",new Answer("a,b,c"),new AnswerList(new string[]{"a)ans1", "b)ans2", "c)ans3"})),
            // };
            // string filePath = @"D:\AT\ITI-PD43\C#\Day7\Task\LogFolder\myfile3.txt";
            // using(TextWriter textWriter=File.CreateText(filePath))
            // {
            //     textWriter.WriteLine("Hello from the other side");
            //     textWriter.WriteLine("ok lets try it again side by sides");
            // }
            // Console.WriteLine("write ok ya 3am"); 
            #endregion
            #region loggin the question with more than one question list
            //Question q1 = new TrueOrFalse("body1", 10, "header1", new Answer("true"));
            //Question q2 = new TrueOrFalse("body2", 10, "header2", new Answer("false"));
            //Question q3 = new ChooseOne("body4", 10, "header4", new Answer("a"), new AnswerList(new string[] { "a)ans1", "b)ans2", "c)ans3" }));
            //QuestionList l1 = new QuestionList();
            //l1.Add(q1);
            //l1.Add(q2);
            //l1.Add(q3);
            //Console.WriteLine(l1.Count);
            //QuestionList l2= new QuestionList();
            //l2.Add(q2);
            //l2.Add(q3);
            //l2.Add(q1);
            #endregion
            #region reading from file
            //string filePath = @$"D:\AT\ITI-PD43\C#\Day7\Task\LogFolder\Question1.txt";
            //using(TextReader reader= File.OpenText(filePath))
            //{
            //    string x=reader.ReadToEnd();
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Main Task
            AnswerList a1 = new AnswerList(new());
            a1.list.Add("a)ans1");
            a1.list.Add("b)ans2");
            a1.list.Add("c)ans3");
            Question q1 = new TrueOrFalse("body1", 10, "header1", new Answer("true"));
            Question q2 = new TrueOrFalse("body2", 10, "header2", new Answer("false"));
            Question q3 = new TrueOrFalse("body3", 10, "header3", new Answer("true"));
            Question q4 = new ChooseOne("body4", 10, "header4", new Answer("a"), a1);
            Question q5 = new ChooseOne("body5", 10, "header5", new Answer("b"), a1);
            Question q6 = new ChooseOne("body6", 10, "header6", new Answer("c"), a1);
            Question q7 = new ChooseAll("body7", 10, "header7", new Answer("a,b"), a1);
            Question q8 = new ChooseAll("body8", 10, "header8", new Answer("b,c"), a1);
            Question q9 = new ChooseAll("body9", 10, "header9", new Answer("a,b,c"), a1);

            QuestionList l4 = new QuestionList();
            l4.Add(q1);
            l4.Add(q2);
            l4.Add(q3);
            l4.Add(q4);
            l4.Add(q5);
            l4.Add(q6);
            l4.Add(q7);
            l4.Add(q8);
            l4.Add(q9);
            string x;
            do
            {
                Console.WriteLine("Please enter exam type practice or final");
                x = Console.ReadLine();
            } while (!(x == "practice" || x == "final"));
            if (x == "practice")
            {

                Exam e1 = new practiceExam(60, 9, l4);
                e1.showExam();
            }
            else
            {
                finalExam e1 = new finalExam(60, 9, l4);
                e1.showExam();

                Console.WriteLine("===========================");
                Console.WriteLine($"Your grade in this exam is: {Math.Round(e1.ExamCorrection())}%");
            }





            ////Exam e1 = new practiceExam(60, 9, l4);
            ////e1.showExam();
            //finalExam e2 = new finalExam(60, 9, l4);
            //e2.showExam();
            //Console.WriteLine("==================");
            //Console.WriteLine($"Your grade in this exam is:{Math.Round(e2.ExamCorrection())}%");

            #endregion


            #region Testing cloneImplemntation
            //finalExam e2 = new finalExam(60, 9, l4);
            //finalExam e3 = (finalExam)e2.Clone();
            //e3.QuestionList.RemoveAt(0);
            //e3.Time = 900;
            //Console.WriteLine(e2.QuestionList[0]);
            //Console.WriteLine(e3.QuestionList[0]);
            //Console.WriteLine(e2.Time);
            //Console.WriteLine(e3.Time);
            #endregion


            #region Testing icompare &equals
            //Exam e1 = new practiceExam(60, 9, l4);
            //finalExam e2 = new finalExam(60, 9, l4);
            //finalExam e3 = new finalExam(60, 10, l4);
            //finalExam e4 = new finalExam(60, 9, l4);
            //finalExam e5 = e4; 

            //Console.WriteLine(e2.CompareTo(null));
            //Console.WriteLine(e2.CompareTo(e1));
            //Console.WriteLine(e2.CompareTo(e3));
            //Console.WriteLine(e2.CompareTo(e4));
            //Console.WriteLine(e2.Equals(e4));
            //Console.WriteLine(e5.Equals(e4));
            #endregion

           
        }
    }
}