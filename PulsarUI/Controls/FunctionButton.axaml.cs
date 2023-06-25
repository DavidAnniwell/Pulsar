using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace PulsarUI;

public class FunctionButton : TemplatedControl
{
    public static readonly StyledProperty<string> FBKeyProperty = AvaloniaProperty.Register<SensorLabel, string>(
        "FBKey");
    
    public static readonly StyledProperty<string> FBLabelProperty = AvaloniaProperty.Register<SensorLabel, string>(
        "FBLabel");
    
    public string FBKey
    {
        get => GetValue(FBKeyProperty);
        set => SetValue(FBKeyProperty, value);
    }
    
    public string FBLabel
    {
        get => GetValue(FBLabelProperty);
        set => SetValue(FBLabelProperty, value);
    }
}