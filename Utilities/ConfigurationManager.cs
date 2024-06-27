using System;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace Utilities
{
	/// <summary>
	/// Gets and sets values of the application configuration file.
	/// </summary>
    public class ConfigurationManager
    {

        #region Private Members

        private static XmlDocument ConfFile = new XmlDocument();
        private static string strServerName;
        private static string strDatabaseName;
        private static string strUsername;
        private static string strPassword;
        private static bool bIntegratedSecurity;
        private static string strLanguage;
        
        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets the name of the databse server that holds the application data.
        /// </summary>
        public static string ServerName
        {
            set
            {
                try
                {
                    XmlWriter(0, value);
                    strServerName = value;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    strServerName = XmlReader(0);
                    return strServerName;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets and sets the name of the databse that holds the application data.
        /// </summary>
        public static string DataBaseName
        {
            set
            {
                try
                {
                    XmlWriter(1, value);
                    strDatabaseName = value;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    strDatabaseName = XmlReader(1);
                    return strDatabaseName;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets and sets the username of the SQL database server.
        /// </summary>
        public static string Username
        {
            set
            {
                try
                {
                    XmlWriter(2, value);
                    strUsername = value;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    strUsername = XmlReader(2);
                    return strUsername;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets and sets the password of the SQL database server.
        /// </summary>
        public static string Password
        {
            set
            {
                try
                {
                    XmlWriter(3, value);
                    strPassword = value;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    strPassword = XmlReader(3);
                    return strPassword;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets and sets the Language of the Application.
        /// </summary>
        public static bool IntegratedSecurity
        {
            set
            {
                try
                {
                    string strValue = value.ToString();
                    XmlWriter(4, strValue);
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    string strValue = XmlReader(4);
                    bool.TryParse(strValue, out bIntegratedSecurity);
                    return bIntegratedSecurity;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return false;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return false;
                }
            }
        }
        /// <summary>
        /// Gets and sets the Language of the Application.
        /// </summary>
        public static string Language
        {
            set
            {
                try
                {
                    XmlWriter(5, value);
                    strLanguage = value;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    strLanguage = XmlReader(5);
                    return strLanguage;
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// Gets and sets the connection string of the table adapters in the dataset
        /// </summary>
        public static string ConnectionString
        {
            set
            {
                try
                {
                    XmlWriter(-1, value);
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                }
            }
            get
            {
                try
                {
                    return XmlReader(-1);
                }
                catch (ConfigurationException e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
                catch (Exception e)
                {
                    ErrorHandler.LogError(e);
                    return string.Empty;
                }
            }
        }
        
        #endregion

        #region Private Functions

        /// <summary>
        /// Writes the supplied value in the spplied node index in the configuration file.
        /// </summary>
        /// <param name="node">The index of the node.</param>
        /// <param name="Value">The new value of the node.</param>
        /// <returns>Returns false if error occured otherwise it returns true.</returns>
        private static bool XmlWriter(int node, string Value)
        {
            try
            {
                if (Application.ExecutablePath.Length > 0 && System.IO.File.Exists(Application.ExecutablePath + ".config"))
                {
                    ConfFile.Load(Application.ExecutablePath + ".config");
                    if (node < 0)
                    {
                        //if (node == -1)
                        ConfFile.ChildNodes.Item(1).ChildNodes.Item(0).ChildNodes.Item(0).Attributes.Item(1).Value = ERFT.Yuio(Value);
                        //else
                        //    ConfFile.ChildNodes.Item(1).ChildNodes.Item(0).ChildNodes.Item(1).Attributes.Item(1).Value = ERFT.Yuio(Value);
                    }
                    else
                        ConfFile.ChildNodes.Item(1).ChildNodes.Item(1).ChildNodes.Item(node).Attributes.Item(1).Value = ERFT.Yuio(Value);
                    ConfFile.Save(Application.ExecutablePath + ".config");
                    return true;
                }
                else return false;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return false;
            }
        }
        /// <summary>
        /// Read the value of the supplied node index of the configuration file.
        /// </summary>
        /// <param name="node">The index of the node.</param>
        /// <returns>Returns the value of the supplied node index.</returns>
        private static string XmlReader(int node)
        {
            try
            {
                if (Application.ExecutablePath != null && Application.ExecutablePath.Length > 0
                    && System.IO.File.Exists(Application.ExecutablePath + ".config"))
                {
                    ConfFile.Load(Application.ExecutablePath + ".config");
                    if (node >= 0)
                    {
                        string strNodeValue = ConfFile.ChildNodes.Item(1).ChildNodes.Item(1).ChildNodes.Item(node).Attributes.Item(1).Value;
                        if (strNodeValue == "0")
                            return "0";
                        return ERFT.Rtgy(strNodeValue);
                    }
                    else
                    {
                        //if (node == -1)
                        string strNodeValue = ConfFile.ChildNodes.Item(1).ChildNodes.Item(0).ChildNodes.Item(0).Attributes.Item(1).Value;
                        if (strNodeValue == "0")
                            return "0";
                        return ERFT.Rtgy(strNodeValue);
                    }
                }
                else return string.Empty;
            }
            catch (Exception e)
            {
                ErrorHandler.LogError(e);
                return string.Empty;
            }
        }

        #endregion

    }
}
