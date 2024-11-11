using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace AstrolojiApp.Areas.Admin.Data;

public class DapperRepository<T> : IRepository<T> where T : class
{
    private readonly string _connectionString;
    private readonly string _tableName;
    public DapperRepository()
    {

        //Bağlantıyı hazırlıyoruz
        _connectionString = "Server=localhost,1441;Database=AstrologyDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";

        //    var connection = new SqlConnection(connectionString);



   //    _connectionString = "Server=.\\SQLEXPRESS; Database=AstrologyDb; Integrated Security=True;TrustServerCertificate=True";



        _tableName = typeof(T).Name;

        if (_tableName.EndsWith("y"))
        {

            _tableName = _tableName.Substring(0, _tableName.Length - 1) + "ies";

        }
        else
        {
            _tableName += "s";

        }
    }

    private IDbConnection CreateConnection()
    {

        return new SqlConnection(_connectionString);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        using (var connection = CreateConnection())
        {
            var query = $"Select * from {_tableName}";
            return await connection.QueryAsync<T>(query);
        }
    }

    public Task<T?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}
