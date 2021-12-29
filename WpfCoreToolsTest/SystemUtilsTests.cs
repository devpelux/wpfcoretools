using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace WpfCoreToolsTest
{
    [TestClass]
    public class SystemUtilsTests
    {
        [TestMethod]
        public void GetExecutingDirectory()
        {
            string path = WpfCoreTools.SystemUtils.GetExecutingDirectory().FullName;
            Debug.WriteLine(path);
        }
    }
}
