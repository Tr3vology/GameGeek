using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsGameCollection
{
    ///this class contains code allowing us to manipulate Game

    //private data members
    //create a null instance of the class clsDataConnection with class level scope
    clsDataConnection dBConnection;
    //private data member for the current game
    clsGame mThisGame = new clsGame();



    public clsGame ThisGame
    {
        get
        {
            return mThisGame;
        }
        set
        {
            mThisGame = value;
        }
    }

    //function for the public Add method
    public Int32 Add()
    {
        //this function adds a new record to the database returning the primary key value of the new record

        //var to store the primary key value of the new record
        Int32 PrimaryKey;
        //create a connection to the database
        clsDataConnection NewGame = new clsDataConnection();
      
        NewGame.AddParameter("@Title", mThisGame.Title);

        NewGame.AddParameter("@Console", mThisGame.Type);
        
       
        //add the active parameter
        NewGame.AddParameter("@Active", mThisGame.Active);
        //execute the query to add the record - it will return the primary key value of the new record
        PrimaryKey = NewGame.Execute("sproc_tblGame_Insert");
        //return the primary key value of the new record
        return PrimaryKey;
    }

    //function for the public Update method
    public void Update()
    {
        //this function updates an existing record specified by the class level variable gameNo
        //it returns no value

        //create a connection to the database
        clsDataConnection NewGame = new clsDataConnection();
        //add the house number parameter
        NewGame.AddParameter("@Title", mThisGame.Title);
        
        NewGame.AddParameter("@Console", mThisGame.Console);
  
       

        //add the active parameter
        NewGame.AddParameter("@Active", mThisGame.Active);
        //execute the query to add the record - it will return the primary key value of the new record
        //execute the query
        NewGame

    ///this function deletes a record in the database based on the value of the gameNo var
    public void Delete()
    ///it is a void function and returns no value
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter data used by the stored procedure
        dBConnection.AddParameter("@GameNo", mThisGame.GameNo);
        //execute the stored procedure to delete the game
        dBConnection.Execute("sproc_tblGame_Delete");
    }


    /
    public void ReportByTitle(string Title)
    
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter data used by the stored procedure
        dBConnection.AddParameter("@Title", Title);
        //execute the stored procedure to delete the address
        dBConnection.Execute("sproc_tblGame_FilterByTitle");
    }

    ///this function defines the public property Count
    public Int32 Count
    ///it returns the count of records currently in QueryResults
    {
        get
        {
            //return the count of records
            return dBConnection.Count;
        }
    }

    ///this function exposes the DataTable via the public collection AllAddresses
    public List<clsGame> GameList
    {
        get
        {
            List<clsGame> mGameList = new List<clsGame>();
            Int32 Index = 0;
            while (Index < dBConnection.Count)
            {
                clsGame NewGame = new clsGame();
          
                NewGame.Title = Convert.ToString(dBConnection.DataTable.Rows[Index]["Title"]);
               
                NewGame.Console = Convert.ToString(dBConnection.DataTable.Rows[Index]["Type"]);
                
           
                NewGame.GameNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["GameNo"]);
                //increment the index
                Index++;
             
                mGameList.Add(NewGame);
            }
            
            return mGameList;
        }
    }

}