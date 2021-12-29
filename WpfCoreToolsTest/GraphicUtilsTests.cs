using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Windows;

namespace WpfCoreToolsTest
{
    [TestClass]
    public class GraphicUtilsTests
    {
        [TestMethod]
        public void GetCursorPos()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
        }
    }
}
