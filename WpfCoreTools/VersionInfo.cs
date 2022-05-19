namespace WpfCoreTools
{
    /// <summary>
    /// Provides version informations about the <see cref="WpfCoreTools"/> package.
    /// </summary>
    public static class VersionInfo
    {
        /// <summary>
        /// Gets the current <see cref="WpfCoreTools"/> version code.
        /// </summary>
        public static string VersionCode => typeof(VersionInfo).Assembly.GetName().Version?.ToString() ?? string.Empty;
    }
}
