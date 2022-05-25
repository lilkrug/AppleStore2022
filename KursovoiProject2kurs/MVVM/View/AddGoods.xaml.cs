using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using System.Xml.Serialization;


namespace KursovoiProject2kurs.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для AddGoods.xaml
    /// </summary>
    public partial class AddGoods : Window
    {
      
        public AddGoods()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
        
       

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            IPhone phone = new IPhone();
            phone.Show();
            Hide();
        }

    }
}
