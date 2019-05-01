using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    class clsCustomerCollection
    {
        //private data member that stores the count of records found
        private Int32 mRecordCount;
        //create a private list data member to store the data from the database
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data ember to connect to the database
        private clsDataConnection myDB = new clsDataConnection();

        //public property returning the count of records
        public Int32 Count
        {
            get
            {
                //return record count
                return mRecordCount;
            }
        }

        //public list of Customers
        public List<clsCustomer> Customers
        {
            //getter for the property
            get
            {
                //return list of customers
                return mCustomerList;
            }
        }

        //find all users method
        public void FindAllCustomers()
        {
            //reset the database connection
            myDB = new clsDataConnection();
            //var to store the index
            Int32 Index = 0;
            //var to store the customer id of the current record
            Int32 CustomerID;
            //var to flag that customer was found
            Boolean CustomerFound;
            //execute the stored procedure
            myDB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            mRecordCount = myDB.Count;
            //while there are still records to process
            while (Index < myDB.Count)
            {
                //create an instance of the customer class
                clsCustomer NewCustomer = new clsCustomer();
                //get the customer id from the database
                CustomerID = Convert.ToInt32(myDB.DataTable.Rows[Index]["CustomerID"]);
                //find the customer by invoking the find method
                CustomerFound = NewCustomer.Find(CustomerID);
                if (CustomerFound == true)
                {
                    //add the customer to the list
                    mCustomerList.Add(NewCustomer);
                }
                //increment the index
                Index++;
            }

        }
    }
}
