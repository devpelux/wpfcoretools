using System.IO;
using System.Linq;
using System.Windows;

namespace WpfCoreTools
{
    /// <summary>
    /// Provides a set of system utilities.
    /// </summary>
    public static class SystemUtils
    {
        /// <summary>
        /// Returns the current active window.
        /// </summary>
        /// <returns>Current active window.</returns>
        public static Window? GetActiveWindow() => Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

        /// <summary>
        /// Returns the current application executing file.
        /// </summary>
        /// <returns>Current application executing file.</returns>
        public static FileInfo GetExecutingFile() => CoreTools.SystemUtils.GetExecutingFile();

        /// <summary>
        /// Returns the current application executing directory.
        /// </summary>
        /// <returns>Current application executing directory.</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static DirectoryInfo GetExecutingDirectory() => CoreTools.SystemUtils.GetExecutingDirectory();
    }
}
