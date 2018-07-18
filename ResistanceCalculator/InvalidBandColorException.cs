using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCalculator.Service
{
    public class InvalidBandColorException:Exception
    {
        public char BandName { get; set; }

        public InvalidBandColorException(char bandName, string message):base(message)
        {
            BandName = bandName;
        }
    
    }

}
