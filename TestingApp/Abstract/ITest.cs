using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Abstract
{
    public interface ITest
    {
        IEnumerable<IQuestion> Questions { get; set; }
    }
}
