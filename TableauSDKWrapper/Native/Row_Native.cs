using System;
using System.Text;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class RowNative
    {
        [DllImport("TableauExtract.dll", EntryPoint = "TabRowCreate", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Create([Out] out IntPtr handle, IntPtr tableDefinition);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowClose", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Close(IntPtr handle);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetNull", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetNull(IntPtr Row, Int32 columnNumber);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetInteger", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetInteger(IntPtr Row, Int32 columnNumber, Int32 value);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetLongInteger", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetLongInteger(IntPtr Row, Int32 columnNumber, Int64 value);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetDouble", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetDouble(IntPtr Row, Int32 columnNumber, Double value);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetBoolean", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetBoolean(IntPtr Row, Int32 columnNumber, Int32 value);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetString", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetString(IntPtr Row, Int32 columnNumber, [MarshalAs(UnmanagedType.LPWStr)] String value);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetCharString", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Int32 SetCharString(IntPtr Row, Int32 columnNumber, StringBuilder value);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetDate", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetDate(IntPtr Row, Int32 columnNumber, Int32 year, Int32 month, Int32 day);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetDateTime", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetDateTime(IntPtr Row, Int32 columnNumber, Int32 year, Int32 month, Int32 day, Int32 hour, Int32 min, Int32 sec, Int32 frac);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetDuration", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetDuration(IntPtr Row, Int32 columnNumber, Int32 day, Int32 hour, Int32 minute, Int32 second, Int32 frac);

        [DllImport("TableauExtract.dll", EntryPoint = "TabRowSetSpatial", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern Int32 SetSpatial(IntPtr Row, Int32 columnNumber, StringBuilder value);
    }
}
