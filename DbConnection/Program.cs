using System;

namespace DbConnection {
    public class DbCommand {
        private string _command;
        private DbConnection _dbConn;

        public string Command {
            get {
                return _command;
            }
            private set { }
        }

        public DbCommand (DbConnection dbConn, string cmd) {
            if (string.IsNullOrWhiteSpace (cmd) || dbConn == null) {
                throw new ArgumentException ("Invalid Command instruction");
            } else {
                _dbConn = dbConn;
                _command = cmd;
            }
        }

        public void Exec () {
            _dbConn.OpenDb ();
            System.Console.WriteLine (_command);
            _dbConn.CloseDb ();
        }
    }
    class Program {
        static void Main (string[] args) {
            try {
                // // Try to connect with empty(null) connection string
                // var sqlString = "";
                // var oracleString = "";
                // var sqlConnectionNull = new SqlConnection (sqlString);
                // var oracleConnectionNull = new OracleConnection (oracleString);

                var sqlString = "SQL Connection String";
                var oracleString = "Oracle Connection String";

                var sqlConnection = new SqlConnection (sqlString);

                // sqlConnection.OpenDb ();
                // sqlConnection.CloseDb ();

                var oracleConnection = new OracleConnection (oracleString);
                // oracleConnection.OpenDb ();
                // oracleConnection.CloseDb ();

                // Console.WriteLine ();

                /* Implement Database Command */
                DbCommand sqlCommand = new DbCommand (sqlConnection, "Select All");
                DbCommand oracleCommand = new DbCommand (oracleConnection, "Select One");

                sqlCommand.Exec ();
                System.Console.WriteLine ();
                oracleCommand.Exec ();
            } catch (ArgumentException e) {
                System.Console.WriteLine (e.Message);
            }
        }
    }
}