using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace PulsarUI;

public class TitleBar : TemplatedControl
{
    public static readonly StyledProperty<string> TBLeftProperty = AvaloniaProperty.Register<SensorLabel, string>(
        "TBLeft");
    
    public static readonly StyledProperty<string> TBCategoryProperty = AvaloniaProperty.Register<SensorLabel, string>(
        "TBCategory");
    
    public static readonly StyledProperty<string> TBRoundProperty = AvaloniaProperty.Register<SensorLabel, string>(
        "TBRound");
    
    public string TBLeft
    {
        get => GetValue(TBLeftProperty);
        set => SetValue(TBLeftProperty, value);
    }
    
    public string TBCategory
    {
        get => GetValue(TBCategoryProperty);
        set => SetValue(TBCategoryProperty, value);
    }
    
    public string TBRound
    {
        get => GetValue(TBRoundProperty);
        set => SetValue(TBRoundProperty, value);
    }
}