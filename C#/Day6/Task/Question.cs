using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_SD43_Task
{
    internal class Question
    {
        public string Body { get; set; }
        public int Marks { get; set; }
        public string Header { get; set; }
        public Answer mod_answer { get; set; }

        public Question(string _body,int _marks, string _header, Answer _mod_answer)
        {
            Body = _body;
            Marks = _marks;
            Header = _header;
            this.mod_answer = _mod_answer;
        }
    }

    class TrueOrFalse : Question
    {
        public TrueOrFalse(string _body, int _marks, string _header ,Answer _answer) : base(_body, _marks, _header,_answer)
        {

        }

        public override string ToString()
        {

            return $"{Header}:\n{Body}\nTrue\nFalse";
            
        }
    }
    class ChooseOne : Question
    {
        public AnswerList choices { get; set; }
        public ChooseOne(string _body, int _marks, string _header,Answer _mod_ans,AnswerList _choices) : base(_body, _marks, _header,_mod_ans)
        {

            choices= _choices;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append(Header);
            sb.Append("\n");
            sb.Append(Body);
            sb.Append("\n");
            sb.Append(choices.ToString());
            return sb.ToString();
        }
    }
    class ChooseAll : Question
    {
        public AnswerList choices { get; set; }
        public ChooseAll(string _body, int _marks, string _header, Answer _mod_answer, AnswerList _choice) : base(_body, _marks, _header, _mod_answer)
        {
            choices = _choice;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("You can choose More than one\n");
            sb.Append(Header);
            sb.Append("\n");
            sb.Append(Body);
            sb.Append("\n");
            sb.Append(choices.ToString());
            return sb.ToString();
        
        }

    }
}
