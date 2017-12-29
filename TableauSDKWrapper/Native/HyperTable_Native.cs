using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

namespace TableauSDKWrapper
{
    internal static class HyperTableNative
    {
        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableInsert", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Insert(IntPtr Table, IntPtr row);

        [DllImport("TableauHyperExtract.dll", EntryPoint = "TabTableGetTableDefinition", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 GetTableDefinition(IntPtr Table, [Out] out IntPtr retval);
    }
}
