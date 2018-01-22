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
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Infrastructure;
using BusinessLogicLayer.DTO;
using RealEstate.Models;

namespace RealEstate
{
    /// <summary>
    /// Interaction logic for Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        UserService userService;
        UserDTO userDTO;

        public Enter()
        {
            InitializeComponent();

            userService = new UserService();
            userDTO = new UserDTO();

            this.DataContext = new UserViewModel();
        }

        private void Button_LoginClick(object sender, RoutedEventArgs e)
        {
            try
            {
                userService.Authorization(userName.Text, password.Password);
                DialogResult = true;
            }
            catch (Exception excep)
            {
                MessageLabelLogin.Background = new SolidColorBrush(Colors.Red);
                MessageLogin.Text = excep.Message;
            }
        }
        private void Button_RegisterClick(object sender, RoutedEventArgs e)
        {
            try
            {
                //userService.Registration(LoginRegister.Text, PasswordRegister.Password, RepeatPasswordRegister.Password, EmailRegister.Text);
                userService.Registration(new UserViewModel(LoginRegister.Text, PasswordRegister.Password, RepeatPasswordRegister.Password, EmailRegister.Text));
                DialogResult = true;
            }
            catch (ValidationException excep)
            {
                SignUpMessageLabel.Background = new SolidColorBrush(Colors.Red);
                SignUpMessage.Text = excep.Message;
            }
        }
    }
}
