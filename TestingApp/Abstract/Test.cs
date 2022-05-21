using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Abstract
{
    public abstract class Test
    {
        public bool PointSystem { get; set; }
        IEnumerable<IQuestion> Questions { get; set; }
    }
}
