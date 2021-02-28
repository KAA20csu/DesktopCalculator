using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;


namespace CustomCalculator
{
    public class MainWindow : Window
    {
        public MainWindow()
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
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
