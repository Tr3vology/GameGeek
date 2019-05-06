using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>this class exposes the count and query results of the county data
/// </summary>

public class clsDeveloperCollection
{
    //create a connection to the database with class level scope
    clsDataConnection Developer = new clsDataConnection();

    //constructor
    public clsDeveloperCollection()
    {
        //execute the select all query
        Developers.Execute("sproc_tblDeveloper_SelectAll");
    }

    //this read only function gives us the count property
    public Int32 Count
    {
        get
        {
            //return the count of the data from the database
            return Developers.Count;
        }
    }

    //this readonly function exposes the query results collection
    public List<clsDeveloper> AllDevelopers
    {

        get
        {

            List<clsDeveloper> mAllDevelopers = new List<clsDeveloper>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the number of records to process
            while (Index < Developers.Count)
            {
                //set up the new entry to be added to the list
                clsDeveloper NewDeveloper = new clsDeveloper();
                //get the county number from the database
                NewDeveloper.DeveloperNo = Convert.ToInt32(Developers.DataTable.Rows[Index]["DeveloperNo"]);
                //get teh county name from the database
                NewWatchColour.Developer = Convert.ToString(Developers.DataTable.Rows[Index]["Dveloper"]);
                //add the new entry to the list
                mAllDevelopers.Add(NewDeveloper);
                //increment the index to the next record
                Index++;
            }
            //return the query results from the database
            return mAllDeveloper


    }
    }
}