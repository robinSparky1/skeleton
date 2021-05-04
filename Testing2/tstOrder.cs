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
        public void TestOrderNoFound() {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 6;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.OrderNumber != 6) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemCountFound() {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber =3;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.ItemCount != 80) {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 2;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.AddressNumber != "ankara")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestOrderPriceFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 4;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.OrderPrice != 100)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPayedFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNumber = 3;
            Found = anOrder.Find(OrderNumber);
            Assert.IsTrue(anOrder.Payed);
            
        }

        [TestMethod]
        public void TestDateFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 90;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.Date != Convert.ToDateTime("23/09/2010"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


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
            anOrder.Payed = TestData;
            Assert.AreEqual(anOrder.Payed, TestData);

        }

        [TestMethod]
        public void addressPropertOK() {
            clsOrder anOrder = new clsOrder();
            string TestData = "";
            anOrder.AddressNumber = TestData;
            Assert.AreEqual(anOrder.AddressNumber, TestData);
        }

        [TestMethod]
        public void datePropertyOK() {
            clsOrder anOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
        }

        [TestMethod]
        public void FindMethodOK() {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNumber = 1;
            Found = anOrder.Find(OrderNumber);
            Assert.IsTrue(Found);
        }
    }
}
