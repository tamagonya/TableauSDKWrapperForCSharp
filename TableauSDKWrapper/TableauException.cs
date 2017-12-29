using System;

namespace TableauSDKWrapper
{
    /// <summary>
    /// Tableau Exception Class
    /// </summary>
    public class TableauException : Exception
    {
        private readonly Result m_result;
        private readonly String m_message;

        public TableauException(Result r, String m)
        {
            m_result = r;
            m_message = m;
        }

        public Result GetResultCode()
        {
            return m_result;
        }

        public string GetMessage()
        {
            return m_message;
        }
    }
}
