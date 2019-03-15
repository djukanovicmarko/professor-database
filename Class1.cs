using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Domaci5
{
    class Profesor
    {
        private int id;
        private string ime;
        private string prezime;
        private string zvanje;
        private string katedra;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti ime profesora!!!");
                ime = value;
            }
        }

        public string Prezime
        {
            get { return prezime; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti prezime profesora!!!");
                prezime = value;
            }
        }

        public string Zvanje 
        {
            get { return zvanje; }
            set 
            {
                if (value == "")
                    throw new Exception("Morate uneti zvanje profesora");
                zvanje = value;
            }
        }

        public string Katedra 
        {
            get { return katedra; }
            set 
            {
                if (value == "")
                    throw new Exception("Morate uneti katedru profesora");
                katedra = value;
            }
        }

        private string _connectionString = @"Data Source=.\SQLEXPRESS;
                                            AttachDbFilename=C:\Users\Marko\Desktop\Domaci C#\Domaci5-6-7\Domaci5\Domaci.mdf;
                                             Integrated Security=True;
                                                 Connect Timeout=30;
                                                     User Instance=True";

        public void dodajProfesora()
        {
            string insertSql = "INSERT INTO Profesor" +
                "(Ime, Prezime, Zvanje, Katedra) VALUES " +
                "(@Ime, @Prezime, @Zvanje, @Katedra)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Zvanje", Zvanje));
                command.Parameters.Add(new SqlParameter("@Katedra", Katedra));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void azurirajProfesora()
        {
            string updateSql = "UPDATE Profesor SET Ime = @Ime, Prezime = @Prezime,  Zvanje = @Zvanje, Katedra = @Katedra WHERE profesorid = @profesorid";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@profesorid", ID));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Zvanje", Zvanje));
                command.Parameters.Add(new SqlParameter("@Katedra", Katedra));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiProfesora()
        {
            string deleteSql =
                "DELETE FROM Profesor WHERE profesorid = @profesorid";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@profesorid", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Profesor> ucitajProfesora()
        {
            List<Profesor> profesori = new List<Profesor>();
            string queryString =
                "SELECT * FROM Profesor";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Profesor prof;
                    while (reader.Read())
                    {
                        prof = new Profesor();
                        prof.ID = Int32.Parse(reader["profesorid"].ToString());
                        prof.Ime = reader["Ime"].ToString();
                        prof.Prezime = reader["Prezime"].ToString();
                        prof.Zvanje = reader["Zvanje"].ToString();
                        prof.Katedra = reader["Katedra"].ToString();
                        profesori.Add(prof);
                    }
                }
            }
            return profesori;

    }
}

}
