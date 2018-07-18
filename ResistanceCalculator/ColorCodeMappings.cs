using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCalculator.Service
{
    internal static class ColorCodeMappings
    {
        //Color Code dictionary for Band A and B(Significant figures)
        public static readonly IReadOnlyDictionary<string, int> SignificantFigures = new Dictionary<string, int>
        {
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
        };

        // Color code dictionary for Band C(Multiplier)
        public static readonly IReadOnlyDictionary<string, int> Multiplier =  new Dictionary<string, int> {
                    {"pink", -3},
                    {"silver",  -2},
                    {"gold",  -1},
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange",3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue",  6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
            };

        // Color code dictionary for Band D(Tolerance)
        public static readonly IReadOnlyDictionary<string, double> Tolerance = new Dictionary<string, double> {
                    {"silver", 0.10},
                    {"gold", 0.05},
                    {"brown",  0.01},
                    {"red", 0.02},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005}
            };


    }
}
