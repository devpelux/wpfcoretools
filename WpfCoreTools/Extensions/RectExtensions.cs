using System;
using System.Windows;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Rect"/> extensions.
    /// </summary>
    public static class RectExtensions
    {
        /// <summary>
        /// Returns <see langword="true"/> if the <see cref="Rect"/> has one of his parameters setted to <see langword="NaN"/>.
        /// </summary>
        /// <param name='rect'>The <see cref="Rect"/> to check.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Rect"/> has one of his parameters setted to <see langword="NaN"/>,
        /// otherwise <see langword="false"/>.
        /// </returns>        
        public static bool HasNaN(this Rect rect) => double.IsNaN(rect.X) || double.IsNaN(rect.Y) || double.IsNaN(rect.Height) || double.IsNaN(rect.Width);

        /// <summary>
        /// Returns whether or not the <see cref="Rect"/> has an area greater than 0.
        /// This is equal to check if <b>width</b> and <b>height</b> are greater than 0.
        /// </summary>
        /// <param name="rect">The <see cref="Rect"/> to check.</param>
        /// <returns>
        /// <see langword="true"/> if the <see cref="Rect"/> has an area greater than 0
        /// (<b>width</b> and <b>height</b> are greater than 0), otherwise <see langword="false"/>.
        /// </returns>
        public static bool HasArea(this Rect rect) => rect.Width > 0 && rect.Height > 0;

        /// <summary>
        /// Expands or shrinks the rectangle by using the specified <see cref="Thickness"/>.
        /// </summary>
        /// <param name="rect"><see cref="Rect"/> to inflate.</param>
        /// <param name="thickness"><see cref="Thickness"/> to use to expand or shrink the <see cref="Rect"/>.</param>
        /// <returns>
        /// The <see cref="Rect"/> expanded or shrunken in <b>width</b> and <b>height</b> by adding the <see cref="Thickness"/>
        /// <b>top</b> + <b>bottom</b> and <b>left</b> + <b>right</b>, and moved backward from the <b>x</b> by subtracting
        /// the <see cref="Thickness"/> <b>left</b>, and from the <b>y</b> by subtracting the <see cref="Thickness"/> <b>top</b>.
        /// </returns>
        /// <exception cref="InvalidOperationException"/>
        public static void Inflate(this Rect rect, Thickness thickness)
        {
            if (rect.IsEmpty)
            {
                throw new InvalidOperationException("Cannot inflate an empty Rect.");
            }

            double inflatedWidth = thickness.Left + thickness.Right;
            double inflatedHeight = thickness.Top + thickness.Bottom;

            //Checks if the resulting rect has a positive or zero area, then applies the inflation, otherwise the rect will become empty.
            if (rect.Width + inflatedWidth >= 0 && rect.Height + inflatedHeight >= 0)
            {
                rect.Width += inflatedWidth;
                rect.Height += inflatedHeight;
                rect.X = Math.Max(0.0, rect.X - thickness.Left);
                rect.Y = Math.Max(0.0, rect.Y - thickness.Top);
            }
            else
            {
                //Deflate the rect by an infinity width and height to make it empty.
                rect.Inflate(double.NegativeInfinity, double.NegativeInfinity);
            }
        }

        /// <summary>
        /// Returns a new <see cref="Rect"/> instance equal to the original.
        /// </summary>
        /// <param name="rect"><see cref="Rect"/> to clone.</param>
        /// <returns>New <see cref="Rect"/> instance with the same parameters of the original.</returns>
        public static Rect Clone(this Rect rect) => rect.IsEmpty ? Rect.Empty : new Rect(rect.X, rect.Y, rect.Width, rect.Height);
    }
}
