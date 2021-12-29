using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using WpfCoreTools.Core;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="BitmapSource"/> extensions.
    /// </summary>
    public static class BitmapSourceExtensions
    {
        /// <summary>
        /// Converts the <see cref="BitmapSource"/> to a <see cref="Bitmap"/>.
        /// </summary>
        /// <param name="bitmapSource"><see cref="BitmapSource"/> to convert.</param>
        /// <returns>A <see cref="Bitmap"/>, or <see langword="null"/> if an error occurred.</returns>
        public static Bitmap? ToBitmap(this BitmapSource bitmapSource)
        {
            try
            {
                using MemoryStream stream = new();

                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapSource));
                enc.Save(stream);

                using Bitmap tempBitmap = new(stream);

                return new Bitmap(tempBitmap);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the <see cref="Bitmap"/> to a <see cref="BitmapSource"/>.
        /// </summary>
        /// <param name="bitmap"><see cref="Bitmap"/> to convert.</param>
        /// <returns>A <see cref="BitmapSource"/>, or <see langword="null"/> if an error occurred.</returns>
        public static BitmapSource? ToBitmapSource(this Bitmap bitmap)
        {
            IntPtr hBitmap = bitmap.GetHbitmap();

            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(hBitmap, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _ = NativeMethods.DeleteObject(hBitmap);
            }
        }
    }
}
