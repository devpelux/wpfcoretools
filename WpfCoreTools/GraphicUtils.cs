using System.Windows;
using WpfCoreTools.Extensions;

namespace WpfCoreTools
{
    /// <summary>
    /// Provides a set of graphic utilities.
    /// </summary>
    public static class GraphicUtils
    {
        /// <summary>
        /// Returns the current cursor position on display.
        /// </summary>
        /// <returns>Current cursor position on display.</returns>
        public static Point GetCursorPos() => CoreTools.GraphicUtils.GetCursorPos().ToWindowsPoint();
    }
}
