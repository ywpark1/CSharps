using System;

namespace DbConnection {
    public abstract class DbConnection {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection (string connStr) {
            if (string.IsNullOrWhiteSpace (connStr))
                throw new ArgumentException ("Invalid connection string.");
            else {
                ConnectionString = connStr;
                Timeout = new TimeSpan (0, 0, 30);
            }
        }

        public abstract void OpenDb ();
        public abstract void CloseDb ();
    }
}