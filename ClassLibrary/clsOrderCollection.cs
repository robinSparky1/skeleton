using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        private List<clsOrder> mAddressList;

        public clsOrderCollection() {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
            while (Index < RecordCount) {
                clsOrder anOrder = new clsOrder();
                anOrder.Payed = Convert.ToBoolean(DB.DataTable.Rows[Index]["isPayed"]);
                anOrder.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                anOrder.ItemCount = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemCount"]);
                anOrder.OrderPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderPrice"]);
                anOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                anOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);

                mOrderList.Add(anOrder);
                Index++;
            }
         
        }
        public clsOrder ThisOrder {
            get {
                return mThisOrder;
            } set {
                mThisOrder = value;
            }
        }

        public List<clsOrder> OrderList
        {
            get {
                return mOrderList;
            }
            set {
                mOrderList = value;
            }
        }

        public int Count {
            get {
                return mOrderList.Count;
            }
            set {

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@ItemCount", mThisOrder.ItemCount);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@isPayed", mThisOrder.Payed);
            DB.AddParameter("@Date", mThisOrder.Date);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete() {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.Execute("sproc_tblOrder_Delete");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@Itemcount", mThisOrder.ItemCount);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@isPayed", mThisOrder.Payed);

            DB.Execute("sproc_tblOrder_Update");
        }

        public void RepostByAddress(string Address) {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Address", Address);
            DB.Execute("sproc_tblOrder_FilterByAddress");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB) {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder anOrder = new clsOrder();
                anOrder.Payed = Convert.ToBoolean(DB.DataTable.Rows[Index]["isPayed"]);
                anOrder.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                anOrder.ItemCount = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemCount"]);
                anOrder.OrderPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderPrice"]);
                anOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                anOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);

                mOrderList.Add(anOrder);
                Index++;
            }
        }
    }
}