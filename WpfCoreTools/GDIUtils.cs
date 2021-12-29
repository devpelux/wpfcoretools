using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfCoreTools.Extensions;

namespace WpfCoreTools
{
    /// <summary>
    /// Provides a set of utilities for handling some gdi operations.
    /// </summary>
    public static class GDIUtils
    {
        /// <summary>
        /// Returns the color of the pixel at a specified position.
        /// </summary>
        /// <param name="pos">Position of the pixel from to get the color.</param>
        /// <param name="takeScreenshotWhenPossible">Take a screenshot when possible to get the pixel color
        /// (this may be slower and is supported only in Windows).</param>
        /// <returns>Color of the pixel at the specified position.</returns>
        public static Color GetPixelColor(Point pos, bool takeScreenshotWhenPossible = false)
            => CoreTools.GDIUtils.GetPixelColor(pos.ToDrawingPoint(), takeScreenshotWhenPossible).ToMediaColor();

        /// <summary>
        /// Returns the color of the pixel at the current cursor position on display.
        /// </summary>
        /// <param name="takeScreenshotWhenPossible">Take a screenshot when possible to get the pixel color
        /// (this may be slower and is supported only in Windows).</param>
        /// <returns>Color of the pixel at the current cursor position on display.</returns>
        public static Color GetPixelColorAtCursorPos(bool takeScreenshotWhenPossible = false)
            => CoreTools.GDIUtils.GetPixelColorAtCursorPos(takeScreenshotWhenPossible).ToMediaColor();

        /// <summary>
        /// Captures a screenshot from a specified position, with a specified size.
        /// </summary>
        /// <param name="pos">Top-left corner of the screenshot.</param>
        /// <param name="size">Size of the screenshot.</param>
        /// <returns>Screenshot as a <see cref="BitmapSource"/>, or <see langword="null"/> if an error occurred.</returns>
        public static BitmapSource? CaptureScreenshot(Point pos, Size size)
            => CoreTools.GDIUtils.CaptureScreenshot(pos.ToDrawingPoint(), size.ToDrawingSize()).ToBitmapSource();

        /// <summary>
        /// Captures a screenshot from the current cursor position on display, with a specified size, and offset.
        /// </summary>
        /// <param name="size">Size of the screenshot.</param>
        /// <param name="offset">Offset of the screenshot.</param>
        /// <returns>Screenshot as a <see cref="BitmapSource"/>, or <see langword="null"/> if an error occurred.</returns>
        public static BitmapSource? CaptureScreenshotAtCursorPos(Size size, Size offset)
            => CoreTools.GDIUtils.CaptureScreenshotAtCursorPos(size.ToDrawingSize(), offset.ToDrawingSize()).ToBitmapSource();

        /// <summary>
        /// Captures a screenshot from the current cursor position on display, with a specified size.
        /// </summary>
        /// <param name="size">Size of the screenshot.</param>
        /// <returns>Screenshot as a <see cref="BitmapSource"/>, or <see langword="null"/> if an error occurred.</returns>
        public static BitmapSource? CaptureScreenshotAtCursorPos(Size size)
            => CoreTools.GDIUtils.CaptureScreenshotAtCursorPos(size.ToDrawingSize()).ToBitmapSource();
    }
}
