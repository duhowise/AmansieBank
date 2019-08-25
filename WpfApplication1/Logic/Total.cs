using System.Data;
using System.Windows;
using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace WpfApplication1.Logic
{
    public class Total
    {

        public double TotalPo { get; set; }
        public double TotalPaid { get; set; }
        public double recieved { get; set; }
        public double BillsPayable { get; set; }
        public double Outstanding { get; set; }
        public string SchoolName { get; set; }

        public Total(string school)
        {
            SchoolName = school;

        }

        public Total()
        {
        }

        public double Recieved()
        {
            double Value = 0;

            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.Recieved('{SchoolName}')";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Value = reader.GetDouble(0);
                        }
                        connection.Close();

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            recieved = Value;
            return recieved;
        }
        public double Commission()
        {
            double Value = 0;

            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.Commission('{SchoolName}')";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Value = reader.GetDouble(0);
                        }
                        connection.Close();

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            return Value;
        }
        public double StandingOrder()
        {
            double Value = 0;

            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.StandingOrder('{SchoolName}')";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Value = reader.GetDouble(0);
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

            return Value;
        }
        public double TotalStandingOrder()
        {
            double Value = 0;

            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.TotalStandingOrder()";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Value = reader.GetDouble(0);
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

            return Value;
        }
        public double TotalAmount()
        {
            double Value = 0;

            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.TotalPaid('{SchoolName}')";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Value = reader.GetDouble(0);
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

            return Value;
        }

        public double ActualAmount()
        {
            double value = 0;
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.TotalActualAmount()";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            value = reader.GetDouble(0);
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

            return value;
        }
        public double TotalCommission()
        {
            double value = 0;
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.TotalCommission()";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            value = reader.GetDouble(0);
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

            return value;
        }

        public double AmountPaid()
        {
            double value = 0;
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"SELECT dbo.TotalAmountPaid()";
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            value = reader.GetDouble(0);
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

            return value;
        }
        public DataTable ViewTransactions(string schoolname)
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
                        var query = command.CommandText = $"SELECT po.Id AS 'Transaction Id',po.Beneficiary,po.Payee,po.Amount,po.Date,po.Status FROM PaymentOrder po WHERE po.SchoolId=(SELECT s.Id FROM School s WHERE s.SchoolName='{schoolname}') and po.RecievedDate BETWEEN GETDATE()-30 AND GETDATE()";
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