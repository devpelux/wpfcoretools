using System.Windows;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="Thickness"/> extensions.
    /// </summary>
    public static class ThicknessExtensions
    {
        /// <summary>
        /// Sums a <see cref="Thickness"/> to the current <see cref="Thickness"/>.
        /// </summary>
        /// <param name="a">Current <see cref="Thickness"/>.</param>
        /// <param name="b"><see cref="Thickness"/> to sum to the current.</param>
        /// <returns></returns>
        public static Thickness Add(this Thickness a, Thickness b) => new(a.Left + b.Left, a.Top + b.Top, a.Right + b.Right, a.Bottom + b.Bottom);

        /// <summary>
        /// Subtracts a <see cref="Thickness"/> from the current <see cref="Thickness"/>.
        /// </summary>
        /// <param name="a">Current <see cref="Thickness"/>.</param>
        /// <param name="b"><see cref="Thickness"/> to subtract from the current.</param>
        /// <returns></returns>
        public static Thickness Subtract(this Thickness a, Thickness b) => new(a.Left - b.Left, a.Top - b.Top, a.Right - b.Right, a.Bottom - b.Bottom);

        /// <summary>
        /// Inverts the <see cref="Thickness"/> by replacing every value with its negative.
        /// </summary>
        /// <param name="thickness">Current <see cref="Thickness"/>.</param>
        /// <returns></returns>
        public static Thickness Invert(this Thickness thickness) => new(-thickness.Left, -thickness.Top, -thickness.Right, -thickness.Bottom);

        /// <summary>
        /// Collapses the <see cref="Thickness"/> into a <see cref="Size"/>.
        /// </summary>
        /// <param name="thickness"><see cref="Thickness"/> to collapse.</param>
        /// <returns>
        /// A <see cref="Size"/> whose <b>width</b> is the sum of <b>left and right</b> <see cref="Thickness"/> parameters,
        /// and whose <b>height</b> is the sum of <b>top and bottom</b> <see cref="Thickness"/> parameters.
        /// </returns>
        public static Size Collapse(this Thickness thickness) => new(thickness.Left + thickness.Right, thickness.Top + thickness.Bottom);
    }
}
