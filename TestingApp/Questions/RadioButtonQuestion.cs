using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Abstract;

namespace TestingApp.Questions
{
    public class RadioButtonQuestion : Question, IAnswerParsable<RadioAnswer>, IOptionable
    {
        public RadioButtonQuestion() : base()
        {
            Options = new List<Option>();
        }

        public RadioButtonQuestion(List<Option> options, IEnumerable<Attachment> attachments) : base(attachments)
        {
            Options = options;
        }

        public List<Option> Options { get; private set; }

        public bool Parse(RadioAnswer answer)
        {
            return answer.IdChoosen == 0; //todo
        }
    }
}
