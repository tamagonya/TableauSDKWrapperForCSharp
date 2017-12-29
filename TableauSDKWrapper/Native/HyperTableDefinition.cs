using System;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class HyperTableDefinitionNative
    {
        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionCreate", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Create([Out] out IntPtr handle);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionClose", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Close(IntPtr handle);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionGetDefaultCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetDefaultCollation(IntPtr TableDefinition, [Out] out Int32 retval);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionSetDefaultCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetDefaultCollation(IntPtr TableDefinition, Int32 collation);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionAddColumn", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 AddColumn(IntPtr TableDefinition, [MarshalAs(UnmanagedType.LPWStr)] String name, Int32 type);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionAddColumnWithCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 AddColumnWithCollation(IntPtr TableDefinition, [MarshalAs(UnmanagedType.LPWStr)] String name, Int32 type, Int32 collation);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionGetColumnCount", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnCount(IntPtr TableDefinition, [Out] out Int32 retval);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionGetColumnName", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnName(IntPtr TableDefinition, Int32 columnNumber, [Out] out IntPtr retval);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionGetColumnType", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnType(IntPtr TableDefinition, Int32 columnNumber, [Out] out Int32 retval);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableDefinitionGetColumnCollation", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetColumnCollation(IntPtr TableDefinition, Int32 columnNumber, [Out] out Int32 retval);
    }
}
