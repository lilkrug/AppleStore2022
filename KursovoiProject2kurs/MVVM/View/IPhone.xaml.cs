﻿using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static KursovoiProject2kurs.MVVM.View.AddGoods;

namespace KursovoiProject2kurs.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для IPhone.xaml
    /// </summary>
    public partial class IPhone : Window
    {
        public IPhone()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();
            Hide();
        }
    }
}
