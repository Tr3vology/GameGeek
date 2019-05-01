using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    class clsCustomer
    {
        //private data members for the class
        private Int32 mCustomerID;
        private string mFirstName;
        private string mLastName;
        private DateTime mDateOfBirth;
        private string mAddressLine1;
        private string mAddressLine2;
        private string mPostCode;
        private string mTown;
        clsDataConnection myDB = new clsDataConnection();

        //public properties
        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return mAddressLine1;
            }
            set
            {
                mAddressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return mAddressLine2;
            }
            set
            {
                mAddressLine2 = value;
            }
        }

        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }

        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }

        //public find method
        public Boolean Find(Int32 CustomerID)
        {
            //reset the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            myDB.Execute("sproc_tblCustomer_filterByCustomerID");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 CustomerID;
                mCustomerID = Convert.ToInt32(myDB.DataTable.Rows[0]["CustomerID"]);
                //private string FirstName
                mFirstName = Convert.ToString(myDB.DataTable.Rows[0]["FirstName"]);
                //private string LastName
                mLastName = Convert.ToString(myDB.DataTable.Rows[0]["LastName"]);
                // return success
                return true;
            }
            else //customer id was invalid
            {
                //return error
                return false;
            }
        }
    }
}
