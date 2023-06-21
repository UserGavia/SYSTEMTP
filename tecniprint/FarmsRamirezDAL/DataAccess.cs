using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FarmsRamirezDAL
{
    public class DataAccess
    {
        //Singleton
        #region Singleton
        private static volatile DataAccess instance = null;
        private static readonly object padlock = new object();
        public static string conString = "Server=tcp:USER6663-PC\\SERVERTP,49500; Database=TECNIPRINT; User id = sa; Password=12345";

        private DataAccess() { }
        public static DataAccess Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new DataAccess();
            return instance;
        }
        #endregion

        #region Query/Execute Dapper
        public T QuerySingle<T>(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingle<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public T QuerySingle<T>(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingle<T>(query, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public T QuerySingleOrDefault<T>(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingleOrDefault<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public T QuerySingleOrDefault<T>(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingleOrDefault<T>(query, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public string QueryString(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingle<string>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public string QueryString(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.QuerySingle<string>(query, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public List<T> Query<T>(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.Query<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300).ToList();
        }

        public List<T> Query<T>(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.Query<T>(query, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 300).ToList();
        }

        public int Insert(string query, DynamicParameters dynamicParameters, string fieldName)
        {
            using (var con = new SqlConnection(conString))
                return (int)((IDictionary<string, object>)con.QuerySingle(query, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 300))[fieldName];
        }

        public int Execute(string query)
        {
            using (var con = new SqlConnection(conString))
                return con.Execute(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }

        public int Execute(string query, DynamicParameters dynamicParameters)
        {
            using (var con = new SqlConnection(conString))
                return con.Execute(query, dynamicParameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
        }
        #endregion
    }
}
