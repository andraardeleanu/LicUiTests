using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LicUiTests.Helpers
{
    public class DbAccess
    {
        public static void CompanyCleanUp(string CUI)
        {
            var sql = "SP_CompanyCleanUp";

            using (IDbConnection connection = new SqlConnection(AppSettings.LicUiTestsConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(sql,
                    param: new
                    {
                        CUI
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public static void WorkpointCleanUp(string Name)
        {
            var sql = "SP_WorkpointCleanUp";

            using (IDbConnection connection = new SqlConnection(AppSettings.LicUiTestsConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(sql,
                    param: new
                    {
                        Name
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public static void ProductCleanUp(string Name)
        {
            var sql = "SP_ProductCleanUp";

            using (IDbConnection connection = new SqlConnection(AppSettings.LicUiTestsConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(sql,
                    param: new
                    {
                        Name
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public static void StockReset(string Name)
        {
            var sql = "SP_StockReset";

            using (IDbConnection connection = new SqlConnection(AppSettings.LicUiTestsConnectionString))
            {
                connection.Open();
                var affectedRows = connection.Execute(sql,
                    param: new
                    {
                        Name
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
