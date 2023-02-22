namespace D6_SD43_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question[] list1 =
            {
                new TrueOrFalse("body1", 10, "header1", new Answer("true")),
                new TrueOrFalse("body2", 10, "header2", new Answer("false")),
                new TrueOrFalse("body3", 10, "header3", new Answer("true")),
                new ChooseOne("body4",10,"header4",new Answer("a"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
                new ChooseOne("body5",10,"header5",new Answer("b"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
                new ChooseOne("body6",10,"header6",new Answer("c"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
                new ChooseAll("body7",10,"header7",new Answer("a,b"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
                new ChooseAll("body8",10,"header8",new Answer("b,c"),new AnswerList(new string[]{"a)ans1","b)ans2","c)ans3"})),
                new ChooseAll("body9",10,"header9",new Answer("a,b,c"),new AnswerList(new string[]{"a)ans1", "b)ans2", "c)ans3"})),
            };
            string x;
            do
            {
                Console.WriteLine("Please enter exam type practice or final");
                 x=Console.ReadLine();
            } while (!(x=="practice"||x=="final"));
            if(x=="practice")
            {

                Exam e1 = new practiceExam(60, 9, list1);
                e1.showExam();
            }
            else
            {
                finalExam e1 = new finalExam(60, 9, list1);
                e1.showExam();

                Console.WriteLine("===========================");
                Console.WriteLine($"Your grade in this exam is: {Math.Round(e1.ExamCorrection())}%");
            }


            //Exam e1 = new practiceExam(60, 9, list1);
            //e1.showExam();


        }
    }
}