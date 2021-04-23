using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mAddressList = new List<clsCustomer>();
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