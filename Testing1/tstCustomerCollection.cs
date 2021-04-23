using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);

        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.AccountVerified = true;
            TestItem.AccountNo = 1;
            TestItem.Ballance = 1;
            TestItem.CustomerName = "johny";
            TestItem.CustomerEmail = "Heres@johny.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DateOfBirth=Convert.ToDateTime("01/01/2000");
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Int32 SomeCount = 0;
            AllCustomers.Count = SomeCount;
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.AccountVerified = true;
            TestItem.AccountNo = 1;
            TestItem.Ballance = 1;
            TestItem.CustomerName = "johny";
            TestItem.CustomerEmail = "Heres@johny.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DateOfBirth = Convert.ToDateTime("01/01/2000");
            
            AllCustomers.ThisAddress = TestList;
            Assert.AreEqual(AllCustomers.ThisAddress, TestList);
        }
    }
}
