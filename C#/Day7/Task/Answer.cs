using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7_SD43_Task
{
    internal class Answer
    {

        public string mod_answer { get; set; }
        public Answer(string _ans)
        {
            mod_answer= _ans;
        }
        public override string ToString()
        {
            return $"{mod_answer}";
        }
    }
    class AnswerList
    {
        public List<string> list { get; set;}

        public AnswerList(List<string> list)
        {
            this.list = list;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item.ToString());
                sb.Append('\n');
            }

            return sb.ToString();
        }
    }
}
