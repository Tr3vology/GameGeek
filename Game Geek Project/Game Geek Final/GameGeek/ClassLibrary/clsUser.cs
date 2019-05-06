using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
   public class clsUser
    {
        //private data members for the class
        private Int32 mUserNo;
        private string mUserName;
        private string mFirstName;
        private string mSurname;
        clsDataConnection myDB = new clsDataConnection();


        //public properties
        public Int32 UserNo
        {
            get
            {
                return mUserNo;
            }
            set
            {
                mUserNo = value;
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
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

        public string Surname
        {
            get
            {
                return mSurname;
            }
            set
            {
                mSurname = value;
            }
        }
        ///public find method
        public Boolean Find(Int32 UserNo)
        {
            //re set the connection to the database
            myDB = new clsDataConnection();
            //pass the parameter to the stored procedure
            myDB.AddParameter("@UserNo", UserNo);
            //execute the stored procedure
            myDB.Execute("sproc_tblUser_FilterByUserNo");
            //check to see if we found anything
            if (myDB.Count == 1)
            {
                //set the private data members with the data from the database
                //private Int32 userNo;
                mUserNo = Convert.ToInt32(myDB.DataTable.Rows[0]["UserNo"]);
                //private string userName;
                mUserName = Convert.ToString(myDB.DataTable.Rows[0]["UserName"]);
                //private string firstName;
                mFirstName = Convert.ToString(myDB.DataTable.Rows[0]["FirstName"]);
                //private string surname;
                mSurname = Convert.ToString(myDB.DataTable.Rows[0]["Surname"]);
                //return success
                return true;
            }
            else //user no was invalid
            {
                //return that there was a problem
                return false;
            }
        }


    }

}
