using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace tstPayment
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
                //test to see that it exists 
                Assert.IsNotNull(AnPayment);

        }

        [TestMethod]
         public void CarIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "C1332D";
            //assign the data to the property 
            AnPayment.CarID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.CarID, TestData); 
        }

        [TestMethod]
        public void CostPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Double TestData = 3.00;
            //asign the data to the property 
            AnPayment.Cost = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Cost, TestData);
        }

        [TestMethod]
        public void DateTimePropertyOK() 
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            DateTime TestData = Convert.ToDateTime( "22/02/2016");
            //assign the data to the property 
            AnPayment.DateTime = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.DateTime, TestData);
        }

       
         [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Car MOT";
            //assign the data to the property 
            AnPayment.Description = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Description, TestData);
        }

        [TestMethod]
        public void EmployeeIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "E12334534";
            //assign the data to the property 
            AnPayment.EmployeeID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.EmployeeID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "John";
            //assign the data to the property 
            AnPayment.FirstName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.FirstName, TestData);
        }

        [TestMethod]
        public void SurnameNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Stanley";
            //assign the data to the property 
            AnPayment.SurnameName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.SurnameName, TestData);
        }



    }
}
