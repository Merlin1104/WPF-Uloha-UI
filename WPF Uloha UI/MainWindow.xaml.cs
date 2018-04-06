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

namespace WPF_Uloha_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetBlackOutDates()
        {
            MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(
                new DateTime(2018, 3, 1),
                new DateTime(2018, 3, 7)
                ));
            MonthlyCalendar.BlackoutDates.Add(new CalendarDateRange(
                new DateTime(2018, 4, 1),
                new DateTime(2018, 4, 4)
                ));


        }


    }
}
