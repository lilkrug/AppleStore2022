using KursovoiProject2kurs.MVVM.View;
using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace KursovoiProject2kurs
{
    /// <summary>
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow 
    {
        public ShopWindow()
        {
            InitializeComponent();
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
            DataContext = new DataManageVM();
            
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow shopWindow = new ShopWindow();
            shopWindow.Show();
            Hide();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void America_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }

        private void Russia_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void Weld_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_Play(object sender, RoutedEventArgs e)
        {
            myVideo.Play();
        }

        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            myVideo.Stop();
        }
    }
    }
