using System.Windows;
using System.Windows.Media.Imaging;
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

        /// <summary>
        /// Loads a <see cref="BitmapImage"/> from the specified uri <see cref="string"/>.
        /// </summary>
        /// <param name="uri">Uri <see cref="string"/> of the image to load.</param>
        /// <returns><see cref="BitmapImage"/>.</returns>
        public static BitmapImage LoadBitmapImageFromUri(string uri)
        {
            BitmapImage image = new();
            image.BeginInit();
            image.UriSource = new(uri);
            image.EndInit();
            return image;
        }
    }
}
