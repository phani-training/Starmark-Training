using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyComponentLib.Components;
/*
* Unit test is a test conducted on a single unit of UR code. 
* An Unit is the smallest part of the code that can be independently executed. 
* In Unit Tests, U test ur code. 
* We use Attributes to define tests and Test Methods. 
* UR Tests that U want to conduct will be grouped into a Unit Test Class. 
* All Classes of Unit Testing in .NET are suffixed with Test
*/
namespace MyComponentLib.Tests
{
    [TestClass]
    public class MathComponentTest
    {
        [TestMethod]
        public void Test_For_Adding_Numbers()
        {
            var component = new MathComponent();
            var expected = 15;
            var input1 = 12;
            var input2 = 3;
            var actual = component.AddNumbers(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_For_Adding_NegativeNumbers()
        {
            var component = new MathComponent();
            var expected = -25;
            var input1 = -15;
            var input2 = -10;
            var actual = component.AddNumbers(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_For_Adding_Numbers_In_Array()
        {
            var component = new MathComponent();
            var input = new int[] { 2, 3, 4 };
            var expected = 9;
            var actual = component.AddNumbers(input);
            Assert.AreEqual<int>(expected, actual);
        }
    }
}
