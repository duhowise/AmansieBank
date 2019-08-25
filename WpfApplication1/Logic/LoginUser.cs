using System;
using System.Windows;
using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace WpfApplication1.Logic
{
    public class LoginUser
    {
        public static int UserId;
        private static int roleId;

        public static int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }

        public static bool Valid(string username, string password)
        {
            int user = 0;
            bool valid=false;
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT UserId FROM dbo.Login WHERE UserName='{username}' AND Password='{password}'";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            user++;
                            UserId = reader.GetInt32(0);
                        }
                        connection.Close();

                        if (user==1)
                        {
                            valid = true;
                        }
                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
            return valid;
        }

       public string Username()
        {
            string name=String.Empty;
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT RoleId,Name FROM dbo.Users WHERE Id={UserId}";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            RoleId = reader.GetInt32(0);
                            name = reader.GetString(1);

                        }
                        connection.Close();

                      
                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
            return name;
        }
        public int Role()
        {
            
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT RoleId FROM dbo.Users WHERE Id={UserId}";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            RoleId = reader.GetInt32(0);
                          }
                        connection.Close();


                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
            return RoleId;
        }
    }
}