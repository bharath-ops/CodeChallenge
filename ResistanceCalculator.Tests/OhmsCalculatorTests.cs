using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistanceCalculator.Service;

namespace ResistanceCalculator.Tests
{
    [TestClass]
    public class OhmsCalculatorTests
    {
        [TestMethod]
        public void CalculateOnmValue_ValidParameters_ReturnsResistance()
        {
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance =  objOhmCalculator.CalculateOhmValue("brown", "red", "red", "yellow");

            Assert.AreEqual(resistance, 1200);
        }

        [TestMethod]
        public void CalculateOnmValue_HighValue_ReturnsResistance()
        {
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue("white", "white", "white", "gold");

            Assert.AreEqual(resistance, 99000000000);
        }

        [TestMethod]
        public void CalculateOnmValue_LowValue_ReturnsResistance()
        {
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue("black", "brown", "pink", "gold");

            Assert.AreEqual(resistance, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBandColorException), "Invalid color accepted for Band A")]
        public void CalculateOnmValue_InValidBandA_ReturnsException()
        {           
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue("Pale", "red", "red", "yellow");        
            
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBandColorException), "Invalid color accepted for Band B")]
        public void CalculateOnmValue_InValidBandB_ReturnsException()
        {
          
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue("brown", "pale", "red", "yellow");
          
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBandColorException), "Invalid color accepted for Band C")]
        public void CalculateOnmValue_InValidBandC_ReturnsException()
        {          
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue("brown", "red", "pale", "yellow");         
           
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidBandColorException), "Invalid color accepted for Band D")]
        public void CalculateOnmValue_InValidBandD_ReturnsException()
        {           
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue("brown", "red", "red", "pale");           
        }    

        [TestMethod]
        [ExpectedException(typeof(InvalidBandColorException), "Null parameter accepted for Bands")]
        public void CalculateOnmValue_NullValues_ReturnsException()
        {            
            var objOhmCalculator = new Service.OhmCalculator();

            var resistance = objOhmCalculator.CalculateOhmValue(null,null,null,null);         
        }
    }
}
