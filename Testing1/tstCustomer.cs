﻿using System;
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
            AnAddress.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.CustomerName, TestData);
        }

    }



}