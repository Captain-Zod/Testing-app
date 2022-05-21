using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Abstract
{
    public abstract class Question
    {
        private IEnumerable<Attachment> _attachments;
        public Question()
        {
            _attachments = new List<Attachment>();
        }
        public Question(IEnumerable<Attachment> attachments)
        {
            _attachments = attachments;
            
        }
        public IEnumerable<Attachment> Attachments => _attachments;
        public int Points { get; set; }
        public string Text { get; set; }
        public bool TesterChecks { get; set; }
    }

    

    
}
