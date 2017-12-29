using System;

namespace TableauSDKWrapper.Extract
{
    /// <summary>
    /// Extract API Class
    /// Provides management functions for the Extract API.
    /// </summary>
    public class ExtractAPI : IDisposable
    {
        /// <summary>
        /// Initializes the Extract API. 
        /// Calling this method is optional. 
        /// The call initializes logging in the TableauSDKExtract.log file.
        /// </summary>
        public ExtractAPI()
        {
            Int32 result = ExtractAPINative.Initialize();
            Util.CheckResult(result);
        }
        ~ExtractAPI()
        {
            Cleanup();
        }
        public void Dispose()
        {
            Cleanup();
        }

        /// <summary>
        /// Shuts down the Extract API. 
        /// This call is required only if you previously called the Initialize method.
        /// Note: This method is called from ~ExtractAPI() and Dispose().
        /// </summary>
        public void Cleanup()
        {
            ExtractAPINative.Cleanup();
        }
    }
}
