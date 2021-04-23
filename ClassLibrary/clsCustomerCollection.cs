using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mAddressList = new List<clsCustomer>();
        public clsCustomerCollection()
        {
            clsCustomer TestItem = new clsCustomer();
            TestItem.AccountVerified = true;
            TestItem.AccountNo = 1;
            TestItem.Ballance = 1;
            TestItem.CustomerName = "johny";
            TestItem.CustomerEmail = "Heres@johny.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DateOfBirth = Convert.ToDateTime("01/01/2000");
            mAddressList.Add(TestItem);
            TestItem = new clsCustomer();
            TestItem.AccountVerified = true;
            TestItem.AccountNo = 1;
            TestItem.Ballance = 1;
            TestItem.CustomerName = "Wendy";
            TestItem.CustomerEmail = "Wendy@door.com";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DateOfBirth = Convert.ToDateTime("01/01/2000");
            mAddressList.Add(TestItem);
        }
        public List<clsCustomer> CustomerList {
            get {
                return mAddressList;
            }
            set {
                mAddressList = value;
            }
        }
        public int Count {
            get
            {
                return mAddressList.Count;
            }
            set
            {
                
            }
        }
        public clsCustomer ThisAddress { get; set; }
    }
}