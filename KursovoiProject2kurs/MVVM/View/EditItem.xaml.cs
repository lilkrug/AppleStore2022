using KursovoiProject2kurs.DataModel;
using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
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
using static KursovoiProject2kurs.MVVM.View.AddGoods;

namespace KursovoiProject2kurs.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для EditItem.xaml
    /// </summary>
    public partial class EditItem : Window
    {
        
        public EditItem(Good iphone)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedGoods = iphone;
            DataManageVM.IPhoneName = iphone.Name;
            DataManageVM.IPhoneCategory = iphone.Category;
            DataManageVM.IPhonePrice = iphone.Price;
            DataManageVM.IPhoneCountry = iphone.Country;
            DataManageVM.IPhoneDescription = iphone.Description;
        }
        
        private void Back_Click(object sender, RoutedEventArgs e)
        {
           OutPutGoods outPutGoods = new OutPutGoods();
           outPutGoods.Show();
           Hide();
        }
    }
}
