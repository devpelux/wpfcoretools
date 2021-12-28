using System.IO;

namespace WpfCoreTools
{
    /// <summary>
    /// Provides a set of system utilities.
    /// </summary>
    public static class SystemUtils
    {
        /// <summary>
        /// Gets the current application executing file.
        /// </summary>
        /// <returns>Current application executing file.</returns>
        public static FileInfo GetExecutingFile() => CoreTools.SystemUtils.GetExecutingFile();

        /// <summary>
        /// Gets the current application executing directory.
        /// </summary>
        /// <returns>Current application executing directory.</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static DirectoryInfo GetExecutingDirectory() => CoreTools.SystemUtils.GetExecutingDirectory();
    }
}
