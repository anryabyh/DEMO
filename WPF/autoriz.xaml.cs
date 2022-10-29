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
    /// Логика взаимодействия для autoriz.xaml
    /// </summary>
    public partial class autoriz : Window
    {
        RospotrebnadzorEntities db;
        public autoriz()
        {
            InitializeComponent();
        }

        private void vhodbutton_Click(object sender, RoutedEventArgs e)
        {
            db = new RospotrebnadzorEntities();
            var loginn = LoginBox.Text;
            var pass = PassBox.Password;
            var autoriz = db.userr.FirstOrDefault(a => a.loginn == loginn && a.passwordd == pass);
            if (autoriz != null)
            {
                if (autoriz.businessman == true)
                {
                    (new businessmen()).Show();
                    this.Close();
                }
                else
                {
                    (new Sotrudnik()).Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
