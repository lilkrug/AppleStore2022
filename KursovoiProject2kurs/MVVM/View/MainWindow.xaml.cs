using KursovoiProject2kurs.MVVM.ViewModel;
using System.Windows;
using System.Windows.Controls;



namespace KursovoiProject2kurs
{
    public partial class MainWindow : Window
    {
        public static ListBox AllGoodsView;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllGoodsView = ViewAllGoods;
        }  
    }
  
}
