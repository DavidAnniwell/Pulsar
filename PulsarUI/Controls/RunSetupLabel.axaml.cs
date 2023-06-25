using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace PulsarUI;

public class RunSetupLabel : TemplatedControl
{
    public static readonly StyledProperty<string> RSLLeftTreeProperty = AvaloniaProperty.Register<RunSetupLabel, string>(
        "RSLLeftTree");
    
    public static readonly StyledProperty<string> RSLRightTreeProperty = AvaloniaProperty.Register<RunSetupLabel, string>(
        "RSLRightTree");
    
    public static readonly StyledProperty<string> RSLTreeProperty = AvaloniaProperty.Register<RunSetupLabel, string>(
        "RSLTree");
    
    public static readonly StyledProperty<string> RSLStModeProperty = AvaloniaProperty.Register<RunSetupLabel, string>(
        "RSLStMode");
    
    public static readonly StyledProperty<string> RSLFinishProperty = AvaloniaProperty.Register<RunSetupLabel, string>(
        "RSLFinish");
    
    public string RSLLeftTree
    {
        get => GetValue(RSLLeftTreeProperty);
        set => SetValue(RSLLeftTreeProperty, value);
    }
    
    public string RSLRightTree
    {
        get => GetValue(RSLRightTreeProperty);
        set => SetValue(RSLRightTreeProperty, value);
    }
    
    public string RSLTree
    {
        get => GetValue(RSLTreeProperty);
        set => SetValue(RSLTreeProperty, value);
    }
    
    public string RSLStMode
    {
        get => GetValue(RSLStModeProperty);
        set => SetValue(RSLStModeProperty, value);
    }
    
    public string RSLFinish
    {
        get => GetValue(RSLFinishProperty);
        set => SetValue(RSLFinishProperty, value);
    }
}