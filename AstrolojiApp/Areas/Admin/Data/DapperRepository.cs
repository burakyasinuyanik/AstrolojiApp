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
            var query = $"Select * from {_tableName} where Id={id}";
            return await connection.QuerySingleOrDefaultAsync<T>(query);
        }
    }

    public async Task<int> AddAsync(T entity)
    {
        using (var connection = CreateConnection())
        {
            var query =GetAddQuery(entity);
            var result = await connection.ExecuteAsync(query, entity);
            return result;
        }
    }
    //insert into student(name, clasNumber...) Values(Name=@Name, classNumber=@ClassNumber)
    private string GetAddQuery(T entity)
    {
        var properties = typeof(T).GetProperties();
        var columnNames = new List<string>();

        foreach (var property in properties)
        {
            if (property.Name == "Id")
                continue;
            columnNames.Add(property.Name);
        }

        var column = String.Join(", ", columnNames);
        var values = String.Join(", @", columnNames);
        var query = $"insert into {_tableName} ({column}) values (@{values})";    
        return query;
    }

    //update student (name, clasNumber...) set (Name=@Name, classNumber=@ClassNumber)  where Id=id
    public async Task<int> UpdateAsync(T entity)
    {
        using (var connection = CreateConnection())
        {
            var query = GetUpdateQuery(entity);
            var result = await connection.ExecuteAsync(query,entity);
            return result;
        }
    }

    private string GetUpdateQuery(T entity)
    {
        var properties = typeof(T).GetProperties();
        var columnNames = new List<string>();
        int? entityId = null;
        foreach (var property in properties)
        {
            if (property.Name == "Id")
            {
                entityId = property.GetValue(entity).GetHashCode();
                continue;

            }

            columnNames.Add($"{property.Name}=@{property.Name}");
        }

        var values = String.Join(", ", columnNames);
        var query = $"update {_tableName} set {values} where Id=@Id";

        return query;
    }

    public Task<int> DeleteAsync(int id)
    {
        using (var connection = CreateConnection())
        {
            var query = $"delete {_tableName} where={id}";
            var result = connection.ExecuteAsync(query, new { Id = id });
            return null;
        }
    }
}
