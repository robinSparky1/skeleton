using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mAccountNo;
        private bool mAccountVerified;
        private DateTime mDateAdded;
        private DateTime mDateOfBirth;
        private int mBallance;
        private string mCustomerName;
        private string mCustomerEmail;
        private DateTime dateKaneTanaka;
        private int BallanceTemp;

        public bool AccountVerified { get {
                return mAccountVerified;
            } set {
                mAccountVerified = value;
            } }
        public DateTime DateAdded {
            get {
                return mDateAdded;
            }
            set {
                mDateAdded = value;
            } }
        public int Ballance
        {
            get
            {
                //return the private data
                return mBallance;
            }
            set
            {
                //set the private data
                mBallance = value;
            }
        }

        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set
            {
                //set the private data
                mCustomerName = value;
            }
        }

        public string CustomerEmail
        {
            get
            {
                //return the private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }

        public DateTime DateOfBirth {
            get
            {
                return mDateOfBirth;
            }
            set {
                mDateOfBirth = value;
            } }
        public int AccountNo {
            get {
                return mAccountNo;
            }
            set {
                mAccountNo = value;
            }
        }

        public bool Find(int AccountNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccountNo", AccountNo);
            DB.Execute("sproc_tblCustomer_FilterByAccountNo");
            if (DB.Count == 1)
            {
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mAccountNo = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNo"]);
                mBallance = Convert.ToInt32(DB.DataTable.Rows[0]["Ballance"]);
                mAccountVerified = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountVerified"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string CustomerName,
            string CustomerEmail, string dateAdded,
            string DateOfBirth, string Ballance)
        {
            String Error = "";
            DateTime dateTemp;
            if (CustomerName.Length == 0)
            {
                Error = Error + "Name may not be blank: ";
            }
            if (CustomerName.Length > 50)
            {
                Error = Error + "Name must be less than 50 characters: ";
            }
            if (CustomerEmail.Length == 0)
            {
                Error = Error + "Email may not be blank: ";
            }
            if (CustomerEmail.Length > 50)
            {
                Error = Error + "Email must be less than 50 characters: ";
            }
            try
            {
                dateTemp = Convert.ToDateTime(dateAdded);
                if (DateTime.Now.Date != dateTemp)
                {
                    Error = Error + "dateAdded must be today";
                }
            }
            catch
            {
                Error = Error + "not a valid date";
            }
            try
            {
                dateTemp = Convert.ToDateTime(DateOfBirth);
                dateKaneTanaka = Convert.ToDateTime("02/01/1903");
                if (DateTime.Now.Date < dateTemp)
                {
                    Error = Error + "dateOfBirth must be in the past";
                }
                if (dateKaneTanaka > dateTemp)
                {
                    Error = Error + "dateOfBith must be after 2/1/1903";
                }
            }
            catch
            {
                Error = Error + "not a valid date";
            }
            try
            {
                BallanceTemp = Convert.ToInt32(Ballance);
                if (1000000 < BallanceTemp)
                {
                    Error = Error + "Ballance must be in the less than 1,000,000";
                }
                if (0 > BallanceTemp)
                {
                    Error = Error + "Ballance must be positive";
                }
            }
            catch
            {
                Error = Error + "not a valid int";
            }
            return Error;
        }
    }
}