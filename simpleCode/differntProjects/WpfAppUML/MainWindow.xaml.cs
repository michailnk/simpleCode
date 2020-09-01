using System;
using System.Windows;

namespace WpfAppUML {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            p = new Presenter(this);
        }
        Presenter p;
        public event EventHandler SomeEvent = null;

        private void Button_Click(object sender, RoutedEventArgs e) {
            SomeEvent(sender, e);  
        }
    }
}
