using System.Collections.Generic;
using System.Windows;
using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace WpfApplication1.Logic
{
    public class User
    {
        public int Id { get; set; }
        public int  Type { get; set; }
        public string Name { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int FindId(User user)
        {
            int getId = 0;
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT Id FROM dbo.Users where Name='{user.Name}'";
                      var reader=command.ExecuteReader();
                        while (reader.Read())
                        {
                            getId = reader.GetInt32(0);
                        }
                        connection.Close();

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            return getId;
        }
        public void Save(User user)
        {
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO dbo.Users(RoleId,Name)VALUES({user.Type},N'{user.Name}')";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"successfully Added {user.Name}");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        public void CreateLogin(User user)
        {
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO dbo.Login(UserName ,UserId ,Password)VALUES('{user.userName}',{user.Id},'{user.Password}')";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"successfully Added {user.userName}");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        public User( string name,int type)
        {
           Name = name;
            Type = type;
        }

        public User(int id, string userName, string password)
        {
            Id = id;
            this.userName = userName;
            Password = password;
        }
        public User(string name)
        {
            Name = name;
        }
        public User()
        {
        }
        public static List <string> Names()
        {
            List<string> names = new List<string>();
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT Name FROM dbo.Users";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            names.Add(reader.GetString(0));
                        }
                        connection.Close();
                        if (names.Count<1)
                        {
                            names.Add("No Data Available");
                        }
                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }

            return names;
        }
    }
}