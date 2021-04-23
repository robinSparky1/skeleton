﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer TestItem = new clsCustomer();
                TestItem.AccountVerified = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountVerified"]);
                TestItem.AccountNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountNo"]);
                TestItem.Ballance = Convert.ToInt32(DB.DataTable.Rows[Index]["Ballance"]);
                TestItem.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                TestItem.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                TestItem.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                TestItem.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                mCustomerList.Add(TestItem);
                Index++;
            }
        }
        public List<clsCustomer> CustomerList {
            get {
                return mCustomerList;
            }
            set {
                mCustomerList = value;
            }
        }
        public int Count {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                
            }
        }
        public clsCustomer ThisCustomer {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer= value;
            }
        }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}