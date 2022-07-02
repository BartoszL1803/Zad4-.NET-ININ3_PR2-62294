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
using System.Windows.Shapes;

namespace WpfApp11
{
    public partial class OknoPodkategorii : Window
    {
        public OknoPodkategorii()
        {
            InitializeComponent();
        }

        public OknoPodkategorii(System.Xml.XmlElement kategoria)
        {
            DataContext = kategoria;
            Console.WriteLine(kategoria);
            InitializeComponent();
        }

        private void WyświetlModele(object sender, RoutedEventArgs e)
        {
            FrameworkElement parent = (FrameworkElement)((FrameworkElement)sender).Parent;
            ListBox lista = (ListBox)parent.FindName("Marka");
            new OknoElementów((System.Xml.XmlElement)lista.SelectedItem).Show();
        }
    }
}
