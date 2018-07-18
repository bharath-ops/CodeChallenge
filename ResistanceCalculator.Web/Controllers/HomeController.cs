using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResistanceCalculator.Service;
using ResistanceCalculator.Shared;
using ResistanceCalculator.Web.Models;
using ResistanceCalculator.Web.Utilties;

namespace ResistanceCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private IOhmValueCalculator _ohmCalculator;

        public HomeController(IOhmValueCalculator ohmCalculator)
        {
            _ohmCalculator = ohmCalculator;
        }

        public ActionResult Index()
        {
            try
            {
                //Load dropdown values for Band A, Band B, Band C, and Band D
                ColorCodes colorCodes = new ColorCodes();

                //Return index view containing the color code calculator user interface
                return View(colorCodes);
            }
            catch (Exception ex)
            {
                // if exception then return error as response 
                return Json(new { error = "Exception ocurred while loading select controls: " + ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetResistanceValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            try
            {
                ColorCodes colorCodes = new ColorCodes();
                // Call library method to calculcate the resistance value.
                double ohmValue = _ohmCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);

                var tolerance = colorCodes.Tolerance[bandDColor].Item2;

                string resistance = Formatters.FormatResistance(ohmValue, tolerance);
                                
                /// return JSON response
                return Json(new { resistance = resistance }, JsonRequestBehavior.AllowGet);                
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.Message);
                throw ex;              
            }
        }

        
    }
}