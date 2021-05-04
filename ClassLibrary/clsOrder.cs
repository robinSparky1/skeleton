using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderNumber;
        private string mAddress;
        private Int32 mItemCount;
        private double mOrderPrice;
        private Boolean mPayed;
        private DateTime mdate;

        public clsOrder() {
       
        }

        public Int32 OrderNumber
        {
            get
            {
                return mOrderNumber;
            }
            set
            {
                mOrderNumber = value;
            }
        }

    public string AddressNumber
        {
            get {
                return mAddress;
            }
            set {
                mAddress = value;
            }
        }
    public int ItemCount {
            get {
                return mItemCount;
            }
            set {
                mItemCount = value;
            }
        }
    public double OrderPrice {

            get {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }
    public Boolean Payed {
            get {
                return mPayed;
            }
            set {
                mPayed = value;
            }
        }
    public DateTime Date {
            get {
                return mdate;
            }
            set {
                mdate = value;
            }
        }


        public bool Find(int OrderNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@OrderNumber", OrderNumber);
            DB.Execute("sproc_tblOrder_FilterByOrderNumber");
            if (DB.Count == 1)
            {

                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[5]["OrderNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[1]["Address"]);
                mItemCount = Convert.ToInt32(DB.DataTable.Rows[2]["ItemCount"]);
                mOrderPrice = Convert.ToDouble(DB.DataTable.Rows[3]["OrderPrice"]);
                mPayed = Convert.ToBoolean(DB.DataTable.Rows[2]["isPayed"]);
                mdate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);

                return true;
            }
            else {
                return false;
            }
        }
    }


}