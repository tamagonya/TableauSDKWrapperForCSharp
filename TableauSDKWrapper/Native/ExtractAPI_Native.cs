using System;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class ExtractAPINative
    {
        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractAPIInitialize", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Initialize();

        [DllImport("TableauExtract.dll", EntryPoint = "TabExtractAPICleanup", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Cleanup();
    }
}
