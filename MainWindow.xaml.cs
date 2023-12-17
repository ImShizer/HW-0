using System.Windows;

namespace HW_0
{
    public partial class MainWindow : Window
    {
        private int clickCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            clickCount++;
            MessageBox.Show($"Количество нажатий: {clickCount}", "Сообщение");
        }
    }
}
