using System.Windows;
using System.Windows.Controls;

namespace AttachedProperties.SimpleAP;

public class SimpleAttachedProperty : Button
{
    public static readonly DependencyProperty SimpleStringValueProperty = DependencyProperty.RegisterAttached(
        "SimpleStringValue",
        typeof(string),
        typeof(SimpleAttachedProperty),
        new PropertyMetadata(default(string)));

    public static string GetSimpleStringValue(DependencyObject d) 
    {
        return (string) d.GetValue(SimpleStringValueProperty);
    }

    public static void SetSimpleStringValue(DependencyObject d, string bindingStringValue) 
    { 
        d.SetValue(SimpleStringValueProperty, bindingStringValue);
    }
}
