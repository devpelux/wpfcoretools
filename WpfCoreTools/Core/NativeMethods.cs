using System;
using System.Runtime.InteropServices;

namespace WpfCoreTools.Core
{
    /// <summary>
    /// External native methods.
    /// </summary>
    internal static class NativeMethods
    {
        [DllImport("gdi32")]
        internal static extern int DeleteObject(IntPtr o);
    }
}
