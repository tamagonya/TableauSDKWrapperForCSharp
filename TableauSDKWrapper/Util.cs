using System;
using System.Text;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    /// <summary>
    /// Utility Class
    /// </summary>
    internal static class Util
    {
        public static Int32 ToInt(this object value)
        {
            return Convert.ToInt32(value);
        }
        public static string ToString(this IntPtr value)
        {
            return Marshal.PtrToStringUni(value);
        }
        public static StringBuilder ToStringBuilder(this string value)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(value);
            return sb;
        }
        public static bool ToBoolean(this object value)
        {
            return Convert.ToBoolean(value);
        }
        public static Type ToType(this object value)
        {
            return (Type)value;
        }
        public static Result ToResult(this object value)
        {
            return (Result)value;
        }
        public static Collation ToCollation(this object value)
        {
            return (Collation)value;
        }
        public static void CheckResult(Int32 result)
        {
            if (result != Result.Result_Success.ToInt())
                throw new TableauException(result.ToResult(), Native.GetLastErrorMessage());
        }
    }
}
