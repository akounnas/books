using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace books.Controllers
{
    class SqlController
    {
        private readonly string connectionString;

        public SqlController()
        {
            connectionString = "Server=DESKTOP-5H5OH06" + "\\" + "SQLEXPRESS;" + "Initial Catalog=Books;" + "Integrated Security=True;";
        }

        public bool InsertData(DataModel data)
        {
            
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = string.Format(Queries.Queries.InsertQuery, "Books");

                    command.Parameters.Add("@title", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@author", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@year", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@isbn", SqlDbType.VarChar, 50);
                    command.Parameters.Add("@genre", SqlDbType.VarChar, 50);

                    if (!string.IsNullOrEmpty(data.title)  && !string.IsNullOrEmpty(data.author) && (data.year == "0") && (data.genre == "Select Genre...") ) {
                        try
                        {
                            connection.Open();

                            command.Parameters["@title"].Value = data.title;
                            command.Parameters["@author"].Value = data.author;
                            command.Parameters["@year"].Value = data.year;
                            command.Parameters["@isbn"].Value = data.isbn;
                            command.Parameters["@genre"].Value = data.genre;

                            command.ExecuteNonQuery();

                            return true;
                        }
                        catch (Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                            return false;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("title, author, year and genre fields can't be empty");
                        return false;
                    }
                }
            }
        }

        public List<DataModel> SelectData(string selection)
        {
            
            List<DataModel> result = new List<DataModel>();
            var query = string.Format(Queries.Queries.SelectQuery, "Books",selection);

            using(var connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DataModel data = new DataModel();
                                data.title = reader["title"].ToString();
                                data.author = reader["author"].ToString();
                                data.year = reader["year"].ToString();
                                data.isbn = reader["isbn"].ToString();
                                data.genre = reader["genre"].ToString();
                                result.Add(data);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }


        public List<string> SelectGenre()
        {

            List<string> result = new List<string>();
            var query = string.Format(Queries.Queries.SelectQuery, "Books");

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();


                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(reader["genre"].ToString());
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return result;
        }
    }

}
