using Avalonia;
using Avalonia.Markup.Xaml;

namespace MarkupTest
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
