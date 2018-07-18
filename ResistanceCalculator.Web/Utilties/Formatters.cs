using ResistanceCalculator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistanceCalculator.Web.Utilties
{
    public static class Formatters
    {
        public static string FormatResistance(double ohmValue, double tolerance)
        {

            ColorCodes colorCodes = new ColorCodes();
            string resistance;
            //to show in Mega format 
            if (ohmValue >= 100000000)
                resistance = (ohmValue / 1000000).ToString("#,0M") + "Ω";

            else if (ohmValue >= 10000000)
                resistance = (ohmValue / 1000000).ToString("0.#") + "MΩ";
            //to show in Kilo format
            else if (ohmValue >= 100000)
                resistance = (ohmValue / 1000).ToString("#,0KΩ");

            else if (ohmValue >= 10000)
                resistance = (ohmValue / 1000).ToString("0.#") + "KΩ";
            else
                resistance = ohmValue.ToString() + "Ω";
         
            if (ohmValue > 0)
            {
                resistance = resistance + "    " + " ±"+ tolerance.ToString()+"%";
            }

            return resistance;

        }
    }
}