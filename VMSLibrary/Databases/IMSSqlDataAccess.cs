using System.Collections.Generic;
using System.Threading.Tasks;

namespace VMSLibrary.Databases
{
    public interface IMSSqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement,
                               U parameters,
                               string connectionStringName,
                               bool isStoredProcedure = false);

        Task<List<T>> LoadDataAsync<T, U>(string storedProcedure,
                                          U parameters,
                                          string connectionStringName);

        void SaveData<T>(string sqlStatement,
                         T parameters,
                         string connectionStringName,
                         bool isStoredProcedure = false);

        Task SaveDataAsync<T>(string storedProcedure,
                              T parameters,
                              string connectionStringName);
    }
}