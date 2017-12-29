using System;
using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class ServerConnectionNative
    {
        [DllImport("TableauServer.dll", EntryPoint = "TabServerConnectionCreate", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Create([Out] out IntPtr handle);

        [DllImport("TableauServer.dll", EntryPoint = "TabServerConnectionClose", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Close(IntPtr handle);

        [DllImport("TableauServer.dll", EntryPoint = "TabServerConnectionSetProxyCredentials", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 SetProxyCredentials(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)] String username, [MarshalAs(UnmanagedType.LPWStr)] String password);

        [DllImport("TableauServer.dll", EntryPoint = "TabServerConnectionConnect", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Connect(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)] String host, [MarshalAs(UnmanagedType.LPWStr)] String username, [MarshalAs(UnmanagedType.LPWStr)] String password, [MarshalAs(UnmanagedType.LPWStr)] String siteID);

        [DllImport("TableauServer.dll", EntryPoint = "TabServerConnectionPublishExtract", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 PublishExtract(IntPtr handle, [MarshalAs(UnmanagedType.LPWStr)] String path, [MarshalAs(UnmanagedType.LPWStr)] String projectName, [MarshalAs(UnmanagedType.LPWStr)] String datasourceName, Int32 overwrite);

        [DllImport("TableauServer.dll", EntryPoint = "TabServerConnectionDisconnect", PreserveSig = true, SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Disconnect(IntPtr handle);
    }
}
