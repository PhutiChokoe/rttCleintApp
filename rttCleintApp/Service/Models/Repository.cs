using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using Service.Interface;

namespace Service.Models
{
    public class Repository : IRepository
    {
        private const string DatabaseName = "Client_Database";
        private static RttLogger _rttLogger = new RttLogger();
        private const int CommandTimeout = 1200;

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings[DatabaseName].ConnectionString;
        }
        public DataTable CreateDataTable(string selectCommand)
        {
            return CreateDataTable(selectCommand, new List<SqlParameter>(), CommandType.Text);
        }

        public static DataTable CreateDataTable(string selectCommand, IEnumerable<SqlParameter> parameters, CommandType sqlCommandType)
        {
            var table = new DataTable();
            string connectionString = GetConnectionString();
            var dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            dataAdapter.SelectCommand.CommandType = sqlCommandType;
            foreach (SqlParameter parameter in parameters)
            {
                dataAdapter.SelectCommand.Parameters.Add(parameter);
            }
            dataAdapter.SelectCommand.CommandTimeout = CommandTimeout;
            dataAdapter.Fill(table);
            return table;
        }
        public static string CreateInsertSql(string table,
                                      IDictionary<string, string> parameterMap)
        {
            try
            {
                var keys = parameterMap.Keys.ToList();
                var values = parameterMap.Values.ToList();
                var sql = new StringBuilder("INSERT INTO ").Append(table).Append("(");

                for (var i = 0; i < keys.Count; i++)
                {
                    sql.Append(keys[i]);
                    if (i < keys.Count - 1)
                        sql.Append(", ");
                }

                sql.Append(") VALUES(");

                for (var i = 0; i < values.Count; i++)
                {
                    switch (table)
                    {
                        case "AddressDetails":
                            //  if (i != 5)
                            sql.Append("'").Append(values[i]).Append("'");
                            //    else sql.Append(values[i]);
                            break;
                        case "ClientDetails":
                            if (i != 3)
                                sql.Append("'").Append(values[i]).Append("'");
                            else sql.Append(values[i]);

                            break;
                        case "ContactDetails":
                            if (i != 1)
                                sql.Append("'").Append(values[i]).Append("'");
                            else sql.Append(values[i]);
                            break;
                    }


                    if (i < values.Count - 1)
                        sql.Append(", ");
                }

                return sql.Append(")").ToString();
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);

                throw;
            }
          
        }
        public void SqlInsert(string table, IDictionary<string, string> parameterMap)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(GetConnectionString());

                using (var connection = sqlCon)
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = CreateInsertSql(table, parameterMap);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);

                throw;
            }
           
        }
    }
}