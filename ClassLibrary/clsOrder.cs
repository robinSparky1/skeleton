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

        public clsOrder()
        {

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

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }
        public int ItemCount
        {
            get
            {
                return mItemCount;
            }
            set
            {
                mItemCount = value;
            }
        }
        public double OrderPrice
        {

            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }
        public Boolean Payed
        {
            get
            {
                return mPayed;
            }
            set
            {
                mPayed = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return mdate;
            }
            set
            {
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

                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mItemCount = Convert.ToInt32(DB.DataTable.Rows[0]["ItemCount"]);
                mOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["OrderPrice"]);
                mPayed = Convert.ToBoolean(DB.DataTable.Rows[0]["isPayed"]);
                mdate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);

                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string address, string itemCount, string orderPrice, string date)
        {

            String Error = "";
            DateTime DateTemp;
            if (address.Length == 0)
            {

                Error = Error + "The address may not be blank : ";

            }
            else if (address.Length > 50)
            {

                Error = Error + "The address must be less than 50 characters : ";            }            try
            {
                if (Convert.ToInt32(itemCount) == 0)
                {
                    Error = Error + "The item count may not be blank : ";
                }
                else if (Convert.ToInt32(itemCount) > 200)
                {

                    Error = Error + "The item count may not be more than 200 : ";
                }
            }
            catch {

                Error = Error + " Invalid Item Count : Item Count may not be negative ";
            }            try
            {
                if (Convert.ToInt32(orderPrice) < 0)
                {

                    Error = Error + "The order price may not be less than 0 : ";
                }
                else if (Convert.ToInt32(orderPrice) > 1000)
                {

                    Error = Error + "The order price may not be more than 1000 : ";
                }
            }catch{
                Error = Error + "The order price may not be negative : ";

            }

            try
            {
                DateTemp = Convert.ToDateTime(date);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                else if (DateTemp > DateTime.Now.Date)
                {

                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch

            {
                Error = Error + "The date was not a valid date : ";

            }
            return Error;

        }
    }

}