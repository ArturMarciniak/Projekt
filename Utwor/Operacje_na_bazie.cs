using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Utwor
{
    class Operacje_na_bazie
    {
        private SqlConnection _connection;
        private string _dbUserId;
        private string _password;

        public void SetUserId(string dbUserId)
        {
            _dbUserId = dbUserId;
        }

        private string GetUserId()
        {
            return _dbUserId;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        private string GetPassword()
        {
            return _password;
        }

        public void ConnectToSQL()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString =
                "Data Source=mssql-2016.labs.wmi.amu.edu.pl;" +
                "Initial Catalog=dbad_s426187;" +
                "User id=s426187;" +
                "Password=eRW12aVqq1";
            try
            {
                _connection.Open();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                _connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }

            if (_connection == null)
            {
                return;
            }
        }
    }
}