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

namespace RealEstate_v2
{
    /// <summary>
    /// Interaction logic for Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void Button_LoginClick(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception excep)
            {
                MessageLabel.Background = new SolidColorBrush(Colors.Red);
                Message.Text = excep.Message;
            }
        }
    }
}
