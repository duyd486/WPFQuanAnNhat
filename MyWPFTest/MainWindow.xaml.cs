using FireSharp.Config;
using FireSharp.Interfaces;
using MyWPFTest.Views;
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

namespace MyWPFTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        TestView testView = new TestView();
        testView.Show();
    }
}