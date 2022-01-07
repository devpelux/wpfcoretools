namespace WpfCoreTools
{
    /// <summary>
    /// Provides boxed values for <see cref="bool"/> values.
    /// </summary>
    public static class BoolValues
    {
        /// <summary>
        /// Boxed value for <see langword="true"/>.
        /// </summary>
        public static readonly object True = true;

        /// <summary>
        /// Boxed value for <see langword="false"/>.
        /// </summary>
        public static readonly object False = false;


        /// <summary>
        /// Boxes a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">Value to box.</param>
        public static object Box(bool value) => value ? True : False;

        /// <summary>
        /// Unboxes a <see cref="bool"/> value.
        /// </summary>
        /// <param name="value">Value to unbox.</param>
        public static bool Unbox(object value) => (bool)value;
    }
}
