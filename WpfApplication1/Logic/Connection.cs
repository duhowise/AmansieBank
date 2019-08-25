using VistaDB.Provider;

namespace WpfApplication1.Logic
{
    public  class Connection
    {
        public static VistaDBConnection Connexion = new VistaDBConnection(new Connection().ConnectionString);
        public string ConnectionString { get; set; }
        public Connection()
        {
            string bd= @"Data Source='|DataDirectory|Amansie.vdb5'";
            ConnectionString = bd;
        }

   }
}