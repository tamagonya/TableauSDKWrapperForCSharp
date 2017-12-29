using System;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class TableDefinitionNative
    {
        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionCreate", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Create([Out] out IntPtr handle);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionClose", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Close(IntPtr handle);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionGetDefaultCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetDefaultCollation(IntPtr TableDefinition, [Out] out Int32 retval);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionSetDefaultCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetDefaultCollation(IntPtr TableDefinition, Int32 collation);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionAddColumn", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 AddColumn(IntPtr TableDefinition, [MarshalAs(UnmanagedType.LPWStr)] String name, Int32 type);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionAddColumnWithCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 AddColumnWithCollation(IntPtr TableDefinition, [MarshalAs(UnmanagedType.LPWStr)] String name, Int32 type, Int32 collation);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionGetColumnCount", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnCount(IntPtr TableDefinition, [Out] out Int32 retval);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionGetColumnName", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnName(IntPtr TableDefinition, Int32 columnNumber, [Out] out IntPtr retval);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionGetColumnType", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnType(IntPtr TableDefinition, Int32 columnNumber, [Out] out Int32 retval);

        [DllImport("TableauExtract.dll", EntryPoint = "TabTableDefinitionGetColumnCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnCollation(IntPtr TableDefinition, Int32 columnNumber, [Out] out Int32 retval);
    }
}
