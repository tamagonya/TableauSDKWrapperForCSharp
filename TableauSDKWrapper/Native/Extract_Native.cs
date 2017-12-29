using System;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class ExtractNative
    {
        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractCreate", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Create([Out] out IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)] String path);

        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractClose", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Close(IntPtr handle);

        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractAddTable", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 AddTable(IntPtr Extract, [MarshalAs(UnmanagedType.LPWStr)] String name, IntPtr tableDefinition, [Out] out IntPtr retval);

        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractOpenTable", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 OpenTable(IntPtr Extract, [MarshalAs(UnmanagedType.LPWStr)] String name, [Out] out IntPtr retval);

        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractHasTable", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 HasTable(IntPtr Extract, [MarshalAs(UnmanagedType.LPWStr)] String name, [Out] out Int32 retval);
    }
}
