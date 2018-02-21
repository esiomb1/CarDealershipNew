using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //test
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActiveCustomerOk()
        {
            //create an instane of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //
            Boolean TestData = true;
            //
            AnCustomer.Active = TestData;
            //test
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21B";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Ryan";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Fretwell";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE3 0EB";
            //assign the data to the property
            AnCustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "p15238469@my365.dmu.ac.uk";
            //assign the data to the property
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07123456789";
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void FirstNameMisLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is ok
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "a";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "aa";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdefghijabcdefghijabcde";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "";
            //pad the string with a charcaters
            SomeCustomer = SomeCustomer.PadRight(500, 'a');
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMisLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is ok
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "a";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "aa";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "abcdefghijabcdefghijabcde";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "";
            //pad the string with a charcaters
            SomeCustomer = SomeCustomer.PadRight(500, 'a');
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign the property
            string SomeCustomer = "";
            //invoke the method
            OK = AnCustomer.Valid(SomeCustomer);
            //test to see that the result is ok
            Assert.IsFalse(OK);

        }
    }


}
