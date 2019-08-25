using System;
using System.IO;

namespace WpfApplication1.Logic
{
    public static class Log
    {
        public static void UserAdded(LoginUser loginUser,string add,string role)
        {
            Write(loginUser.Username(),add,role);
        }

        public static void Logging(LoginUser loginUser)
        {
            #region MyRegion
            //using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        using (VistaDBCommand command = new VistaDBCommand())
            //        {
            //            command.Connection = connection;
            //            command.CommandText =$"";
            //            command.ExecuteNonQuery();
            //            connection.Close();

            //        }
            //    }
            //    catch (VistaDBException exception)
            //    {
            //        MessageBox.Show(exception.Message);
            //    }
            //} 
            #endregion
            Write(loginUser.Username(), "Logged in");
        }
        
        public static void Logout(LoginUser loginUser)
        {
            #region MyRegion
            //using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        using (VistaDBCommand command = new VistaDBCommand())
            //        {
            //            command.Connection = connection;
            //            command.CommandText = $"";
            //            command.ExecuteNonQuery();
            //            connection.Close();
            //        }
            //    }
            //    catch (VistaDBException exception)
            //    {
            //        MessageBox.Show(exception.Message);
            //    } 
            //}
            #endregion
            Write(loginUser.Username(),"Logged Out");
        }

        public static void Error(Exception e)
        {
            Write(e.Message);
        }
        private static void SetFileReadAccess(string fileName, bool setReadOnly)
        {
            if (File.Exists(fileName))
            {
                FileInfo fInfo = new FileInfo(fileName);

                // Set the IsReadOnly property.
                fInfo.IsReadOnly = setReadOnly;
            }

        }
        private static void Write(string user, string error)
        {
            SetFileReadAccess("Amansielog.dll",false);
            File.AppendAllText("Amansielog.dll", $"{DateTime.Now} {user} {error} {Environment.NewLine}");
            SetFileReadAccess("Amansielog.dll", true);
        }
        private static void Write(string exception = null)
        {
            SetFileReadAccess("AmansieError.dll", false);
            File.AppendAllText("AmansieError.dll", $"{DateTime.Now} {exception} {Environment.NewLine}");
            SetFileReadAccess("AmansieError.dll", true);
        }
        private static void Write(string username, string added, string role)
        {
            SetFileReadAccess("Amansielog.dll", false);
            File.AppendAllText("Amansielog.dll", $"{DateTime.Now} {username} Added {added} as {role} {Environment.NewLine}");
            SetFileReadAccess("Amansielog.dll", true);
        }
    }
}