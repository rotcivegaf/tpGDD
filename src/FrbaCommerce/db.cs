using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace FrbaCommerce
{
    public static class db
    {
        public static SqlConnection crearConexion()
        {
            /*Devuelve un SqlConnection ABIERTA*/
            SqlConnection cn = new SqlConnection(cnString());
            cn.Open();
            return cn;
        }

        private static string cnString()
        {
            return "user id=gd;" + "password=gd2014;server=localhost\\SQLSERVER2008;" +
                   "Trusted_Connection=yes;" + "database=GD1C2014; " + "connection timeout=150";
        }

        internal static void runFunction(string sp, List<SqlParameter> lista)
        {

            using (SqlConnection cn = db.crearConexion())
            {
                using (SqlCommand cm = new SqlCommand("LOL.sp_" + sp, cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    foreach(SqlParameter param in lista)
                    {
                        cm.Parameters.Add(param);
                    }
                    cm.ExecuteNonQuery();
                }
            }
        }
        internal static void runStoredProcedure(string sp, List<SqlParameter> lista)
        {

            using (SqlConnection cn = db.crearConexion())
            {
                using (SqlCommand cm = new SqlCommand("LOL.sp_" + sp, cn))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter param in lista)
                    {
                        cm.Parameters.Add(param);
                    }
                    cm.ExecuteNonQuery();
                }
            }
        }
    }
}
