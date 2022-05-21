using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Abstract
{
    public interface IAnswerParsable<T> where T : Answer
    {
        public bool Parse(T answer);
    }

    public abstract class Answer
    {

    }

    public class RadioAnswer : Answer
    {
        public RadioAnswer(int idChoosen)
        {
            IdChoosen = idChoosen;
        }
        public int IdChoosen { get; set; }
    }

    public class CheckAnswer : Answer
    {

    }
}
