using System;
using System.Windows;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Size"/> extensions.
    /// </summary>
    public static class SizeExtensions
    {
        /// <summary>
        /// Sums a <see cref="Size"/> to the current <see cref="Size"/>.
        /// </summary>
        /// <param name="a">Current <see cref="Size"/>.</param>
        /// <param name="b"><see cref="Size"/> to sum to the current.</param>
        /// <returns>
        /// A new <see cref="Size"/> calculated by adding the specified one's <b>width</b> and <b>height</b>
        /// from the current one's <b>width</b> and <b>height</b>.
        /// </returns>
        public static Size Add(this Size a, Size b) => new(a.Width + b.Width, a.Height + b.Height);

        /// <summary>
        /// Subtracts a <see cref="Size"/> from the current <see cref="Size"/>.
        /// </summary>
        /// <param name="a">Current <see cref="Size"/>.</param>
        /// <param name="b"><see cref="Size"/> to subtract from the current.</param>
        /// <returns>
        /// A new <see cref="Size"/> calculated by subtracting the specified one's <b>width</b> and <b>height</b>
        /// from the current one's <b>width</b> and <b>height</b>.
        /// If a result value is negative, this value will be replaced with 0.
        /// </returns>
        public static Size Subtract(this Size a, Size b) => new(Math.Max(0.0, a.Width - b.Width), Math.Max(0.0, a.Height - b.Height));

        /// <summary>
        /// Converts the <see cref="System.Drawing.Size"/> to a <see cref="Size"/>.
        /// </summary>
        /// <param name="size"><see cref="System.Drawing.Size"/> to convert.</param>
        /// <returns><see cref="Size"/>.</returns>
        public static Size ToWindowsSize(this System.Drawing.Size size)
            => new(size.Width, size.Height);

        /// <summary>
        /// Converts the <see cref="Size"/> to a <see cref="System.Drawing.Size"/>.
        /// </summary>
        /// <param name="size"><see cref="System.Drawing.Size"/> to convert.</param>
        /// <returns><see cref="System.Drawing.Size"/>.</returns>
        public static System.Drawing.Size ToDrawingSize(this Size size)
            => new((int)size.Width, (int)size.Height);

        /// <summary>
        /// Initializes a new <see cref="Size"/> with uniform dimensions.
        /// </summary>
        /// <param name="dim">Dimensions.</param>
        /// <returns>New <see cref="Size"/> with uniform dimensions.</returns>
        public static Size UniformSize(double dim) => new(dim, dim);
    }
}
