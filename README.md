<!-- icon -->

<p align="center">
  <img width="90px" align="center" src="https://raw.githubusercontent.com/devpelux/wpfcoretools/1.3.0/Assets/Icon.png"></img>
</p>
<h1 align="center">WpfCoreTools</h1>
<p align="center">Lightweight package with some utilities for .NET Core wpf applications.</p>

<!-- badges -->

<p align="center">
  <img src="https://img.shields.io/github/v/release/devpelux/wpfcoretools?sort=semver"></img>
  <img src="https://img.shields.io/nuget/v/wpfcoretools"></img>
  <img src="https://img.shields.io/github/release-date/devpelux/wpfcoretools"></img>
  <img src="https://img.shields.io/nuget/dt/wpfcoretools"></img>
  <img src="https://img.shields.io/github/license/devpelux/wpfcoretools"></img>
</p>
<p align="center">
  <img src="https://img.shields.io/badge/code:release-v1.3.0-blue"></img>
  <img src="https://img.shields.io/badge/code:status-stable-blue"></img>
</p>


<!-- description -->

# Availability
**NUGET:** https://www.nuget.org/packages/WpfCoreTools


# Dependencies
[![net5](https://img.shields.io/badge/.NET-v5.0-blue)](https://docs.microsoft.com/dotnet)
[![net6](https://img.shields.io/badge/.NET-v6.0-blue)](https://docs.microsoft.com/dotnet)
[![coretools](https://img.shields.io/badge/CoreTools-v1.1.1-blue)](https://www.nuget.org/packages/CoreTools)


# Content
Content of the package:


## GraphicUtils
This static class contains the following functions:

#### `Point GetCursorPos()`
*Returns the current cursor position on display.*


## GDIUtils
This static class contains the following functions:

#### `Color GetPixelColor(Point pos, [bool takeScreenshotWhenPossible = false])`
*Returns the color of the pixel at a specified position.*  
Parameters:  
**pos**: Position of the pixel from to get the color.  
**takeScreenshotWhenPossible**: Take a screenshot when possible to get the pixel color (this may be slower and is supported only in Windows).

#### `Color GetPixelColorAtCursorPos([bool takeScreenshotWhenPossible = false])`
*Returns the color of the pixel at the current cursor position on display.*  
Parameters:  
**takeScreenshotWhenPossible**: Take a screenshot when possible to get the pixel color (this may be slower and is supported only in Windows).

#### `BitmapSource? CaptureScreenshot(Point pos, Size size)`
*Captures a screenshot from a specified position, with a specified size (returns `null` if an error occurred).*  
Parameters:  
**pos**: Top-left corner of the screenshot.  
**size**: Size of the screenshot.

#### `BitmapSource? CaptureScreenshotAtCursorPos(Size size, Size offset)`
*Captures a screenshot from the current cursor position on display, with a specified size, and offset (returns `null` if an error occurred).*  
Parameters:  
**size**: Size of the screenshot.  
**offset**: Offset of the screenshot.

#### `BitmapSource? CaptureScreenshotAtCursorPos(Size size)`
*Captures a screenshot from the current cursor position on display, with a specified size (returns `null` if an error occurred).*  
Parameters:  
**size**: Size of the screenshot.


## SystemUtils
This static class contains the following functions:

#### `Window? GetActiveWindow()`
*Returns the current active window (returns `null` if there is no active window).*

#### `FileInfo GetExecutingFile()`
*Returns the current application executing file.*

#### `DirectoryInfo GetExecutingDirectory()`
*Returns the current application executing directory.*


## MathUtils
This static class provides "fuzzy" comparison functionality for doubles and some common double-based classes and structs:

#### `double DOUBLE_EPSILON = 2.2204460492503131e-016`
*The smallest double such that 1.0 + DOUBLE_EPSILON != 1.0.*

#### `bool AreClose(double value1, double value2)`
*Returns whether or not two double are close.*  
Parameters:  
**value1**: The first double to compare.  
**value2**: The first double to compare.

#### `bool LessThan(double value1, double value2)`
*Returns whether or not the first double is less than the second double.*  
Parameters:  
**value1**: The first double to compare.  
**value2**: The first double to compare.

#### `bool GreaterThan(double value1, double value2)`
*Returns whether or not the first double is greater than the second double.*  
Parameters:  
**value1**: The first double to compare.  
**value2**: The first double to compare.

#### `bool LessThanOrClose(double value1, double value2)`
*Returns whether or not the first double is less than or close to the second double.*  
Parameters:  
**value1**: The first double to compare.  
**value2**: The first double to compare.

#### `bool GreaterThanOrClose(double value1, double value2)`
*Returns whether or not the first double is greater than or close to the second double.*  
Parameters:  
**value1**: The first double to compare.  
**value2**: The first double to compare.

#### `bool IsOne(double value)`
*Returns whether or not the double is close to 1.*  
Parameters:  
**value**: The double to compare to 1.

#### `bool IsZero(double value)`
*Returns whether or not the double is close to 0.*  
Parameters:  
**value**: The double to compare to 0.

#### `bool IsBetweenZeroAndOne(double value)`
*Returns whether or not the double is between 0 and 1.*  
Parameters:  
**value**: The double to check.

#### `bool AreClose(Point point1, Point point2)`
*Compares two Point for fuzzy equality.*  
Parameters:  
**point1**: The first Point to compare.  
**point2**: The second Point to compare.

#### `bool AreClose(Size size1, Size size2)`
*Compares two Size for fuzzy equality.*  
Parameters:  
**size1**: The first Size to compare.  
**size2**: The second Size to compare.

#### `bool AreClose(Vector vector1, Vector vector2)`
*Compares two Vector for fuzzy equality.*  
Parameters:  
**vector1**: The first Vector to compare.  
**vector2**: The second Vector to compare.

#### `bool AreClose(Rect rect1, Rect rect2)`
*Compares two Rect for fuzzy equality.*  
Parameters:  
**rect1**: The first Rect to compare.  
**rect2**: The second Rect to compare.


## BoolValues
This class provides boxed values for bool values, and some functions to box and unbox bool values:

#### `object True = true`
*Boxed value for true.*

#### `object False = false`
*Boxed value for false.*

#### `object Box(bool value)`
*Boxes a bool value.*  
Parameters:  
**value**: Value to box.

#### `bool Unbox(object value)`
*Unboxes a bool value.*  
Parameters:  
**value**: Value to unbox.


## IDialog
This interface defines an object that can return a result, and contains the following functions:

#### `object? GetResult()`
*Gets the result as object.*


## DialogWindow
This class is a decorator that incapsulates a Window to be displayed as dialog and, in the end, return an object as result.

#### `DialogWindow(Window window)`
*Initializes a new instance of DialogWindow.*  
Parameters:  
**window**: The Window to handle.

#### `object? Show()`
*Displays the dialog and, in the end, return an object as result.*


## ClipConverter
This class is a converter that clips elements that are out of a control, and contains the following functions:

#### `public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)`
*Calculates and returns a clip with the specified parameters.*  
Parameters:  
**values**: Array containing some properties of the control to clip. (Width, Height, CornerRadius, BorderThickness)  
**targetType**: Unused.  
**parameter**: Unused.  
**culture**: Unused.

#### `object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)`
*Unsupported.*


## BitmapSourceExtensions
This static class provides a set of BitmapSource extensions:

#### `Bitmap? ToBitmap()`
*Converts the BitmapSource to a Bitmap.*

#### `BitmapSource? ToBitmapSource()`
*Converts the Bitmap to a BitmapSource.*


## ColorExtensions
This static class provides a set of Color extensions:

#### `Color Invert()`
*Inverts the color by subtracting every value R, G, B from 255.*

#### `System.Windows.Media.Color ToMediaColor()`
*Converts the System.Drawing.Color to a System.Windows.Media.Color.*

#### `System.Drawing.Color ToDrawingColor()`
*Converts the System.Windows.Media.Color to a System.Drawing.Color.*


## DependencyObjectExtensions
This static class provides a set of DependencyObject extensions:

#### `bool IsNull(DependencyProperty dependencyProperty)`
*Checks if the DependencyProperty is null.*  
Parameters:  
**dependencyProperty**: DependencyProperty to check if is null.

#### `bool IsNotNull(DependencyProperty dependencyProperty)`
*Checks if the DependencyProperty is not null.*  
Parameters:  
**dependencyProperty**: DependencyProperty to check if is not null.


## StoryboardExtensions
This static class provides a set of Storyboard extensions:

#### `Task BeginAsync()`
*Applies the animations associated with this Storyboard to their targets and initiates them asyncronously.*


## PointExtensions
This static class provides a set of Point extensions:

#### `System.Windows.Point ToWindowsPoint()`
*Converts the System.Drawing.Point to a System.Windows.Point.*

#### `System.Drawing.Point ToDrawingPoint()`
*Converts the System.Windows.Point to a System.Drawing.Point.*


## SizeExtensions
This static class provides a set of Size extensions:

#### `Size Add(Size b)`
*Sums a Size to the current Size.*  
Parameters:  
**b**: Size to sum to the current.

#### `Size Subtract(Size b)`
*Subtracts a Size from the current Size.*  
Parameters:  
**b**: Size to subtract from the current.

#### `System.Windows.Size ToWindowsSize()`
*Converts the System.Drawing.Size to a System.Windows.Size.*

#### `System.Drawing.Size ToDrawingSize()`
*Converts the System.Windows.Size to a System.Drawing.Size.*

#### `Size UniformSize(double dim)`
*Initializes a new Size with uniform dimensions.*  
Parameters:  
**dim**: Dimensions.


## ThicknessExtensions
This static class provides a set of Thickness extensions:

#### `Thickness Add(Thickness b)`
*Sums a Thickness to the current Thickness.*  
Parameters:  
**b**: Thickness to sum to the current.

#### `Thickness Subtract(Thickness b)`
*Subtracts a Thickness from the current Thickness.*  
Parameters:  
**b**: Thickness to subtract from the current.

#### `Thickness Invert()`
*Inverts the Thickness by replacing every value with its negative.*

#### `Size Collapse()`
*Collapses the Thickness into a Size.*


## RectExtensions
This static class provides a set of Rect extensions:

#### `bool HasNaN()`
*Returns true if the Rect has one of his parameters setted to NaN.*

#### `bool HasArea()`
*Returns whether or not the Rect has an area greater than 0.*  
*This is equal to check if width and height are greater than 0.*

#### `Rect Inflate(Thickness thickness)`
*Expands or shrinks the rectangle by using the specified Thickness.*  
Parameters:  
**b**: Thickness to use to expand or shrink the Rect.

#### `Rect Clone()`
*Returns a new Rect instance equal to the original.*


<!-- license -->

# License
Copyright (C) 2021-2022 devpelux (Salvatore Peluso)  
Licensed under MIT license.

[![mit](https://raw.githubusercontent.com/devpelux/wpfcoretools/1.3.0/Assets/Mit.png)](https://github.com/devpelux/wpfcoretools/blob/1.3.0/LICENSE)
