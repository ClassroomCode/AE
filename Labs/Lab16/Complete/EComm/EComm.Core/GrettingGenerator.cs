using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Core
{
    public class GrettingGenerator
    {
        public string GetGreeting(string name, DateTime? dt = null)
        {
            var now = dt ?? DateTime.Now;
            if (now.Hour > 12) {
                //
            }
            return "";
        }
    }
}
