﻿using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mAccountNo;
        private bool mAccountVerified;
        private DateTime mDateAdded;
        private DateTime mDateOfBirth;
        private int mBallance;

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
            mBallance = 1;
            mAccountVerified = true;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mDateOfBirth = Convert.ToDateTime("16/9/2015");
            return true;
        }
    }
}