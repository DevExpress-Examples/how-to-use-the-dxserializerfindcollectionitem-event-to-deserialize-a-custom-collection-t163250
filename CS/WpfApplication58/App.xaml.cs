// Developer Express Code Central Example:
// How to serialize custom properties with a custom type using the CreateContentPropertyValue event
// 
// This example demonstrates how to serialize and deserialize custom properties
// with a custom type. If a custom property is null when the deserialization
// process is invoked, it's necessary to handle the
// DXSerializer.CreateContentPropertyValue event. In the CreateContentPropertyValue
// event handler, create a new instance of a custom type and assign it to the
// XtraCreateContentPropertyValueEventArgs.SomeCustomProperty property.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T159099

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication58
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
