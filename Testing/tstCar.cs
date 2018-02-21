using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;


namespace CarTest
{
    [TestClass]
    public class tstCar
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //test to see if it exists
            Assert.IsNotNull(ACar);
        }
        [TestMethod]
        public void ActiveCaryOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACar.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Active, TestData);

        
        }
        [TestMethod]
        public void AgeOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACar.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Age, TestData);


        }
        [TestMethod]
        public void BodyTypeOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData =  "Sedan";
            //assign the data to the property
            ACar.BodyType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.BodyType, TestData);


        }
        [TestMethod]
        public void CarMakeOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Audi";
            //assign the data to the property
            ACar.CarMake = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarMake, TestData);


        }
        [TestMethod]
        public void CarModelOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Camero";
            //assign the data to the property
            ACar.CarModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarModel, TestData);


        }

        [TestMethod]
        public void Colour()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Blue";
            //assign the data to the property
            ACar.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Colour, TestData);


        }

    }

}
