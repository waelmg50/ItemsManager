using System;
using System.Data.SqlClient;
using System.Data;

namespace Utilities
{
    /// <summary>
    /// Connect and disconnect the application with the database.
    /// </summary>
    public class DBConnection
    {

        #region Private Members

        private static SqlConnection cnn = new SqlConnection();
        static string strConnectionString = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the connection object of the application to the database.
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                return cnn;
            }
        }
        /// <summary>
        /// Gets and sets the connection string of the database.
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return strConnectionString;
            }
            set
            {
                ConfigurationManager.ConnectionString = strConnectionString = value;
            }
        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Connects to the database of the application.
        /// </summary>
        /// <returns>Returns true if the application successfully connected to the database otherwise 
        /// it returns false.</returns>
        public static bool Connect()
        {
            try
            {
                if (cnn.State == ConnectionState.Open) return true;
                return Connect(ConfigurationManager.ServerName, ConfigurationManager.DataBaseName, ConfigurationManager.Username, ConfigurationManager.Password, ConfigurationManager.IntegratedSecurity);
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Connects to the database of the application.
        /// </summary>
        /// <param name="ServerName">The server that holds the application databse.</param>
        /// <param name="DatabaseName">The name of the application databse.</param>
        /// <param name="Username">The user name that connects to the application databse.</param>
        /// <param name="Password">The password of the user that connects to the application databse.</param>
        /// <param name="IntegratedSecurity">Use integrated security to connect to the database server without user name or password.</param>
        /// <returns>Returns true if the application successfully connected to the database otherwise 
        /// it returns false.</returns>
        public static bool Connect(string ServerName, string DatabaseName, string Username, string Password, bool IntegratedSecurity)
        {
            if (ServerName == "0" && DatabaseName == "0" && Username == "0" && Password == "0" && !IntegratedSecurity)
                return false;
            if (cnn.State == ConnectionState.Open)
                return true;
            if (string.IsNullOrWhiteSpace(ServerName) || string.IsNullOrWhiteSpace(DatabaseName) || ((string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password)) && !IntegratedSecurity))
                return false;
            if (IntegratedSecurity)
                strConnectionString = "data source=" + ServerName + ";Integrated Security=True;initial catalog=" + DatabaseName;
            else
                strConnectionString = "data source=" + ServerName + ";user id= " + Username + ";pwd  = " + Password + ";persist security info=true;initial catalog=" + DatabaseName;
            cnn.ConnectionString = strConnectionString;
            try
            {
                cnn.Open();
                if (ConfigurationManager.ServerName != ServerName)
                    ConfigurationManager.ServerName = ServerName;
                if (ConfigurationManager.DataBaseName != DatabaseName)
                    ConfigurationManager.DataBaseName = DatabaseName;
                if (ConfigurationManager.Username != Username)
                    ConfigurationManager.Username = Username;
                if (ConfigurationManager.Password != Password)
                    ConfigurationManager.Password = Password;
                if (ConfigurationManager.IntegratedSecurity != IntegratedSecurity)
                    ConfigurationManager.IntegratedSecurity = IntegratedSecurity;
                return true;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return false;
            }
            finally
            {
                if (cnn.State != ConnectionState.Open)
                    strConnectionString = string.Empty;
            }
        }
        /// <summary>
        /// Disconnects the connection from the database server.
        /// </summary>
        /// <returns>Returns true if the connection is disconnected successfully other wise it returns false.</returns>
        public static bool Disconnect()
        {
            try
            {
                if (cnn.State != ConnectionState.Closed) cnn.Close();
                return true;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return false;
            }
        }

        #endregion

    }
}