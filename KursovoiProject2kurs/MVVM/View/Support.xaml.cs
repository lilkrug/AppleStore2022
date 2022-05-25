using KursovoiProject2kurs.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace KursovoiProject2kurs.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для Support.xaml
    /// </summary>
    public partial class Support : Window
    {
        public Support()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }

        //private void Send_Click(object sender, RoutedEventArgs e)
        //{
        //    string to, from, pass, messageBody;
        //    MailMessage message = new MailMessage();
        //    to = EmailTexBox.Text;
        //    pass = "kolalalka";
        //    from = "lilkrug2003@gmail.com";
        //    messageBody = MessageTexBox.Text;
        //    message.To.Add(to);
        //    message.From = new MailAddress(from);
        //    message.Body = "From : " + "</br>Message : " + messageBody;
        //    message.Subject = SubjectTexBox.Text;
        //    message.IsBodyHtml = true;
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Host = "smtp.gmail.com";
        //    smtp.UseDefaultCredentials = false;
        //    smtp.EnableSsl = true;
        //    smtp.Port = 587; // 587 or 465
        //    NetworkCredential nc = new NetworkCredential(from, pass);
        //    smtp.Credentials = nc;
        //    smtp.Send(message);
        //    MessageBox.Show("Email Sent Successfully");
        //    EmailTexBox.Clear();
        //    SubjectTexBox.Clear();
        //    MessageTexBox.Clear();
        //}


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            UserWindow userWindow = new UserWindow();
            userWindow.Show();
            Hide();
        }
    }

}
