using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "joe";
        string CustomerEmail = "joe@gmail.com";
        string DateAdded = DateTime.Now.Date.ToString();
        string DateOfBirth = DateTime.Now.Date.ToString();
        string Ballance = "5";
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
            Int32 ABallence = 1;
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
            Int32 AccountNo = 1;
            Found = AnAccount.Find(AccountNo);
            if (AnAccount.AccountNo != 1)
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
            Int32 AccountNo = 1;
            Found = AnAccount.Find(AccountNo);
            if (AnAccount.DateOfBirth != Convert.ToDateTime("12/02/2000"))
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
            Int32 AddressNo = 1;
            Found = AnAddress.Find(AddressNo);
            if (AnAddress.DateAdded != Convert.ToDateTime("12/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AccountNo = 1;
            //invoke the method
            Found = AnAddress.Find(AccountNo);
            //check the property
            if (AnAddress.AccountVerified != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBallanceFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.Ballance != 200)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.CustomerName != "julia")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = AnAddress.Find(AddressNo);
            //check the property
            if (AnAddress.CustomerEmail != "juliasomething@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACutomer = new clsCustomer();
            String Error = "";
            Error = ACutomer.Valid(CustomerName,CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMinLessOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "";//this should trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMin()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "a";//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMinPlusOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "aa";//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMaxLessOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49,'a');//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMax()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMid()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMaxPlusOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');//this should trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CutomerNameMaxExtremeMax()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(1000, 'a');//this should trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMinLessOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "";//this should trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMin()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "a";//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMinPlusOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "aa";//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMaxLessOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMax()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMid()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');//this should not trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMaxPlusOne()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(51, 'a');//this should trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CutomerEmailMaxExtremeMax()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(1000, 'a');//this should trigger an error
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(-100);//this should trigger an error
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedNow()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date;//this should trigger an error
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void DateAddedTommorow()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddDays(1);//this should trigger an error
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMaxExtremeMax()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddYears(100);//this should trigger an error
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedyesterday()
        {
            //create instance of class we want
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            String Error = "";
            //test data to pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date.AddDays(1);//this should trigger an error
            string DateAdded = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, DateAdded,
            DateOfBirth, Ballance);
            //see if result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}