using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Utwor
{
    public class Operacje_na_bazie
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


        public void DodajUtworDoBazy(Utwor utwor)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();
            SqlCommand cmd = new SqlCommand("INSERT INTO [PprUtwor] (id, tytul, wykonawca, dlugosc,rok, id_albumu) VALUES "
                + "(@id, @tytul, @wykonawca, @dlugosc, @rok)", baza.GetConnection());
            cmd.Parameters.Add("@id", utwor.getId());
            cmd.Parameters.Add("@tytul", utwor.getTytul());
            cmd.Parameters.Add("@wykonawca", utwor.getWykonawca());
            cmd.Parameters.Add("@dlugosc", utwor.getDlugosc());
            cmd.Parameters.Add("@rok", utwor.getRok_wydania());
            cmd.Parameters.Add("@id_albumu", utwor.getId_albumu());

            cmd.ExecuteNonQuery();

            baza.CloseConnection();
        }

        public void DodajAlbumDoBazy(Album album)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("INSERT INTO [PprAlbum] (id, nazwa, dlugosc, wydawnictwo) VALUES "
                + "(@id, @nazwa, @dlugosc, @wydawnicwo)", baza.GetConnection());
            cmd.Parameters.Add("@id", album.getId_albumu());
            cmd.Parameters.Add("@nazwa", album.getNazwa());
            cmd.Parameters.Add("@dlugsc", album.getDlugosc());
            cmd.Parameters.Add("@wydawnicwo", album.getWydawnictwo());

            cmd.ExecuteNonQuery();

            baza.CloseConnection();
        }

        public void DodajWydawnictwoDoBazy(Wydawnictwo wydawnictwo)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("INSERT INTO [PprWydawnictwo] (id, nazwa, rok, wlasciciel, kraj) VALUES "
                + "(@id, @nazwa, @rok, @wlasciciel, @kraj)", baza.GetConnection());
            cmd.Parameters.Add("@id", wydawnictwo.getId());
            cmd.Parameters.Add("@nazwa", wydawnictwo.getNazwa());
            cmd.Parameters.Add("@rok", wydawnictwo.getRok_zal());
            cmd.Parameters.Add("@wlasciciel", wydawnictwo.getWlasciciel());
            cmd.Parameters.Add("@kraj", wydawnictwo.getKraj());
            cmd.ExecuteNonQuery();

            baza.CloseConnection();
        }


        public void UsunUtwor(string id)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("DELETE FROM [PprUtwor] WHERE id = " + id, baza.GetConnection());

            cmd.ExecuteNonQuery();
            baza.CloseConnection();

        }

        public void UsunAlbum(string id)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("DELETE FROM [PprAlbum] WHERE id = " + id, baza.GetConnection());

            cmd.ExecuteNonQuery();
            baza.CloseConnection();

        }

        public void UsunWydawnictwo(string id)
        {
            Operacje_na_bazie baza = new Operacje_na_bazie();
            baza.ConnectToSQL();

            SqlCommand cmd = new SqlCommand("DELETE FROM [PprWydawicwo] WHERE id = " + id, baza.GetConnection());

            cmd.ExecuteNonQuery();
            baza.CloseConnection();

        }


    }
}