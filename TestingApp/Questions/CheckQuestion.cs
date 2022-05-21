using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Abstract;

namespace TestingApp.Questions
{
    public class CheckQuestion : Question, IAnswerParsable<CheckAnswer>
    {
        public CheckQuestion() : base()
        {
            Options = new List<Option>();
        }

        public CheckQuestion(List<Option> options, IEnumerable<Attachment> attachments) : base(attachments)
        {
            Options = options;
        }

        public List<Option> Options { get; private set; }

        public bool Parse(RadioAnswer answer)
        {
            throw new NotImplementedException();
        }
    }
}
