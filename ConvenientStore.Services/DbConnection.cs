using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services
{
    public class DbConnection
    {
        private static readonly Lazy<DbConnection> _lazy = new Lazy<DbConnection>(() => new DbConnection());
        //private static DbConnection _instance = null;
        public static DbConnection Instance
        {
            get { return _lazy.Value; }
        }

        public MySqlConnection Connection { get; private set; }

        private DbConnection()
        {
            //var conString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            var conString = "server=45.252.248.18;database=mrwhoami_OOAD;uid=mrwhoami_myuser;pwd=Haideptrai1;AllowUserVariables=True;SslMode=none;";
            Connection = new MySqlConnection(conString);
        }

        //public static DbConnection GetInstance()
        //{
        //    if (_instance is null)
        //        _instance = new DbConnection();

        //    return _instance;
        //}
    }
}
