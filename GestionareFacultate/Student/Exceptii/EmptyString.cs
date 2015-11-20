using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Exceptii
{
    public class EmptyString:ArgumentException
    {
        public EmptyString(string exceptieEmpty)
            : base(string.Format("Argument {0} cannot be empty string.", exceptieEmpty), exceptieEmpty)
        {

        }
    }
}
