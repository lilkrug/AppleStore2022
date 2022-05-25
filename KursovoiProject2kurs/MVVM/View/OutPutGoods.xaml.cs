using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace KursovoiProject2kurs.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для OutPutGoods.xaml
    /// </summary>
    public partial class OutPutGoods : Window
    {
        public static ListView AllUsersView;
        public static ListView AllOrdersView;
        public static ListView AllGoodsView;
        public OutPutGoods()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllGoodsView = ListViewTable;
            AllUsersView = ViewAllUsers;
            AllOrdersView = ViewAllOrders;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            IPhone iphone = new IPhone();
            iphone.Show();
            Hide();
        }
    }
}
