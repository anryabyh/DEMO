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
    /// Логика взаимодействия для Glavnaya.xaml
    /// </summary>
    public partial class Glavnaya : Window
    {
        RospotrebnadzorEntities db;
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new RospotrebnadzorEntities();
            DG_departament.ItemsSource = db.rospotreb_departament.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rospotreb_departament rsp = new rospotreb_departament();
                rsp.inn_departamen = Convert.ToDecimal(TB_inn_departament.Text);
                rsp.name_departament = TB_name_departament.Text;
                rsp.street_departament = TB_street_departament.Text;
                rsp.home_departament = Convert.ToInt32(TB_home_departament.Text);
                rsp.town_departament = TB_town_departament.Text;
                rsp.phone_departament = Convert.ToDecimal(TB_phone_departament.Text);
                db.rospotreb_departament.Add(rsp);
                db.SaveChanges();
                DG_departament.ItemsSource = db.rospotreb_departament.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
           try
            { 
                decimal inn = Convert.ToDecimal(TB_inn_departament.Text);
                var uRow = db.rospotreb_departament.Where(w => w.inn_departamen == inn).FirstOrDefault();
                uRow.inn_departamen = Convert.ToDecimal(TB_inn_departament.Text);
                uRow.name_departament = TB_name_departament.Text;
                uRow.street_departament = TB_street_departament.Text;
                uRow.home_departament = Convert.ToInt32(TB_home_departament.Text);
                uRow.town_departament = TB_town_departament.Text;
                uRow.phone_departament = Convert.ToDecimal(TB_phone_departament.Text);
                db.SaveChanges();
                DG_departament.ItemsSource = db.rospotreb_departament.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DG_departament.SelectedValue != null)
                {
                    var inn = Convert.ToDecimal(TB_inn_departament.Text);
                    var dRow = db.rospotreb_departament.FirstOrDefault(w => w.inn_departamen == inn);
                    db.rospotreb_departament.Remove(dRow);
                    db.SaveChanges();
                    DG_departament.ItemsSource = db.rospotreb_departament.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CB_inn_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DG_departament.ItemsSource = null;
            var text = Convert.ToDecimal(CB_innn.SelectedValue);
            DG_departament.ItemsSource = db.rospotreb_departament.Where(k => k.inn_departamen == text).ToList();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            DG_departament.ItemsSource = null;
            var t = Search.Text;
            DG_departament.ItemsSource = db.rospotreb_departament.Where(n => n.name_departament.Contains(t)).ToList();
        }
    }
}
