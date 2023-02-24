using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Metrics;

namespace D7_SD43_Task
{
    internal class QuestionList : List<Question>
    {
      public static int counter { get; set; } = 1;
        int innerCounter { get; set; }
        public QuestionList() 
        {
            innerCounter = counter;
            counter++;
        }


        public new void  Add(Question item)
        {
            string filePath = @$"D:\AT\ITI-PD43\C#\Day7\Task\LogFolder\QuestionList{innerCounter}.txt";
            using(TextWriter writer=File.AppendText(filePath))
            {
                writer.WriteLine(item.ToString());
                writer.WriteLine("====================");
            }
            base.Add(item);
        }
    }
}
