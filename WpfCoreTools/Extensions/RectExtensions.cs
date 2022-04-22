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
        public static bool HasArea(this Rect rect) => !MathUtils.IsZero(rect.Width) && !MathUtils.IsZero(rect.Height);

        /// <summary>
        /// Deflates the <see cref="Rect"/> by subtracting a <see cref="Thickness"/>.
        /// </summary>
        /// <param name="rect"><see cref="Rect"/> to deflate.</param>
        /// <param name="thickness"><see cref="Thickness"/> to subtract from the <see cref="Rect"/>.</param>
        /// <returns>
        /// The <see cref="Rect"/> shrunken in <b>width</b> and <b>height</b> by removing the <see cref="Thickness"/>
        /// <b>top + bottom</b> and <b>left + right</b>, and moved forward from the <b>x</b> by adding
        /// the <see cref="Thickness"/> <b>left</b>, and from the <b>y</b> by adding the <see cref="Thickness"/> <b>top</b>.
        /// </returns>
        public static Rect Deflate(this Rect rect, Thickness thickness)
            => new(rect.Left + thickness.Left, rect.Top + thickness.Top,
                   Math.Max(0.0, rect.Width - thickness.Left - thickness.Right), Math.Max(0.0, rect.Height - thickness.Top - thickness.Bottom));

        /// <summary>
        /// Inflates the <see cref="Rect"/> by adding a <see cref="Thickness"/>.
        /// </summary>
        /// <param name="rect"><see cref="Rect"/> to inflate.</param>
        /// <param name="thickness"><see cref="Thickness"/> to add to the <see cref="Rect"/>.</param>
        /// <returns>
        /// The <see cref="Rect"/> expanded in <b>width</b> and <b>height</b> by adding the <see cref="Thickness"/>
        /// <b>top + bottom</b> and <b>left + right</b>, and moved backward from the <b>x</b> by subtracting
        /// the <see cref="Thickness"/> <b>left</b>, and from the <b>y</b> by subtracting the <see cref="Thickness"/> <b>top</b>.
        /// </returns>
        public static Rect Inflate(this Rect rect, Thickness thickness)
            => new(Math.Max(0.0, rect.Left - thickness.Left), Math.Max(0.0, rect.Top - thickness.Top),
                   rect.Width + thickness.Left + thickness.Right, rect.Height + thickness.Top + thickness.Bottom);
    }
}
