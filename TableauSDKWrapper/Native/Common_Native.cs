using System.Runtime.InteropServices;

namespace TableauSDKWrapper
{
    internal static class Native
    {
        [DllImport("TableauCommon.dll", EntryPoint = "TabGetLastErrorMessage", PreserveSig = true, ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetLastErrorMessage();
    }
}
