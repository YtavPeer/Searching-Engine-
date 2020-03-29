using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;




namespace saveToDB
{

    // all this class is for saving all the search data to the database
    public class DBsave
    {

      //this is the main function that get from the searchMain.cs all the lost of the files thats founds, and the main file name thats the client
      //search for- we will deaclare by entity framework and initialize new db, then by loop we will go over all the list of the found file
      // and save all all the fields of them to the database, then we will save the db
      // all the data going to the local databse file "Filery.mdf"
        public static void SaveFunc(string fileNAME, List<string> files)
        {

            //initialize the new object of db
            FileryEntities db = new FileryEntities();
            
            //going by loop 1 by 1 all the found files
            foreach (string item in files)
            { 
              //initizlize new object of the table: search1 and
              // save all the data to the fields in the db by add the object to the table, then save the db
            FIlerySearch search1 = new FIlerySearch(); 
           
            search1.SearchQuery = fileNAME;
            search1.Path = item;
                db.FIlerySearch.Add(search1);
            db.SaveChanges();
           
            }


            var result = db.FIlerySearch.ToList();


        }

    }
}
