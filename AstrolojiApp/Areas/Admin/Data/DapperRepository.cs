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

    public async Task<T?> GetAsync(int id)
    {
        using (var connection = CreateConnection())
        {
            var query = $"SELECT * FROM {_tableName} WHERE Id = @Id";
            return await connection.QuerySingleOrDefaultAsync<T>(query, new { Id = id });
        }
    }


    public async Task<int> AddAsync(T entity)
    {
        using (var connection = CreateConnection())
        {
            var query = $"INSERT INTO {_tableName} ({string.Join(",", GetColumns())}) " +
                        $"VALUES ({string.Join(",", GetParameters())});";
            return await connection.ExecuteAsync(query, entity);
        }
    }

    private IEnumerable<string> GetColumns()
    {

        var properties = typeof(T).GetProperties();
        return properties.Select(p => p.Name);
    }

    private IEnumerable<string> GetParameters()
    {

        var properties = typeof(T).GetProperties();
        return properties.Select(p => "@" + p.Name);
    }


    public async Task<int> UpdateAsync(T entity)
    {
        using (var connection = CreateConnection())
        {
            var query = $"UPDATE {_tableName} SET {string.Join(",", GetUpdateSet())} WHERE Id = @Id";
            return await connection.ExecuteAsync(query, entity);
        }
    }

    private IEnumerable<string> GetUpdateSet()
    {
        var properties = typeof(T).GetProperties();
        return properties.Where(p => p.Name != "Id")
                         .Select(p => $"{p.Name} = @{p.Name}");
    }


    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = CreateConnection())
        {
            var query = $"DELETE FROM {_tableName} WHERE Id = @Id";
            return await connection.ExecuteAsync(query, new { Id = id });
        }
    }

}
