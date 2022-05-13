using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media.Imaging;

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

        [TestMethod]
        public void LoadBitmapImageFromUri()
        {
            _ = Application.Current;
            BitmapImage image = WpfCoreTools.GraphicUtils.LoadBitmapImageFromUri("pack://application:,,,/WpfCoreToolsTest;component/Resources/testcolors.png");
            Debug.WriteLine(image);
        }
    }
}
