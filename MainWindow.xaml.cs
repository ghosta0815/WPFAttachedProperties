using AttachedProperties.SimpleAP;
using System.Windows;

namespace AttachedProperties
{
    public partial class MainWindow : Window
    {
        private MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
        }

        #region Button Clicks
        private void ButtonClickSimpleAP(object sender, RoutedEventArgs e)
        {
            string bindingValue = SimpleAttachedProperty.GetSimpleStringValue(simpleAPButton);
            MessageBox.Show(bindingValue);
        }

        private void bindingAPButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_vm.BindingString);
        }

        private void APChangedButton_Click(object sender, RoutedEventArgs e)
        {
            _vm.BoundStringChangedByEvent = "Value changed by an event";
        }
        #endregion
    }
}
