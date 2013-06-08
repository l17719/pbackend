using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace BackendConnector.Utils
{
    public class Utility
    {
        private static Utility _instance;
        private static EntityConnectionStringBuilder _licConnStrBuilder;

        #region Ctor
        public static Utility GetInstance()
        {
            return _instance ?? (_instance = new Utility());
        }
        #endregion

        #region ConnectionStringData
        public static EntityConnectionStringBuilder GetSqlConfigData(string value)
        {
            var resultado = new EntityConnectionStringBuilder();
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var config = WebConfigurationManager.OpenWebConfiguration("~");
            var connString = config.ConnectionStrings.ConnectionStrings[value].ConnectionString;
            var sqlbuilder = new SqlConnectionStringBuilder(connString);
            resultado.Metadata = @"res://*/";
            resultado.Provider = "System.Data.SqlClient";
            resultado.ProviderConnectionString = sqlbuilder.ToString();
            return resultado;
        }

        public static void IniciaConnection()
        {
            _licConnStrBuilder = GetSqlConfigData("LicencaConn");
        }
       

     

        public EntityConnectionStringBuilder DevolveCOnnectionString()
        {
            if (_licConnStrBuilder == null)
            {
                IniciaConnection();
            }
            return _licConnStrBuilder;
        }
        #endregion
    }
}