using System.Windows;

namespace WpfCoreTools
{
    /// <summary>
    /// Provides a set of graphic utilities.
    /// </summary>
    public static class GraphicUtils
    {
        /// <summary>
        /// Gets the current cursor position on display.
        /// </summary>
        /// <returns>Current cursor position on display.</returns>
        public static Point GetCursorPos()
        {
            System.Drawing.Point dpos = CoreTools.GraphicUtils.GetCursorPos();
            return new Point(dpos.X, dpos.Y);
        }
    }
}
