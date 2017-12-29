using System;

namespace TableauSDKWrapper
{
    /// <summary>
    /// ServerConnection Class
    /// Represents a connection to an instance of Tableau Server.
    /// </summary>
    public class ServerConnection : IDisposable
    {
        private IntPtr m_Handle;
        internal IntPtr Handle
        {
            get { return m_Handle; }
        }

        /// <summary>
        /// Initializes a new instance of the ServerConnection class.
        /// </summary>
        public ServerConnection()
        {
            Int32 result = ServerConnectionNative.Create(out m_Handle);
            Util.CheckResult(result);
        }
        ~ServerConnection()
        {
            Close();
        }
        public void Dispose()
        {
            Close();
        }

        /// <summary>
        /// Destroys a server connection object.
        /// </summary>
        public void Close()
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = ServerConnectionNative.Close(m_Handle);
                m_Handle = IntPtr.Zero;
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Sets the username and password for the HTTP proxy.
        /// This method is needed only if the server connection is going through a proxy that requires authentication.
        /// </summary>
        /// <param name="username">The username for the proxy</param>
        /// <param name="password">The password for the proxy</param>
        public void SetProxyCredentials(String username, String password)
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = ServerConnectionNative.SetProxyCredentials(m_Handle, username, password);
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Connects to the specified server and site.
        /// </summary>
        /// <param name="host">The URL of the server to connect to.</param>
        /// <param name="username">The username of the user to sign in as. The user must have permissions to publish to the specified site.</param>
        /// <param name="password">The password of the user to sign in as.</param>
        /// <param name="siteID">The site ID. Pass an empty string to connect to the default site.</param>
        public void Connect(String host, String username, String password, String siteID)
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = ServerConnectionNative.Connect(m_Handle, host, username, password, siteID);
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Publishes a data extract to the server.
        /// </summary>
        /// <param name="path">The path to the ".tde" file to publish.</param>
        /// <param name="projectName">The name of the project to publish the extract to.</param>
        /// <param name="datasourceName">The name of the data source to create on the server.</param>
        /// <param name="overwrite">True to overwrite an existing data source on the server that has the same name; otherwise, false.</param>
        public void PublishExtract(String path, String projectName, String datasourceName, bool overwrite)
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = ServerConnectionNative.PublishExtract(m_Handle, path, projectName, datasourceName, Convert.ToInt32(overwrite));
                Util.CheckResult(result);
            }
        }

        /// <summary>
        /// Disconnects from the server.
        /// </summary>
        /// <param name="path"></param>
        public void Disconnect(String path)
        {
            if (m_Handle != IntPtr.Zero)
            {
                Int32 result = ServerConnectionNative.Disconnect(m_Handle);
                Util.CheckResult(result);
            }
        }
    }
}
