/*
 * 
 * This program shows how a key_pair value can be created
 * and how a file can be manipulated in c#
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Andy
{
    internal class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {
            var key_Val = new KeyValuePair<string, int>("Andy", 8);

            Console.WriteLine(key_Val.Key);

            
            var ida = new IDada();
            
            var dataset = new DataSet();

           

            var dataTable = new    DataTable();

             _ =  dataTable.Columns.Add("Cars").ColumnName;
             _ = dataTable.Columns.Add("Carise").ColumnName;
             _ = dataTable.Columns.Add("Car").ColumnName;

            var da = dataTable.NewRow() ;
            

 

            da.SetField(0,"Ann fe ");
            da.SetField(1, "bag");
 

   
               int item = da.ItemArray.Length;

               for(int i = 0; i < item; i++)
               {

                Console.WriteLine(da.ItemArray[i]);
               }

                   
                 dataset.Tables.Add(dataTable);
       

            Console.WriteLine(ida.Update(dataset));

           // var file = File.OpenRead("C:\\Users\\andyd\\OneDrive\\Documents\\CADA.txt");
            try
            {
                var file = File.OpenRead("C:\\Users\\andyd\\OneDrive\\Documents\\CADA.txt");
                while (file.Position < file.Length)
                {
                    var ch = (char)file.ReadByte();

                    if (ch.ToString().Equals(ch.ToString().ToUpper()))
                    {

                        Console.Write(ch);
                    }

                    // Console.Write(((char)file.ReadByte()));

                }
                file.Close();
            }
            catch (Exception)
            {

                Console.WriteLine ("File doesn't exist");
            }
                 
            
         

        }
    }
}
