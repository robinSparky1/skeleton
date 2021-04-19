using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mAccountNo;
        public bool AccountVerified { get; set; }
        public DateTime DateAdded { get; set; }
        public int Ballance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
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
            return true;
        }
    }
}