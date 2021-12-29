using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Runtime.Versioning;
using System.Windows.Media.Imaging;

namespace WpfCoreToolsTest
{
    [TestClass]
    public class GDIUtilsTests
    {
        [TestMethod]
        public void GetPixelColorAtCursorPosR()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = WpfCoreTools.GDIUtils.GetPixelColorAtCursorPos();
            Color testColor = Color.FromRgb(255, 0, 0); //FFFF0000
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(testColor, color);
        }

        [TestMethod]
        public void GetPixelColorAtCursorPosG()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = WpfCoreTools.GDIUtils.GetPixelColorAtCursorPos();
            Color testColor = Color.FromRgb(0, 255, 0); //FF00FF00
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(testColor, color);
        }

        [TestMethod]
        public void GetPixelColorAtCursorPosB()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = WpfCoreTools.GDIUtils.GetPixelColorAtCursorPos();
            Color testColor = Color.FromRgb(0, 0, 255); //FF0000FF
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(testColor, color);
        }

        [TestMethod]
        [SupportedOSPlatform("windows7.0")]
        public void GetPixelColorAtCursorPosR2()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = WpfCoreTools.GDIUtils.GetPixelColorAtCursorPos(true);
            Color testColor = Color.FromRgb(255, 0, 0); //FFFF0000
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(testColor, color);
        }

        [TestMethod]
        [SupportedOSPlatform("windows7.0")]
        public void GetPixelColorAtCursorPosG2()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = WpfCoreTools.GDIUtils.GetPixelColorAtCursorPos(true);
            Color testColor = Color.FromRgb(0, 255, 0); //FF00FF00
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(testColor, color);
        }

        [TestMethod]
        [SupportedOSPlatform("windows7.0")]
        public void GetPixelColorAtCursorPosB2()
        {
            Point pos = WpfCoreTools.GraphicUtils.GetCursorPos();
            Debug.WriteLine(pos);
            Color color = WpfCoreTools.GDIUtils.GetPixelColorAtCursorPos(true);
            Color testColor = Color.FromRgb(0, 0, 255); //FF0000FF
            Debug.WriteLine("Color getted: " + color);
            Debug.WriteLine("Test color: " + testColor);
            Assert.AreEqual(testColor, color);
        }

        [TestMethod]
        [SupportedOSPlatform("windows7.0")]
        public void CaptureScreenshotAtCursorPos()
        {
            BitmapSource? bitmap = WpfCoreTools.GDIUtils.CaptureScreenshotAtCursorPos(new Size(2, 8));
            if (bitmap == null) Assert.Fail();
            //else
            //{
            //    System.Drawing.Bitmap? bmp = bitmap.ToBitmap();
            //    if (bmp != null)
            //    {
            //        for (int i = 0; i < bmp.Width; i++)
            //        {
            //            for (int j = 0; j < bmp.Height; j++)
            //            {
            //                Debug.WriteLine($"Color ({i},{j}): " + bmp.GetPixel(i, j));
            //            }
            //        }
            //    }
            //}
        }

        [TestMethod]
        [SupportedOSPlatform("windows7.0")]
        public void CaptureScreenshotAtCursorPosWithOffset()
        {
            BitmapSource? bitmap = WpfCoreTools.GDIUtils.CaptureScreenshotAtCursorPos(new Size(2, 8), new Size(10, 0));
            if (bitmap == null) Assert.Fail();
            //else
            //{
            //    System.Drawing.Bitmap? bmp = bitmap.ToBitmap();
            //    if (bmp != null)
            //    {
            //        for (int i = 0; i < bmp.Width; i++)
            //        {
            //            for (int j = 0; j < bmp.Height; j++)
            //            {
            //                Debug.WriteLine($"Color ({i},{j}): " + bmp.GetPixel(i, j));
            //            }
            //        }
            //    }
            //}
        }
    }
}
