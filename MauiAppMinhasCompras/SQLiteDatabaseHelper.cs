using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras
{
    public class SQLiteDatabaseHelper
    {
        private string path;

        public SQLiteDatabaseHelper(string databasePath)
        {
            path = databasePath;
        }

        internal async Task InsertAsync(Produto p)
        {
            throw new NotImplementedException();
        }
    }
}