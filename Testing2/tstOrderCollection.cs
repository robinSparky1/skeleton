using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection allOrders = new clsOrderCollection();
       }
    

    [TestMethod]
        public void OrderListOK() {
        clsOrderCollection AllOrders = new clsOrderCollection();
        List<clsOrder> TestList = new List<clsOrder>();
        clsOrder TestItem = new clsOrder();
        TestItem.Payed = true;
        TestItem.OrderNumber = 1;
        TestItem.OrderPrice = 10;
        TestItem.OrderNumber = 2;
        TestItem.Address = "ankara";
        TestItem.Date = DateTime.Now.Date;

        TestList.Add(TestItem);

        AllOrders.OrderList = TestList;
        Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK() {
            clsOrderCollection allOrders = new clsOrderCollection();
            Int32 SomeCount = 0;
            allOrders.Count = SomeCount;
            Assert.AreEqual(allOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK() {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Payed = true;
            TestOrder.OrderNumber = 1;
            TestOrder.OrderPrice = 10;
            TestOrder.OrderNumber = 2;
            TestOrder.Address = "ankara";
            TestOrder.Date = DateTime.Now.Date;

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK() {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Payed = true;
            TestItem.OrderNumber = 1;
            TestItem.OrderPrice = 10;
            TestItem.OrderNumber = 2;
            TestItem.Address = "ankara";
            TestItem.Date = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
