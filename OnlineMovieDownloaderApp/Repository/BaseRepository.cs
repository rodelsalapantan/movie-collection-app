using Dapper;
using MySql.Data.MySqlClient;
using OnlineMovieDownloaderApp.Contracts;
using OnlineMovieDownloaderApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieDownloaderApp.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private MySqlConnection _con;
        private string _tableName;
        private IDictionary<string, string> _propAttributeList;

        // Constructor
        public BaseRepository()
        {
            // Get all properties of a class
            _tableName = GetClassAttribute();
            if (_tableName == null)
                MessageBox.Show("Table Not Found");

            // Get all Properties
            _propAttributeList = GetAttributeOfProperties();
            StartConnection();
        }

        # region ------  CRUD -------
        // Insert
        public async Task<bool> Create(T model)
        {
            StartConnection();

            string queryString = GenerateInsertQuery();
            int count = await _con.ExecuteAsync(queryString, model);
            CloseConnection();

            return count > 0;
        }
        // Select Single by Id
        public async Task<T> GetOne(object id)
        {
            StartConnection();

            string queryString = $"SELECT * FROM {_tableName} WHERE id = @Id";

            var result = await _con.QuerySingleOrDefaultAsync<T>(queryString, new { Id = id });
            CloseConnection();

            if (result != null)
                return result;

            return null;
        }
        // Select All
        public async Task<IEnumerable<T>> GetAll()
        {
            StartConnection();

            string queryString = $"SELECT * FROM {_tableName}";

            var result = await _con.QueryAsync<T>(queryString);
            CloseConnection();

            if (result != null)
                return result;

            return null;
        }
        // Delete
        public async Task<bool> Delete(object id)
        {
            var result = await GetOne(id);
            if (result == null)
            {
                MessageBox.Show("Item not found!");
                return false;
            }

            string queryString = $"DELETE FROM {_tableName} WHERE id = @Id";
            var resultQuery = await _con.ExecuteAsync(queryString, new { Id = id });
            CloseConnection();

            return resultQuery > 0;
        }
        // Update
        public async Task<bool> Update(object id, T model)
        {
            var result = await GetOne(id);
            if (result == null)
            {
                MessageBox.Show("Item not found!");
                return false;
            }

            string queryString = GenerateUpdateQuery();
            var resultQuery = await _con.ExecuteAsync(queryString, model);
            CloseConnection();

            return resultQuery > 0;
        }
        # endregion CRUD

        // Start Database Connection
        private void StartConnection()
        {
            string conString = ConfigSettings.GetConnectionString();
            _con = new MySqlConnection();
            _con.ConnectionString = conString;

            try
            {
                _con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error While Connecting to Database: {ex}", "Message");
            }
        }

        // End Database Connection
        private void CloseConnection() => _con.Close();


        // Get the class' attribute
        private string GetClassAttribute()
        {
            // Get the table name attribute of a class
            var classAttribute = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (classAttribute.Length > 0)
            {
                return (classAttribute[0] as TableAttribute).Name;
            }
            else
            {
                return null;
            }
        }

        // Get all properties of the class
        private IDictionary<string, string> GetAttributeOfProperties()
        {
            var resultList = new Dictionary<string, string>();

            foreach (var prop in typeof(T).GetProperties())
            {
                var columnName = prop.GetCustomAttribute<ColumnAttribute>().Name;
                // if ColumnName attribute is missing, use its property name
                if (columnName != null)
                    resultList.Add(columnName, prop.Name);
                else
                    resultList.Add(prop.Name, prop.Name);
            }

            if (resultList != null)
                return resultList;
            return null;
        }

        // Query String Generator for Insert
        private string GenerateInsertQuery()
        {
            StringBuilder query = new StringBuilder($"INSERT INTO {_tableName} ( ");
            var propertyList = _propAttributeList;

            foreach (var item in propertyList)
                query.Append($"{item.Key},");

            query
                .Remove(query.Length - 1, 1)
                .Append(") VALUES (");

            foreach (var item in propertyList)
                query.Append($"@{item.Value},");

            query
                .Remove(query.Length - 1, 1)
                .Append(")");
            return query.ToString();
        }

        // Query String Generator for Update
        private string GenerateUpdateQuery()
        {
            var query = new StringBuilder($"UPDATE {_tableName} SET ");
            var propList = _propAttributeList;

            foreach (var item in propList)
            {
                if (!item.Key.Equals("id"))
                {
                    query.Append($"{item.Key}=@{item.Value},");
                }
            }
            query.Remove(query.Length - 1, 1) // remove last comma
                .Append(" WHERE id = @Id");

            return query.ToString();
        }
    }
}
