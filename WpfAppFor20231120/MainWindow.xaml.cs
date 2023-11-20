using System.Windows;
using System.Windows.Controls;

namespace WpfAppFor20231120;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Loaded += MainWindow_Loaded;
        textBox1.TextChanged += TextBox1_TextChanged;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        textBox1.Text = MySettings.Default.HandoffMessage;
    }

    private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender != null && !string.IsNullOrEmpty(textBox1.Text))
        {
            MySettings.Default.HandoffMessage = textBox1.Text;
            MySettings.Default.Save();
        }
    }
}
