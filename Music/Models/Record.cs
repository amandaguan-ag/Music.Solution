using System.Collections.Generic;
using MySqlConnector;

namespace Music.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Title { get; }
        public int Id { get; private set; }
        public string ArtistName { get; set; }
        public int ArtistId { get; set; }

        public Record(string title)
        {
            Title = title;
        }
        public Record(string title, int id)
        {
            Title = title;
            Id = id;
        }
        public static List<Record> GetAll()
        {
            List<Record> allRecords = new List<Record> { };
            //Opening a Database Connection
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            conn.Open();
            //Construct a SQL Query
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = "SELECT * FROM records;";
            //Returning Results from the Database
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            // reads results from the database one at a time until it reaches the end of the records
            while (rdr.Read())
            {
                //return the integer at the 0th index of the array returned by the reader.
                int recordId = rdr.GetInt32(0);
                //our record title will be at the 1st index of the array returned by the reader.
                string recordTitle = rdr.GetString(1);
                //instantiate new Record objects and add them to our allRecords list.
                Record newRecord = new Record(recordTitle, recordId);
                allRecords.Add(newRecord);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allRecords;
        }
        public static void ClearAll()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = "DELETE FROM records;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }
        public override bool Equals(System.Object otherRecord)
        {
            if (!(otherRecord is Record))
            {
                return false;
            }
            else
            {
                Record newRecord = (Record)otherRecord;
                bool idEquality = (this.Id == newRecord.Id);
                bool titleEquality = (this.Title == newRecord.Title);
                return (idEquality && titleEquality);
            }
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

            cmd.CommandText = "INSERT INTO records (title) VALUES (@RecordTitle);";
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@RecordTitle";
            param.Value = this.Title;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            Id = (int)cmd.LastInsertedId;

            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }
        public static Record Find(int id)
        {
            // We open a connection.
            MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
            conn.Open();

            // We create MySqlCommand object and add a query to its CommandText property. 
            // We always need to do this to make a SQL query.
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = "SELECT * FROM records WHERE id = @ThisId;";

            // We have to use parameter placeholders @ThisId and a `MySqlParameter` object to 
            // prevent SQL injection attacks. 
            // This is only necessary when we are passing parameters into a query. 
            // We also did this with our Save() method.
            MySqlParameter param = new MySqlParameter();
            param.ParameterName = "@ThisId";
            param.Value = id;
            cmd.Parameters.Add(param);

            // We use the ExecuteReader() method because our query will be returning results and 
            // we need this method to read these results. 
            // This is in contrast to the ExecuteNonQuery() method, which 
            // we use for SQL commands that don't return results like our Save() method.
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            int recordId = 0;
            string recordTitle = "";
            while (rdr.Read())
            {
                recordId = rdr.GetInt32(0);
                recordTitle = rdr.GetString(1);
            }
            Record foundRecord = new Record(recordTitle, recordId);

            // We close the connection.
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return foundRecord;
        }
    }
}