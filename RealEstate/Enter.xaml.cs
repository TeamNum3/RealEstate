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
using System.Windows.Shapes;
using BUS;

namespace RealEstate_v2
{
    /// <summary>
    /// Interaction logic for Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        Controller controller;

        public Enter()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void Button_LoginClick(object sender, RoutedEventArgs e)
        {
            try
            {

                DialogResult = true;
            }
            catch (Exception excep)
            {
                MessageLabel.Background = new SolidColorBrush(Colors.Red);
                Message.Text = excep.Message;
            }
        }
        private void Button_RegisterClick(object sender, RoutedEventArgs e)
        {
            try
            {
                controller.Registration(LoginRegister.Text, PasswordRegister.Password, RepeatPasswordRegister.Password, EmailRegister.Text);
                DialogResult = true;
            }
            catch (Exception excep)
            {
                SignUpMessageLabel.Background = new SolidColorBrush(Colors.Red);
                SignUpMessage.Text = excep.Message;
            }
        }
    }
}
