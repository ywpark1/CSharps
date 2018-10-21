namespace DbConnection
{
    public class OracleConnection : DbConnection {

        public OracleConnection (string conn) : base (conn) { }
        public override void OpenDb () {
            System.Console.WriteLine ("Open Oracle Connection. Connection string is '{0}'", ConnectionString);
        }

        public override void CloseDb () {
            System.Console.WriteLine ("Close Oracle Connection");
        }
    }
}