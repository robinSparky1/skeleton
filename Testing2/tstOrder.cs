using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrder
{
    [TestClass]
    public class UnitTest1
    {
        public object TestData { get; private set; }

        [TestMethod]
        public void InstantiateOK() { 
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderNumberPropertyOK() {
            clsOrder anOrder = new clsOrder();
            Int32 TestData = 0;
            anOrder.OrderNumber = TestData;
            Assert.AreEqual(anOrder.OrderNumber, TestData);
        }
        [TestMethod]
        public void ItemCountPropertyOK()
        {
            clsOrder anOrder = new clsOrder();
            Int32 TestData = 0;
            anOrder.ItemCount = TestData;
            Assert.AreEqual(anOrder.ItemCount, TestData);
        }

        [TestMethod]
        public void OrderPricePropertyOK()
        {
            clsOrder anOrder = new clsOrder();
            double TestData = 0;
            anOrder.OrderPrice = TestData;
            Assert.AreEqual(anOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void isPayedPropertyOK() {
            clsOrder anOrder = new clsOrder();
            Boolean TestData = true;
            anOrder.Active = TestData;
            Assert.AreEqual(anOrder.Active, TestData);

        }

        [TestMethod]
        public void addressPropertOK() {
            clsOrder anOrder = new clsOrder();
            string TestData = "";
            anOrder.Address = TestData;
            Assert.AreEqual(anOrder.Address, TestData);
        }

        [TestMethod]
        public void datePropertyOK() {
            clsOrder anOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
        }
    }
}
