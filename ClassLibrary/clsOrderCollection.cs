using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList { get; set; }
        
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