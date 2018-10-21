namespace DbConnection
{
    public class SqlConnection : DbConnection {

        public SqlConnection (string conn) : base (conn) { }
        public override void OpenDb () {
            System.Console.WriteLine ("Open Sql Connection. Connection string is '{0}'", ConnectionString);
        }

        public override void CloseDb () {
            System.Console.WriteLine ("Close Sql Connection");
        }
    }
}