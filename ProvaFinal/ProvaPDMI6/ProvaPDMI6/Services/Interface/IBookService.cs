using ProvaPDMI6.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPDMI6.Services.Interface
{
    public interface IBookService
    {
        Task InitializeAsync();
        Task<List<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        Task<int> AddBook(Book book);
        Task<int> UpdateBook(Book book); 
        Task<int> DeleteBook(Book book);
    }
}
