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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;


namespace RealEstate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.IsSelected = true;
        }

        private void SizeWindowChangedEventHandler(object sender, SizeChangedEventArgs e)
        {
            if (e.WidthChanged)
            {
                double deltaWidth = e.NewSize.Width - e.PreviousSize.Width == MinWidth ? 0 : e.NewSize.Width - e.PreviousSize.Width;
                double margin;

                foreach (TabItem item in MainTabControl.Items.OfType<TabItem>())
                {
                    margin = deltaWidth / 5 ;
                    item.Width += deltaWidth;

                    if (item.Width <= item.MinWidth)
                    {
                        item.Margin = new Thickness(0, 47, 0, -47);
                    }
                    else if (item.Width >= item.MaxWidth)
                    {
                        item.Margin = new Thickness(0, 75, 0, -75);
                    }
                    else
                    {
                        item.Margin = new Thickness(0, item.Margin.Top + margin, 0, item.Margin.Bottom - margin);
                    }
                }

                logoImage.Width += deltaWidth;
                logoImage.Height += deltaWidth;
            }
            if (e.HeightChanged)
            {
                double deltaHeight = e.NewSize.Height - e.PreviousSize.Height == MinHeight ? 0 : e.NewSize.Height - e.PreviousSize.Height;

                foreach (TabItem item in MainTabControl.Items.OfType<TabItem>())
                {
                    item.Height += deltaHeight / 10;
                }
                logoImage.Height += deltaHeight;
            }
        }


        private void Button_EnterClick(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke((Action)(() => MainTabControl.SelectedIndex = 1));

            Enter window = new Enter();
            window.Owner = this;
            if (window.ShowDialog() == true)
            {
                MessageBox.Show("успішно");
                EnterLabel.Text = "Кабінет користувача";
                EnterLabel.MouseLeftButtonDown -= Button_EnterClick;
            }
            else
            {
            }
        }
    }
}
