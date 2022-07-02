using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WyświetlMarki(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("Pojazdy");
            new OknoPodkategorii((System.Xml.XmlElement)lista.SelectedItem).Show();
        }
    }
}
