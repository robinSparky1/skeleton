using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
 

        public clsOrderCollection() {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
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
        public clsOrder ThisOrder { get; set; }

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
    }
}