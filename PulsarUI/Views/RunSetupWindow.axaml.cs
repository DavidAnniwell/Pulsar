using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PulsarUI.Views;

public partial class RunSetupWindow : Window
{
    public RunSetupWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}