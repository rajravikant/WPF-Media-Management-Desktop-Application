using System.Windows;
using System.Windows.Input;

namespace Media_Management
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            Tg_Btn.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                SystemCommands.MaximizeWindow(this);
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                SystemCommands.RestoreWindow(this);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            me.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void btnHide_Click(object sender, RoutedEventArgs e)
        {
            if (sidePanel.Visibility == Visibility.Visible)
            {
                sidePanel.Visibility = Visibility.Collapsed;
            }
            else if (sidePanel.Visibility == Visibility.Collapsed)
            {
                sidePanel.Visibility = Visibility.Visible;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        public void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {

            cntControl.Margin = new Thickness(0, 0, 0, 0);
        }

        public void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            cntControl.Margin = new Thickness(200, 0, 0, 0);
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (!(WindowState == WindowState.Maximized))
            {
                SystemCommands.MaximizeWindow(this);

            }
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            AboutUs us = new AboutUs();
            us.Show();
        }
    }
}
