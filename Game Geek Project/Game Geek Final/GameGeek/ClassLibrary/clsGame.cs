using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>

/// </summary>
public class clsGame
{

    
    private string mTitle;
 
    public string Title
    {
        get
        {
            return mTitle;
        }
        set
        {
            mTitle = value;
        }
    }

    //street private member variable
    private string mConsole;
   
    public string Console
    {
        get
        {
            return mConsole;
        }
        set
        {
            mConsole = value;
        }
    }

    

    //active private member variable
    private Boolean mActive;
    //Active public property
    public Boolean Active
    {
        get
        {
            return mActive;
        }
        set
        {
            mActive = value;
        }
    }

    
    private Int32 mGameNo;
   
    public Int32 GameNo
    {
        get
        {
            //this line of code sends data out of the property
            return mGameNo;
        }
        set
        {
            //this line of code allows data into the property
            mGameNo = value;
        }
    }

    //data member for data connection
    private clsDataConnection dBConnection = new clsDataConnection();



    //function for the public validation method
    public string Valid(string title,
                        string console)
                        
    ///this function accepts 5 parameters for validation
    ///the function returns a string containing any error message
    ///if no errors found then a blank string is returned
    {
        //var to store the error message
        string ErrMsg = "";
        //check the min length of the tile
        if (title.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Title is blank. ";
        }
        //check the max length of the house no
        if (title.Length > 50)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Title must be less than 50 characters. ";
        }
        //check the min length of the street
        if (console.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Console is blank. ";
        }
        //check the max length of the type
        if (console.Length > 50)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Console must be less than 50 characters. ";
        }
        
       
    }

    //function for the find public method
    public Boolean Find(Int32 GameNo)
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the  parameter
        dBConnection.AddParameter("@GameNo", GameNo);
        //execute the query
        dBConnection.Execute("sproc_tblGame_FilterByWatchNo");
        //if the record was found
        if (dBConnection.Count == 1)
        {
           
            mGameNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["GameNo"]);
          
            mTitle = Convert.ToString(dBConnection.DataTable.Rows[0]["Title"]);
            
            mConsole = Convert.ToString(dBConnection.DataTable.Rows[0]["Console"]);
            
            try
            {
                mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);
            }
            catch
            {
                mActive = true;
            }
            //return success
            return true;
        }
        else
        {
            //return failure
            return false;
        }
    }

}