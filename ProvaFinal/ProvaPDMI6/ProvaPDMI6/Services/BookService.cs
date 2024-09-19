using ProvaPDMI6.Data;
using ProvaPDMI6.Services.Interface;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPDMI6.Services
{
    public class BookService : IBookService
    {
        private SQLiteAsyncConnection _dbConnection;
        public async Task InitializeAsync()
        {
            await SetUpDb();
        }

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath =
                Path.Combine(FileSystem.Current.AppDataDirectory, "clientdb.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Book>();
            }
        }

        public async Task<int> AddBook(Book book)
        {
            return await _dbConnection.InsertAsync(book);
        }

        public async Task<int> DeleteBook(Book book)
        {
            return await _dbConnection.DeleteAsync(book);
        }
        public async Task<int> UpdateBook(Book book)
        {
            return await _dbConnection.UpdateAsync(book);
        }

        public async Task<Book> GetBookById(int id)
        {
            var aluno = await _dbConnection.QueryAsync<Book>($"Select * From { nameof(Book) } where Id = { id } ");
            return aluno.FirstOrDefault();
        }

        public async Task<List<Book>> GetBooks()
        {
            return await _dbConnection.Table<Book>().ToListAsync();
        }

        
    }
}
