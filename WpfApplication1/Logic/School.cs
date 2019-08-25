using System.Collections.Generic;
using System.Windows;
using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace WpfApplication1.Logic
{
    public class School
    {
        public School(int id, string schoolName, int typeId)
        {
            Id = id;
            SchoolName = schoolName;
            TypeId = typeId;
        }

        public int Id { get; set; }
        public string SchoolName { get; set; }
        public int TypeId { get; set; }
        public double amount { get; set; }
        public School(string schoolName)
        {
         SchoolName = schoolName;
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT Id,TypeId FROM dbo.School WHERE SchoolName='{schoolName}'";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Id = reader.GetInt32(0);
                            TypeId = reader.GetInt32(1);

                        }
                        connection.Close();


                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        public double Amount()
        {
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT Amount FROM dbo.SchoolType WHERE Id={TypeId}";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            amount = reader.GetInt32(0);
                            }
                        connection.Close();


                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            return amount;
        }
        public School(int id, string schoolName)
        {
            Id = id;
            SchoolName = schoolName;
        }

        public School()
        {
        }

        public List<string> Names()
        {
            List<string>names=new List<string>();
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT SchoolName FROM dbo.School";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            names.Add(reader.GetString(0));
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

            return names;
        } 

    }
}