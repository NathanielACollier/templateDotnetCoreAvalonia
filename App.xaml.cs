using Avalonia;
using Avalonia.Markup.Xaml;

namespace templateDotnetCoreAvalonia
{
    class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}