using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace VMSLibrary.Databases
{
    public class MSSqlDataAccess : IMSSqlDataAccess
    {
        private readonly IConfiguration config;

        public MSSqlDataAccess(IConfiguration config)
        {
            this.config = config;
        }
        public List<T> LoadData<T, U>(string sqlStatement,
                                      U parameters,
                                      string connectionStringName,
                                      bool isStoredProcedure = false)
        {
            string connectionString = config.GetConnectionString(connectionStringName);
            CommandType commandType = CommandType.Text;

            if (isStoredProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters, commandType: commandType).ToList();
                return rows;
            }

        }

        public async Task<List<T>> LoadDataAsync<T, U>(string storedProcedure,
                                                       U parameters,
                                                       string connectionStringName)
        {
            string connectionString = config.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(storedProcedure,
                                                          parameters,
                                                          commandType: CommandType.StoredProcedure);
                return rows.ToList();
            }
        }

        public void SaveData<T>(string sqlStatement,
                                T parameters,
                                string connectionStringName,
                                bool isStoredProcedure = false)
        {
            string connectionString = config.GetConnectionString(connectionStringName);
            CommandType commandType = CommandType.Text;

            if (isStoredProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters, commandType: commandType);
            }
        }

        public async Task SaveDataAsync<T>(string storedProcedure,
                                           T parameters,
                                           string connectionStringName)
        {
            string connectionString = config.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(storedProcedure,
                                              parameters,
                                              commandType: CommandType.StoredProcedure);
            }
        }
    }
}
