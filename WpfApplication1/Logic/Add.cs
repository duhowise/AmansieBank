using System.Windows;
using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace WpfApplication1.Logic
{
     
    public class Add
    {

        public void School(School school)
        {
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        //command.CommandText = $"INSERT INTO dbo.School(SchoolName)VALUES('{school.SchoolName}')";
                        command.CommandText = $"INSERT INTO dbo.School(TypeId,SchoolName)VALUES({school.TypeId},'{school.SchoolName}')";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"Successfully added {school.SchoolName}");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
        }
        public void CategoryInterest(int id,double amount, string categoryName)
        {
            using (VistaDBConnection connection = Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"UPDATE dbo.SchoolType SET Amount ={amount} WHERE  Id = {id}";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"Successfully updated Commission for {categoryName} Category");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
        }

        public void Payment(PaymentOrder payment, School school, User user)
        {
            using (VistaDBConnection connection=Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO dbo.PaymentOrder(PoNumber,Beneficiary,Payee,Phone,Amount,Interest,SchoolId,UserId)VALUES('{payment.PoNumber}','{payment.Beneficiary}','{payment.Payee}','{payment.Phone}',{payment.Amount},{payment.Interest},{school.Id},{user.Id},)";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"Successfully added Payment for {school.SchoolName}");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
        }
        public void User(User user)
        {
            using (VistaDBConnection connection =Connection.Connexion)
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO dbo.Users(Name,RoleId)VALUES('{user.Name}',2)";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show($"successfully added {user.Name}");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }

        }

    }
}