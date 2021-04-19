using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer ACustomer = new clsCustomer();
            
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void AccountNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.AccountNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.AccountNo, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean TestData = true;
            ACustomer.AccountVerified = TestData;
            Assert.AreEqual(ACustomer.AccountVerified, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }
        [TestMethod]
    public void BallancePropertyOK()
    {
        //create an instance of the class we want to create
        clsCustomer ABallance = new clsCustomer();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        ABallance.Ballance = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(ABallance.Ballance, TestData);
    }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AName = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Alex";
            //assign the data to the property
            AName.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AName.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Alex@test.com";
            //assign the data to the property
            AnAddress.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CustomerEmail, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class
            clsCustomer AClass = new clsCustomer();
            //bool to store result of validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ABallence = 21;
            //invoke
            Found = AClass.Find(ABallence);
            //test if true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestAccountNoFound()
        {
            clsCustomer AnAccount = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountNo = 21;
            Found = AnAccount.Find(AccountNo);
            if (AnAccount.AccountNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirth()
        {
            clsCustomer AnAccount = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AccountNo = 21;
            Found = AnAccount.Find(AccountNo);
            if (AnAccount.DateOfBirth != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test data to assign to the property
            Boolean Found = false;
            Boolean OK = true;
            int32 AddressNo = 21;
            Found = AnAddress.Find(AddressNo);
            if (AnAddress.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }



    }



}