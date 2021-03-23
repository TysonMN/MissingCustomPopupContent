using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MyNamespace {
  public partial class MainWindow : Window, INotifyPropertyChanged {

    public MainWindow() {
      DataContext = this;
      InitializeComponent();
    }

    private Visibility customPopupContentVisibility = Visibility.Collapsed;
    public Visibility CustomPopupContentVisibility {
      get => customPopupContentVisibility;
      set {
        customPopupContentVisibility = value;
        OnPropertyChanged();
      }
    }

    private bool isCustomPopupOpen = false;
    public bool IsCustomPopupOpen {
      get => isCustomPopupOpen;
      set {
        isCustomPopupOpen = value;
        CustomPopupContentVisibility = value ? Visibility.Visible : Visibility.Collapsed;
        OnPropertyChanged();
      }
    }

    private void OpenCustomPopup(object _1, RoutedEventArgs _2) => IsCustomPopupOpen = true;
    private void CloseCustomPopup(object _1, RoutedEventArgs _2) => IsCustomPopupOpen = false;

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null) =>
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
  }
}