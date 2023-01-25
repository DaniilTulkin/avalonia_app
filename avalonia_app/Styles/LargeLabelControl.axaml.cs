using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace avalonia_app
{
    public class LargeLabelControl : TemplatedControl
    {
        public static readonly StyledProperty<string> LargeTextProperty = AvaloniaProperty.Register<LargeLabelControl, string>(nameof(LargeText), "LargeText");
        public string LargeText
        {
            get => GetValue(LargeTextProperty);
            set => SetValue(LargeTextProperty, value);
        }

        public static readonly StyledProperty<string> SmallTextProperty = AvaloniaProperty.Register<LargeLabelControl, string>(nameof(SmallText), "SmallText");
        public string SmallText
        {
            get => GetValue(SmallTextProperty);
            set => SetValue(SmallTextProperty, value);
        }
    }
}
