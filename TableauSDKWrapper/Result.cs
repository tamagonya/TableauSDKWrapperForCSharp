namespace TableauSDKWrapper
{
    /// <summary>
    /// Result
    /// </summary>
    public enum Result
    {
        Result_Success = 0,             // Successful function call
        Result_OutOfMemory = 12,        // ENOMEM
        Result_PermissionDenied = 13,   // EACCES
        Result_InvalidFile = 9,         // EBADF
        Result_FileExists = 17,         // EEXIST
        Result_TooManyFiles = 24,       // EMFILE
        Result_FileNotFound = 2,        // ENOENT
        Result_DiskFull = 28,           // ENOSPC
        Result_DirectoryNotEmpty = 41,  // ENOTEMPTY
        Result_NoSuchDatabase = 201,    // Data Engine errors start at 200.
        Result_QueryError = 202,        // 
        Result_NullArgument = 203,      // 
        Result_DataEngineError = 204,   // 
        Result_Cancelled = 205,         // 
        Result_BadIndex = 206,          // 
        Result_ProtocolError = 207,     // 
        Result_NetworkError = 208,      // 
        Result_InternalError = 300,     // 300+: other error codes
        Result_WrongType = 301,         // 
        Result_UsageError = 302,        // 
        Result_InvalidArgument = 303,   // 
        Result_BadHandle = 304,         // 
        Result_CurlError = 400,         // 400+: Server Client error codes
        Result_ServerError = 401,       // 
        Result_NotAuthenticated = 402,  // 
        Result_BadPayload = 403,        // 
        Result_InitError = 404,         // 
        Result_UnknownError = 999,      // 
    }
}
