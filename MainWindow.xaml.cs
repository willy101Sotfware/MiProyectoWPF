using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiProyectoWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ButtonHandler buttonHandler = new ButtonHandler();
   
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, RoutedEventArgs e)
    {
        buttonHandler.HandleButtonClick(sender, e);
    }
}
