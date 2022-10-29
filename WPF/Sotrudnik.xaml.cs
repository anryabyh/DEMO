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

namespace Wpf3_1
{
    /// <summary>
    /// Логика взаимодействия для Sotrudnik.xaml
    /// </summary>
    public partial class Sotrudnik : Window
    {
        public Sotrudnik()
        {
            InitializeComponent();
        }

        private void glavnayabutton_Click(object sender, RoutedEventArgs e)
        {
            Glavnaya gl = new Glavnaya();
            gl.Owner = this;
            gl.Show();
        }

        private void complex_request_Click(object sender, RoutedEventArgs e)
        {
            complexreqest cp = new complexreqest();
            cp.Owner = this;
            cp.Show();
        }
    }
}
