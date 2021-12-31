namespace WpfCoreTools
{
    /// <summary>
    /// Defines an object that can return a result.
    /// </summary>
    public interface IDialog
    {
        /// <summary>
        /// Gets the result as <see cref="object"/>.
        /// </summary>
        /// <returns>Result as <see cref="object"/>.</returns>
        public object? GetResult();
    }
}
