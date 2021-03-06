using System.Windows;

namespace WpfCoreTools.Extensions
{
    /// <summary>
    /// Provides a set of <see cref="DependencyObject"/> extensions.
    /// </summary>
    public static class DependencyObjectExtensions
    {
        /// <summary>
        /// Checks if the <see cref="DependencyProperty"/> is <see langword="null"/>.
        /// </summary>
        /// <param name="dependencyObject"><see cref="DependencyObject"/> that contains the property.</param>
        /// <param name="dependencyProperty"><see cref="DependencyProperty"/> to check if is <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if is <see langword="null"/>, <see langword="false"/> otherwise.</returns>
        public static bool IsNull(this DependencyObject dependencyObject, DependencyProperty dependencyProperty)
            => dependencyObject.GetValue(dependencyProperty) == null;

        /// <summary>
        /// Checks if the <see cref="DependencyProperty"/> is not <see langword="null"/>.
        /// </summary>
        /// <param name="dependencyObject"><see cref="DependencyObject"/> that contains the property.</param>
        /// <param name="dependencyProperty"><see cref="DependencyProperty"/> to check if is not <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if is not <see langword="null"/>, <see langword="false"/> otherwise.</returns>
        public static bool IsNotNull(this DependencyObject dependencyObject, DependencyProperty dependencyProperty)
            => dependencyObject.GetValue(dependencyProperty) != null;
    }
}
