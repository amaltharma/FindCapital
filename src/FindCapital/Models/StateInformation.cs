using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindCapital.Models
{
   
    public class StateInformation
    {
        public string StateName { get; set; }

        public string StateNameAbbrivation { get; set; }

        public string StateCapitol { get; set; }

        public StateInformation(string StateName, string StateNameAbbrivation, string StateCapitol)
        {
            this.StateName = StateName;
            this.StateNameAbbrivation = StateNameAbbrivation;
            this.StateCapitol = StateCapitol;
        }
    }
}
