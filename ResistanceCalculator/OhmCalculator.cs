using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResistanceCalculator.Shared;

namespace ResistanceCalculator.Service
{
    public class OhmCalculator : IOhmValueCalculator
    {
        
        public double CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            try
            {
                //Validations
                if (string.IsNullOrEmpty(bandAColor) || !ColorCodeMappings.SignificantFigures.Keys.Contains(bandAColor?.ToLower()))
                    throw new InvalidBandColorException('A',"Not a valid color");
                if (string.IsNullOrEmpty(bandBColor) || !ColorCodeMappings.SignificantFigures.Keys.Contains(bandBColor?.ToLower()))
                    throw new InvalidBandColorException('B', "Not a valid color");
                if (string.IsNullOrEmpty(bandCColor) || !ColorCodeMappings.Multiplier.Keys.Contains(bandCColor?.ToLower()))
                    throw new InvalidBandColorException('C', "Not a valid color");
                if (string.IsNullOrEmpty(bandDColor) || !ColorCodeMappings.Tolerance.Keys.Contains(bandDColor?.ToLower()))
                    throw new InvalidBandColorException('D', "Not a valid color");

                //Concatenate first and second band values
                int ohmValue = Convert.ToInt32(string.Format("{0}{1}", ColorCodeMappings.SignificantFigures[bandAColor.ToLower()], ColorCodeMappings.SignificantFigures[bandBColor.ToLower()]));
                
                int multiplier = ColorCodeMappings.Multiplier[bandCColor.ToLower()];

                // Multiplying the concatenated value with multipler to determine resistance
                double result = (ohmValue * Math.Pow(10, multiplier));
                
                return result;               
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.Message);
                throw;
            }
        }
    }
}
