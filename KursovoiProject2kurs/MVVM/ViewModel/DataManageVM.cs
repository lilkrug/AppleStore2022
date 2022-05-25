using KursovoiProject2kurs.Core;
using KursovoiProject2kurs.DataModel;
using KursovoiProject2kurs.MVVM.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Image = KursovoiProject2kurs.DataModel.Image;

namespace KursovoiProject2kurs.MVVM.ViewModel
{
//MVVM — это паттерн разработки, позволяющий разделить приложение на три функциональные части:
//Model — описывается основная логика программы(работа с данными, вычисления, запросы и так далее).
//View — вид или представление(пользовательский интерфейс).
//ViewModel — модель представления, которая служит прослойкой между View и Model.
    public class DataManageVM : INotifyPropertyChanged
    {
        private List<Good> allGoods = DataWorker.GetAllGoods();
        public List<Good> AllGoods
        {
            get { return allGoods; }
            set
            {
                allGoods = value;
                NotifyPropertyChanged("allGoods");
            }
        }
        private List<Order> allCurrentOrders = DataWorker.GetAllUserOrders(Id);
        public List<Order> AllCurrentOrders
        {
            get { return allCurrentOrders; }
            set
            {
                allCurrentOrders = value;
                NotifyPropertyChanged("allCurrentOrders");
            }
        }
        private List<Order> allOrders = DataWorker.GetAllOrders();
        public List<Order> AllOrders
        {
            get { return allOrders; }
            set
            {
                allOrders = value;
                NotifyPropertyChanged("allOrders");
            }
        }
        private List<User> allUsers = DataWorker.GetAllUsers();
        public List<User> AllUsers
        {
            get { return allUsers; }
            set
            {
                allUsers = value;
                NotifyPropertyChanged("allUsers");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #region METHODS TO OPEN WINDOW
        //open add window methods
        private void OpenAddGoodsWindowMethod()
        {
            AddGoods newGoodWindow = new AddGoods();
            newGoodWindow.Show();
        }
        private void OpenOutPutGoodsWindowMethod()
        {
            OutPutGoods newOutPutGoodWindow = new OutPutGoods();
            newOutPutGoodWindow.Show();
        }
        public void OpenSupportWindowMethod()
        {
            View.Support newSupportWindow = new View.Support();
            newSupportWindow.Show();
        }
        public void OpenInformationWindowMethod()
        {
            Information newInformationWindow = new Information();
            newInformationWindow.Show();
        }
        public void OpenIPhoneWindowMethod()
        {
            IPhone newIPhoneWindow = new IPhone();
            newIPhoneWindow.Show(); 
        }
        private void OpenRegisterWindowMethod()
        {
            RegsWindow newRegisterWindow = new RegsWindow();
            newRegisterWindow.Show();
        }
        private void OpenLoginWindowMethod()
        {
            AuthWindow newLoginWindow = new AuthWindow();
            newLoginWindow.Show();
        }
        private void OpenUserWindowMethod()
        {
            UserWindow newUserWindow = new UserWindow();
            newUserWindow.Show();
        }

        //open edit windows methods
        private void OpenEditItemWindowMethod(Good iphone)
        {
            EditItem newItemWindow = new EditItem(iphone);
            newItemWindow.Show();
        }
        #endregion
        #region COMMANDS TO OPEN WINDOWS
        private RelayCommand openAddGoodsWnd;
        public RelayCommand OpenAddGoodsWnd
        {
            get
            {
                return openAddGoodsWnd ?? new RelayCommand(obj =>
                {
                    OpenAddGoodsWindowMethod();
                });
            }
        }
        private RelayCommand openOutPutGoodsWnd;
        public RelayCommand OpenOutPutGoodsWnd
        {
            get
            {
                return openOutPutGoodsWnd ?? new RelayCommand(obj =>
                {
                    OpenOutPutGoodsWindowMethod();
                });
            }
        }
        private RelayCommand openSupportWnd;
        public RelayCommand OpenSupportWnd
        {
            get
            {
                return openSupportWnd ?? new RelayCommand(obj =>
                {
                    OpenSupportWindowMethod();
                });
            }
        }
        private RelayCommand openInformationWnd;
        public RelayCommand OpenInformationWnd
        {
            get
            {
                return openInformationWnd ?? new RelayCommand(obj =>
                {
                    OpenInformationWindowMethod();
                });
            }
        }
        private RelayCommand openIPhoneWnd;
        public RelayCommand OpenIPhoneWnd
        {
            get
            {
                return openIPhoneWnd ?? new RelayCommand(obj =>
                {
                    OpenIPhoneWindowMethod();
                });
            }
        }
        private RelayCommand openRegisterUserWnd;
        public RelayCommand OpenRegisterUserWnd
        {
            get
            {
                return openRegisterUserWnd ?? new RelayCommand(obj =>
                {
                    OpenRegisterWindowMethod();
                });
            }
        }
        private RelayCommand openUserWnd;
        public RelayCommand OpenUserWnd
        {
            get
            {
                return openUserWnd ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    wnd.Hide();
                    OpenUserWindowMethod();
                    wnd.Show();
                });
            }
        }
        private RelayCommand openLoginUserWnd;
        public RelayCommand OpenLoginUserWnd
        {
            get
            {
                return openLoginUserWnd ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    wnd.Hide();
                    OpenLoginWindowMethod();
                    wnd.Close();
                });
            }
        }
        private RelayCommand exitMainWnd;
        public RelayCommand ExitMainWnd
        {
            get
            {
                return exitMainWnd ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    RegsWindow newRegisterWindow = new RegsWindow();
                    wnd.Hide();
                    newRegisterWindow.ShowDialog();
                    SetNullValuesToUserProperties();
                    SetNullValuesToProperties();
                    wnd.Close();
                });
            }
        }
        #endregion
        #region PROPERTIES
        //свойства телефона
        public static string IPhones { get; set; }
        public static string IPhoneName { get; set; }
        public static string IPhoneCategory { get; set; }
        public static int IPhonePrice { get; set; }
        public static string IPhoneCountry { get; set; }
        public static Image IPhoneImage { get; set; }
        public static string IPhoneDescription { get; set; }
        //свойства картинки
        public string ImagePath { get; set; }
        public byte[] ImageData { get; set; }
        //свойства для выделенных элементов
        public TabItem SelectedTabItem { get; set; }
        public static Good SelectedGoods { get; set; }
        public static Order SelectedOrder { get; set; }
        //свойства для пользователей
        public static int Id { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string RePassword { get; set; }
        //свойства для поддержки
        public static string Mail { get; set; }
        public static string Message { get; set; }
        public static string Subject { get; set; }
        #endregion
        #region COMMANDS TO ADD
        private RelayCommand addNewIPhone;
        public RelayCommand AddNewIPhone
        {
            get
            {
                return addNewIPhone ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (IPhoneName == null || IPhoneName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "TextBoxNameGood");
                    }
                    if (IPhoneCategory == null || IPhoneCategory.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "TextBoxCategory");
                    }
                    if (IPhoneCountry == null || IPhoneCountry.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "TextBoxCountry");
                    }
                    if (IPhoneDescription == null || IPhoneDescription.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "TextBoxDescription");
                    }
                    if (IPhonePrice == 0)
                    {
                        SetRedBlockControll(wnd, "TextBoxPrice");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateGoods(0, IPhoneName, IPhoneCategory, IPhonePrice, IPhoneCountry, IPhoneDescription, IPhoneImage);
                        ShowMessageToUser(resultStr);
                        OutPutGoods wd = new OutPutGoods();
                        UpdateAllGoodsView();
                        SetNullValuesToProperties();
                        wnd.Close();
                    }
                }
                );
            }
        }
        private RelayCommand addNewImage;
        public RelayCommand AddNewImage
        {
            get
            {
                return addNewImage ?? new RelayCommand(obj =>
                {
                    var dialog = new OpenFileDialog
                    {
                        CheckFileExists = true,
                        Multiselect = false,
                        Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*"
                    };

                    if (dialog.ShowDialog() != true) { return; }
                    ImagePath = dialog.FileName;
                    ImageData = File.ReadAllBytes(ImagePath);
                    IPhoneImage = new Image { ImageId = 0, Path = ImagePath, Picture = ImageData };
                }
                );
            }
        }
        #endregion
        #region COMMANDS TO DELETE
        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get
            {
                return deleteItem ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                    //если телефон
                    if (SelectedTabItem.Name == "GoodsTab" && SelectedGoods != null)
                    {
                        resultStr = DataWorker.DeleteGoods(SelectedGoods);
                        UpdateAllGoodsView();
                    }
                    //обновление
                    SetNullValuesToProperties();
                    OutPutGoods outPutGoods = new OutPutGoods();
                    ShowMessageToUser(resultStr);
                    

                });
            }
        }
        #endregion
        #region COMMAND TO EDIT
        private RelayCommand openEditItemWnd;
        public RelayCommand OpenEditItemWnd
        {
            get
            {
                return openEditItemWnd ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                    //если телефон
                    if (SelectedTabItem.Name == "GoodsTab" && SelectedGoods != null)
                    {
                        OpenEditItemWindowMethod(SelectedGoods);
                        resultStr = "Success";
                    }
                    //обновление
                    ShowMessageToUser(resultStr);
                });
            }
        }
        #endregion
        #region USER COMMANDS
        private RelayCommand searchGood;
        public RelayCommand SearchGood
        {
            get
            {
                return searchGood ?? new RelayCommand(obj =>
                {
                        List<Good> goods = new List<Good>();
                        goods = AllGoods.FindAll(x => x.Name.Contains(IPhones));
                        AllGoods = goods;
                        UpdateAllGoodsMyView();
                        AllGoods = DataWorker.GetAllGoods();
                });
            }
        }
        private RelayCommand resetFilters;
        public RelayCommand ResetFilters
        {
            get
            {
                return resetFilters ?? new RelayCommand(obj =>
                {
                    AllGoods = DataWorker.GetAllGoods();
                    UpdateAllGoodsMyView();
                });
            }
        }
        private RelayCommand sendMessage;
        public RelayCommand SendMessage
        {
            get
            {
                return sendMessage ?? new RelayCommand(obj =>
                {
                    try
                    {
                        Window wnd = obj as Window;
                        
                        if (Mail == null || Mail.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "MailBlock");
                        }
                        if (Subject == null || Subject.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "SubjectBlock");
                        }
                        if (Message == null || Message.Replace(" ", "").Length == 0)
                        {
                            SetRedBlockControll(wnd, "MessageBlock");
                        }
                        else
                        {
                            string resultStr = "";
                            var smtpClient = new System.Net.Mail.SmtpClient("smtp.mail.ru", 587);
                            smtpClient.Credentials = new System.Net.NetworkCredential("lilkrug_2003@mail.ru", "XWcfqqJUPGvTSV7Uw20C");
                            smtpClient.EnableSsl = true;
                            smtpClient.Send(new System.Net.Mail.MailMessage("lilkrug_2003@mail.ru", $"{Mail}", "Интернет-магазин мобильных телефонов", 
                                "Здравствуйте, ваше обращение доставлено, в ближайшее время мы вам ответим"));
                            resultStr = DataWorker.CreateSupport(Mail, Subject, Message);
                            ShowMessageToUser(resultStr);
                            wnd.Close();
                            SetNullValuesToProperties();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                );
            }
        }
        private RelayCommand sortGood;
        public RelayCommand SortGood
        {
            get
            {
                return sortGood ?? new RelayCommand(obj =>
                {
                    AllGoods.Sort((x, y) => x.Price.CompareTo(y.Price));
                    UpdateAllGoodsMyView();
                });
            }
        }
        private RelayCommand buyGood;
        public RelayCommand BuyGood
        {
            get
            {
                return buyGood ?? new RelayCommand(obj =>
                {
                    string resultStr = "Не выбран товар";
                    UserWindow usr = new UserWindow();
                    if (SelectedGoods != null)
                    {
                        resultStr = DataWorker.CreateOrder(SelectedGoods, DataWorker.FindIdByLogin(Login));
                    }
                    UpdateAllOrdersUserWindow();
                    ShowMessageToUser(resultStr);
                });
            }
        }
        private RelayCommand cancelOrder;
        public RelayCommand CancelOrder
        {
            get
            {
                return cancelOrder ?? new RelayCommand(obj =>
                {
                    string resultStr = "Ничего не выбрано";
                    if (SelectedOrder != null)
                    {
                        resultStr = DataWorker.DeleteOrder(SelectedOrder);
                        UpdateAllOrdersUserWindow();
                    }
                    ShowMessageToUser(resultStr);
                    SetNullValuesToProperties();
                });
            }
        }
        private RelayCommand registerUser;
        public RelayCommand RegisterUser
        {
            get
            {
                return registerUser ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string PasswNoMatch = "Пароли не сходятся";
                    string LoginExists = "Данный пользователь уже существует";
                    if (!DataWorker.GetLogins(Login))
                    {
                        if (Password == RePassword && Password != null && RePassword != null)
                        {
                            DataWorker.RegisterUser(Login, Password);
                            SetNullValuesToProperties();
                            SetNullValuesToUserProperties();
                            wnd.Hide();
                            OpenLoginWindowMethod();
                            wnd.Close();
                        }
                        else
                        {
                            ShowMessageToUser(PasswNoMatch);
                        }
                    }
                    else
                    {
                        ShowMessageToUser(LoginExists);
                    }
                }
                );
            }
        }
        private RelayCommand loginUser;
        public RelayCommand LoginUser
        {
            get
            {
                return loginUser ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = DataWorker.CheckUserData(Login, Password);
                    if (resultStr == "Данного пользователя не существует")
                    {
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                    }
                    if (resultStr == "Введен неверный пароль")
                    {
                        ShowMessageToUser(resultStr);
                        SetNullValuesToProperties();
                    }
                    if (resultStr == "Отлично")
                    {
                        resultStr = DataWorker.LoginUser(Login, Password);
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                        if (Login == "admin")
                        {
                           ShopWindow shopWindow = new ShopWindow();
                           shopWindow.Show();
                        }
                        else
                        {
                            MainWindow main = new MainWindow();
                            main.Show();
                        }
                    }
                }
                );
            }
        }
        private RelayCommand exitUser;
        public RelayCommand ExitUser
        {
            get
            {
                return exitUser ?? new RelayCommand(obj =>
                {
                    string result = Login;
                    SetNullValuesToProperties();
                    SetNullValuesToUserProperties();
                    ShowMessageToUser(result + ", вы успешно вышли.");
                });
            }
        }
        #endregion
        #region EDIT COMMANDS
        private RelayCommand editGoods;
        public RelayCommand EditGoods
        {
            get
            {
                return editGoods ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Не выбран телефон";
                    string noCategoryStr = "Не выбрана категория";
                    string noPriceStr = "Не выбрана цена";
                    string noCountryStr = "Не выбрана страна изготовитель";
                    string noDescriptionStr = "Нет Описания товара";
                    if (SelectedGoods != null)
                    {
                            if (IPhoneCategory != null)
                            {
                                if (IPhonePrice != 0)
                                {
                                    if (IPhoneCountry != null)
                                    {
                                        if (IPhoneDescription != null)
                                        {
                                             resultStr = DataWorker.EditGoods(SelectedGoods, IPhoneCategory, IPhonePrice, IPhoneCountry, IPhoneDescription);
                                             UpdateAllGoodsView();
                                             SetNullValuesToProperties();
                                             ShowMessageToUser(resultStr);
                                             window.Close();
                                        }
                                        else
                                        {
                                            ShowMessageToUser(noDescriptionStr);
                                        }
                                       
                                    }
                                    else
                                    {
                                        ShowMessageToUser(noCountryStr);
                                    }
                                }
                                else
                                {
                                    ShowMessageToUser(noPriceStr);
                                }
                            }
                            else
                            {
                                ShowMessageToUser(noCategoryStr);
                            }
                    }
                    else
                    {
                        ShowMessageToUser(resultStr);
                    }
                });
            }
        }
        #endregion
        #region UPDATE VIEWS
        private void SetNullValuesToProperties()
        {
            IPhoneName = null;
            IPhoneCategory = null;
            IPhonePrice = 0;
            IPhoneCountry = null;
            IPhoneDescription = null;
            IPhoneImage = null;
            ImagePath = null;
            ImageData = null;
        }
        private void SetNullValuesToUserProperties()
        {
                Login = null;
                Id = 0;
                Password = null;
                RePassword = null;
         }
        
       
        private void UpdateAllGoodsView()
        {
            AllGoods = DataWorker.GetAllGoods();
            OutPutGoods.AllGoodsView.ItemsSource = null;
            OutPutGoods.AllGoodsView.Items.Clear();
            OutPutGoods.AllGoodsView.ItemsSource = AllGoods;
            OutPutGoods.AllGoodsView.Items.Refresh();
        }
        private void UpdateAllOrdersUserWindow()
        {
            AllCurrentOrders = DataWorker.GetAllUserOrders(Id);
            UserWindow.AllCurrentOrdersView.ItemsSource = null;
            UserWindow.AllCurrentOrdersView.Items.Clear();
            UserWindow.AllCurrentOrdersView.ItemsSource = AllCurrentOrders;
            UserWindow.AllCurrentOrdersView.Items.Refresh();
        }
        private void UpdateAllGoodsMyView()
        {
            MainWindow.AllGoodsView.ItemsSource = null;
            MainWindow.AllGoodsView.Items.Clear();
            MainWindow.AllGoodsView.ItemsSource = AllGoods;
            MainWindow.AllGoodsView.Items.Refresh();
        }
        #endregion
        #region SOME SIMPLE METHODS
        private string GetFileName()
        {
            string FileName = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            openFileDialog1.DefaultExt = ".jpeg";
            FileName = openFileDialog1.FileName;
            return FileName;
        }
        private void ShowMessageToUser(string message)
        {
            MessageView messageView = new MessageView(message);
            messageView.Show();
        }
        private void SetRedBlockControll(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }
        #endregion
    }
}
