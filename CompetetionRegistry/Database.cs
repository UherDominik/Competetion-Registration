using System.Data.SqlClient;

namespace CompetetionRegistry
{
    public class Database
    {
        private string connectionString = "Data Source=DESKTOP-OAC99GQ;Initial Catalog=CompRegDB;Integrated Security=True;Pooling=False";


        //Load Data from DB
        public List<Competitor> LoadData()
        {
            List<Competitor> competitors = new();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Competitors";
                using (SqlCommand sqlQuery = new SqlCommand(query, connection))
                {
                    SqlDataReader sqlDataReader = sqlQuery.ExecuteReader();
                    sqlDataReader.Read();
                    
                    while (sqlDataReader.Read())
                    {
                        competitors.Add(new Competitor((int)sqlDataReader["Id"], (string)sqlDataReader["Name"], (string)sqlDataReader["Surname"], (string)sqlDataReader["Category"]));
                    }
                   

                }


                connection.Close();
            }
            return competitors;


        }

        //Insert Competitor into DB
        public void InsertNewCopetitor(string name, string surname, string category)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Competitors (Name, Surname, Category) VALUES (@name, @surname, @category)";
                using (SqlCommand sqlQuery = new SqlCommand(query, connection))
                {
                    sqlQuery.Parameters.AddWithValue("@name", name);
                    sqlQuery.Parameters.AddWithValue("@surname", surname);
                    sqlQuery.Parameters.AddWithValue("@category", category);
                    sqlQuery.ExecuteNonQuery();

                }


                connection.Close();
            }


        }
        //Update Competitor in DB
        public void UpdateCopetitor(string name, string surname, string category, int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Competitors SET Name=@name, Surname=@surname, Category=@category WHERE Id=@id";
                using (SqlCommand sqlQuery = new SqlCommand(query, connection))
                {
                    sqlQuery.Parameters.AddWithValue("@name", name);
                    sqlQuery.Parameters.AddWithValue("@surname", surname);
                    sqlQuery.Parameters.AddWithValue("@category", category);
                    sqlQuery.Parameters.AddWithValue("@id", id);
                    sqlQuery.ExecuteNonQuery();

                }


                connection.Close();
            }
        }

        //Delete Competitor from DB
        public void DeleteCopetitor(int id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Competitors WHERE Id=@id";
                using (SqlCommand sqlQuery = new SqlCommand(query, connection))
                {
                
                    sqlQuery.Parameters.AddWithValue("@id", id);
                    sqlQuery.ExecuteNonQuery();

                }


                connection.Close();
            }
        }
    }
}

