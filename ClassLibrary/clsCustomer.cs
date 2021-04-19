using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mAccountNo;
        private DateTime mDateAdded;
        private DateTime mDateOfBirth;

        public bool AccountVerified { get; set; }
        public DateTime DateAdded {
            get {
                return mDateAdded;
            }
            set {
                mDateAdded = value;
            } }
        public int Ballance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
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
            mAccountNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mDateOfBirth = Convert.ToDateTime("16/9/2015");
            return true;
        }
    }
}