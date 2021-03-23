using System.Windows;
using System.Windows.Controls;

namespace MyNamespace {
  public class CustomPopup : ContentControl {
    public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register(
        nameof(IsOpen), typeof(bool), typeof(CustomPopup), new FrameworkPropertyMetadata(default(bool), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    public bool IsOpen {
      get => (bool)GetValue(IsOpenProperty);
      set => SetValue(IsOpenProperty, value);
    }

    public static readonly DependencyProperty CustomPopupContentProperty = DependencyProperty.Register(
        nameof(CustomPopupContent), typeof(object), typeof(CustomPopup), new PropertyMetadata(default(object)));

    public object CustomPopupContent {
      get => GetValue(CustomPopupContentProperty);
      set => SetValue(CustomPopupContentProperty, value);
    }
  }
}