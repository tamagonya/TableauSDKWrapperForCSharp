using System;

namespace TableauSDKWrapper
{
    /// <summary>
    /// ServerAPI Class
    /// Provides management functions for the Server API.
    /// </summary>
    public class ServerAPI : IDisposable
    {
        /// <summary>
        /// Initializes the Server API.
        /// You must initialize the API before you call any methods in the ServerConnection class.
        /// </summary>
        public ServerAPI()
        {
            Int32 result = ServerAPINative.Initialize();
            Util.CheckResult(result);
        }
        ~ServerAPI()
        {
            Cleanup();
        }
        public void Dispose()
        {
            Cleanup();
        }

        /// <summary>
        /// Shuts down the Server API. 
        /// You must call this method after you have finished calling other methods in the Server API.
        /// Note: This method is called from ~ServerAPI() and Dispose().
        /// </summary>
        public void Cleanup()
        {
            ServerAPINative.Cleanup();
        }
    }
}
