using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistanceCalculator.Web.Models
{
    public class ColorCodes
    {
        //color code dictionaries for loading band A and band B Significant 
        public Dictionary<string, string> SignificantFigure;
        //color code dictionaries for loading band C select control
        public Dictionary<string, string> Multiplier;
        //color code dictionaries for loading band D select control
        public Dictionary<string, Tuple<string, double>> Tolerance;

        public ColorCodes()
        {
            //intialize band A and band B select control 
            SignificantFigure = new Dictionary<string, string> {
                    {"black", "0 Black"},
                    {"brown", "1 Brown"},
                    {"red", "2 Red"},
                    {"orange", "3 Orange"},
                    {"yellow", "4 Yellow"},
                    {"green", "5 Green"},
                    {"blue", "6 Blue"},
                    {"violet", "7 Violet"},
                    {"gray", "8 Gray"},
                    {"white", "9 White"}
                };

            //intialize band C select control 
            Multiplier = new Dictionary<string, string> {
                    {"pink", "x0.001 Pink"},
                    {"silver", "x0.01 Silver"},
                    {"gold", "x0.1 Gold"},
                    {"black", "x1 Black"},
                    {"brown", "x10 Brown"},
                    {"red", "x100 Red"},
                    {"orange", "x1k Orange"},
                    {"yellow", "x10k Yellow"},
                    {"green", "x100k Green"},
                    {"blue", "x1M Blue"},
                    {"violet",  "x10M Violet"},
                    {"gray",  "x100M Gray"},
                    {"white", "x1000M White"}
            };

            //intialize band D select control 
            Tolerance = new Dictionary<string, Tuple<string,double>> {
                    {"silver",  new Tuple<string,double>("± 10% Silver",10)},
                    {"gold", new Tuple<string,double>("± 5% Gold",5) },
                    {"yellow", new Tuple<string,double>("± 5% Yellow",5)},
                    {"red", new Tuple<string,double>("± 2% Red",2)},
                    {"brown", new Tuple<string,double>("± 1% Brown",1)},
                    {"green", new Tuple<string,double>("± 0.5% Green",0.5)},
                    {"blue",  new Tuple<string,double>("± 0.25% Blue",0.25)},
                    {"violet", new Tuple<string,double>("± 0.1% Violet",0.1)},
                    {"gray", new Tuple<string,double>("± 0.05% Gray",0.05)}
            };

            
        }
    }
}