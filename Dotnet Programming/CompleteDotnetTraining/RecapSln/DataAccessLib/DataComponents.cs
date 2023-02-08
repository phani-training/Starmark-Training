using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public interface IBookStore
    {
        /// <summary>
        /// Adds a New book to the System
        /// </summary>
        /// <param name="title">The Title of the Book</param>
        /// <param name="author">The Author of the Book</param>
        /// <param name="price">The Cost of the Book</param>
        /// <exception cref="DataAccessLib.BookDataException"/>
        void AddNewBook(string title, string author, int price);
        void UpdateBook(int bookId, string title, string author, int price);
        void DeleteBook(int id);
        DataTable GetAllBooks();
    }
    public static class BookStoreFactory
    {
        public static IBookStore GetComponent() => new ConnectedBookStore();
    }
    internal class ConnectedBookStore : IBookStore
    {
        static readonly string STRCONNECTION = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        const string STRINSERT = "Insert into BookTable values(@title, @author, @price)";
        const string STRQUERY = "SELECT * FROM BOOKTABLE";
        const string STRUPDATE = "Update BookTable Set Title = @title, Author =@author, Price = @price WHERE BookId = @id";
        const string STRDELETE = "DELETE FROM BookTable where BookId = @id";


        public void AddNewBook(string title, string author, int price)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRINSERT, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@price", price);
            using (connection)
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new BookDataException("Adding of the Book failed", ex);
                }
            }
        }

        public void DeleteBook(int id)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRDELETE, connection);
            command.Parameters.AddWithValue("@id", id);
            using (connection)
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new BookDataException("Deleting of the Book failed", ex);
                }
            }

        }

        public DataTable GetAllBooks()
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRQUERY, connection);
            using (connection)
            {
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var table = new DataTable("Books");
                    table.Load(reader);
                    return table;
                }
                catch (Exception ex)
                {
                    throw new BookDataException("Getting the books failed", ex);
                }
            }
        }

        public void UpdateBook(int bookId, string title, string author, int price)
        {
            var connection = new SqlConnection(STRCONNECTION);
            var command = new SqlCommand(STRUPDATE, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@id", bookId);
            using (connection)
            {
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new BookDataException("Updating of the Book failed", ex);
                }
            }
        }
    }

}
