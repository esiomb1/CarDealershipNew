using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace tstMaintenance
{
    [TestClass]
    public class tstMaintenance
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance
            clsMaintenance AMaintenance = new clsMaintenance();
            //test to see that exists
            Assert.IsNotNull(AMaintenance);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property 
            AnMaintenance.Active = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Active, testData);
        }

        [TestMethod]
        public void RepairIDPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property 
            AnMaintenance.Active = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Active, testData);
        }

//Descption Test

        [TestMethod]
        public void DescriptionPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            String testData = "a car";
            //assign the data to the property
            AnMaintenance.Description = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Description, testData);
        }

        [TestMethod]
        public void DescriptionLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            //create some test data to assign to the property 
            string TestDescription = "";
            string TestCost="1.00";
            string TestDate=DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription,TestCost,TestDate);
            //test to see that the result is correct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DescriptionMinBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "a";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DescriptionPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DescriptionMaxBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


//Cost Test


        [TestMethod]
        public void CostPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Int32 testData = 1;
            //assign the data to the property
            AnMaintenance.Cost = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Cost, testData);
        }



        [TestMethod]
        public void CostLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            //create some test data to assign to the property 
            string TestDescription = "";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CostMinBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "a";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CostPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CostMaxBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            Boolean OK = false;
            string TestDescription = "aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa aaaaaaaaaa";
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            OK = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }


//Date Test 

        [TestMethod]
        public void DatePropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            AnMaintenance.Date = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Date, testData);
        }

    }
}
