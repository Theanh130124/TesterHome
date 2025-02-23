using _21_Anh_Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation c; 
        


        [TestInitialize]
        public void SetUp()
        {
            c = new Caculation(2,1);
            //

        }

        
     
        [TestMethod]
        public void Test_Cong()
        {
            int expected , actual ;
           
            expected = 2;
            

            actual = c.Execute("+");

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Tru()
        {
            int expected, actual;
         
            expected = 2;

            actual = c.Execute("-");

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Nhan()
        {
            int expected, actual;

            expected = 0;

            actual = c.Execute("*");

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Chia()
        {
            int expected, actual;

            expected = 1;

            actual = c.Execute("/");

            Assert.AreEqual(expected, actual);

        }

        
   








    }
}
