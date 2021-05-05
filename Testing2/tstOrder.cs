using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrder
{
    [TestClass]
    public class tstOrder
    {
        string Address = "LE70 1HQ";
        string ItemCount = "20";
        string OrderPrice = "70";
        string Date = DateTime.Now.Date.ToString();
        public object TestData { get; private set; }

        [TestMethod]
        public void TestOrderFound() {
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
        public void TestItemCountNoFound() {
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
        public void TestAddressNoFound()
        {
            clsOrder anOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 1;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.Address == "paris")
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
            Int32 OrderNumber = 1;
            Found = anOrder.Find(OrderNumber);

            if (anOrder.Date != Convert.ToDateTime("05/05/2021"))
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
            anOrder.Address = TestData;
            Assert.AreEqual(anOrder.Address, TestData);
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

        [TestMethod]
        public void AddressMinLessOne() {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "a";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "aa";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemCountMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "0";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "1";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "2";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "199";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "200";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "201"; 
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ItemCountMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            ItemCount = "100";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "-1";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "1";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "2";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "999";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "1000";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "1001";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderPriceMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            OrderPrice = "500";
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Date = TestDate.ToString();
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = anOrder.Valid(Address, ItemCount, OrderPrice, Date);
            Assert.AreNotEqual(Error, "");
        }

    }
}
