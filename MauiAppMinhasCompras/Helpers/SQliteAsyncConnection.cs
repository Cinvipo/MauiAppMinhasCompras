using SQLite;
using MauiAppMinhasCompras.Models;

public class SQLiteDatabaseHelper
{
    private SQLiteAsyncConnection _connection;

    public SQLiteDatabaseHelper(string dbPath)
    {
        _connection = new SQLiteAsyncConnection(dbPath);
        _connection.CreateTableAsync<Produto>().Wait();
    }

    public Task<int> Insert<T>(T item)
    {
        return _connection.InsertAsync(item);
    }

    internal async Task<List<Produto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    internal async Task InsertAsync(Produto p)
    {
        throw new NotImplementedException();
    }

    internal async Task<List<Produto>> SearchAsync(string q)
    {
        throw new NotImplementedException();
    }
}
