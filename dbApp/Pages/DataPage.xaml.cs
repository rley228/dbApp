using dbApp.Models;
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

namespace dbApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();

            using (Model1 db = new Model1())
            {
                dataList.ItemsSource = db.Staff.ToList();
            }
        }

        private void btnedit_Click(object sender, RoutedEventArgs e)
        {
            btnSave.Visibility = Visibility.Visible; 
            dataList.IsReadOnly = false;
        }

        private void dataList_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}
