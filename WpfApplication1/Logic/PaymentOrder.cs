using System.Data;
using VistaDB.Diagnostic;
using VistaDB.Provider;
using MessageBox = System.Windows.MessageBox;

namespace WpfApplication1.Logic
{
    public class PaymentOrder
    {
        public int Id { get; set; }
        public string PoNumber { get; set; }
        public string Beneficiary { get; set; }
        public string Payee { get; set; }
        public string Phone { get; set; }
        public double Amount { get; set; }
        public double Interest { get; set; }
        public int SchoolId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }

        public PaymentOrder(string poNumber, string beneficiary, string payee, string phone, double amount, double interest, int schoolId, int userId, string status)
        {
            PoNumber = poNumber;
            Beneficiary = beneficiary;
            Payee = payee;
            Phone = phone;
            Amount = amount;
            Interest = interest;
            SchoolId = schoolId;
            UserId = userId;
            Status = status;
        }

        public PaymentOrder(int id, string poNumber, string beneficiary, string payee, string phone, double amount, double interest, int schoolId, int userId, string status)
        {
            Id = id;
            PoNumber = poNumber;
            Beneficiary = beneficiary;
            Payee = payee;
            Phone = phone;
            Amount = amount;
            Interest = interest;
            SchoolId = schoolId;
            UserId = userId;
            Status = status;
        }

        public PaymentOrder()
        {
            
        }

        public void Save(PaymentOrder paymentOrder)
        {
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO dbo.PaymentOrder(PoNumber,Beneficiary,Payee,Phone,Amount,Interest,SchoolId,UserId)VALUES('{paymentOrder.PoNumber}','{paymentOrder.Beneficiary}','{paymentOrder.Payee}','{paymentOrder.Phone}',{paymentOrder.Amount},{paymentOrder.Interest},{SchoolId},{UserId})";
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(@"successfully Saved Payment");

                    }
                }
                catch (VistaDBException exception)
                {
                    MessageBox.Show("Something went wrong");
                    Log.Error(exception);
                }
            }
        }

        public DataTable ViewPending()
        {
            var data =new DataTable();
            using (VistaDBConnection connection = new VistaDBConnection(new Connection().ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (VistaDBCommand command = new VistaDBCommand())
                    {
                        command.Connection = connection;
                     var query=   command.CommandText = $"SELECT Id,PoNumber,Beneficiary,Amount,(SELECT SchoolName FROM  School s WHERE s.Id=p.SchoolId) AS 'School' FROM dbo.PaymentOrder p where status='Pending'";
                        var adapter=new VistaDBDataAdapter(command.CommandText,command.Connection);
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
        public DataTable ViewPending(string search)
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
                        var query = command.CommandText = $"SELECT Id,PoNumber,Beneficiary,Amount,(SELECT SchoolName FROM  School s WHERE s.Id=p.SchoolId) AS 'School' FROM dbo.PaymentOrder p where status='Pending' and PoNumber LIKE '%{search}%'";
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
        public DataTable Viewpending(string search)
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
                        var query = command.CommandText = $"SELECT Id,PoNumber,Beneficiary,Amount,(SELECT SchoolName FROM  School s WHERE s.Id=p.SchoolId) AS 'School' FROM dbo.PaymentOrder p where status='Pending' AND p.SchoolId=(SELECT id FROM dbo.School s WHERE s.SchoolName='{search}')";
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