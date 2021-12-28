using System.Resources;
using System.Windows;
using System.Windows.Markup;

[assembly: NeutralResourcesLanguage("en")]

//Namespaces prefix
[assembly: XmlnsPrefix("http://devpelux.github.io/wpfcoretools", "wct")]
[assembly: XmlnsPrefix("http://devpelux.github.io/wpfcoretools/extensions", "wcte")]

//Namespaces
[assembly: XmlnsDefinition("http://devpelux.github.io/wpfcoretools", "WpfCoreTools")]
[assembly: XmlnsDefinition("http://devpelux.github.io/wpfcoretools/extensions", "WpfCoreTools.Extensions")]

//Theme
[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]
