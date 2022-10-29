using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ClosedXML.Excel;

namespace Wpf3_1
{
    /// <summary>
    /// Логика взаимодействия для complexreqest.xaml
    /// </summary>
    public partial class complexreqest : Window
    {
        RospotrebnadzorEntities db;
        public complexreqest()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new RospotrebnadzorEntities();
            var reqest = db.certificatee.Join(db.userr,
                c => c.loginnbussinesmen,
                u => u.loginn,
                (c, u) => new { u.surname, u.namee, u.patronymic, c.date_issue, c.numb_certificate, c.inn_departament_rsp, c.inn_company });
            dgcomplexreqest.ItemsSource = reqest.ToList();
        }

        private void ExcelButton_Click(object sender, RoutedEventArgs e)
        {
            var st = dpst.SelectedDate.Value;
            var fin = dpfin.SelectedDate.Value;
            if (st != null && fin != null)
            {
                dgcomplexreqest.ItemsSource = null;
                dgcomplexreqest.ItemsSource = db.certificatee.Where(i => i.date_issue >= st && i.date_issue <= fin)
                    .Join(db.userr,
                c => c.loginnbussinesmen,
                u => u.loginn,
                (c, u) => new { u.surname, u.namee, u.patronymic, c.date_issue, c.numb_certificate, c.inn_departament_rsp, c.inn_company })
                    .ToList();
                Excel(st, fin);
            }
            else
            {
                MessageBox.Show("Выберите дату");
            }
        }

            private void Excel(DateTime st, DateTime fin)
            {
                var p = Environment.CurrentDirectory;
            var WB = new XLWorkbook();
            WB.AddWorksheet();
            var WS = WB.Worksheet(1);
            string data = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
            WS.Cell("A1").Value = "Дата:" + " " + data;
            WS.Cell("A3").Value = "Данные по сертификату";
            WS.Cell("A5").Value = "Фамилия";
            WS.Cell("B5").Value = "Имя";
            WS.Cell("C5").Value = "Отчетсво";
            WS.Cell("D5").Value = "Номер сертификата";
            WS.Cell("E5").Value = "Дата выдачи";
            WS.Cell("F5").Value = "ИНН отдела роспотребнадзора";
            WS.Cell("G5").Value = "ИНН компании";
            var a = db.certificatee.Where(i => i.date_issue >= st && i.date_issue <= fin)
                    .Join(db.userr,
                c => c.loginnbussinesmen,
                u => u.loginn,
                (c, u) => new { u.surname, u.namee, u.patronymic, c.date_issue, c.numb_certificate, c.inn_departament_rsp, c.inn_company }).ToList();
            int r = 6;
            foreach (var i in a)
            {
                WS.Cell($"A{r}").Value = i.surname;
                WS.Cell($"B{r}").Value = i.namee;
                WS.Cell($"C{r}").Value = i.patronymic;
                WS.Cell($"D{r}").Value = i.numb_certificate;
                WS.Cell($"E{r}").Value = i.date_issue;
                WS.Cell($"F{r}").Value = i.inn_departament_rsp;
                WS.Cell($"G{r}").Value = i.inn_company;
                r++;
            }
            WS.Columns().AdjustToContents();
            var file = $@"{p}\сертификат.xlsx";
            WB.SaveAs(file);
            System.Diagnostics.Process.Start(file);
        }
        }
    }
