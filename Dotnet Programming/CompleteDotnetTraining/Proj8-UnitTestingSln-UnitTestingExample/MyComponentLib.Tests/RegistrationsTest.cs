using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyComponentLib.Components;
//Complete the method provided which accepts a collection of registration numbers and returns a collection of registration numbers which are sorted on RTO-Zonal area where the vehicles were registered. Note: If vehicles are from same area then they should be sorted based on registration sequence number
//3As of Testing
namespace MyComponentLib.Tests
{
    /// <summary>
    /// Summary description for RegistrationsTest
    /// </summary>
    [TestClass]
    public class RegistrationsTest
    {
        [TestMethod]
        public void Test_For_SortingVehicles_ByArea()
        {
            //Arrange
            var inputs = new string[] { "KA-55-AB-4555", "KA-01-EF-4444", "KA-04-AB-9000", "KA-56-200", "KA-50-T-3111", "KA-02-AG-9243" };
            var expected = new string[] { "KA-56-200", "KA-01-EF-4444", "KA-55-AB-4555", "KA-02-AG-9243", "KA-50-T-3111", "KA-04-AB-9000" };
            var component = new Registration();
            //Act
            var actuals = component.SortByArea(inputs);
            //Assert
            CollectionAssert.AreEqual(expected, actuals);
        }

        [TestMethod]
        public void Test_For_SortingVehicles_ByArea_And_Numbers()
        {
            //Arrange
            var inputs = new string[] { "KA-51-DE-111", "KA-51-A-9", "KA-04-500", "KA-02-L-41" };
            var expected = new string[] { "KA-51-A-9", "KA-51-DE-111", "KA-02-L-41", "KA-04-500" };
            var component = new Registration();
            //Act
            var actuals = component.SortByAreaAndNumbers_v2(inputs);
            CollectionAssert.AreEqual(expected, actuals);
        }

        [TestMethod]
        public void Test_For_SortingVehicles_ByArea_And_Numbers_v2()
        {
            //Arrange
            var inputs = new string[] { "KA-11-DE-111", "KA-41-A-9", "KA-11-500", "KA-11-L-41" };
            var expected = new string[] { "KA-11-500", "KA-11-DE-111", "KA-11-L-41", "KA-41-A-9" };
            var component = new Registration();
            //Act
            var actuals = component.SortByAreaAndNumbers_v2(inputs);
            CollectionAssert.AreEqual(expected, actuals);
        }

        [TestMethod]
        public void Test_For_SortingVehicles_ByArea_And_Numbers_v3()
        {
            //Arrange
            var inputs = new string[] { "KA-34-AE-9876", "KA-41-QA-1099", "KA-41-MB-7619", "KA-11-L-41" };
            var expected = new string[] { "KA-34-AE-9876", "KA-11-L-41", "KA-41-MB-7619", "KA-41-QA-1099" };
            var component = new Registration();
            //Act
            var actuals = component.SortByAreaAndNumbers_v2(inputs);
            CollectionAssert.AreEqual(expected, actuals);
        }

    }
}
