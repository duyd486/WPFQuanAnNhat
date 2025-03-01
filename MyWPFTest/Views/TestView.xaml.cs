using FireSharp.Config;
using FireSharp.Interfaces;
using MyWPFTest.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyWPFTest.Views
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : Window
    {
        public TestViewModel TestViewModel { get; set; }
        public TestView()
        {
            this.DataContext = TestViewModel = new TestViewModel();
            InitializeComponent();
        }
    }
}
