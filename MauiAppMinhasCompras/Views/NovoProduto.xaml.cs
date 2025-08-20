using MauiAppMinhasCompras.Models;
using SQLite;

namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
    public NovoProduto()
    {
        InitializeComponent();
    }

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text)
            };

            // Ensure the SQLiteDatabaseHelper class has an Insert method
            await App.Db.InsertAsync(p); // Changed to InsertAsync to match common SQLite async patterns
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}

public class SQLiteDatabaseHelper
{
    private readonly SQLiteAsyncConnection _database;

    public SQLiteDatabaseHelper(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Produto>().Wait();
    }

    public Task<int> InsertAsync(Produto produto)
    {
        return _database.InsertAsync(produto);
    }
}
