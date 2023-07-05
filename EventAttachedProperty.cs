using System;
using System.Windows;
using System.Windows.Controls;

namespace AttachedProperties.SimpleAP;

public class EventAttachedProperty : Button
{
    public static readonly DependencyProperty SimpleStringProperty = DependencyProperty.RegisterAttached(
        "SimpleString",
        typeof(string),
        typeof(EventAttachedProperty),
        new PropertyMetadata(default(string), new PropertyChangedCallback(OnSimpleStringPropertyValueChanged)));

    public static string GetSimpleString(DependencyObject d) 
    {
        return (string) d.GetValue(SimpleStringProperty);
    }

    public static void SetSimpleString(DependencyObject d, string bindingStringValue) 
    { 
        d.SetValue(SimpleStringProperty, bindingStringValue);
    }

    private static void OnSimpleStringPropertyValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        MessageBox.Show($"Old Value: {e.OldValue}\nNew value: {e.NewValue}");
    }


}
