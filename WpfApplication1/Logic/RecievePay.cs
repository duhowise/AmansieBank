using System.Collections.Generic;
using System.Data;
using System.Windows;
using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace WpfApplication1.Logic
{
    public class RecievePay
    {
        public RecievePay(PaymentOrder payment)
        {
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"UPDATE dbo.PaymentOrder SET Status = 'Recieved',RecievedBy ={LoginUser.UserId},RecievedDate = GETDATE() WHERE Id = {payment.Id}";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(@"successfully Recieved");

                    }
                }
                catch (VistaDBException exception)
                {
                    Log.Error(exception);
                }
            }
        }
        public RecievePay(List<PaymentOrder>list )
        {
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    foreach (var pay in list)
                    {
                        connection.Open();
                        using (VistaDBCommand command = new VistaDBCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = $"UPDATE dbo.PaymentOrder SET Status = 'Recieved',RecievedBy ={LoginUser.UserId},RecievedDate = GETDATE() WHERE Id = {pay.Id}";
                            command.ExecuteNonQuery();
                            connection.Close();

                        }
                    }
                   
                    MessageBox.Show(@"Selected payments confirmed successfully");
                }
                catch (VistaDBException exception)
                {
                   Log.Error(exception);
                }
            }
        }
        public DataTable ViewPending()
        {
            var data = new DataTable();
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        var query = command.CommandText = $"SELECT PoNumber as PONumber,UserId,Date FROM dbo.PaymentOrder where status='Pending'";
                        var adapter = new VistaDBDataAdapter(command.CommandText, command.Connection);
                        adapter.Fill(data);
                        connection.Close();


                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            return data;
        }
        public DataTable ViewPending(string serch)
        {
            var data = new DataTable();
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        var query = command.CommandText = $"SELECT PoNumber as PONumber,UserId,Date FROM dbo.PaymentOrder where status='Pending'";
                        var adapter = new VistaDBDataAdapter(command.CommandText, command.Connection);
                        adapter.Fill(data);
                        connection.Close();


                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
            return data;
        }
    }
}