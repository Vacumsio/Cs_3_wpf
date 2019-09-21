using System.Windows;
using System.Net.Mail;
using System.Security;
using System.Net;
using System;

namespace MailSender.WPF.test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            var user_name = UsenNameEditor.Text;
            var password = PasswordEditor.SecurePassword;
            var host = "smtp.yandex.ru";
            var port = 25;

            var msg = "Hello world"+ DateTime.Now;

            using (var client = new SmtpClient(host, port))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(user_name, password);

                using(var message = new MailMessage())
                {
                    message.From = new MailAddress("madisava@yandex.ru", "Пётр");
                    message.To.Add(new MailAddress("vacumsio@gmail.com", "Пётр"));
                    message.Subject = "Заголовок письма";
                    message.Body = msg;
                    //message.Attachments.Add(new Attachment(.....)); для отправки вложений в письме

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Почта успешно отправлена","Успех!",MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
} 
