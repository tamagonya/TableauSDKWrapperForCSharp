using System;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class ServerAPINative
    {
        [DllImport("TableauServer.dll", EntryPoint = "TabServerAPIInitialize", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Initialize();

        [DllImport("TableauServer.dll", EntryPoint = "TabServerAPICleanup", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Cleanup();
    }
}
